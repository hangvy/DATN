using DAHangAnh.BLL;
using DAHangAnh.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAHangAnh
{
    public partial class Login : DevComponents.DotNetBar.Office2007RibbonForm
    {
        string listError;
        UserBLL userBLL = new UserBLL();
        SqlHelper sqlHelper = new SqlHelper();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            listError = "";
            UserEntity userE = new UserEntity();
            if (txtUser.Text.Equals(""))
            {
                listError = Constants.UER001;
            }
            else
            {
                if (txtPassword.Text.Equals(""))
                {
                    listError = Constants.UER002;
                }
                else
                {
                    userE = userBLL.checkUserLogin(sqlHelper.strConn, txtUser.Text.Trim(), txtPassword.Text.Trim());
                    if (userE != null)
                    {
                        Session.userSession = userE;
                        this.Close();
                    }
                    else
                    {
                        listError = Constants.UER003;
                    }
                }
            }
            if (!listError.Equals(""))
            {
                lbError.Text = listError;
                lbError.Visible = true;
            }
            else
            {
                lbError.Text = "";
                lbError.Visible = false;
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
