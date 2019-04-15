using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestHoadon
{
    public class CheckDeleteHD
    {
        public static string kt_XoaHD(string MaHD)
        {
            Connection con = new Connection();
            con.TruyVan("delete from HOADON WHERE MaHD = '" + MaHD + "'");
            return "0";
        }
    }
}
