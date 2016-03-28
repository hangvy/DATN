using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAHangAnh.DAL.Entities;
using DAHangAnh.DAL;

namespace DAHangAnh
{
    public class UserDAL
    {
        public DataTable fnGetListUser(string strConn)
        {
            var conn = new DBConnect(strConn);
            try
            {
                var dt = new DataTable();
                dt = conn.ExecuteReaderNonParmarter("spGetListUser");
                return dt;
            }
            catch
            {
                return null;
                throw;
            }
            finally
            {
                conn.CloseConnection();
            }
        }


        public UserEntity fnCheckUserLogin(string strConn, string UserName, string Password)
        {
            var conn = new DBConnect(strConn);
            try
            {
                var dt = new DataTable();
                var userE = new UserEntity();
                SqlParameter[] p = new SqlParameter[2];
                p[0] = new SqlParameter("UserName", UserName);
                p[1] = new SqlParameter("Password", Password);
                dt = conn.ExecuteReaderParmarter("spCheckLogin", p);
                userE.UserName = dt.Rows[0]["UserName"].ToString();
                userE.Password = dt.Rows[0]["Password"].ToString();
                userE.FullName = dt.Rows[0]["FullName"].ToString();
                userE.PhoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
                userE.Role = dt.Rows[0]["Role"].ToString();
                return userE;
            }
            catch
            {
                return null;
                throw;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
        public UserEntity fnGetUserByID(string strConn, int UserID)
        {
            var conn = new DBConnect(strConn);
            try
            {
                var dt = new DataTable();
                var userE = new UserEntity();
                SqlParameter[] p = new SqlParameter[1];
                p[0] = new SqlParameter("@UserID", UserID);
                dt = conn.ExecuteReaderParmarter("spGetUserByID", p);
                userE.UserName = dt.Rows[0]["UserName"].ToString();
                userE.Password = dt.Rows[0]["Password"].ToString();
                userE.PhoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
                userE.FullName = dt.Rows[0]["FullName"].ToString();
                userE.Role = dt.Rows[0]["Role"].ToString();
                return userE;
            }
            catch
            {
                return null;
                throw;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public UserEntity fnGetUserByUserName(string strConn, string UserName)
        {
            var conn = new DBConnect(strConn);
            try
            {
                var dt = new DataTable();
                var userE = new UserEntity();
                SqlParameter[] p = new SqlParameter[1];
                p[0] = new SqlParameter("@UserName", UserName);
                dt = conn.ExecuteReaderParmarter("spGetUserByUserName", p);
                userE.UserName = UserName;
                userE.Password = dt.Rows[0]["Password"].ToString();
                userE.PhoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
                userE.FullName = dt.Rows[0]["FullName"].ToString();
                userE.Role = dt.Rows[0]["Role"].ToString();
                return userE;
            }
            catch
            {
                return null;
                throw;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public bool fnCheckRegister(string strConn, string UserName)
        {
            var conn = new DBConnect(strConn);
            try
            {
                var dt = new DataTable();
                var userE = new UserEntity();
                SqlParameter[] p = new SqlParameter[1];
                p[0] = new SqlParameter("@UserName", UserName);
                dt = conn.ExecuteReaderParmarter("spGetUserByUserName", p);
                userE.UserName = UserName;
                userE.Password = dt.Rows[0]["Password"].ToString();
                userE.PhoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
                userE.FullName = dt.Rows[0]["FullName"].ToString();
                userE.Role = dt.Rows[0]["Role"].ToString();
                if (userE != null)
                    return true;
                else return false;
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
        public bool fnInsertUser(string strConn, UserEntity userEntity)
        {
            var conn = new DBConnect(strConn);
            try
            {
                SqlParameter[] p = new SqlParameter[5];
                p[0] = new SqlParameter("@UserName", userEntity.UserName);
                p[1] = new SqlParameter("@Password", userEntity.Password);
                p[2] = new SqlParameter("@FullName", userEntity.FullName);
                p[3] = new SqlParameter("@PhoneNumber", userEntity.PhoneNumber);
                p[4] = new SqlParameter("@Role", userEntity.Role);
                conn.ExecuteNonQueryParmarter("spInsertUser", p);
                return true;
            }
            catch
            {
                return false;
                throw;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public bool fnUpdateUser(string strConn, UserEntity userEntity)
        {
            var conn = new DBConnect(strConn);
            try
            {
                SqlParameter[] p = new SqlParameter[6];
                p[0] = new SqlParameter("@UserName", userEntity.UserName);
                p[1] = new SqlParameter("@Password", userEntity.Password);
                p[2] = new SqlParameter("@FullName", userEntity.FullName);
                p[3] = new SqlParameter("@PhoneNumber", userEntity.PhoneNumber);
                p[4] = new SqlParameter("@Role", userEntity.Role);
                conn.ExecuteNonQueryParmarter("spUpdateUser", p);
                return true;
            }
            catch
            {
                return false;
                throw;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public bool fnDeleteUser(string strConn, int UserID)
        {
            var conn = new DBConnect(strConn);
            try
            {
                SqlParameter[] p = new SqlParameter[1];
                p[0] = new SqlParameter("@UserID", UserID);
                conn.ExecuteNonQueryParmarter("spDeleteUser", p);
                return true;
            }
            catch
            {
                return false;
                throw;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
    }
}
