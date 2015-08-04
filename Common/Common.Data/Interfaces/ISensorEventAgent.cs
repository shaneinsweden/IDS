using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ids.Common.Data.Interfaces
{
    public interface ISensorEventAgent
    {
        /// <summary>
        /// log an alert
        /// </summary>
        /// <param name="sensorId"></param>
        /// <param name="sourceAddress"></param>
        /// <param name="sourcePort"></param>
        /// <param name="destinationAddress"></param>
        /// <param name="destinationPort"></param>
        /// <param name="timeVal"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        int LogEvent(string sensorId, string sourceAddress, int sourcePort, string destinationAddress, int destinationPort, DateTime timeVal, string payload);

        /// <summary>
        /// get data for port scan analysis
        /// </summary>
        /// <param name="analysisWindow"></param>
        /// <returns></returns>
        int GetMaxVericalEventsWithinAnalysisWindow(int? analysisWindow);

        /// <summary>
        /// get data for hosy scan analysis
        /// </summary>
        /// <param name="analysisWindow"></param>
        /// <returns></returns>
        int GetMaxHorizontalEventsWithinAnalysisWindow(int? analysisWindow);

        /// <summary>
        /// get event data for DoS analysis
        /// </summary>
        /// <param name="webServerAddress"></param>
        /// <param name="port"></param>
        /// <param name="analysisWindow"></param>
        /// <returns></returns>
        int GetTotalEvents(string webServerAddress, int port, int? analysisWindow);


        /// <summary>
        /// Get any traces of activity via text in the packet
        /// e.g. admin, su , root
        /// </summary>
        /// <param name="searchTerms"></param>
        /// <returns></returns>
        int GetTotalEvents(string[] searchTerms);
    }
}
