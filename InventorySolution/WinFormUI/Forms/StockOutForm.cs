using ModelLibrary.Models;
using SqlLibrary.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Helper;

namespace WinFormUI.Forms
{
    public partial class StockOutForm : Form
    {
        private readonly string conStr;
        private readonly string imageFilePath;
        private int quantityLimit;
        public StockOutForm()
        {
            InitializeComponent();
            conStr = Helper.ConfigInfo.GetConString("ConString");
            imageFilePath = Helper.ConfigInfo.GetImageDirectory("ImageFileDirectory");
            txtBarcode.Select();
            txtQuantity.Text = "1";
            txtDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            quantityLimit = 100;
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            string barcode = txtBarcode.Text;
            //txtProductComments.Text = $"{barcode}";
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

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            Utils.ValidateIntegerTextBox((TextBox)sender, quantityLimit);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.AllowDigitsOnly(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool barcodeIsNullOrEmpty = Utils.TextBoxIsNullOrEmpty(txtBarcode, "Barcode");
            if (barcodeIsNullOrEmpty) return;

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
                StockOut stock = new StockOut(barcode, txtDate.Text, quantity);
                int rowsAffected;
                bool result = Queries.InsertStockOutMulti(conStr, stock, out rowsAffected);
                if (result) MessageBox.Show($"Success: {rowsAffected} row(s) inserted"); else MessageBox.Show("Failed to insert");
            }
            catch (ArgumentException error)
            {
                Utils.MessageBoxError($"Invalid value passed to StockIn constructor. {error.Message}. {error.StackTrace}");
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            FormFactory.MakeNewProductForm().Show();
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
