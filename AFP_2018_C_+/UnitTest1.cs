using System;
using AFP_2018_C;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AFP_2018_C__
{
    [TestClass]
    public class SzuloAdminTest
    {
        [TestMethod]
        public void SzuloAdmine()
        {
            var loginSzulo = new LoginSzulo();

            var result = loginSzulo.szulo.IsAdmin;

            Assert.IsTrue(result);


            }
        }
  
}
