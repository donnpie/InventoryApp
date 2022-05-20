﻿using ModelLibrary.Models;
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
                    pctProductImage.Image = new Bitmap($"{imageFilePath}{prod.ImageFileName}");
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
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

            StockOut stock = new StockOut(barcode, txtDate.Text, quantity);
            int rowsAffected;
            bool result = Queries.InsertStockOutMulti(conStr, stock, out rowsAffected);
            if (result) MessageBox.Show($"Success: {rowsAffected} row(s) inserted"); else MessageBox.Show("Failed to insert");
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
