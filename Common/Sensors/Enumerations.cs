using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ids.Common
{
    public class Enumerations
    {
        public enum SensorMode
        {
                PacketCapture,
                Statistics  
        }

        public enum DefaultPort
        {
            Ftp = 21,
            Ssh = 22,   
            Telnet = 23,
            Smtp = 25,
            Dns = 53,
            Http = 80,
            Https = 443
        }
    }
}
