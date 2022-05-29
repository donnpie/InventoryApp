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
    public partial class UpdateProductForm : ProductForm
    {
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            if (SelectedCategory is null)
            {
                Utils.MessageBoxError("Please select a valid category");
                return;
            }
            if (SelectedGroup is null)
            {
                Utils.MessageBoxError("Please select a valid group");
                return;
            }
            if (SelectedGpn is null)
            {
                Utils.MessageBoxError("Please select a valid generic product name");
                return;
            }
            if (SelectedBrand is null)
            {
                Utils.MessageBoxError("Please select a valid brand");
                return;
            }
            int id = Int32.Parse(TxtProductId.Text);
            string name = TxtProductName.Text;
            if (Utils.TextBoxValueIsNullOrEmpty(TxtProductName, "Product name"))
            {
                TxtProductName.BackColor = Color.Pink;
                return;
            }
            string barcode = TxtBarcode.Text;
            if (Utils.TextBoxValueIsNullOrEmpty(TxtBarcode, "Barcode"))
            {
                TxtBarcode.BackColor = Color.Pink;
                return;
            }
            string comments = TxtProductComments.Text;
            //string imageFileName = txtFilePath.Text;
            string imageFileName = TxtBarcode.Text + ".png";

            Product prod = new Product(id, name, barcode, comments, imageFileName, SelectedGpn, SelectedBrand);
            bool result = Queries.UpdateProduct(ConStr, prod);
            if (result) MessageBox.Show("Updated succesfully"); else MessageBox.Show("Failed to update");
        }
    }
}
