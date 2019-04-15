using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH.TestSanPham;
using System.Windows.Forms;
using QLBH;

namespace UnitTest_Login
{
    [TestClass]
    public class SanPham
    {
       
        [TestMethod]
        public void Test_Them_SP()
        {
            string actual = CheckAddSP.kt_themsp("058", "nuoc tay trang", "200000");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Xoa_SP()
        {
            string actual = CheckDeleteSP.kt_xoasp("002");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Update_SP()
        {
            string actual = CheckUpdateSP.kt_suasp("009", "Nước lau sàn", "20000");
            string expected = "0";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_SP_2()
        {
            string actual = CheckUpdateSP.kt_suasp("009", "", "20000");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_SP_3()
        {
            string actual = CheckUpdateSP.kt_suasp("009", "Bong tay trang", "");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_SP_TimThay()
        {
            string actual = CheckSearchSP.kt_timkiemsp("002");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_SP_Rong()
        {
            string actual = CheckSearchSP.kt_timkiemsp(string.Empty);
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_SP_KhongTimThay()
        {
            string actual = CheckSearchSP.kt_timkiemsp("111");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
    }
}
