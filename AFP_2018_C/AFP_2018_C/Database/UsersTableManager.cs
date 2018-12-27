using AFP_2018_C.Database.Entities;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C.Database
{
    public class UsersTableManager : BaseDatabaseManager
    {
        public List<User> SelectAll()
        {
            List<User> list = new List<User>();
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Users";
            command.Connection = getConnection();

            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    User record = new User();
                    record.Username = reader["username"].ToString();
                    record.Password = reader["password"].ToString();
                    record.Szerepkor = reader["szerepkor"].ToString();
                    list.Add(record);
                }
            }         

            return list;
        }

        public bool Insert(User user)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO users(username,password,szerepkor) VALUES(:username,:password,:szerepkor);";

            OracleParameter username = new OracleParameter();
            username.ParameterName = ":username";
            username.DbType = System.Data.DbType.String;
            username.Value = user.Username;
            command.Parameters.Add(username);

            OracleParameter password = new OracleParameter();
            password.ParameterName = ":password";
            password.DbType = System.Data.DbType.String;
            password.Value = user.Password;
            command.Parameters.Add(password);

            OracleParameter szerepkor = new OracleParameter();
            szerepkor.ParameterName = ":szerepkor";
            szerepkor.DbType = System.Data.DbType.String;
            szerepkor.Value = user.Szerepkor;
            command.Parameters.Add(szerepkor);

            command.Connection = getConnection();
            return command.ExecuteNonQuery() == -1;

        }

        public bool Delete(User user)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Users WHERE username = :username;";

            OracleParameter username = new OracleParameter();
            username.ParameterName = ":username";
            username.DbType = System.Data.DbType.String;
            username.Value = user.Username;
            command.Parameters.Add(username);

            command.Connection = getConnection();
            return command.ExecuteNonQuery() == -1;
        }

        public User GetUser(string username, string password)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Users WHERE username = :username AND password = :password";
            command.Connection = getConnection();

            OracleParameter p_username = new OracleParameter();
            p_username.ParameterName = ":username";
            p_username.DbType = System.Data.DbType.String;
            p_username.Value = username;
            command.Parameters.Add(p_username);

            OracleParameter p_password = new OracleParameter();
            p_password.ParameterName = ":password";
            p_password.DbType = System.Data.DbType.String;
            p_password.Value = password;
            command.Parameters.Add(p_password);

            User user;

            using (OracleDataReader reader = command.ExecuteReader())
            {
                
                if (reader.Read())
                {
                    user = new User();
                    user.Username = reader["username"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Szerepkor = reader["szerepkor"].ToString();
                }
                else
                {
                    user = null;
                }


                return user;
            }

        }

        public UsersTableManager() { }
    }
}
