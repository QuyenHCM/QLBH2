using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestCHITIETHOADON
{
    public class CheckUpdateCHITIETHOADON
    {
        public static string kt_SuaCHITIETHOADON(string MaHD, string MaSP, string SoLuongthaydoi)
        {

            Connection con = new Connection();
            string kt = "0";
            if (SoLuongthaydoi == "") { kt = "1"; }
            else
            {
                con.TruyVan("UPDATE CHITIETHOADON SET SoLuong = '" + SoLuongthaydoi + "', WHERE MaHD ='" + MaHD + "'");
                kt = "0";
            }
            return kt;
        }
    }
}
