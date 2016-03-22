using DAHangAnh.DAL;
using DAHangAnh.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHangAnh.BLL
{
    public class FormBLL
    {
        public DataTable GetListForm(string strConn)
        {
            var formDAL = new FormDAL();
            return formDAL.fnGetListForm(strConn);
        }

        public bool InsertForm(string strConn,FormEntity formE)
        {
            var formDAL = new FormDAL();
            return formDAL.fnInsertForm(strConn,formE);
        }
    }
}
