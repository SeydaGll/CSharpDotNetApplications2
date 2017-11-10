using Coder.Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder.WinApp
{
    public partial class Form1 : Form
    {
        private ICategoryService _categoryService;
        public Form1(ICategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _categoryService.GetAll();
        }
    }
}
