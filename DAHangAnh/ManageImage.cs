using DAHangAnh.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAHangAnh.DAL.Entities;
using DAHangAnh.DAL;

namespace DAHangAnh
{
    public partial class ManageImage : Form
    {
        FormBLL formBLL = new FormBLL();
        SqlHelper sqlHelper = new SqlHelper();
        public ManageImage()
        {
            InitializeComponent();
        }

        public void loadListForm()
        {
            dtGrvForm.DataSource = formBLL.GetListForm(sqlHelper.strConn);
        }

        private void ManageImage_Load(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCreateForm;
            loadListForm();
        }

        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            FormEntity formE = new FormEntity();
            formE.formID = txtFormID.Text;
            formE.formName = txtFormName.Text;
            formE.userName = "ANh";
            if (formE.userName != null)
            {
                
            }
            bool rs = formBLL.InsertForm(sqlHelper.strConn, formE);
            if (rs)
            {
                loadListForm();
            }
            else { MessageBox.Show("Insert Không thành công"); }
        }

        private void btnUpdateForm_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteForm_Click(object sender, EventArgs e)
        {

        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabUploadForm;
        }

    }
}
