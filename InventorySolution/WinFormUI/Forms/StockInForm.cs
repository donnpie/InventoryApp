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
    public partial class StockInForm : Form
    {
        private List<Store> storeList;
        private Store selectedStore;
        private readonly string conStr;

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
        }
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            txtBarcode.BackColor = Color.White;          
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Search product by barcode
            string barcode = txtBarcode.Text;
            if (string.IsNullOrEmpty(barcode))
            {
                Utils.MessageBoxError("Barcode field cannot be empty");
                txtBarcode.BackColor = Color.Pink;
                return;
            }
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
            //if found:
            //Return product details (Id, Name, comments, image filename
            //search for GPN, group, Category, brand
        }
    }
}
