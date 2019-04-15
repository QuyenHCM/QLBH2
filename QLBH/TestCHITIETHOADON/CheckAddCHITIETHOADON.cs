using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.TestCHITIETHOADON
{
        public class CheckAddCHITIETHOADON
        {
            public static string kt_themCHITIETHOADON(string MaHD , string MaSP, string SoLuong)
            {
                Connection con = new Connection();
                con.TruyVan("insert into CHITIETHOADON(MaHD,MaSP,SoLuong) values ('" + MaHD + "','" + MaSP + "','" + SoLuong + "')");
                return "0";
            }
        }
       
    
}
