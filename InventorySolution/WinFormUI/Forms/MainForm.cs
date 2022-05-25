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
            FormFactory.MakeNewCategoryForm().Show();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactory.MakeNewGroupForm().Show();
        }

        private void genericProductNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactory.MakeNewGpnForm().Show();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactory.MakeNewBrandForm().Show();
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactory.MakeNewStoreForm().Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactory.MakeNewProductForm().Show();
        }

        private void stockCheckinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactory.MakeStockInForm().Show();
        }     

        private void stockCheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactory.MakeStockOutForm().Show();
        }

        private void basicSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactory.MakeBasicSearchForm().Show();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFactory.MakeViewProductForm().Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Test().Show();
        }
    }
}
