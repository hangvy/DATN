using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using DAHangAnh;

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
            String timeUpload = System.DateTime.Now.ToShortTimeString();
            String fileUpload="";
            DriveService service = Authentication.AuthenticateOauth(Constants.CLIENT_ID, Constants.CLIENT_SECRET, Environment.UserName);

            //create folder
            Google.Apis.Drive.v2.Data.File folder = new Google.Apis.Drive.v2.Data.File();
            folder.Title = "username";
            folder.Description = "folder document description";
            folder.MimeType = "application/vnd.google-apps.folder";

            // service is an authorized Drive API service instance
            //File file = service.Files.Insert(folder).Execute();

            OpenFileDialog ofdImageInput = new OpenFileDialog();
            ofdImageInput.Filter = "Image|*.*";
            ofdImageInput.Title = "Choose Image";
            if (ofdImageInput.ShowDialog() == DialogResult.OK)
            {
                fileUpload = ofdImageInput.FileNames[0];
              //  MessageBox.Show(fileUpload.ToString());

            }
            string Q = "mimeType = 'application/vnd.google-apps.folder'";
           IList<File> _Files = ConnectGoogleDrive.GetFiles(service, Q);
         //   MessageBox.Show(_Files.Count.ToString());
            _Files.Add(ConnectGoogleDrive.createDirectory(service, "test", "DiamtoSample", "root"));
           // string directoryId = file.Id;
          //  File newFile = ConnectGoogleDrive.uploadFile(service, fileUpload, directoryId);
            File newFile = ConnectGoogleDrive.uploadFile(service, fileUpload, "root");
            MessageBox.Show("upload " + fileUpload + " completed");
        }
    }
}