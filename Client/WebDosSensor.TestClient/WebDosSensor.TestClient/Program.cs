using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ids.Common;
using Ids.Common.Reporters;
using Ids.Common.Sensors;

namespace Ids.Client.WebDosSensor.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ids.Common.Interfaces.ISensorReport> reporters = new List<Ids.Common.Interfaces.ISensorReport>();
            reporters.Add(new Ids.Common.Reporters.SimpleReportAgent());
            string connectionString = @"Data Source=UB1NB092\SQL2012;Initial Catalog=AzureIdsDb;Persist Security Info=True;User ID=cyberproduct;Password=x2000; Connect Timeout=600;Max Pool Size = 200;Pooling = True";

            AzureSqlDbReportAgent cloudDbReportAgent = new AzureSqlDbReportAgent(connectionString,String.Empty);

            reporters.Add(cloudDbReportAgent);
            CaptureDeviceDescription cdd = new CaptureDeviceDescription()
            {
                DeviceNumber = 0,
                TextInDeviceName = "whatever"
            };

            //www.google.com = 216.58.209.100
            //const string googleIpAddress = "216.58.209.100";
            //WebServerDosSensor wds = WebServerDosSensor.FactoryMethod(cdd, googleIpAddress, 443, false, reporters, 5000);
            //cloudDbReportAgent.UpdateSensorId(wds.GetSensorId());
            //wds.StartCapturing();
            //Console.ReadLine();
            //wds.StopCapturing();

            const string ftpIpAddress = "192.168.1.74";
            FtpServerDosSensor fds = FtpServerDosSensor.FactoryMethod(cdd, ftpIpAddress, 443, false, reporters, 5000);
            cloudDbReportAgent.UpdateSensorId(fds.GetSensorId());
            fds.StartCapturing();
            Console.ReadLine();
            fds.StopCapturing();
        }
    }
}
