﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;

namespace UnitTest_Login
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Nhap_Dung_Tai_Khoan()
        {
            string actual = checkLogin.ktdangnhap("baoquyen", "123");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_ID_and_Pass()
        {
            string actual = checkLogin.ktdangnhap("", "");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_ID()
        {
            string actual = checkLogin.ktdangnhap("", "123");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_Pass()
        {

            string actual = checkLogin.ktdangnhap("abc", "");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }
    

    }
}
