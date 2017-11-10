using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RP.Business;
using RP.Entity;
namespace RP.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshGrid();
        }

        GenericRepository<Category> rp = new GenericRepository<Category>();

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGrid();

        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = rp.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category category = new Category() { CategoryName = txtCategory.Text };
            rp.Add(category);
            RefreshGrid();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int catId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            rp.Delete(catId);
            RefreshGrid();

            GenericRepository<TextBox> repo = new GenericRepository<TextBox>();

        }
    }
}
