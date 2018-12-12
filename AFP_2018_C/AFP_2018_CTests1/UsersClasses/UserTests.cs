using Microsoft.VisualStudio.TestTools.UnitTesting;
using AFP_2018_C;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void UserTestUserUsername1()
        {
            string username = "username";
            User user = new User(username, "password");

            string expected = "username";

            string actual = user.Username;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserTestUserPassword1()
        {
            string password = "password";
            User user = new User("username", password);

            string expected = "password";

            string actual = user.Password;

            Assert.AreEqual(expected, actual);
        }
    }
}