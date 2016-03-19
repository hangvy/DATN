using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN1.DAL
{
    public class DBConnect
    {
        public string ConnectionString;
        private SqlConnection myConnection = null;
        private SqlCommand myComand = null;
        private SqlDataAdapter myDataAdapter = null;
        public DBConnect(string strconn)
        {
            myConnection = new SqlConnection(strconn);
            OpenConnection();
        }
        public void OpenConnection()
        {
            try
            {
                if (myConnection.State == ConnectionState.Closed)
                    myConnection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ExecuteReaderNonParmarter(string spName)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                OpenConnection();
                myComand = new SqlCommand(spName, myConnection);
                myComand.CommandType = CommandType.StoredProcedure;
                myDataAdapter = new SqlDataAdapter(myComand);
                myDataAdapter.Fill(myDataTable);
                return myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ExecuteReaderParmarter(string spName, SqlParameter[] p)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                OpenConnection();
                myComand = new SqlCommand(spName, myConnection);
                myComand.CommandType = CommandType.StoredProcedure;
                myComand.Parameters.AddRange(p);
                myDataAdapter = new SqlDataAdapter(myComand);
                myDataAdapter.Fill(myDataTable);
                return myDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExecuteNonQueryParmarter(string spName, SqlParameter[] p)
        {
            try
            {
                OpenConnection();
                myComand = new SqlCommand(spName, myConnection);
                myComand.CommandType = CommandType.StoredProcedure;
                myComand.Parameters.AddRange(p);
                return myComand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }
        public int ExecuteScalarParmarter(string spName, SqlParameter[] p)
        {
            try
            {
                OpenConnection();
                myComand = new SqlCommand(spName, myConnection);
                myComand.CommandType = CommandType.StoredProcedure;
                myComand.Parameters.AddRange(p);
                return (Int32)myComand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }
        public int ExecuteScalarNonParmarter(string spName)
        {
            try
            {
                OpenConnection();
                myComand = new SqlCommand(spName, myConnection);
                myComand.CommandType = CommandType.StoredProcedure;
                return (Int32)myComand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }
        public DataSet ExecuteReaderParmarterReturnDataset(string spName, SqlParameter[] p)
        {
            DataSet myDataSet = new DataSet();
            try
            {
                OpenConnection();
                myComand = new SqlCommand(spName, myConnection);
                myComand.CommandType = CommandType.StoredProcedure;
                myComand.Parameters.AddRange(p);
                myDataAdapter = new SqlDataAdapter(myComand);
                myDataAdapter.Fill(myDataSet);
                return myDataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
