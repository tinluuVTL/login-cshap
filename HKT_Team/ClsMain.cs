using HKT_Team.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HKT_Team
{
    public class ClsMain
    {
        public static string taiKhoan;
        public static string pathUserFile = string.Format(@"{0}\Users.ini", Application.StartupPath);
        //khai bao danh sach user (toan cu)
        public static List<User> users = null;
    }
}
