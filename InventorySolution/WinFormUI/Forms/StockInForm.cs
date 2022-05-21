using ModelLibrary.Models;
using SqlLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormUI.Helper;

namespace WinFormUI.Forms
{
    public partial class StockInForm : Form
    {
        private List<Store> storeList;
        private Store selectedStore;
        private readonly string conStr;
        private readonly string imageFilePath;
        private int quantityLimit;

        private void SearchAndPopulateStores()
        {
            storeList = Queries.SearchStoreAllReturnStoreList(conStr);
            Utils.PopulateStoreComboBox(cmbStoreName, storeList);
            selectedStore = storeList[0];
        }

        public StockInForm()
        {
            InitializeComponent();
            conStr = Helper.ConfigInfo.GetConString("ConString");
            imageFilePath = ConfigInfo.GetImageDirectory("ImageFileDirectory");
            SearchAndPopulateStores();
            txtBarcode.Select();
            txtQuantity.Text = "1";
            txtDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            quantityLimit = 100;
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
                    if (File.Exists(path)) pctProductImage.Image = new Bitmap(path); else pctProductImage.Image = null;
                    pctProductImage.SizeMode = PictureBoxSizeMode.Zoom;
                    txtCategoryName.Text = prod.Gpn.Group.Category.Name;
                    txtGroupName.Text = prod.Gpn.Group.Name;
                    txtGpnName.Text = prod.Gpn.Name;
                    txtBrandName.Text = prod.Brand.Name;
                    txtProductID.Text = (prod.Id).ToString();
                    txtProductName.Text = prod.Name;
                    txtProductComments.Text = prod.Comments;
                }
                else
                {
                    pctProductImage.Image = null;
                    txtCategoryName.Text = "";
                    txtGroupName.Text = "";
                    txtGpnName.Text = "";
                    txtBrandName.Text = "";
                    txtProductID.Text = "";
                    txtProductName.Text = "";
                    txtProductComments.Text = "";
                }
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.AllowDigitsOnly(e);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            Utils.ValidateIntegerTextBox((TextBox)sender, quantityLimit);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.AllowDigitsAndFullStop(e);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            Utils.ValidateDecimalTextBox((TextBox)sender);
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            FormFactory.MakeNewProductForm().Show();
        }

        private void btnAddNewStore_Click(object sender, EventArgs e)
        {
            FormFactory.MakeNewStoreForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool barcodeIsNullOrEmpty = Utils.TextBoxIsNullOrEmpty(txtBarcode, "Barcode");
            if (barcodeIsNullOrEmpty) return;

            if (selectedStore is null)
            {
                Utils.MessageBoxError("Store field cannot be empty");
                cmbStoreName.BackColor = Color.Pink;
                return;
            }
            else cmbStoreName.BackColor = Color.White;
            if (selectedStore.Id < 1)
            {
                Utils.MessageBoxError("Selected store ID is invalid");
                cmbStoreName.BackColor = Color.Pink;
                return;
            }
            else cmbStoreName.BackColor = Color.White;

            bool priceIsNullOrEmpty = Utils.TextBoxIsNullOrEmpty(txtPrice, "Price");
            if (priceIsNullOrEmpty) return;

            float price;
            bool priceIsValidFloat = Utils.FloatTextBoxIsValidFloat(txtPrice, out price, "Price");
            if (!priceIsValidFloat) return;

            bool quantityIsNullOrEmpty = Utils.TextBoxIsNullOrEmpty(txtQuantity, "Quantity");
            if (quantityIsNullOrEmpty) return;

            int quantity;
            bool quantityIsValid = Utils.IntegerTextBoxIsValidInteger(txtQuantity, out quantity);
            if (!quantityIsValid) return;
            
            bool quantityIsLessThanMaximum = Utils.IntegerTextBoxIsLessThanMaximum(txtQuantity, quantityLimit, quantity);
            if (!quantityIsLessThanMaximum) return;

            string barcode = txtBarcode.Text;
            Product prod = Queries.SearchProductByBarcodeReturnProduct(conStr, barcode);

            bool barcodeIsValid = Utils.BarcodeIsValid(txtBarcode, prod);
            if (!barcodeIsValid) return;

            try
            {
                StockIn stock = new StockIn(barcode, selectedStore.Id, txtDate.Text, price, quantity);
                int rowsAffected;
                bool result = Queries.InsertStockInMulti(conStr, stock, out rowsAffected);
                if (result) MessageBox.Show($"Success: {rowsAffected} row(s) inserted"); else MessageBox.Show("Failed to insert");
            }
            catch (ArgumentException error)
            {
                Utils.MessageBoxError($"Invalid value passed to StockIn constructor. {error.Message}. {error.StackTrace}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbStoreName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedStore = cmbStoreName.SelectedItem as Store;
        }
    }
}
