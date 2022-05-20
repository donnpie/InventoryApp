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
            Form f = FormFactory.MakeNewCategoryForm();
            f.Show();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeNewGroupForm();
            f.Show();
        }

        private void genericProductNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeNewGpnForm();
            f.Show();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeNewBrandForm();
            f.Show();
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeNewStoreForm();
            f.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeNewProductForm();
            f.Show();
        }

        private void stockCheckinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeStockInForm(
                "Check stock in",
                "Add"
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

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Test().Show();
        }
    }
}
