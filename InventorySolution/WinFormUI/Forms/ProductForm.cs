using ModelLibrary.Models;
using SqlLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private readonly string imageFilePath;
        public ProductForm()
        {
            InitializeComponent();
            conStr = Helper.ConfigInfo.GetConString("ConString");
            imageFilePath = Helper.ConfigInfo.GetImageDirectory("ImageFileDirectory");
            SearchAndPopulateCategories();
            SearchAndPopulateGroups();
            SearchAndPopulateGpns();
            SearchAndPopulateBrands();
            txtBarcode.Select();
        }

        private void SearchAndPopulateCategories()
        {
            catList = Queries.SearchCategoryAllReturnCategoryList(conStr);
            Utils.PopulateCategoryComboBox(cmbCategoryName, catList);
            selectedCategory = catList[0];
        }

        private void SearchAndPopulateGroups()
        {
            groupList = Queries.SearchGroupByCategoryID(conStr, selectedCategory);
            if (groupList.Count > 0)
            {
                Utils.PopulateGroupComboBox(cmbGroupName, groupList);
                selectedGroup = groupList[0];
            }
            else
            {
                selectedGroup = null;
                cmbGroupName.ResetText();
            }
        }

        private void SearchAndPopulateGpns()
        {
            gpnList = Queries.SearchGpnByGroupID(conStr, selectedGroup);
            if (groupList.Count > 0)
            {
                Utils.PopulateGpnComboBox(cmbGpnName, gpnList);
                selectedGpn = gpnList[0];
            }
            else
            {
                selectedGpn = null;
                cmbGpnName.ResetText();
            }
        }

        private void SearchAndPopulateBrands()
        {
            brandList = Queries.SearchBrandAllReturnBrandList(conStr);
            Utils.PopulateGroupComboBox(cmbBrandName, brandList);
            selectedBrand = brandList[0];
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

        private void cmbGpnName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedGpn = cmbGpnName.SelectedItem as GenericProductName;
        }

        private void cmbBrandName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedBrand = cmbBrandName.SelectedItem as Brand;
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeNewCategoryForm();
            f.Show();
        }

        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeNewGroupForm();
            f.Show();
        }

        private void btnNewGpn_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeNewGpnForm();
            f.Show();
        }

        private void btnNewBrand_Click(object sender, EventArgs e)
        {
            Form f = FormFactory.MakeNewBrandForm();
            f.Show();
        }

        private void btnRefreshCategory_Click(object sender, EventArgs e)
        {
            SearchAndPopulateCategories();
            SearchAndPopulateGroups();
            SearchAndPopulateGpns();
        }

        private void btnRefreshGroup_Click(object sender, EventArgs e)
        {
            SearchAndPopulateGroups();
            SearchAndPopulateGpns();
        }

        private void btnRefreshGpn_Click(object sender, EventArgs e)
        {
            SearchAndPopulateGpns();
        }

        private void btnRefreshBrand_Click(object sender, EventArgs e)
        {
            SearchAndPopulateBrands();
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
            //string imageFileName = txtFilePath.Text;
            string imageFileName = txtBarcode.Text + ".png";

            Product prod = new Product(name, barcode, comments, imageFileName, selectedGpn, selectedBrand);
            bool result = Queries.InsertProduct(conStr, prod);
            if (result) MessageBox.Show("Inserted succesfully"); else MessageBox.Show("Failed to insert - possible duplicate");
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            string barcode = txtBarcode.Text;
            if (string.IsNullOrEmpty(barcode))
            {
                txtBarcode.BackColor = Color.Pink;
                return;
            }
            else
            {
                txtBarcode.BackColor = Color.White;
                Product prod = Queries.SearchProductByBarcodeReturnProduct(conStr, barcode);
                if (prod != null)
                {
                    string path = $"{imageFilePath}{prod.ImageFileName}";
                    if (File.Exists(path)) pctProductImage.Image = new Bitmap(path);
                    else pctProductImage.Image = null;
                    pctProductImage.SizeMode = PictureBoxSizeMode.Zoom;

                    selectedCategory = prod.Gpn.Group.Category;
                    cmbCategoryName.SelectedIndex = cmbCategoryName.FindStringExact(selectedCategory.Name);

                    groupList = Queries.SearchGroupByCategoryID(conStr, selectedCategory);
                    Utils.PopulateGroupComboBox(cmbGroupName, groupList);
                    selectedGroup = prod.Gpn.Group;
                    cmbGroupName.SelectedIndex = cmbGroupName.FindStringExact(selectedGroup.Name);

                    gpnList = Queries.SearchGpnByGroupID(conStr, selectedGroup);
                    Utils.PopulateGpnComboBox(cmbGpnName, gpnList);
                    selectedGpn = prod.Gpn;
                    cmbGpnName.SelectedIndex = cmbGpnName.FindStringExact(selectedGpn.Name);

                    selectedBrand = prod.Brand;
                    cmbBrandName.SelectedIndex = cmbBrandName.FindStringExact(selectedBrand.Name);

                    txtProductName.Text = prod.Name;
                    txtProductComments.Text = prod.Comments;
                }
                else
                {
                    pctProductImage.Image = null;
                    txtProductID.Text = "";
                    txtProductName.Text = "";
                    txtProductComments.Text = "";
                }
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
