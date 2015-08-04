using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Ids.Common.Data;
using Ids.Common.Data.Interfaces;
using Ids.Common.Idmef;
using Ids.Common.Interfaces;
using Ids.Common.Utilities;
using PacketDotNet;
using Tamir.IPLib.Packets;
using Packet = PacketDotNet.Packet;

namespace Ids.Common.Reporters
{
    /// <summary>
    /// Log sensor events to a database in the Azure Cloud
    /// </summary>
    public class AzureSqlDbReportAgent: ISensorReport, IAlertReport
    {
        private string _connectionString;

        private ISensorEventAgent _sensorEventAgent;

        public string SensorId
        {
            get
            {
                return _sensorId;
            }
            set
            {
                _sensorId = value;
            }
        }

        private string _sensorId;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connectionString">Connection string to the AzureSql Server</param>
        public AzureSqlDbReportAgent(string connectionString)
        {
            _connectionString = connectionString;
            _sensorEventAgent = new SensorEventDbAgent(connectionString);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connectionString">Connection string to the AzureSql Server</param>
        /// <param name="sensorId"></param>
        public AzureSqlDbReportAgent(string connectionString, string sensorId)
        {
            _connectionString = connectionString;
            _sensorId = sensorId;
            _sensorEventAgent = new SensorEventDbAgent(connectionString);
        }

        public void UpdateSensorId(string newSensorId)
        {
            _sensorId = newSensorId;
        }
        public void ReportPacketCapture(Packet packet, DateTime arrivalTime)
        {
            IpPacket ip = (IpPacket)packet.Extract(typeof(IpPacket)); 
            TcpPacket tcp = (TcpPacket)packet.Extract(typeof(TcpPacket));
            ASCIIEncoding format = new ASCIIEncoding();
            string payloadAsText = format.GetString(packet.Bytes);
            payloadAsText = payloadAsText.ToLower();

            //remove non readable characters
            //payloadAsText = Regex.Replace(payloadAsText, @"[^\u0000-\u007F]", string.Empty);
            payloadAsText = Regex.Replace(payloadAsText, "[^0-9a-zA-Z]+", string.Empty);

            if ((tcp != null) && (payloadAsText.Contains("ftp")))
            {
                int x = 5;
            }
            if (payloadAsText.Length > 255)
            {
                payloadAsText = payloadAsText.Substring(0, 255);
            }

            
            if (tcp != null)
            {
                _sensorEventAgent.LogEvent(_sensorId, ip.DestinationAddress.ToString(), tcp.DestinationPort, ip.SourceAddress.ToString(), tcp.SourcePort,
                   arrivalTime, payloadAsText);
            }
        }

        public void SendHeartBeat(string sensorId)
        {
            SensorHeartbeatDbAgent.InsertHeartbeatEvent(_connectionString, _sensorId);
        }

        /// <summary>
        /// Statistics would be a great way of detecting DoS attacks - more efficient than looking at individual packet detection
        /// </summary>
        /// <param name="statsPacket"></param>
        /// <param name="lasTimeval"></param>
        /// <param name="sensorId"></param>
        public void ReportStatistics(SharpPcap.WinPcap.StatisticsModePacket statsPacket, SharpPcap.PosixTimeval lasTimeval, string sensorId)
        {
            throw new NotImplementedException();
        }

        public void ReportAltert(IDMEFMessage alertMessage, string analyzerId)
        {
            string altertMessageAsXml = IdmefMessageMapper.GetXml(alertMessage);

            AnalyserAlertDbAgent.InsertAlert(_connectionString, analyzerId, altertMessageAsXml);
        }
    }
}
