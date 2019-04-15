using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH.TestHoadon;
using QLBH;

namespace UnitTest_Login
{
    [TestClass]
    public class HoaDon
    {
        [TestMethod]
        public void Test_Search_HD_TimThay()
        {
            string actual = CheckSearchHD.kt_SearchHD("001");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_HD_Rong()
        {
            string actual = CheckSearchHD.kt_SearchHD(string.Empty);
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_HD_KhongTimThay()
        {
            string actual = CheckSearchHD.kt_SearchHD("111");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ADD_HD()
        {
            string actual = CheckAddHD.kt_AddHD("099", "478", "999", "2019-08-06", "2019-08-10");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Xoa_HD()
        {
            string actual = CheckDeleteHD.kt_XoaHD("012");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Update_HD()
        {
            string actual =CheckUpdateHDcs.kt_SuaHD("001", "001", "001","2019-04-04", "2019-04-09");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Update_HD_2()
        {
            string actual = CheckUpdateHDcs.kt_SuaHD("001", "001", "001", "", "2016-09-10 00:00:00.000");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Update_HD_3()
        {
            string actual = CheckUpdateHDcs.kt_SuaHD("001", "001", "001", "2015-08-06 00:00:00.000", "");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
    }
}
