using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
using Ids.Common.Idmef;
using PacketDotNet;

namespace Ids.Common.Utilities
{
    /// <summary>
    /// Created IDMEF messages from various formats
    /// </summary>
    public class IdmefMessageMapper
    {
        public static Idmef.IDMEFMessage CreateAltertMessageFromRawPacket(Packet packet)
        {
            IDMEFMessage idmefMessage = new IDMEFMessage();
            idmefMessage.Items = new object[1];

            //this is an IDMEF alert
            Alert alertMessage = new Idmef.Alert();

            //build the alert message
            alertMessage.CreateTime = CreateTimestamp(DateTime.Now);
            // add more alert stuff here

            //add the alert to the message
            idmefMessage.Items[0] = alertMessage;

            return idmefMessage;
        }

        private static TimeWithNtpstamp CreateTimestamp(DateTime dateTime)
        {
            Idmef.TimeWithNtpstamp timestamp = new Idmef.TimeWithNtpstamp();
            timestamp.ntpstamp = dateTime.ToShortDateString();
            return timestamp;
        }

        public static IDMEFMessage CreateWebDoSAlert(string webServerAddress, string analyzerId)
        {
            IDMEFMessage idmefMessage = new IDMEFMessage();
            idmefMessage.Items = new object[1];

            //this is an IDMEF alert
            Alert alertMessage = new Alert();

            //build the alert message
            alertMessage.CreateTime = CreateTimestamp(DateTime.Now);
            
            alertMessage.Analyzer = new Analyzer();
            alertMessage.Analyzer.analyzerid = analyzerId;

            //add the alert to the message
            idmefMessage.Items[0] = alertMessage;

            return idmefMessage;
        }

        public static string GetXml(IDMEFMessage alertMessage)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(alertMessage.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, alertMessage);
                return textWriter.ToString();
            }

            //using (MemoryStream memStm = new MemoryStream())
            //{
            //    DataContractSerializer serializer = new DataContractSerializer(typeof(IDMEFMessage));

            //    serializer.WriteObject(memStm, alertMessage);

            //    memStm.Seek(0, SeekOrigin.Begin);

            //    using (var streamReader = new StreamReader(memStm))
            //    {
            //        string result = streamReader.ReadToEnd();
            //        return result;
            //    }
            //}
        }
    }
}
