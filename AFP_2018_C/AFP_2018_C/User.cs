using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C
{
    class User
    {
        private string username;
        private string password;

        public string Username
        {
            get { return username; }
        }

        public string Password
        {
            get { return password; }
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
