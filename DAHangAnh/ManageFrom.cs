using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAHangAnh.BLL;
using DAHangAnh.DAL.Entities;
using DAHangAnh.DAL;

namespace DAHangAnh
{
    public partial class ManageFrom: DevComponents.DotNetBar.Office2007Form
    {
        public bool isCheckInsert = true;
        FormBLL formBLL = new FormBLL();
        SqlHelper sqlHelper = new SqlHelper();
        public ManageFrom()
        {
            InitializeComponent();
        }

        public void LoadListForm()
        {
            DataTable dt = formBLL.GetListForm(sqlHelper.strConn);
            dtGrvForm.DataSource = dt;
            dtGrvForm.Show();
        }

        public void LoadComboboxStatus()
        {
            DataTable dt = formBLL.GetListForm(sqlHelper.strConn);
            DataTable dtStatus = new DataTable();
            dtStatus.Columns.Add("Status", typeof(string));
            DataRow[] rows = dt.Select();
            for (int i = 0; i < rows.Length; i++)
            {
                DataRow row = dtStatus.NewRow();
                row[0] = rows[i].ItemArray[0].ToString();
                dtStatus.Rows.Add(row);
            }
            cbxStatus.DataSource = dtStatus;
            cbxStatus.ValueMember = "Status";
        }
        private void btnFormatForm_Click(object sender, EventArgs e)
        {
            isCheckInsert = true;
            Form formatForm = new FormatForm();
            this.Visible = false;
            formatForm.Show();
        }

        private void btnUpdateFormatForm_Click(object sender, EventArgs e)
        {
            isCheckInsert = false;
            Form formatForm = new FormatForm();
            this.Visible = false;
            formatForm.Show();
        }

        private void ManageFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form login = new Login();
            login.Show();
        }

        private void ManageFrom_Load(object sender, EventArgs e)
        {
            LoadComboboxStatus();
            LoadListForm();
        }
    }
}
