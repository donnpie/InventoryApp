using ModelLibrary.Models;
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
    public partial class GpnForm : Form
    {
        string conStr;
        List<Category> catList;
        Category selectedCategory;
        List<Group> groupList;
        Group selectedGroup;

        public List<Category> CatList { get { return catList; } set { catList = value; } }
        public Category SelectedCategory { get { return selectedCategory; } set { selectedCategory = value; } }
        public List<Group> GroupList { get { return groupList; } set{ groupList = value; } }
        public Group SelectedGroup { get { return selectedGroup; } set { selectedGroup = value; } }

        public GpnForm()
        {
            InitializeComponent();
            conStr = Helper.ConfigInfo.GetConString("ConString");
            catList = Queries.SearchCategoryAllReturnCategoryList(conStr);
            Utils.PopulateCategoryComboBox(cmbCategoryName, catList);
            selectedCategory = catList[0];

            groupList = Queries.SearchGroupByCategoryID(conStr, selectedCategory);
            if (groupList.Count > 0)
            {
                Utils.PopulateGroupComboBox(cmbGroupName, groupList);
                selectedGroup = groupList[0];
            }
        }

        public void SetCategoryComboBox()
        {
            Utils.PopulateCategoryComboBox(cmbCategoryName, catList);
            cmbCategoryName.SelectedIndex = cmbCategoryName.FindStringExact(selectedCategory.Name);
        }

        public void SetGroupCombox()
        {
            Utils.PopulateGroupComboBox(cmbGroupName, groupList);
            cmbGroupName.SelectedIndex = cmbGroupName.FindStringExact(selectedGroup.Name);
        }

        //private void PopulateCategoryComboBox(ComboBox cmb, List<Category> catList)
        //{
        //    cmb.DataSource = catList;
        //    cmb.ValueMember = "Id";
        //    cmb.DisplayMember = "Name";
        //}

        //private void PopulateGroupComboBox(ComboBox cmb, List<Group> groupList)
        //{
        //    cmb.DataSource = groupList;
        //    cmb.ValueMember = "Id";
        //    cmb.DisplayMember = "Name";
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (selectedCategory is null)
            {
                Utils.MessageBoxError("Please select a valid category");
                return;
            }
            if (selectedGroup is null)
            {
                Utils.MessageBoxError("Please select a valid group");
                return;
            }
            string name = txtGpnName.Text;
            if (Utils.TextBoxValueIsNullOrEmpty(txtGpnName, "Generic product name"))
            {
                txtGpnName.BackColor = Color.Pink;
                return;
            }
            GenericProductName gpn = new GenericProductName(0, name, selectedGroup);
            bool result = Queries.InsertGpn(conStr, gpn);
            if (result) MessageBox.Show("Inserted succesfully"); else MessageBox.Show("Failed to insert - possible duplicate");
        }

        private void cmbCategoryName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedCategory = cmbCategoryName.SelectedItem as Category;
            groupList = Queries.SearchGroupByCategoryID(conStr, selectedCategory);
            Utils.PopulateGroupComboBox(cmbGroupName, groupList);
            if (groupList.Count > 0)
            {
                selectedGroup = groupList[0];
            }
            else
            {
                selectedGroup = null;
                cmbGroupName.ResetText();
            }
        }

        private void cmbGroupName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedGroup = cmbGroupName.SelectedItem as Group;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGpnName_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
