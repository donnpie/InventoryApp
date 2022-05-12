using ModelLibrary.Models;
using SqlLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WinFormUI.Helper;

namespace WinFormUI.Forms
{
    public partial class GroupForm : Form
    {
        string conStr;
        FormMode mode;
        List<string> values;
        Category selectedCategory;
        public GroupForm(FormMode mode)
        {
            InitializeComponent();
            conStr = ConfigInfo.GetConString("ConString");
            this.mode = mode;
            values = new List<string>();
            //LoadCategoryDataFromDataTable();
            LoadCategoryDataFromList();
        }

        void LoadCategoryDataFromDataTable()
        {
            DataTable dt = Queries.SearchCategoryAllReturnDataTable(conStr);

            
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

        void LoadCategoryDataFromList()
        {
            List<Category> list = Queries.SearchCategoryAllReturnCategoryList(conStr);
            //list.Sort();
            this.cmbCategoryName.DataSource = list;
            this.cmbCategoryName.ValueMember = "Id";
            this.cmbCategoryName.DisplayMember = "Name";
            

            //Find an item in a list using Linq
            //string search = "lookforme";
            //List<string> myList = new List<string>();
            //string result = myList.Single(s => s == search);
        }



        private void cmbCategoryName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedCategory = cmbCategoryName.SelectedItem as Category;
            //MessageBox.Show($"{cat.Id}, {cat.Name}");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;
            Group group = new Group(0, name, description, selectedCategory);
            bool result = Queries.InsertGroup(conStr, group);
            if (result) MessageBox.Show("Inserted succesfully"); else MessageBox.Show("Failed to insert");
        }

        //private void cmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox cmb = (ComboBox)sender;
        //    int index = cmb.SelectedIndex;
        //    string value = (string)cmb.SelectedValue;
        //    string text = cmb.SelectedText;
        //    MessageBox.Show($"{index}, {value}, {text}");
        //}
    }
}
