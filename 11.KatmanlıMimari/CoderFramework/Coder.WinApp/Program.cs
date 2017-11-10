using Coder.DataAccess.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder.WinApp
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
            Coder.Business.Concrete.CategoryManager manager = new Business.Concrete.CategoryManager(new EFCategoryDAL());
            Application.Run(new Form1(manager));
        }
    }
}
