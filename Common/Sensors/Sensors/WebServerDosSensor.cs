using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ids.Common.Interfaces;
using SharpPcap;

namespace Ids.Common.Sensors
{
    public class WebServerDosSensor : BaseSensor
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

        private WebServerDosSensor(CaptureDeviceDescription deviceToCaptureInfo, string filter, DeviceMode deviceMode, List<ISensorReport> reportMethods, int heartBeatDelay)
            : base(deviceToCaptureInfo, filter, deviceMode, reportMethods, heartBeatDelay, Enumerations.SensorMode.PacketCapture)
        {
        }
        public static WebServerDosSensor FactoryMethod(CaptureDeviceDescription deviceToCaptureInfo,string webServerAdress, int port, bool sensorDeployedOnWebServer, List<ISensorReport> reportMethods, int heartBeatDelay)
        {
            //string webFilter = string.Format("((dst net {0}) and (dst port {1}))", webServerAdress, port);
            //string webFilter = string.Format("dst net {0}", webServerAdress);
            DeviceMode sensorListeningMode = DeviceMode.Promiscuous;
            string webFilter = "port 80";

            if (sensorDeployedOnWebServer) sensorListeningMode = DeviceMode.Normal;

            return new WebServerDosSensor(deviceToCaptureInfo, webFilter, sensorListeningMode, reportMethods, heartBeatDelay);
        }        
    }
}
