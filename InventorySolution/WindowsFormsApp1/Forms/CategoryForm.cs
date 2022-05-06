using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Helper;

namespace WinFormUI.Forms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            string connStr = ConfigInfo.GetConString("DbNameToBeUpdated");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
