using System;
using System.Diagnostics;
using Ids.Common.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.Data.Test
{
    [TestClass]
    public class SensorEventLogAgentTest
    {
        [TestMethod]
        public void InsertEvemt_Succeeds()
        {
            //arrange
            string connectionString = @"Data Source=UB1NB092\SQL2012;Initial Catalog=AzureIdsDb;Persist Security Info=True;User ID=cyberproduct;Password=x2000; Connect Timeout=600;Max Pool Size = 200;Pooling = True";
            Ids.Common.Data.Interfaces.ISensorEventAgent isea = new SensorEventDbAgent(connectionString);

            //act
            int numInserted = isea.LogEvent( "100", "123.3.4.3", 80, "199.16.5.7", 80, DateTime.Now,"hello world");

            //assert
            Assert.AreEqual(numInserted, 1);
           
        }
    }
}
