using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ids.Common.Analysers;
using Ids.Common.Data;
using Ids.Common.Interfaces;
using Ids.Common.Reporters;

namespace Analyser.PortScanAnalysisClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=UB1NB092\SQL2012;Initial Catalog=AzureIdsDb;Persist Security Info=True;User ID=cyberproduct;Password=x2000; Connect Timeout=600;Max Pool Size = 200;Pooling = True";

            //reporters
            List<IAlertReport> reporters = new List<IAlertReport>();
            //AzureSqlDbReportAgent ara = new AzureSqlDbReportAgent(connectionString);
            //reporters.Add(ara);
            reporters.Add(new Ids.Common.Reporters.SimpleReportAgent());


            //data agent
            SensorEventDbAgent dbDataAgent = new SensorEventDbAgent(connectionString);

            SimplePortScanAnalyser psa = new SimplePortScanAnalyser(reporters, 2000, dbDataAgent);

            psa.CheckForHorizontalScan(connectionString, 2, null);

        }
    }
}
