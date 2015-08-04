using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ids.Common;
using Ids.Common.Reporters;
using Ids.Common.Sensors;

namespace BaseSensorAzureReport.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ids.Common.Interfaces.ISensorReport> reporters = new List<Ids.Common.Interfaces.ISensorReport>();
            string connectionString = @"Data Source=UB1NB092\SQL2012;Initial Catalog=AzureIdsDb;Persist Security Info=True;User ID=cyberproduct;Password=x2000; Connect Timeout=600;Max Pool Size = 200;Pooling = True";

            AzureSqlDbReportAgent cloudDbReportAgent = new AzureSqlDbReportAgent(connectionString,
                "7C8FA0D3-1F00-42F1-B849-184348D834F6");

            reporters.Add(cloudDbReportAgent);
            reporters.Add(new SimpleReportAgent());
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
                baseSensor = new BaseSensor(cdd, "port 21", SharpPcap.DeviceMode.Normal, reporters, 20000, Enumerations.SensorMode.PacketCapture);
            }
            else
            {
                baseSensor = new BaseSensor(cdd, "tcp", SharpPcap.DeviceMode.Normal, reporters, 1000, Enumerations.SensorMode.Statistics);
            }

            baseSensor.StartCapturing();

            Console.ReadLine();
            baseSensor.StopCapturing();
        }
    }
}
