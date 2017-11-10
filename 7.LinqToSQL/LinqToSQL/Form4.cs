using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSQL
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        NorthwindDbDataContext ctx = new NorthwindDbDataContext();
        private void Form4_Load(object sender, EventArgs e)
        {
            //dgvCategories.DataSource = ctx.Categories.ToList();
            RefreshGrid();
        }
        void RefreshGrid()
        {
            dgvCategories.DataSource = from q in ctx.Categories
                                       select new
                                       {
                                           Id = q.CategoryID,
                                           CategoryName = q.CategoryName

                                       };
            dgvCategories.Columns[0].Visible = false;  //visible= gözle görülür..
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCatName.Text;
            ctx.Categories.InsertOnSubmit(category);   // listeye birşey ekliyormuş gibi..
            ctx.SubmitChanges();  // veritabanına yansıması  için..

            RefreshGrid();
            //dgvCategories.DataSource = ctx.Categories.ToList();

        }

        private void ctxMenuForGridSilClicked(object sender, EventArgs e)
        {
            int catId = (int)dgvCategories.SelectedRows[0].Cells[0].Value;
            //MessageBox.Show(catId.ToString());

            //var deletedCategory = (from c in ctx.Categories  //IQuerable yani çoğul geliyo o yüzden firstordefault kullanman gerekiyo..
            //                      where c.CategoryID == catId
            //                      select c).FirstOrDefault();

            var deletedCategory = ctx.Categories.Where(q => q.CategoryID == catId).FirstOrDefault();
            

            ctx.Categories.DeleteOnSubmit(deletedCategory);
            ctx.SubmitChanges();
            RefreshGrid();
        }

        int editCatId;
        private void DuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCatName.Text = dgvCategories.SelectedRows[0].Cells[1].Value.ToString();
            editCatId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells[0].Value);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            var cat = ctx.Categories.Where(q => q.CategoryID == editCatId).FirstOrDefault();
            cat.CategoryName = txtCatName.Text;
            ctx.SubmitChanges();
            txtCatName.Text="";
            RefreshGrid();
        }
    }
}
