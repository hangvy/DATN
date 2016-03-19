using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DATN1
{
    public class SqlHelper
    {
        public string strConn { get; set; }
        //get connection string get from file web.config
        public SqlHelper()
        {
            strConn = ConfigurationManager.ConnectionStrings["strConnection"].ConnectionString;
            //hang
        }
    }
}
