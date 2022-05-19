using ModelLibrary.Models;
using SqlLibrary.Queries;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using WinFormUI.Helper;

namespace WinFormUI.Forms
{
    public partial class CategoryForm : Form
    {
        readonly string conStr;
        readonly FormMode mode;
        readonly Table table;

        public CategoryForm(FormMode mode, Table table)
        {
            InitializeComponent();
            conStr = ConfigInfo.GetConString("ConString");
            this.mode = mode;
            this.table = table;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            if (Utils.TextBoxValueIsNullOrEmpty(txtName, "Name")) return;
            txtName.BackColor = System.Drawing.Color.White;
            string description = txtDescription.Text;

            bool result = false;
            switch (mode)
            {
                case FormMode.New:
                    switch (table)
                    {
                        case Table.Category:
                            result = Queries.InsertCategory(conStr, name, description);
                            break;
                        case Table.Brand:
                            result = Queries.InsertBrand(conStr, name, description);
                            break;
                        case Table.Store:
                            result = Queries.InsertStore(conStr, name, description);
                            break;
                        default:
                            break;
                    }             
                    break;
                case FormMode.Edit:
                    switch (table)
                    {
                        case Table.Category:
                            throw new NotImplementedException();
                            break;
                        case Table.Brand:
                            throw new NotImplementedException();
                            break;
                        case Table.Store:
                            throw new NotImplementedException();
                            break;
                        default:
                            break;
                    }
                    throw new NotImplementedException();
                    break;
                case FormMode.View:
                    switch (table)
                    {
                        case Table.Category:
                            throw new NotImplementedException();
                            break;
                        case Table.Brand:
                            throw new NotImplementedException();
                            break;
                        case Table.Store:
                            throw new NotImplementedException();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    throw new NotImplementedException();
                    break;
                    switch (table)
                    {
                        case Table.Category:
                            throw new NotImplementedException();
                            break;
                        case Table.Brand:
                            throw new NotImplementedException();
                            break;
                        case Table.Store:
                            throw new NotImplementedException();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                case FormMode.Delete:
                    switch (table)
                    {
                        case Table.Category:
                            throw new NotImplementedException();
                            break;
                        case Table.Brand:
                            throw new NotImplementedException();
                            break;
                        case Table.Store:
                            throw new NotImplementedException();
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                    }
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
            if (result) MessageBox.Show("Inserted succesfully"); else MessageBox.Show("Failed to insert - possible duplicate");
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
