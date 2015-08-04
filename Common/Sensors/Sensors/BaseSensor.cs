using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using PacketDotNet;
using SharpPcap;
using Ids.Common.Interfaces;
using System.Threading;
using SharpPcap.WinPcap;

namespace Ids.Common.Sensors
{
    public class BaseSensor : ISensor
    {
        private ICaptureDevice _currentCaptureDevice;
        private List<ISensorReport> _reportMethods;
        private PosixTimeval _lastTimeval;

        private Guid _sensorId;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="deviceToCaptureInfo"></param>
        /// <param name="filter"></param>
        /// <param name="deviceMode"></param>
        /// <param name="reportMethods"></param>
        /// <param name="heartBeatDelay"></param>
        public BaseSensor(CaptureDeviceDescription deviceToCaptureInfo, string filter, DeviceMode deviceMode, List<ISensorReport> reportMethods, int heartBeatDelay, Enumerations.SensorMode sensorMode)
        {
            _sensorId = Guid.NewGuid();

            _lastTimeval = new PosixTimeval(0, 0);

            _reportMethods = reportMethods;

            _currentCaptureDevice = GetDeviceToCapture(deviceToCaptureInfo);
            _currentCaptureDevice.Open(deviceMode);
            if (!string.IsNullOrEmpty(filter)) _currentCaptureDevice.Filter = filter;

            //attach listeners
            switch (sensorMode)
            {
                case Enumerations.SensorMode.PacketCapture:
                    //_currentCaptureDevice.OnPacketArrival += new PacketArrivalEventHandler(_currentCaptureDevice_OnPacketArrival);
                    _currentCaptureDevice.OnPacketArrival += new PacketArrivalEventHandler(device_OnPacketArrival);
                    break;
                case Enumerations.SensorMode.Statistics:
                    var device = _currentCaptureDevice as WinPcapDevice;
                    device.Mode = CaptureMode.Statistics;
                    device.OnPcapStatistics += device_OnPcapStatistics;
                    break;
            }

            //start heartbeat timer
            StartHeartbeat(heartBeatDelay, reportMethods);
        }

        void device_OnPcapStatistics(object sender, StatisticsModeEventArgs e)
        {
            foreach (ISensorReport reportMethod in _reportMethods)
            {
                reportMethod.ReportStatistics(e.Statistics, _lastTimeval, _sensorId.ToString());
            }

            _lastTimeval = e.Statistics.Timeval;
        }


        /// <summary>
        /// start capturing network packets
        /// </summary>
        public void StartCapturing()
        {
            _currentCaptureDevice.StartCapture();
        }

        /// <summary>
        /// stop capturing ntwork packets
        /// </summary>
        public void StopCapturing()
        {
            _currentCaptureDevice.StopCapture();
        }

        /// <summary>
        /// Set up a timer that triggers a heartbeat event after ever <heartBeatDelay> milliseconds
        /// </summary>
        /// <param name="heartBeatDelay"></param>
        /// <param name="reportMethods"></param>
        private void StartHeartbeat(int heartBeatDelay, List<ISensorReport> reportMethods)
        {
            Timer timer = new Timer(_ => SendHeartbeat(reportMethods), null, heartBeatDelay, heartBeatDelay);
        }

        private delegate void BackgroundMethodDelegate(List<ISensorReport> reportMethods);

        /// <summary>
        /// sent a heartbeat report to show the sensor is still alive
        /// </summary>
        /// <param name="reportMethods"></param>
        private void SendHeartbeat(IEnumerable<ISensorReport> reportMethods)
        {
            foreach (ISensorReport reportMethod in reportMethods)
            {
                reportMethod.SendHeartBeat(_sensorId.ToString());
            }
        }

        /// <summary>
        /// handle the packet capture event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _currentCaptureDevice_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            PacketDotNet.Packet packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            Console.WriteLine("device_OnPacketArrival: " + e.Device.Statistics);

            foreach (ISensorReport reportMethod in _reportMethods)
            {
                reportMethod.ReportPacketCapture(packet, e.Packet.Timeval.Date);
            }
        }


        private static void device_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            DateTime time = e.Packet.Timeval.Date;
            int len = e.Packet.Data.Length;
            byte[] data = e.Packet.Data;
            //var packet = TcpPacket.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            //Console.WriteLine(e.Packet.LinkLayerType.ToString());
            Packet pack = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            if (pack is PacketDotNet.EthernetPacket)
            {
                var eth = pack.Extract(typeof(EthernetPacket)) as EthernetPacket;
                if (len > 100)
                {
                    Console.WriteLine("ETHERNET/INTERNET/HTTP PACKET");
                    //Console.WriteLine(HttpServerUtility.UrlTokenEncode(eth.Bytes));
                    Console.WriteLine("{0}-{1}", eth.DestinationHwAddress, eth.SourceHwAddress);
                    //Console.WriteLine(eth.PayloadPacket.PayloadPacket.PrintHex());
                    Console.WriteLine(System.Text.Encoding.UTF8.GetString(eth.Bytes));
                }
            }
            if (pack is PacketDotNet.TcpPacket)
            {
                var tcp = pack.Extract(typeof(TcpPacket)) as TcpPacket;
                if (len > 100)
                {
                    //Console.WriteLine("[{0}:{1}:{2}:{3}][{4}][{5}]",
                    //time.Hour, time.Minute, time.Second, time.Millisecond,
                    //len, Stringfy.RawPacketToHex(data));
                    Console.WriteLine("TCP PACKET");
                    Console.WriteLine(tcp.PrintHex());
                    //Console.WriteLine(arp.SenderHardwareAddress);
                }
            }
            if (pack is PacketDotNet.InternetPacket)
            {
                var inet = pack.Extract(typeof(InternetPacket)) as InternetPacket;
                if (len > 100)
                {
                    //Console.WriteLine("[{0}:{1}:{2}:{3}][{4}][{5}]",
                    //time.Hour, time.Minute, time.Second, time.Millisecond,
                    //len, Stringfy.RawPacketToHex(data));
                    Console.WriteLine("INTERNET PACKET");
                    Console.WriteLine(inet.PrintHex());
                    //Console.WriteLine(arp.SenderHardwareAddress);
                }
            }
            if (pack is PacketDotNet.IpPacket)
            {
                var ip = pack.Extract(typeof(IpPacket)) as IpPacket;
                if (len > 100)
                {
                    //Console.WriteLine("[{0}:{1}:{2}:{3}][{4}][{5}]",
                    //time.Hour, time.Minute, time.Second, time.Millisecond,
                    //len, Stringfy.RawPacketToHex(data));
                    Console.WriteLine("IP PACKET");
                    Console.WriteLine(ip.PrintHex());
                    //Console.WriteLine(arp.SenderHardwareAddress);
                }
            }
        }
        #region select a network interface to listen to
        private ICaptureDevice GetDeviceToCapture(CaptureDeviceDescription deviceToCaptureInfo)
        {
            ICaptureDevice foundDevice = null;

            if ((string.IsNullOrEmpty(deviceToCaptureInfo.TextInDeviceName) && (!deviceToCaptureInfo.DeviceNumber.HasValue)))
            {
                Console.WriteLine("Device description missing valid information");
                //throw new MissingFieldException("Device " + deviceToCaptureInfo.DeviceNumber + " was notfound on this machine");

                return foundDevice;
            }

            // Retrieve the device list
            CaptureDeviceList devices = CaptureDeviceList.Instance;

            // if we have no device do nothing
            if (devices.Count < 1)
            {
                //possibly want to log an error here
                Console.WriteLine("No devices were found on this machine");
                //throw new IndexOutOfRangeException("No devices were found on this machine");
            }
            else if (devices.Count == 1)
            {
                foundDevice = devices[0];

            }
            else
            {
                if (deviceToCaptureInfo.DeviceNumber.HasValue) 
                {
                    if (devices.Count < deviceToCaptureInfo.DeviceNumber)
                    {
                        Console.WriteLine("Device " + deviceToCaptureInfo.DeviceNumber + " was notfound on this machine");
                        //throw new IndexOutOfRangeException("Device " + deviceToCaptureInfo.DeviceNumber + " was notfound on this machine");
                    }
                    else foundDevice = devices[(int)deviceToCaptureInfo.DeviceNumber];
                }
                else if (!string.IsNullOrEmpty(deviceToCaptureInfo.TextInDeviceName))
                {
                    foreach (var device in devices)
                    {
                        if (device.Name.Contains(deviceToCaptureInfo.TextInDeviceName))
                        {
                            foundDevice = device;
                            break;
                        }
                    }
                }
            }
            return foundDevice;
        }
        #endregion select a network interface to listen to


        public string GetSensorId()
        {
            return _sensorId.ToString();
        }
    }
}
