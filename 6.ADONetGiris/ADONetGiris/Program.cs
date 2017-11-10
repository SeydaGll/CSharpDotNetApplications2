using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONetGiris
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
            Application.Run(new Form1());
        }
    }
}
/*
   localdb ile sqlight aynı.. daha çok cep telefonu uygulamaları için kullanılan databaseler..localdb
 
     ADO.NET hem linq to sql e göre hem de entity frame work e göre daha hızlı çalışır.. 
     
     .net te geriye dönük destek her daim vardır!!!
     
     
     */