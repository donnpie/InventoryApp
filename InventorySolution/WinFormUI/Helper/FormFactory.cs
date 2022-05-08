using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormUI.Forms;
using System.Windows.Forms;

namespace WinFormUI.Helper
{
    public static class FormFactory
    {
        public static MainForm MakeMainForm(string title = "Invetory App")
        {
            MainForm f = new MainForm();
            f.Text = title;
            return f;
        }

        public static Form MakeCategoryForm(
            string title = "Category",
            string okButtonText = "OK",
            bool[] canEditFields = null
        )
        {
            Form f = new CategoryForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnOk", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = okButtonText;


            if (canEditFields.Length == 3)
            {
                EnableControl("txtID", f, canEditFields[0]);
                EnableControl("txtName", f, canEditFields[1]);
                EnableControl("txtDescription", f, canEditFields[2]);
            }
            return f;
        }

        private static void EnableControl(string controlName, Form form, bool enabled)
        {
            System.Windows.Forms.Control[] c = form.Controls.Find(controlName, true);
            c[0].Enabled = (c.Length == 1 && enabled) ? true : false;
        }

        public static Form MakeGroupForm(
            string title = "Group",
            string addButtonText = "Add",
            bool[] canEditFields = null
        )
        {
            GroupForm f = new GroupForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnAdd", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = addButtonText;

            if (canEditFields.Length == 4)
            {
                EnableControl("cmbCategoryName", f, canEditFields[0]);
                EnableControl("txtID", f, canEditFields[1]);
                EnableControl("txtName", f, canEditFields[2]);
                EnableControl("txtDescription", f, canEditFields[3]);
            }

            return f;
        }

        public static Form MakeGpnForm(
            string title = "Generic product Name",
            string addButtonText = "Add",
            bool[] canEditFields = null
        )
        {
            GpnForm f = new GpnForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnAdd", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = addButtonText;

            if (canEditFields.Length == 5)
            {
                EnableControl("cmbCategoryName", f, canEditFields[0]);
                EnableControl("cmbGroupName", f, canEditFields[1]);
                EnableControl("txtGpnID", f, canEditFields[2]);
                EnableControl("txtGpnName", f, canEditFields[3]);
                EnableControl("txtGpnDescription", f, canEditFields[4]);
                
            }

            return f;
        }

        public static Form MakeProductForm(
            string title = "Product",
            string addButtonText = "Add",
            bool[] canEditFields = null
        )
        {
            ProductForm f = new ProductForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnAdd", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = addButtonText;

            if (canEditFields.Length == 10)
            {
                EnableControl("cmbCategoryName", f, canEditFields[0]);
                EnableControl("cmbGroupName", f, canEditFields[1]);
                EnableControl("cmbGpnName", f, canEditFields[2]);
                EnableControl("cmbBrandName", f, canEditFields[3]);
                EnableControl("txtProductID", f, canEditFields[4]);
                EnableControl("txtBarcode", f, canEditFields[5]);
                EnableControl("txtProductName", f, canEditFields[6]);
                EnableControl("txtProductComments", f, canEditFields[7]);
                EnableControl("txtFilePath", f, canEditFields[8]);
                EnableControl("btnBrowseFileName", f, canEditFields[9]);
            }
            return f;
        }

        public static Form MakeStockInForm(
            string title = "Stock In",
            string addButtonText = "Add",
            bool[] canEditFields = null
        )
        {
            StockInForm f = new StockInForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnAdd", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = addButtonText;

            if (canEditFields.Length == 11)
            {
                EnableControl("txtCategoryName", f, canEditFields[0]);
                EnableControl("txtGroupName", f, canEditFields[1]);
                EnableControl("txtGpnName", f, canEditFields[2]);
                EnableControl("txtBrandName", f, canEditFields[3]);
                EnableControl("cmbStoreName", f, canEditFields[4]);
                EnableControl("txtProductID", f, canEditFields[5]);
                EnableControl("txtBarcode", f, canEditFields[6]);
                EnableControl("txtProductName", f, canEditFields[7]);
                EnableControl("txtProductComments", f, canEditFields[8]);
                EnableControl("txtPrice", f, canEditFields[9]);
                EnableControl("txtTimestamp", f, canEditFields[10]);
            }
            return f;
        }

        public static Form MakeStockOutForm(
            string title = "Stock Out",
            string addButtonText = "Add",
            bool[] canEditFields = null
        )
        {
            StockOutForm f = new StockOutForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnAdd", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = addButtonText;

            if (canEditFields.Length == 11)
            {
                EnableControl("txtCategoryName", f, canEditFields[0]);
                EnableControl("txtGroupName", f, canEditFields[1]);
                EnableControl("txtGpnName", f, canEditFields[2]);
                EnableControl("txtBrandName", f, canEditFields[3]);
                EnableControl("cmbStoreName", f, canEditFields[4]);
                EnableControl("txtProductID", f, canEditFields[5]);
                EnableControl("txtBarcode", f, canEditFields[6]);
                EnableControl("txtProductName", f, canEditFields[7]);
                EnableControl("txtProductComments", f, canEditFields[8]);
                EnableControl("txtPrice", f, canEditFields[9]);
                EnableControl("txtTimestamp", f, canEditFields[10]);
            }
            return f;
        }
    }
}
