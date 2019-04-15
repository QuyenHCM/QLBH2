using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.TestSanPham
{
    public class CheckSearchSP
    {
        public static string kt_timkiemsp(string masp)
        {
                if (masp == string.Empty) 
                    return "1";
                Connection con = new Connection();
                DataGridView grid = new DataGridView();
                string lenh = "SELECT * FROM SANPHAM where MASP = '" + masp + "'";
                con.TruyVan(lenh);
                return "0";
        }
    }
}
