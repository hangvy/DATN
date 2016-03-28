using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAHangAnh.DAL.Entities;
using DAHangAnh.DAL;
using DAHangAnh.BLL;
namespace DAHangAnh
{
    public partial class FormatForm : DevComponents.DotNetBar.Office2007Form
    {
        public FormatForm()
        {
            InitializeComponent();
        }
        DetailFormBLL detailFormBLL = new DetailFormBLL();
        FormBLL formBLL = new FormBLL();
        SqlHelper sqlHelper = new SqlHelper();
        public void LoadDataGridView()
        {
            grvDetailForm.DataSource = detailFormBLL.GetListDetailForm(sqlHelper.strConn);
            //grvDetailForm.DataBindings;
        }
        private void FormatForm_Load(object sender, EventArgs e)
        {
        }

        private void btnCreatField_Click(object sender, EventArgs e)
        {

        }
    }
}
