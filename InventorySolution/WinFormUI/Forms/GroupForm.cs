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
        readonly string conStr;
        readonly FormMode mode;
        //List<string> values;
        Category selectedCategory;
        public GroupForm(FormMode mode)
        {
            InitializeComponent();
            conStr = ConfigInfo.GetConString("ConString");
            this.mode = mode;
            //values = new List<string>();
            //LoadCategoryDataFromDataTable();
            LoadCategoryDataFromList();
        }

        //void LoadCategoryDataFromDataTable()
        //{
        //    DataTable dt = Queries.SearchCategoryAllReturnDataTable(conStr);
            
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        values.Add((string)dt.Rows[i]["Name"]);
        //    }
        //    values.Sort();
        //    cmbCategoryName.DataSource = values;

        //    //Find an item in a list using Linq
        //    //string search = "lookforme";
        //    //List<string> myList = new List<string>();
        //    //string result = myList.Single(s => s == search);
        //}

        void LoadCategoryDataFromList()
        {
            List<Category> list = Queries.SearchCategoryAllReturnCategoryList(conStr);
            this.cmbCategoryName.DataSource = list;
            this.cmbCategoryName.ValueMember = "Id";
            this.cmbCategoryName.DisplayMember = "Name";
            this.selectedCategory = list[0];
        }

        private void cmbCategoryName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedCategory = cmbCategoryName.SelectedItem as Category;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedCategory is null) return; 
            string name = txtName.Text;
            if (Utils.TextBoxValueIsNullOrEmpty(txtName, "Name")) return;
            txtName.BackColor = System.Drawing.Color.White;
            string description = txtDescription.Text;

            Group group = new Group(name, description, selectedCategory);
            bool result = Queries.InsertGroup(conStr, group);
            if (result) MessageBox.Show("Inserted succesfully"); else MessageBox.Show("Failed to insert - possible duplicate");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (selectedCategory is null) return;
            string name = txtName.Text;
            if (Utils.TextBoxValueIsNullOrEmpty(txtName, "Name")) return;
            txtName.BackColor = System.Drawing.Color.White;
            string description = txtDescription.Text;

            Group group = new Group(name, description, selectedCategory);
            bool result = Queries.InsertGroup(conStr, group);
            if (result) MessageBox.Show("Inserted succesfully"); else MessageBox.Show("Failed to insert - possible duplicate");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
