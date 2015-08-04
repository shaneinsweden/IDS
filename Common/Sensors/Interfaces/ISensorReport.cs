using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ids.Common.Idmef;
using SharpPcap;
using SharpPcap.WinPcap;

namespace Ids.Common.Interfaces
{
    public interface ISensorReport
    {
        void ReportPacketCapture(PacketDotNet.Packet packet, DateTime arrivalTime);
        void SendHeartBeat(string sensorId);
        void ReportStatistics(StatisticsModePacket statsPacket, PosixTimeval lasTimeval, string sensorId);
    }
}
