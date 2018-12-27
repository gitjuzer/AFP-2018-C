using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C.Database
{
    public class BaseDatabaseManager
    {
        public BaseDatabaseManager() { }

        protected OracleConnection getConnection()
        {
            string connString = @"Data Source = 193.225.33.71; User Id = HQFTAD; Password = szelektcsillag;";
            OracleConnection connection = new OracleConnection(connString);
            connection.Open();
            return connection;
        }
    }
}
