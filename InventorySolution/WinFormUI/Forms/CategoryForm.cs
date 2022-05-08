using SqlLibrary.Queries;
using System;
using System.Windows.Forms;
using WinFormUI.Helper;

namespace WinFormUI.Forms
{
    public partial class CategoryForm : Form
    {
        string conStr;
        FormMode mode;
        Table table;
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
            if (result) MessageBox.Show("Inserted succesfully"); else MessageBox.Show("Failed to insert");
        }

        private void InsertCategory(string v1, string conStr, string v2, object name, string v3, object description)
        {
            throw new NotImplementedException();
        }

       


    }
}
