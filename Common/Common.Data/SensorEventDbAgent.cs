using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Ids.Common.Data.Interfaces;

namespace Ids.Common.Data
{
    /// <summary>
    /// Handles data access with the SensorHeartbeatLog table
    /// </summary>
    public class SensorEventDbAgent : ISensorEventAgent
    {
        private string _connectionString;

        public SensorEventDbAgent(string connectionString)
        {
            _connectionString = connectionString;
        }
         public int LogEvent(string sensorId, string sourceAddress, int sourcePort, string destinationAddress, int destinationPort, DateTime timeVal, string payload)
         {
             int result = 0;
            string query = "INSERT INTO dbo.SensorEventLog (SensorId, SourceAddress, SourcePort, DestinationAddress, DestinationPort, TimeVal, Payload, Created) " +
                   "VALUES (@SensorId, @SourceAddress, @SourcePort, @DestinationAddress, @DestinationPort, @TimeVal, @Payload, @Created) ";

             // create connection and command
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@SensorId", SqlDbType.VarChar, 50).Value = sensorId;
                    cmd.Parameters.Add("@SourceAddress", SqlDbType.VarChar, 50).Value = sourceAddress;
                    cmd.Parameters.Add("@SourcePort", SqlDbType.VarChar, 50).Value = sourcePort;
                    cmd.Parameters.Add("@DestinationAddress", SqlDbType.VarChar, 50).Value = destinationAddress;
                    cmd.Parameters.Add("@DestinationPort", SqlDbType.Int).Value = destinationPort;
                    cmd.Parameters.Add("@TimeVal", SqlDbType.VarChar, 50).Value = timeVal;
                    //cmd.Parameters.Add("@Payload", SqlDbType.Text).Value = payload; SqlDbType.VarChar, 50
                    cmd.Parameters.Add("@Payload", SqlDbType.VarChar, 255).Value = payload; 
                    cmd.Parameters.Add("@Created", SqlDbType.DateTime).Value = DateTime.Now;

                    // open connection, execute INSERT, close connection
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
             return result;
         }

         public int GetMaxVericalEventsWithinAnalysisWindow(int? analysisWindow)
         {
             int total = 0;
             if (analysisWindow != null)
             {
                 throw new NotImplementedException("we can't handle time windows yet");
             }

             string query = @"select max(count), destinationAddress from (select count(*) as count, destinationAddress from [AzureIdsDb].[dbo].[SensorEventLog] group by DestinationAddress) as temp group by destinationAddress";

             using (SqlConnection conn = new SqlConnection(_connectionString))
             {
                 using (SqlCommand cmd = new SqlCommand(query, conn))
                 {
                     // open connection, execute INSERT, close connection
                     conn.Open();
                     int.TryParse(cmd.ExecuteScalar().ToString(), out total);
                     conn.Close();
                 }
             }

             return total;
         }

         public int GetMaxHorizontalEventsWithinAnalysisWindow(int? analysisWindow)
         {
             int total = 0;
             if (analysisWindow != null)
             {
                 throw new NotImplementedException("we can't handle time windows yet");
             }

             string query = @"select max(count), destinationPort from (select count(*) as count, destinationPort from [AzureIdsDb].[dbo].[SensorEventLog] group by destinationPort) as temp group by destinationPort";

             using (SqlConnection conn = new SqlConnection(_connectionString))
             {
                 using (SqlCommand cmd = new SqlCommand(query, conn))
                 {
                     // open connection, execute INSERT, close connection
                     conn.Open();
                     int.TryParse(cmd.ExecuteScalar().ToString(), out total);
                     conn.Close();
                 }
             }

             return total;
         }

         public int GetTotalEvents(string webServerAddress, int port, int? analysisWindow)
         {
             int total = 0;

             if (analysisWindow != null)
             {
                 throw new NotImplementedException("we can't handle time windows yet");
             }

             string query = @"  select count(*) from [AzureIdsDb].[dbo].[SensorEventLog]  sel where DestinationAddress = @DestinationAddress and DestinationPort = @DestinationPort";

             using (SqlConnection conn = new SqlConnection(_connectionString))
             {
                 using (SqlCommand cmd = new SqlCommand(query, conn))
                 {
                     cmd.Parameters.Add("@DestinationAddress", SqlDbType.VarChar, 50).Value = webServerAddress;
                     cmd.Parameters.Add("@DestinationPort", SqlDbType.Int).Value = port;
                     // open connection, execute INSERT, close connection
                     conn.Open();
                     int.TryParse(cmd.ExecuteScalar().ToString(), out total);
                     conn.Close();
                 }
             }
             return total;
         }

        /// <summary>
        /// search for a captured event where the text in the packet payload
        /// matches one of the searchterms
        ///
        /// </summary>
        /// <param name="searchTerms"></param>
        /// <returns></returns>
         public int GetTotalEvents(string[] searchTerms)
         {
             int total = 0;

             if ((searchTerms == null)||( searchTerms.Length == 0))
             {
                 throw new ArgumentOutOfRangeException("no searchterms found");
             }

             string query = @"select count(*) from [AzureIdsDb].[dbo].[SensorEventLog] where  CHARINDEX(@searchTerm, Payload) > 0";

             using (SqlConnection conn = new SqlConnection(_connectionString))
             {
                 foreach (string searchterm in searchTerms)
                 {
                     using (SqlCommand cmd = new SqlCommand(query, conn))
                     {
                         cmd.Parameters.Add("@searchTerm", SqlDbType.VarChar, 255).Value = searchterm;
                         // open connection, execute INSERT, close connection
                         conn.Open();
                         int.TryParse(cmd.ExecuteScalar().ToString(), out total);
                         conn.Close();
                     }
                     if (total > 0) break;
                 }
             }
             return total;
         }
    }
}
