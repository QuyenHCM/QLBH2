using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;



namespace Unitest_Sanpham
{
    [TestClass]
    public class UnitTest1
    {

        public static string kt_themsp(string masp, string tensp, string tengia)
        {
            Connection con = new Connection();
            con.TruyVan("insert into SANPHAM(MaSP,TenSP,DonGia) values ('" + masp + "','" + tensp + "','user')");
            return "0";
        }
    }
}
