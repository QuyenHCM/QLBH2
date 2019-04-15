using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestSanPham
{
    public class CheckUpdateSP
    {
        public static string kt_suasp(string masp, string tenspthaydoi, string dongiathaydoi)
        {
            
                Connection con = new Connection();
                string kt = "0";
                if (tenspthaydoi == "") { kt = "1"; }

                else if (dongiathaydoi == "") { kt = "2"; }
                else
                {
                    con.TruyVan("UPDATE SANPHAM SET TenSP = '" + tenspthaydoi + "', DonGia = '" + dongiathaydoi + "' WHERE MaSP ='" + masp + "'");
                    kt = "0";
                }
            return kt;

        }
    }
}
