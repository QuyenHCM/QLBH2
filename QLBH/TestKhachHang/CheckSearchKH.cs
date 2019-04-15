using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.TestKhachHang
{
    public class CheckSearchKH
    {
        public static string kt_SearchKH(string MaKH)
        {
            if (MaKH == string.Empty)
                return "1";
            Connection con = new Connection();
            DataGridView grid = new DataGridView();
            string lenh = "SELECT * FROM KHACHHANG where MAKH = '" + MaKH + "'";
            con.TruyVan(lenh);
            return "0";
        }
    }
}
