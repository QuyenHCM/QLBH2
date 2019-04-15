using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.TestSanPham
{
    public class CheckAddSP
    {
        public static string kt_themsp(string masp, string tensp, string dongia)
        {
            Connection con = new Connection();
            con.TruyVan("insert into SANPHAM(MaSP,TenSP,DonGia) values ('" + masp + "','" + tensp + "','" + dongia +"')");
            return "0";
        }

    }
}
