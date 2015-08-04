using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ids.Common.Idmef;
using Ids.Common.Interfaces;

namespace Ids.Common.Analysers
{
    public class SimpleAdminLoginAnalyser : BaseAnalyser
    {
        /// <summary>
        /// this method checks for an attempted admin activity, root, su etc.
        /// </summary>
        /// <returns></returns>
        public bool CheckForTextSignifyingAttack(string[] searchTerms)
        {
            bool alertRaised = false;

            //fetch the data to base the decision from the appropriate agent 
            int totalEvents = SensorEventAgent.GetTotalEvents(searchTerms);

            if (totalEvents > 0)
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
