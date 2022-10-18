using HKT_Team.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKT_Team.BusinessLayer
{
    public class BLLUser
    {
        UserDao userDao;
        public BLLUser()
        {
            userDao = new UserDao();
        }
        public BLLUser(string path)
        {
            userDao = new UserDao(path);
        }
        public bool KiemTraTaiKhoan(string taiKhoan, string matKhau)
        {
            foreach (User item in userDao.ListUser)
            {
                if (item.TaiKhoan.Equals(taiKhoan) && item.MatKhau.Equals(matKhau))
                    return true;
            }
            return false;
        }

        public List<User> GetUsers()
        {
            return userDao.GetUsers();
        }

        public bool GhiUser(string path, List<User> users)
        {
            return userDao.GhiUser(path, users);
        }
    }
}
