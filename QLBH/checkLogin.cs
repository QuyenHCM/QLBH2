using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;

namespace QLBH
{
    public class checkLogin
    {
        public static string ktdangnhap(string id, string pass)
        {
            if((id=="") && (pass =="")){return("1");}
            else
            if((id =="")){return("2");}
            else
            if(pass==""){return("3");}

            else return "0";
        }
    }
}