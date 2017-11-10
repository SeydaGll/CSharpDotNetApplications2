using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEFex
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
//entityframeworktutorial.net  buna bakk..!!!!!!!!!

    /* bundan sonra artık bir uygulamayı hiçbir şekilde sql server ı açmadan başından sonuna kadar yazıp bitirip exe dosyasını release de built ettikten sonra 
     * ya da part yapıp bir setup hazırladıktn snra müşterine verirsin. bu setup içerisinde sql server scripti , sql server kurulumu vs hiçbirşey yok..direk gidip çalıştırdığın
     * anda müsterindeki  sql serverın connection strigini istersin. müşteri verdiği anda gider bağlanır..
     * 
     * yada localsql server kullanabilirsin böylelikle yine sql setup ı oluşturmak zorunda kalmazsın.. connection stringi local sql çalıştırabilcek şekilde düzenleyip bu şekilde de işini yürütebilirsin..p
     * pratik hızlı çözümler yürüten şeyler..*/