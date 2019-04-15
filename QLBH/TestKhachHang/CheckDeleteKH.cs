using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestKhachHang
{
    public class CheckDeleteKH
    {
        public static string kt_XoaKH(string MaKH)
        {
            Connection con = new Connection();
            con.TruyVan("delete from KHACHHANG WHERE MaKH = '" + MaKH + "'");
            return "0";
        }
    }
}
