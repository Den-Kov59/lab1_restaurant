using lab1_restaurant;
using lab1_restaurant.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVP
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
            IMainView MainForm = new StartMenu();
            MainPresenter main = new MainPresenter(MainForm);
            Application.Run((Form)MainForm);
        }
    }
}
