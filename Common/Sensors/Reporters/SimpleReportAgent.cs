
using System;
using Ids.Common.Idmef;
using Ids.Common.Interfaces;
using PacketDotNet;
using SharpPcap;

namespace Ids.Common.Reporters
{
    public class SimpleReportAgent: ISensorReport, IAlertReport
    {
        public void SendHeartBeat(string sensorId)
        {
            Console.WriteLine("heartbeat from " + sensorId + " " + DateTime.Now.ToShortTimeString());
        }

        public void ReportStatistics(SharpPcap.WinPcap.StatisticsModePacket statsPacket, PosixTimeval lastTimeval,string sensorId)
        {
            Console.WriteLine("stats packet:\t" + statsPacket.RecievedPackets + "\t" + statsPacket.RecievedBytes + "\t" +  statsPacket.Timeval.CompareTo(lastTimeval));
        }

        public void ReportPacketCapture(Packet packet, DateTime arrivalTime)
        {
            Console.WriteLine("packet captured" + packet.ToString(StringOutputType.Normal).Substring(0, 40));
        }


        public void ReportAltert(IDMEFMessage alertMessage, string sensorId)
        {
            Console.WriteLine("Alert declared " + alertMessage.version + " by sensor " + sensorId);
        }
    }
}
