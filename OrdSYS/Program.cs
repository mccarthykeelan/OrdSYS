using OrdSYS.Presenters;
using OrdSYS.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdSYS
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String sqlConnection = ConfigurationManager.ConnectionStrings["OrdSYS.Properties.Settings.sqlConnection"].ConnectionString;
            IMainView view = new frmMainMenu();
            new MainPresenter(view, sqlConnection);
            Application.Run((Form)view);
        }
    }
}
