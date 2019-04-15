using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestSanPham
{
    public class CheckDeleteSP
    {
        public static string kt_xoasp(string masp)
        {
            Connection con = new Connection();
            con.TruyVan("delete from SANPHAM WHERE MaSp = '"+masp+"'");
            return "0";
        }
    }
}
