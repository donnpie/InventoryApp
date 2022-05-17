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
    public enum FormMode
    {
        New,
        Edit,
        View,
        Delete
    }

    public enum Table
    {
        Category,
        Brand,
        Store
    }

    public static class FormFactory
    {
        public static MainForm MakeMainForm(string title = "Invetory App")
        {
            MainForm f = new MainForm();
            f.Text = title;
            return f;
        }

        public static Form MakeCategoryForm(
            FormMode mode,
            Table table,
            string title = "Category",
            string okButtonText = "OK"           
        )
        {
            Form f = new CategoryForm(mode, table);
            f.Text = title;
            Control[] controls = f.Controls.Find("btnOk", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = okButtonText;

            switch (mode)
            {
                case FormMode.New:
                    EnableControl("txtID", f, false);
                    EnableControl("txtName", f, true);
                    EnableControl("txtDescription", f, true);
                    break;
                case FormMode.Edit:
                    EnableControl("txtID", f, false);
                    EnableControl("txtName", f, true);
                    EnableControl("txtDescription", f, true);
                    break;
                case FormMode.View:
                    EnableControl("txtID", f, false);
                    EnableControl("txtName", f, false);
                    EnableControl("txtDescription", f, false);
                    break;
                case FormMode.Delete:
                    EnableControl("txtID", f, true);
                    EnableControl("txtName", f, false);
                    EnableControl("txtDescription", f, false);
                    break;
                default:
                    EnableControl("txtID", f, false);
                    EnableControl("txtName", f, false);
                    EnableControl("txtDescription", f, false);
                    break;
            }
            return f;
        }

        private static void EnableControl(string controlName, Form form, bool enabled)
        {
            try
            {
                System.Windows.Forms.Control[] c = form.Controls.Find(controlName, true);
                c[0].Enabled = (c.Length == 1 && enabled);
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show($"{controlName} is not a valid control name. {e.ToString()}"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                );
            }
        }

        public static Form MakeGroupForm(
            FormMode mode,
            string title = "Group",
            string addButtonText = "Add"
            
        )
        {
            GroupForm f = new GroupForm(mode);
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnAdd", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = addButtonText;

            switch (mode)
            {
                case FormMode.New:
                    EnableControl("cmbCategoryName", f, true);
                    EnableControl("txtID", f, false);
                    EnableControl("txtName", f, true);
                    EnableControl("txtDescription", f, true);
                    break;
                case FormMode.Edit:
                    throw new NotImplementedException();
                    
                case FormMode.View:
                    throw new NotImplementedException();
                    
                case FormMode.Delete:
                    throw new NotImplementedException();
                    
                default:
                    throw new ArgumentException("Invalid value for mode parameter");
                    
            }
            return f;
        }

        public static Form MakeGpnForm(
            FormMode mode,
            string title = "Group",
            string addButtonText = "Add"
        )
        {
            GpnForm f = new GpnForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnAdd", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = addButtonText;

            switch (mode)
            {
                case FormMode.New:
                    EnableControl("cmbCategoryName", f, true);
                    EnableControl("cmbGroupName", f, true);
                    EnableControl("txtGpnID", f, false);
                    EnableControl("txtGpnName", f, true);
                    //EnableControl("txtGpnDescription", f, true);
                    break;
                case FormMode.Edit:
                    throw new NotImplementedException();
                case FormMode.View:
                    throw new NotImplementedException();
                case FormMode.Delete:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
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
