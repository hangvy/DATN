using DAHangAnh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAHangAnh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            if (Session.userSession != null)
            {
                if (Session.userSession.Role.Equals(Constants.ROLEADMIN))
                {
                    Application.Run(new ManageUser());
                }
                else
                {
                    if (Session.userSession.Role.Equals(Constants.ROLEFormDecription))
                    {
                        Application.Run(new ManageFrom());
                    }
                    else
                    {
                        if (Session.userSession.Role.Equals(Constants.ROLEImageManagement))
                        {
                            Application.Run(new ManageImage());
                        }
                        else
                        {
                            Application.Run(new ManageFrom());
                        }
                    }
                }
            }
        }
    }
}
