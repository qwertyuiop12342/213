using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AutotestApplicationExample;

namespace People_Test
{
    [TestClass]
    public class UnitTest1
    {

        People PeopleTestTask = new People("labLogin", "admin", "example@gmail.com", "8(800)333222333");

        [TestMethod]
        public void TestMethodLogin()
        {
            Assert.AreEqual("labLogin", PeopleTestTask.login1);
        }
        [TestMethod]
        public void TestMethodPassword()
        {
            Assert.AreEqual("admin", PeopleTestTask.password1);
        }
        [TestMethod]
        public void TestMethodEmail()
        {
            Assert.AreEqual("example@gmail.com", PeopleTestTask.email1);
        }
        [TestMethod]
        public void TestMethodPhone()
        {
            Assert.AreEqual("8(800)333222333", PeopleTestTask.phone1);
        }
    }
}
