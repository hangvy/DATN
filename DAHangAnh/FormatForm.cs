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
    public partial class FormatForm : Form
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

        public void LoadCombox()
        {
            cbListForm.DataSource = formBLL.GetListForm(sqlHelper.strConn);
            cbListForm.DisplayMember = "idForm";
            cbListForm.ValueMember = "formName";
        }
        private void FormatForm_Load(object sender, EventArgs e)
        {
            //grvDetailForm.Rows.Add(1, "Mã sinh viên", 100, 100, 200, 50);
            LoadCombox();
            LoadDataGridView();
        }
    }
}
