using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.TestCHITIETHOADON
{
    public class CheckSearchCHITIETHOADON
    {
        public static string kt_SearchCHITIETHOADON(string MaHD)
        {
            if (MaHD == string.Empty)
                return "1";
            Connection con = new Connection();
            DataGridView grid = new DataGridView();
            string lenh = "SELECT * FROM CHITIETHOADON where MAHD = '" + MaHD + "'";
            con.TruyVan(lenh);
            return "0";
        }
    }
}
