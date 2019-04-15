using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using QLBH;
using QLBH.TestKhachHang;

namespace UnitTest_Login
{
    [TestClass]
    public class KhachHang
    {
        [TestMethod]
        public void Test_AddKH()
        {
            string actual =CheckAddKH.kt_themkh ("015", "Thanh Tam", "0937828889","287648594","32 DakLak");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Xoa_KH()
        {
            string actual = CheckDeleteKH.kt_XoaKH("002");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_KH()
        {
            string actual = CheckUpdateKH.kt_SuaKH("005","Hoang", "0927873930","673893028","12 Sóc Trăng");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Update_KH_2()
        {
            string actual = CheckUpdateKH.kt_SuaKH("005", "", "0928454647","352784930","445 nguyen trai");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_KH_3()
        {
            string actual = CheckUpdateKH.kt_SuaKH("005", "khanh doan", "", "129873788", "56 nguyen trai");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Update_KH_4()
        {
            string actual = CheckUpdateKH.kt_SuaKH("005", "khanh doan", "0917662578", "", " nguyen trai");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Update_KH_5()
        {
            string actual = CheckUpdateKH.kt_SuaKH("005", "khanh doan", "0917552578", "936873788", "");
            string expected = "4";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_KH_TimThay()
        {
            string actual = CheckSearchKH.kt_SearchKH("001");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_KH_Rong()
        {
            string actual = CheckSearchKH.kt_SearchKH(string.Empty);
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_KH_KhongTimThay()
        {
            string actual = CheckSearchKH.kt_SearchKH("111");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
    }
}
