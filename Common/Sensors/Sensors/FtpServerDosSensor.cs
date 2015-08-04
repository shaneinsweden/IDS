using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ids.Common.Interfaces;
using SharpPcap;

namespace Ids.Common.Sensors
{
    public class FtpServerDosSensor : BaseSensor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceToCaptureInfo"></param>
        /// <param name="filter"></param>
        /// <param name="deviceMode"></param>
        /// <param name="reportMethods"></param>
        /// <param name="heartBeatDelay"></param>
        /// <param name="timeWindow">How big is the window we measure for a DoS attack</param>
        /// 
        /// 

        private FtpServerDosSensor(CaptureDeviceDescription deviceToCaptureInfo, string filter, DeviceMode deviceMode, List<ISensorReport> reportMethods, int heartBeatDelay)
            : base(deviceToCaptureInfo, filter, deviceMode, reportMethods, heartBeatDelay, Enumerations.SensorMode.PacketCapture)
        {
        }
        public static FtpServerDosSensor FactoryMethod(CaptureDeviceDescription deviceToCaptureInfo, string webServerAdress, int port, bool sensorDeployedOnWebServer, List<ISensorReport> reportMethods, int heartBeatDelay)
        {
            //string webFilter = string.Format("((dst net {0}) and (dst port {1}))", webServerAdress, port);
            //string webFilter = string.Format("dst net {0}", webServerAdress);
            DeviceMode sensorListeningMode = DeviceMode.Promiscuous;
            string webFilter = "dst net 192.168.1.74";

            if (sensorDeployedOnWebServer) sensorListeningMode = DeviceMode.Promiscuous;

            return new FtpServerDosSensor(deviceToCaptureInfo, webFilter, sensorListeningMode, reportMethods, heartBeatDelay);
        }
    }
}
