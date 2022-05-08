using SqlLibrary.Queries;
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
    public partial class GroupForm : Form
    {
        string conStr;
        FormMode mode;
        List<string> values;
        public GroupForm(FormMode mode)
        {
            InitializeComponent();
            conStr = ConfigInfo.GetConString("ConString");
            this.mode = mode;
            values = new List<string>();
            TestDataTable();
        }

        void TestDataTable()
        {
            DataTable dt = Queries.SearchCategoryAll(conStr);

            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                values.Add((string)dt.Rows[i]["Name"]);
            }
            values.Sort();
            cmbCategoryName.DataSource = values;

            //Find an item in a list using Linq
            //string search = "lookforme";
            //List<string> myList = new List<string>();
            //string result = myList.Single(s => s == search);
        }

        private void cmbCategoryName_SelectedValueChanged(object sender, EventArgs e)
        {
            //ComboBox cmb = (ComboBox)sender;
            //int index = cmb.SelectedIndex;
            //string value = (string)cmb.SelectedValue;
            //string text = cmb.SelectedText;
            //MessageBox.Show($"{index}, {value}, {text}");
        }

        private void cmbCategoryName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show($"{cmbCategoryName.SelectedValue}");
        }

        private void cmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int index = cmb.SelectedIndex;
            string value = (string)cmb.SelectedValue;
            string text = cmb.SelectedText;
            MessageBox.Show($"{index}, {value}, {text}");
        }
    }
}
