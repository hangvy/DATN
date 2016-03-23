using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAHangAnh.DAL;
using DAHangAnh.DAL.Entities;
using System.Data;
namespace DAHangAnh.BLL
{
    public class DetailFormBLL
    {
        public DataTable GetListDetailForm(string strConn)
        {
            var detailFormDAL = new DetailFormDAL();
            return detailFormDAL.fnGetListDetailForm(strConn);
        }

        public bool InsertForm(string strConn, DetailFormEntity detailFormE)
        {
            var detailFormDAL = new DetailFormDAL();
            return detailFormDAL.fnInsertDetailForm(strConn, detailFormE);
        }
    }
}
