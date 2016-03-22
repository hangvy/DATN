using DAHangAnh.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHangAnh.DAL
{
    public class DetailFormDAL
    {
        public DataTable fnGetListDetailForm(string strConn)
        {
            var conn = new DBConnect(strConn);
            try
            {
                var dt = new DataTable();
                dt = conn.ExecuteReaderNonParmarter("spGetListDetailForm");
                return dt;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }


        // Inssert  a form detail
        public bool fnInsertDetailForm(string strConn, DetailFormEntity detailFormE)
        {
            var conn = new DBConnect(strConn);
            try
            {
                SqlParameter[] p = new SqlParameter[6];
                p[0] = new SqlParameter("@fieldName", detailFormE.fieldName);
                p[1] = new SqlParameter("@coordinateX", detailFormE.coordinateX);
                p[2] = new SqlParameter("@coordinateY", detailFormE.coordinateY);
                p[3] = new SqlParameter("@width", detailFormE.width);
                p[4] = new SqlParameter("@height", detailFormE.height);
                p[5] = new SqlParameter("@location", detailFormE.location);
                p[6] = new SqlParameter("@idForm", detailFormE.idForm);
                conn.ExecuteNonQueryParmarter("spInsertDetailForm", p);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
    }
}
