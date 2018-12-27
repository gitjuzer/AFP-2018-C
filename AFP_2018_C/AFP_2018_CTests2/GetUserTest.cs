using System;
using AFP_2018_C.Database.Entities;
using AFP_2018_C.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AFP_2018_CTests2
{
    [TestClass]
    public class GetUserTest
    {
        [TestMethod]
        public void UserNotExists()
        {
            UsersTableManager manager = new UsersTableManager();

            User expected = null;

            User actual = manager.GetUser("nemletezo","nemletezo");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserExists()
        {
            UsersTableManager manager = new UsersTableManager();

            User expected = new User("teszttanulo", "teszttanulo");

            User actual = manager.GetUser("teszttanulo", "teszttanulo");

            Assert.AreEqual(expected, actual);
        }
    }
}
