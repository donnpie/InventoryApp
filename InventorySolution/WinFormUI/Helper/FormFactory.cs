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

        public static MainForm MakeMainForm(string title = "Inventory App")
        {
            MainForm f = new MainForm();
            f.Text = title;
            return f;
        }

        #region Category Form
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

        public static Form MakeNewCategoryForm()
        {
            Form f = MakeCategoryForm(
                FormMode.New,
                Table.Category,
                "Add new Category",
                "Add"
            );
            return f;
        }

        #endregion

        #region Group Form
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

        public static Form MakeNewGroupForm()
        {
            Form f = MakeGroupForm(
                FormMode.New,
                "Add new Group",
                "Add"
            );
            return f;
        }

        #endregion

        #region Generic Product Name Form
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

        public static Form MakeNewGpnForm()
        {
            Form f = FormFactory.MakeGpnForm(
                FormMode.New,
                "Add new Generic Product Name",
                "Add"
            );
            return f;
        }

        #endregion

        #region Product Form
        public static Form MakeProductForm(
            FormMode mode,
            string title = "Product",
            string addButtonText = "Add"
        )
        {
            ProductForm f = new ProductForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnAdd", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = addButtonText;

            switch (mode)
            {
                case FormMode.New:
                    EnableControl("cmbCategoryName", f, true);
                    EnableControl("cmbGroupName", f, true);
                    EnableControl("cmbGpnName", f, true);
                    EnableControl("cmbBrandName", f, true);
                    EnableControl("txtProductID", f, false);
                    EnableControl("txtBarcode", f, true);
                    EnableControl("txtProductName", f, true);
                    EnableControl("txtProductComments", f, true);
                    EnableControl("txtFilePath", f, true);
                    EnableControl("btnBrowseFileName", f, true);
                    break;
                case FormMode.Edit:
                    break;
                case FormMode.View:
                    break;
                case FormMode.Delete:
                    break;
                default:
                    break;
            }

            return f;
        }

        public static Form MakeNewProductForm()
        {
            Form f = FormFactory.MakeProductForm(
                FormMode.New,
                "Add new Product",
                "Add"
            );
            return f;
        }

        public static Form MakeViewProductForm()
        {
            ViewProductForm f = new ViewProductForm();
            EnableControl("txtCategoryName", f, false);
            EnableControl("txtGroupName", f, false);
            EnableControl("txtGpnName", f, false);
            EnableControl("txtBrandName", f, false);
            EnableControl("txtProductID", f, false);
            EnableControl("txtBarcode", f, true);
            EnableControl("txtProductName", f, false);
            EnableControl("txtProductComments", f, false);
            return f;
        }
        #endregion

        #region Brand Form
        public static Form MakeNewBrandForm()
        {
            Form f = MakeCategoryForm(
                FormMode.New,
                Table.Brand,
                "Add new Brand",
                "Add"
            );
            return f;
        }
        #endregion

        #region Store Form
        public static Form MakeNewStoreForm()
        {
            Form f = MakeCategoryForm(
                FormMode.New,
                Table.Store,
                "Add new Store",
                "Add"
            );
            return f;
        }

        #endregion

        #region Stock Forms
        public static Form MakeStockInForm(
            string title = "Scan in stock",
            string addButtonText = "Add"
        )
        {
            StockInForm f = new StockInForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnAdd", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = addButtonText;

            EnableControl("txtCategoryName", f, false);
            EnableControl("txtGroupName", f, false);
            EnableControl("txtGpnName", f, false);
            EnableControl("txtBrandName", f, false);
            EnableControl("cmbStoreName", f, true);
            EnableControl("txtProductID", f, false);
            EnableControl("txtBarcode", f, true);
            EnableControl("txtProductName", f, false);
            EnableControl("txtProductComments", f, false);
            EnableControl("txtPrice", f, true);
            EnableControl("txtDate", f, false);
            EnableControl("txtQuantity", f, true);

            return f;
        }

        
        public static Form MakeStockOutForm(
            string title = "Scan out stock",
            string addButtonText = "Add"
        )
        {
            StockOutForm f = new StockOutForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnAdd", true);
            if (controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = addButtonText;

            EnableControl("txtCategoryName", f, false);
            EnableControl("txtGroupName", f, false);
            EnableControl("txtGpnName", f, false);
            EnableControl("txtBrandName", f, false);
            EnableControl("txtProductID", f, false);
            EnableControl("txtBarcode", f, true);
            EnableControl("txtProductName", f, false);
            EnableControl("txtProductComments", f, false);
            EnableControl("txtDate", f, false);
            EnableControl("txtQuantity", f, true);
            return f;
        }
        #endregion

        #region Search Forms
        public static Form MakeBasicSearchForm()
        {
            BasicSearchForm f = new BasicSearchForm();
            return f;
        }


        #endregion
    }
}
