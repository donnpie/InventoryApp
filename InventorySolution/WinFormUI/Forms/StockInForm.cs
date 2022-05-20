using ModelLibrary.Models;
using SqlLibrary.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Helper;

namespace WinFormUI.Forms
{
    public partial class StockInForm : Form
    {
        private List<Store> storeList;
        private Store selectedStore;
        private readonly string conStr;
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
            SearchAndPopulateStores();
            txtBarcode.Select();
            txtQuantity.Text = "1";
            txtDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            quantityLimit = 100;
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            string barcode = txtBarcode.Text;
            txtProductComments.Text = $"{barcode}";
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
                    //TODO: Load image from file name. Add utility to store image filepath
                    string path = "C:\\Users\\donnp\\source\\repos\\Inventory app\\Img\\";
                    //4088600427003.png
                    pctProductImage.Image = new Bitmap($"{path}{prod.ImageFileName}");
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //Set Handled to true to cancel the KeyPress event.
                //This keeps the control from processing the key press.
                e.Handled = true;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length > 2)
            {
                int qty = Int32.Parse(txt.Text);
                
                if (qty > quantityLimit)
                {
                    Utils.MessageBoxError($"Maximum value for Quantity is {quantityLimit}");
                    txt.BackColor = Color.Pink;
                }
                else txt.BackColor = Color.White;
            }
            else txt.BackColor = Color.White;

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }


        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string input = txt.Text;
            string regex = "^[0-9]+\\.[0-9]{1,2}$";
            int dotCount = input.Count(ch => ch == '.');

            if (dotCount > 1)
            {
                input = input.Substring(0, input.Length - 1);
                txt.Text = input;
                txt.SelectionStart = txt.Text.Length;
                txt.SelectionLength = 0;
            }
            if (!Regex.Match(input, regex).Success)
            {
                txtProductComments.Text = $"{input} Error, dots: {dotCount}";
                txt.BackColor = Color.Pink;
            }
            else
            {
                txtProductComments.Text = $"{input} OK, dots: {dotCount}";
                txt.BackColor = Color.White;
            }
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
            string barcode = txtBarcode.Text;
            if (string.IsNullOrEmpty(barcode))
            {
                Utils.MessageBoxError("Barcode field cannot be empty");
                txtBarcode.BackColor = Color.Pink;
                return;
            }
            else txtBarcode.BackColor = Color.White;

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

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                Utils.MessageBoxError("Price field cannot be empty");
                txtPrice.BackColor = Color.Pink;
                return;
            }
            else txtPrice.BackColor = Color.White;
            float price;
            if (!float.TryParse(txtPrice.Text, out price))
            {
                Utils.MessageBoxError($"Value entered for price is not valid");
                txtPrice.BackColor = Color.Pink;
                return;
            }
            else txtPrice.BackColor = Color.White;

            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                Utils.MessageBoxError("Quantitiy field cannot be empty");
                txtQuantity.BackColor = Color.Pink;
                return;
            }
            else txtQuantity.BackColor = Color.White;
            int quantity;
            if (!Int32.TryParse(txtQuantity.Text, out quantity))
            {
                Utils.MessageBoxError($"Value entered for quantity is not valid");
                txtQuantity.BackColor = Color.Pink;
                return;
            }
            else txtQuantity.BackColor = Color.White;
            if (quantity > quantityLimit)
            {
                Utils.MessageBoxError($"Maximum value for Quantity is {quantityLimit}");
                txtQuantity.BackColor = Color.Pink;
                return;
            }
            else txtQuantity.BackColor = Color.White;
            
            Product prod = Queries.SearchProductByBarcodeReturnProduct(conStr, barcode);
            if (prod is null)
            {
                Utils.MessageBoxError($"Barcode not found. If this is a new product you must add it first");
                txtBarcode.BackColor = Color.Pink;
                return;
            }
            else txtBarcode.BackColor = Color.White;
            
            StockIn stock = new StockIn(barcode, selectedStore.Id, txtDate.Text, price, quantity);
            int rowsAffected;
            bool result = Queries.InsertStockInMulti(conStr, stock, quantity, out rowsAffected);
            if (result) MessageBox.Show($"Success: {rowsAffected} row(s) inserted"); else MessageBox.Show("Failed to insert");
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
