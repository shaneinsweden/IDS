using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ids.Common;
using Ids.Common.Sensors;

namespace Ids.Client.BaseSensorTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ids.Common.Interfaces.ISensorReport> reporters = new List<Ids.Common.Interfaces.ISensorReport>();
            reporters.Add(new Ids.Common.Reporters.SimpleReportAgent());
            CaptureDeviceDescription cdd = new CaptureDeviceDescription()
            {
                DeviceNumber = 0,
                TextInDeviceName = "whatever"
            };
            string enteredChar = "X";
            while (enteredChar != "s" && enteredChar != "p")
            {
                Console.WriteLine("enter type Statistics Capture (s) or Packet Capture (p):");
                 enteredChar = Console.ReadLine();
            }

            BaseSensor baseSensor = null;

            if (enteredChar == "p")
            {
                //baseSensor = new BaseSensor(cdd, "tcp and ip and dst port 80", SharpPcap.DeviceMode.Normal,reporters, 1000, Enumerations.SensorMode.PacketCapture);
                baseSensor = new BaseSensor(cdd, "dst 192.168.0.103", SharpPcap.DeviceMode.Normal, reporters, 10000, Enumerations.SensorMode.PacketCapture);
            }
            else
            {
                baseSensor = new BaseSensor(cdd, "tcp", SharpPcap.DeviceMode.Normal,reporters, 1000, Enumerations.SensorMode.Statistics);
            }
       
            baseSensor.StartCapturing();

            Console.ReadLine();
            baseSensor.StopCapturing();
        }
    }
}
