using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDelegateEx
{
    public partial class Form1 : Form  //partial class söz konusu.. class ın bir kısmıda başka yerde yazıyor
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Benim metodum");
        }
        
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            //textBox1.Text = "Mouse İçeriside";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            //e.  // içinde birşey yok
            //textBox1.Text = "Mouse Dışarıda";
        }

        private void MouseTiklandi(object sender, MouseEventArgs e)  // bunda MouseEventArgs e diyo. bu özel geliştirilmiş bir event argüman sınıfı. bu event argüman özeldir
        {
            textBox1.Text = "X....: " + e.X+ "Y....: "+e.Y; //nereye tıklandı ne kadar süre tıklandı gibi daha birçok veriyi  veriyor
        }

        // EVENTARGS ne sağlıyor bana ? 
        //olay gerçekleştiği anda gerekli olabilecek bazı verileri olaya abone olan metodların içerisine göndermek için eventarg sınıfını kullanıyoruz
        // eventargümanlar olaya abone olan eventhandler ların, yazdığımız bu metodlara eventhandler diyoruz, bunların olayla ilgili bir takım verileri elde etmesini sağlar
        // olay gerçekleşen taraftan bir veri göndermek istiyosam eğer event argümanımı kullanıyorum

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;  //2)) sender ın buton tipinden olduğunu öğrendik. her ne kadar object te gelse orda bir button var. bende senderı buna cast ettim 
            MessageBox.Show(b.Name);
            //MessageBox.Show(sender.GetType().ToString());
        }
        //1)) object sender nedir ? system.windows.form.button tipinden miş sender mız
        //3)) burdaki adı geçen sender olayın tetiklendiği sınıf hangisiyse o sınıfın hafızada üretilen örneği, yani burda buton2 ye tıkladığımda sender buton2 oluyo. textbox a tıkladıpımda
        // bu sender textbox ın örneği oluyo. örneği oluyo diyorum yani textbox sını değil.. 
        /*private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;  sender larımız bunlar...*/
    }
}
