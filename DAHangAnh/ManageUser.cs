﻿using System;
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
    public partial class ManageUser : DevComponents.DotNetBar.Office2007Form
    {
        //Session session = new Session();
        public ManageUser()
        {
            InitializeComponent();
            this.Text += " _ " + Session.userSession.FullName ;
        }
    }
}
