using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ids.Common.Data
{
    public class AnalyserAlertDbAgent
    {

        /// <summary>
        /// Add an alert to the dbo.AlertLog table
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="analyserId"></param>
        /// <param name="idmefXmlData"></param>
        /// <returns></returns>
        public static int InsertAlert(string connectionString, string analyserId, string idmefXmlData)
        {
            int result = 0;
            string query = "INSERT INTO dbo.AlertLog (AnalyserId, IdmefMessage, Created) " +
                   "VALUES (@AnalyserId, @IdmefMessage, @Created) ";

            // create connection and command
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@AnalyserId", SqlDbType.VarChar, 50).Value = analyserId;
                    cmd.Parameters.Add("@IdmefMessage", SqlDbType.Xml).Value = idmefXmlData;
                    //cmd.Parameters.Add("@IdmefMessage", SqlDbType.Text).Value = idmefXmlData;
                    cmd.Parameters.Add("@Created", SqlDbType.DateTime).Value = DateTime.Now;

                    // open connection, execute INSERT, close connection
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return result;
        }
    }
}
