using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBH.TestKhachHang
{
    public class CheckAddKH
    {
        public static string kt_themkh(string makh, string hoten, string sdt,string cmnd,string diachi )
        {
            Connection con = new Connection();
            con.TruyVan("insert into KHACHHANG(MaKH,HoTen,SDT,CMND,DiaChi) values ('" + makh + "','" + hoten + "','" + sdt + "','" + cmnd + "','" + diachi + "')");
            return "0";
        }
    }
}
