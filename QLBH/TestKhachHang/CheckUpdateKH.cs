using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestKhachHang
{
    public class CheckUpdateKH
    {
        public static string kt_SuaKH(string MaKH, string HoTenthaydoi, string SDTthaydoi, string CMNDthaydoi, string DiaChithaydoi)
        {

            Connection con = new Connection();
            string kt = "0";
            if (HoTenthaydoi == "") { kt = "1"; }

            else if (SDTthaydoi == "") { kt = "2"; }
            else if (CMNDthaydoi == "") { kt = "3"; }
            else if (DiaChithaydoi == "") { kt = "4"; }
            else
            {
                    con.TruyVan("UPDATE KHACHHANG SET HoTen = '" + HoTenthaydoi + "', SDT = '" + SDTthaydoi + "' ,CMND = '" + CMNDthaydoi + "',DiaChi = '" + DiaChithaydoi + "', WHERE MaKH ='" + MaKH + "'");
                kt = "0";
            }
            return kt;
        }
    }
}
