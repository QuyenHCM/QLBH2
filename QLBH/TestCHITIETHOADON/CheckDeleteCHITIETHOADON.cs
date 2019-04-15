using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.TestCHITIETHOADON
{
   public class CheckDeleteCHITIETHOADON
    {
        public static string kt_XoaCHITIETHOADON(string MaHD)
        {
            Connection con = new Connection();
            con.TruyVan("delete from CHITIETHOADON WHERE MaHD = '" + MaHD + "'");
            return "0";
        }
    }
}
