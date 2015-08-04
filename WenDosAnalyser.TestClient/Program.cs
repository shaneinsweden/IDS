using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ids.Common.Analysers;
using Ids.Common.Data;
using Ids.Common.Data.Interfaces;
using Ids.Common.Idmef;
using Ids.Common.Interfaces;
using Ids.Common.Reporters;
using Ids.Common.Utilities;

namespace Ids.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=UB1NB092\SQL2012;Initial Catalog=AzureIdsDb;Persist Security Info=True;User ID=cyberproduct;Password=x2000; Connect Timeout=600;Max Pool Size = 200;Pooling = True";

            //reporters
            List<IAlertReport> reporters = new List<IAlertReport>();
            AzureSqlDbReportAgent ara = new AzureSqlDbReportAgent(connectionString);
            reporters.Add(ara);

            //data agent
            SensorEventDbAgent dbDataAgent = new SensorEventDbAgent(connectionString);

            SimpleWebDosAnalyser wda = new SimpleWebDosAnalyser(reporters, 2000, dbDataAgent);

            string webServerAddress = "69.5.9.180";

            wda.CheckForWebServerDosAttack(webServerAddress, 3, null);

        }
    }
}
