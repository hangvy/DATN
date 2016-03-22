using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;

namespace DAHangAnh
{
    public partial class Main : DevComponents.DotNetBar.OfficeForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void scanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chuanHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strImageName = null;
            OpenFileDialog ofdImageInput = new OpenFileDialog();
            ofdImageInput.Filter = "Image|*.*";
            ofdImageInput.Multiselect = false;
            ofdImageInput.ShowReadOnly = false;
            ofdImageInput.Title = "Choose Image";
            if (ofdImageInput.ShowDialog() == DialogResult.OK) { 
                strImageName = ofdImageInput.FileNames[0];
                Bitmap imgInput = new Bitmap(strImageName);
                pbImageInput.Image = imgInput;
            }
        }

        private void uploadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}