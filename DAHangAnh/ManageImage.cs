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
using System.IO;

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

        private void tabControl_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Thêm ảnh"))
            {
                cbbFolerList.Visible = true;
                string[] dirs = Directory.GetDirectories(@"C:\Users\Hoang Anh\Google Drive");
                foreach (string item in dirs)
                {
                    FileInfo f = new FileInfo(item);

                    cbbFolerList.Items.Add(f.Name);

                }
            }

            if (comboBox1.Text.Equals("Tạo mới"))
            {
                cbbFolerList.Visible = false;
                var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
                ImageEntity imageEntity = new ImageEntity();
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Select a folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show("You selected: " + fbd.SelectedPath);
                    DialogResult result = MessageBox.Show("Copy ảnh từ "+fbd.SelectedPath+" qua Google Drive?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var files = GetFilesFrom(fbd.SelectedPath, filters, false);
                      //  if (!Directory.Exists(yourDirectory))
                        String desDir = @"C:\Users\Hoang Anh\Google Drive\"+txtFormName.Text+".user"+".date";
                        Directory.CreateDirectory(desDir);
                        foreach (string s in files)
                        {
                            // Use static Path methods to extract only the file name from the path.

                            String fileName = System.IO.Path.GetFileName(s);
                            String destFile = System.IO.Path.Combine(desDir, fileName);
                            System.IO.File.Copy(s, destFile, true);
                            imageEntity.ImgName = fileName;
                            imageEntity.ImgPath = destFile;
                            imageEntity.Status = 1;
                            imageEntity.UserName = "a";
                            imageEntity.UpTime = Convert.ToDateTime(System.DateTime.Now);
                            imageEntity.IdForm = txtFormID.Text;
                            formBLL.InsertImage(sqlHelper.strConn, imageEntity);
                           // MessageBox.Show(s + destFile);
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        
                    }

                }
            }

        }
        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }

    }
}
