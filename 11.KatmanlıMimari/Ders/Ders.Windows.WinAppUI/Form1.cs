using Ders.Business;
using Ders.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders.Windows.WinAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPersonCount();
        }

        private void ClickAddPerson(object sender, EventArgs e)
        {
            FrmAddPerson f = new FrmAddPerson();
            DialogResult result = f.ShowDialog();
            if (result == DialogResult.Cancel)
                RefreshPersonCount();

        }

        private void RefreshPersonCount()
        {
            PersonManager manager = new PersonManager();
            lblPersonCount.Text = manager.PersonCount.ToString();
        }
    }
}
