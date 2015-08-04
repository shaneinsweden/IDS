using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ids.Common.Idmef;

namespace Ids.Common.Interfaces
{
    public interface IAlertReport
    {
        /// <summary>
        /// Report a security alert in the IDMEF format
        /// </summary>
        /// <param name="alertMessage"></param>
        /// <param name="sensorId"></param>
        void ReportAltert(IDMEFMessage alertMessage, string sensorId);
    }
}
