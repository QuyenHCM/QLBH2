using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;
using QLBH.TestCHITIETHOADON;

namespace UnitTest_Login
{
    [TestClass]
    public class CHITIETHOADON
    {

        [TestMethod]
        public void Test_Search_CHITIETHOADON_TimThay()
        {
            string actual = CheckSearchCHITIETHOADON.kt_SearchCHITIETHOADON("001");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Search_CHITIETHOADON_Rong()
        {
            string actual = CheckSearchCHITIETHOADON.kt_SearchCHITIETHOADON(string.Empty);
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Search_CHITIETHOADON_KhongTimThay()
        {
            string actual = CheckSearchCHITIETHOADON.kt_SearchCHITIETHOADON("111");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_AddCHITIETHOADON()
        {
            string actual = CheckAddCHITIETHOADON.kt_themCHITIETHOADON("003", "074", "20");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_CHITIETHOADON()
        {
            string actual = CheckUpdateCHITIETHOADON.kt_SuaCHITIETHOADON("001", "002", "8");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_CHITIETHOADON_2()
        {
            string actual = CheckUpdateCHITIETHOADON.kt_SuaCHITIETHOADON("001","002","");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Xoa_CHITIETHOADON()
        {
            string actual = CheckDeleteCHITIETHOADON.kt_XoaCHITIETHOADON("001");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
    }
}
