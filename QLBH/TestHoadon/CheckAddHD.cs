using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.TestHoadon
{
    public class CheckAddHD
    {
        public static string kt_AddHD(string MaHD, string MaNV, string MaKH, string NgayLapHD, string NgayNhanHang)
        {
            Connection con = new Connection();
            con.TruyVan("insert into HOADON(MaHD,MaNV,MaKH,NgayLapHD,NgayNhanHang) values ('" + MaHD + "','" + MaNV + "','" + MaKH + "','" + NgayLapHD + "','" + NgayNhanHang + "')");
            return "0";
        }
    }
}
