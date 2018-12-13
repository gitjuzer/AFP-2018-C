using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C.Database
{
    class UsersTableManager : BaseDatabaseManager
    {
        public List<User> SelectAll()
        {
            List<User> list = new List<User>();
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Users";
            command.Connection = getConnection();

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User record = new User();
                record.Username = reader["username"].ToString();
                record.Password = reader["password"].ToString();
                record.Szerepkor = reader["szerepkor"].ToString();
                list.Add(record);
            }
            
            return list;
        }
    }
}
