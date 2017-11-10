using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDelegateEx
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

        //private void textBox1_MouseLeave(object sender, EventArgs e)
        //{
        //    textBox1.Text = "Mouse Dışarıda";
        //}
        /* EventArgs yani event argüman dediğimiz şey bizim olayımız gerçekleştiğinde olaya abone olan eventhandler ların, yani şu yazmış olduğumuz metodlara biz eventhandler diyoruz
         * olay yakalayıcı gibi düşünebilirsiniz, bu metodların olya hakkında bir takım bilgi sağlanabilmesi için geliştirilmiş sınıflar.. */
         //metod hakkında bilgi veren sınıf..
    }
}
