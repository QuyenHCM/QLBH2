using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.TestHoadon
{
    public class CheckSearchHD
    {
        public static string kt_SearchHD(string MaHD)
        {
            if (MaHD == string.Empty)
                return "1";
            Connection con = new Connection();
            DataGridView grid = new DataGridView();
            string lenh = "SELECT * FROM HOADON where MAHD = '" + MaHD + "'";
            con.TruyVan(lenh);
            return "0";
        }
    }
}
