using ModelLibrary.Models;
using SqlLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinFormUI.Helper;

namespace WinFormUI.Forms
{
    public partial class ProductForm : Form
    {
        string conStr;
        List<Category> catList;
        Category selectedCategory;
        List<Group> groupList;
        Group selectedGroup;
        List<GenericProductName> gpnList;
        GenericProductName selectedGpn;
        List<Brand> brandList;
        Brand selectedBrand;
        public ProductForm()
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
                //MessageBox.Show($"{selectedGroup.Id} {selectedGroup.Name}");
            }
            else
            {
                selectedGroup = null;
                cmbGroupName.ResetText();
            }

            gpnList = Queries.SearchGpnByGroupID(conStr, selectedGroup);
            if (groupList.Count > 0)
            {
                Utils.PopulateGpnComboBox(cmbGpnName, gpnList);
                selectedGpn = gpnList[0];
                //MessageBox.Show($"{selectedGroup.Id} {selectedGroup.Name}");
            }
            else
            {
                selectedGpn = null;
                cmbGpnName.ResetText();
            }

            brandList = Queries.SearchBrandAllReturnBrandList(conStr);
            Utils.PopulateGroupComboBox(cmbBrandName, brandList);
            selectedBrand = brandList[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCategoryName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedCategory = cmbCategoryName.SelectedItem as Category;
            groupList = Queries.SearchGroupByCategoryID(conStr, selectedCategory);
            Utils.PopulateGroupComboBox(cmbGroupName, groupList);
            if (groupList.Count > 0)
            {
                selectedGroup = groupList[0];
                gpnList = Queries.SearchGpnByGroupID(conStr, selectedGroup);
                if (groupList.Count > 0)
                {
                    Utils.PopulateGpnComboBox(cmbGpnName, gpnList);
                    selectedGpn = gpnList[0];
                    //MessageBox.Show($"{selectedGroup.Id} {selectedGroup.Name}");
                }
                else
                {
                    selectedGpn = null;
                    cmbGpnName.ResetText();
                }
            }
            else
            {
                selectedGroup = null;
                cmbGroupName.ResetText();
                selectedGpn = null;
                cmbGpnName.ResetText();
            }
        }

        private void cmbGroupName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedGroup = cmbGroupName.SelectedItem as Group;
            if (selectedGroup is null) throw new NullReferenceException("selectedGroup is null");
            gpnList = Queries.SearchGpnByGroupID(conStr, selectedGroup);
            Utils.PopulateGpnComboBox(cmbGpnName, gpnList);
            if (gpnList.Count > 0)
            {
                selectedGpn = gpnList[0];
            }
            else
            {
                selectedGpn = null;
                cmbGpnName.ResetText();
            }
        }

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
            if (selectedGpn is null)
            {
                Utils.MessageBoxError("Please select a valid generic product name");
                return;
            }
            if (selectedBrand is null)
            {
                Utils.MessageBoxError("Please select a valid brand");
                return;
            }
            string name = txtProductName.Text;
            if (Utils.TextBoxValueIsNullOrEmpty(txtProductName, "Product name"))
            {
                txtProductName.BackColor = Color.Pink;
                return;
            }
            string barcode = txtBarcode.Text;
            if (Utils.TextBoxValueIsNullOrEmpty(txtBarcode, "Barcode"))
            {
                txtBarcode.BackColor = Color.Pink;
                return;
            }
            string comments = txtProductComments.Text;
            string imageFileName = txtFilePath.Text;

            Product prod = new Product(name, barcode, comments, imageFileName, selectedGpn, selectedBrand);
            bool result = Queries.InsertProduct(conStr, prod);
            if (result) MessageBox.Show("Inserted succesfully"); else MessageBox.Show("Failed to insert - possible duplicate");
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
