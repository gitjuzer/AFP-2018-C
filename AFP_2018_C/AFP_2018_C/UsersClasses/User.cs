﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C
{
    public class User
    {
        private string username;
        private string password;

        public string Username
        {
            get { return username; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                if (value.Length < 3)
                    throw new ArgumentOutOfRangeException();
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                username = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                if (value.Length < 8)
                    throw new ArgumentOutOfRangeException();
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                password = value;
            }
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
