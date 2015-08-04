using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ids.Common.Data;
using Ids.Common.Data.Interfaces;
using Ids.Common.Idmef;
using Ids.Common.Interfaces;

namespace Ids.Common.Analysers
{
    public class SimplePortScanAnalyser: BaseAnalyser, IPortScanAnalysis, IHostScanAnalysis
    {
        public SimplePortScanAnalyser(List<IAlertReport> reportMethods, int heartBeatDelay, ISensorEventAgent sensorEventAgent)
            : base(reportMethods, heartBeatDelay, sensorEventAgent)
        {
   
        }
        /// <summary>
        /// this method checks for vertival port scans (one destination ip addressv & many ports)
        /// </summary>
        /// <param name="threshold"></param>
        /// <param name="analysisWindow"></param>
        /// <returns></returns>
        public bool CheckForVerticalScan(int threshold, int analysisWindow)
        {
           
            bool alertRaised = false;

            int totalEvents = SensorEventAgent.GetMaxVericalEventsWithinAnalysisWindow(analysisWindow);

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

        /// <summary>
        /// this method checks for vertical port scans (many destination ip addresses & one port)
        /// </summary>
        /// <param name="threshold"></param>
        /// <param name="analysisWindow"></param>
        /// <returns></returns>
        public bool CheckForHorizontalScan(string connectionString, int threshold, int? analysisWindow)
        {
            bool alertRaised = false;

            int totalEvents = SensorEventAgent.GetMaxHorizontalEventsWithinAnalysisWindow(analysisWindow);

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

        public bool CheckForHorizontalScan(string connectionString, int threshold, int analysisWindow)
        {
            throw new NotImplementedException();
        }
    }
}
