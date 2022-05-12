using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Helper;

namespace WinFormUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeCategoryForm(
                FormMode.New,
                Table.Category,
                "Add new Category", 
                "Add"              
            );
            f.Show();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeGroupForm(
                FormMode.New,
                "Add new Group",
                "Add"
            );
            f.Show();
        }

        private void genericProductNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeGpnForm(
                "Add new Generic Product Name",
                "Add",
                new bool[] { false, false, false, false, false }
            );
            f.Show();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeCategoryForm(
                FormMode.New,
                Table.Brand,
                "Add new Brand",
                "Add"
            );
            f.Show();
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeCategoryForm(
                FormMode.New,
                Table.Store,
                "Add new Store",
                "Add"
            );
            f.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeProductForm(
                "Add new Product",
                "Add",
                new bool[] { false, false, false, false, false, false, false, false, false, false }
            );
            f.Show();
        }

        private void stockCheckinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeStockInForm(
                "Check stock in",
                "Add",
                new bool[] { false, false, false, false, false, false, false, false, false, false, false }
            );
            f.Show();
        }     

        private void stockCheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.Print(sender.ToString());
            Form f = FormFactory.MakeStockOutForm(
                "Check stock in",
                "Add",
                new bool[] { false, false, false, false, false, false, false, false, false }
            );
            f.Show();
        }

        private void basicSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicSearchForm f = new BasicSearchForm();
            f.Show();
        }
    }
}
