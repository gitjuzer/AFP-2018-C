using Microsoft.VisualStudio.TestTools.UnitTesting;
using AFP_2018_C;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFP_2018_C.Database.Entities;
using AFP_2018_C.Database;

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

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "A password nem lehet 8 karakternél kisebb")]
        public void UserTestUserPasswordKisebb()
        {
            string password = "passwor";
            User user = new User("username", password);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "A password nem lehet 32 karakternél nagyobb")]
        public void UserTestUserPasswordNagyobb()
        {
            string password = "012345678901234567890123456789012";
            User user = new User("username", password);
        }
        [TestMethod]
        public void MathQuestionsAll()
        {
            MathQuestion expected = new MathQuestion();
            expected.Text = "test";
            expected.Score = 1;
            expected.Answers = new List<MathAnswer>()
            {
                new MathAnswer("valasz1", false),
                new MathAnswer("valasz2", true)
            };

            MathQuestionsManager manager = new MathQuestionsManager();
            MathQuestion actual = manager.Select(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnvironmentalQuestionsAll()
        {
            EnvironmentalQuestion expected = new EnvironmentalQuestion();
            expected.Text = "test";
            expected.Score = 2;
            expected.Answers = new List<EnvironmentalAnswer>()
            {
                new EnvironmentalAnswer("valasz1", false),
                new EnvironmentalAnswer("valasz2", false),
                new EnvironmentalAnswer("valasz3", true),
                new EnvironmentalAnswer("valasz4", false)
            };

            EnvironmentalQuestionsManager manager = new EnvironmentalQuestionsManager();
            EnvironmentalQuestion actual = manager.Select(2);

            Assert.AreEqual(expected, actual);
        }
    }
}