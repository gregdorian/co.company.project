using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using co.company.Business;

namespace UTest.Company
{
    [TestClass]
    public class TestData
    {
        [TestMethod]
        public void LoginAccess()
        {
            Assert.IsTrue(AuthenticateUser.IngresoApp("Angie", "tMmkuAo"));
            //Assert.IsTrue(AccessLogin.IngresoApp("", ""));
            //Assert.IsTrue(AccessLogin.IngresoApp("GREG", "DASD145"));
            //Assert.IsTrue(AccessLogin.IngresoApp("344", ""));//
        }
    }
}
