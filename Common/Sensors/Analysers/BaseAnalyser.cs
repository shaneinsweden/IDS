using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ids.Common.Data.Interfaces;
using Ids.Common.Interfaces;

namespace Ids.Common.Analysers
{
    public class BaseAnalyser
    {
        internal Guid analyserId;

        internal List<IAlertReport> ReportMethods;

        internal ISensorEventAgent SensorEventAgent;
        public BaseAnalyser()
        {
            analyserId = Guid.NewGuid();
        }
        public BaseAnalyser(List<IAlertReport> reportMethods, int heartBeatDelay, ISensorEventAgent sensorEventAgent)
            : base()
        {
            ReportMethods = reportMethods;
            SensorEventAgent = sensorEventAgent;
            analyserId = Guid.NewGuid();
        }

        public string GetId()
        {
            return analyserId.ToString();
        }
    }
}
