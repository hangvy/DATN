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
    public class FormDAL
    {
        public DataTable fnGetListForm(string strConn)
        {
            var conn = new DBConnect(strConn);
            try
            {
                var dt = new DataTable();
                dt = conn.ExecuteReaderNonParmarter("spGetListForm");
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


        // Inssert  a form
        public bool fnInsertForm(string strConn, FormEntity formE)
        {
            var conn = new DBConnect(strConn);
            try
            {
                SqlParameter[] p = new SqlParameter[3];
                p[0] = new SqlParameter("@idForm", formE.formID);
                p[1] = new SqlParameter("@formName",formE.formName);
                p[2] = new SqlParameter("@UserName", formE.userName);
                conn.ExecuteNonQueryParmarter("spInsertForm", p);
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

        //Update 1
        //xóa một loại form- cần chú ý kiểm tra xóa các bản ghi khóa ngoại ở các bảng Image, DetailForm,
        public bool fnDeleteForm(string strConn,string idForm)
        {
            var conn = new DBConnect(strConn);
            try
            {
                SqlParameter[] p = new SqlParameter[1];
                p[0] = new SqlParameter("@idForm", idForm);
                conn.ExecuteNonQueryParmarter("spDeleteForm", p);
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

        public bool fnInsertImage(string strConn, ImageEntity imageE)
        {
            var conn = new DBConnect(strConn);
            try
            {
                SqlParameter[] p = new SqlParameter[6];
                p[0] = new SqlParameter("@imgName", imageE.ImgName);
                p[1] = new SqlParameter("@imgPath", imageE.ImgPath);
                p[2] = new SqlParameter("@status", imageE.Status);
                p[3] = new SqlParameter("@userName", imageE.UserName);
                p[4] = new SqlParameter("@upTime", imageE.UpTime);
                p[5] = new SqlParameter("@idForm", imageE.IdForm);
                conn.ExecuteNonQueryParmarter("spInsertImage", p);
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
