using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Ids.Common;
using Ids.Common.Sensors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ids.Common.Utilities;

namespace Common.Test
{
    [TestClass]
    public class UtilitiesTest
    {
        [TestMethod]
        public void CreateAltertMessage_HasTodaysDate()
        {
            //arrange
            PacketDotNet.Packet packet = null;

            //act
            Ids.Common.Idmef.IDMEFMessage message = Ids.Common.Utilities.IdmefMessageMapper.CreateAltertMessageFromRawPacket(packet);
            Ids.Common.Idmef.Alert alert = message.Items[0] as Ids.Common.Idmef.Alert;

            //assert
            Assert.IsTrue(message.Items.Length == 1);
            Assert.IsNotNull(alert);
            Assert.AreEqual(alert.CreateTime.ntpstamp, DateTime.Now.ToShortDateString());
        }

        [TestMethod]
        public void CreateWebServerDosSensor_ReturnsSuccess()
        {
            //arrange
            CaptureDeviceDescription cdd = new CaptureDeviceDescription()
            {
                DeviceNumber = 0,
                TextInDeviceName = "whatever"
            };
            List<Ids.Common.Interfaces.ISensorReport> reporters = new List<Ids.Common.Interfaces.ISensorReport>();
            reporters.Add(new Ids.Common.Reporters.SimpleReportAgent());

            //act
            BaseSensor baseSensor = new BaseSensor(cdd, "tcp and ip and dst port 80", SharpPcap.DeviceMode.Normal, reporters, 1000, Enumerations.SensorMode.PacketCapture);
            baseSensor.StartCapturing();
            baseSensor.StopCapturing();

            //assert
            Assert.IsNotNull(baseSensor);
        }

        [TestMethod]
        public void CreateBaseSensor_ReturnsSuccess()
        {
            //arrange
            CaptureDeviceDescription cdd = new CaptureDeviceDescription()
            {
                DeviceNumber = 0,
                TextInDeviceName = "whatever"
            };
            List<Ids.Common.Interfaces.ISensorReport> reporters = new List<Ids.Common.Interfaces.ISensorReport>();
            reporters.Add(new Ids.Common.Reporters.SimpleReportAgent());
            const string googleIpAddress = "216.58.209.100";

            //act
            WebServerDosSensor wds = WebServerDosSensor.FactoryMethod(cdd, googleIpAddress, 443, false, reporters, 1000);

            //assert
            Assert.IsNotNull(wds);
        }
    }
}
