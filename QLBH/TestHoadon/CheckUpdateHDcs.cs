using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestHoadon
{
    public class CheckUpdateHDcs
    {
        public static string kt_SuaHD(string MaHD, string MaNV, string MaKH, string NgayLapHDthaydoi, string NgayNhanHangthaydoi)
        {

            Connection con = new Connection();
            string kt = "0";
            if (NgayLapHDthaydoi == "") { kt = "1"; }

            else if (NgayNhanHangthaydoi == "") { kt = "2"; }
            else
            {
                con.TruyVan("UPDATE HOADON SET NgayLapHD = '" + NgayLapHDthaydoi + "', NgayNhanHang = '" + NgayNhanHangthaydoi + "' , WHERE MaHD ='" + MaHD + "'");
                kt = "0";
            }
            return kt;
        }
    }
}
