using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;

namespace Unittest_themsp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Them_SP()
        {
            string actual = check_themsp.kt_themsp("009", "Banh gio co tam", "15000");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
    }
}
