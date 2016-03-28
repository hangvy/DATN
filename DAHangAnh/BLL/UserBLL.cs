using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAHangAnh.DAL.Entities;
using DAHangAnh.DAL;

namespace DAHangAnh.BLL
{
    public class UserBLL
    {
        public UserEntity checkUserLogin(string strConn,string userName, string password)
        {
            UserDAL userDAL=new UserDAL();
            return userDAL.fnCheckUserLogin(strConn, userName, password);
        }
    }
}
