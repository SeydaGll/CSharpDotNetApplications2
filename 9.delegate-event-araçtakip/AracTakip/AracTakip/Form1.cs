using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Arac a = new Arac();
            a.Plaka = "07 AO 077";
            a.HizDegisti += Arac_HizDegisti;
            Random r = new Random();
           
            for(int i=0;i<10;i++)
            {
                System.Threading.Thread.Sleep(1000);
                a.Hiz = r.Next(0, 180);
                listBox1.Items.Add(a.Plaka + "lı aracın hızı:  " + a.Hiz);
            }
            
        }

        private void Arac_HizDegisti(object sender, AracEventArgs e)
        {
            if(e.Hiz>90)
            MessageBox.Show(e.Plaka+" sayılı aracın hızı..:" +e.Hiz);
        }
    }
}
