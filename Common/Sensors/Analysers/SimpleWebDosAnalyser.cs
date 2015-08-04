using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ids.Common.Data;
using Ids.Common.Data.Interfaces;
using Ids.Common.Idmef;
using Ids.Common.Interfaces;
using Ids.Common.Utilities;

namespace Ids.Common.Analysers
{
    public class SimpleWebDosAnalyser : BaseAnalyser, IWebDosAnalysis
    {
        public SimpleWebDosAnalyser(List<IAlertReport> reportMethods, int heartBeatDelay, ISensorEventAgent sensorEventAgent): base( reportMethods, heartBeatDelay, sensorEventAgent)
        {
   
        }

        public SimpleWebDosAnalyser()
            : base()
        {

        }


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
            int totalEvents = SensorEventAgent.GetTotalEvents(webServerAddress, 80, analysisWindow);

            if (totalEvents > threshold)
            {
                foreach (IAlertReport alertReport in ReportMethods)
                {
                    IDMEFMessage alertMessage = IdmefMessageMapper.CreateWebDoSAlert(webServerAddress, analyserId.ToString());
                    alertReport.ReportAltert(alertMessage, analyserId.ToString());
                }
                alertRaised = true;
            }

            return alertRaised;
        }

    }
}
