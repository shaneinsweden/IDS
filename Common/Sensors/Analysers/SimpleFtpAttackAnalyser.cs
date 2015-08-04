using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ids.Common.Idmef;
using Ids.Common.Interfaces;

namespace Ids.Common.Analysers
{
    public class SimpleFtpAttackAnalyser: BaseAnalyser, IWebDosAnalysis
    {
        /// <summary>
        /// this method checks a DoS attack on a webserver
        /// </summary>
        /// <param name="webServerAddress"></param>
        /// <param name="threshold"></param>
        /// <param name="analysisWindow"></param>
        /// <returns></returns>
        public bool CheckForWebServerDosAttack(string webServerAddress, int threshold, int? analysisWindow)
        {
            bool alertRaised = false;

            //fetch the data to base the decision from the appropriate agent 
            int totalEvents = SensorEventAgent.GetTotalEvents(webServerAddress, 21, analysisWindow);

            if (totalEvents > threshold)
            {
                foreach (IAlertReport alertReport in ReportMethods)
                {
                    alertReport.ReportAltert(new IDMEFMessage(), analyserId.ToString());
                }
                alertRaised = true;
            }

            return alertRaised;
        }

    }
}
