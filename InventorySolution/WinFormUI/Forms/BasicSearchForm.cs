using SqlLibrary.Queries;
using System;
using System.Windows.Forms;
using WinFormUI.Helper;

namespace WinFormUI.Forms
{
    public partial class BasicSearchForm : Form
    {
        string conStr;
        public BasicSearchForm()
        {
            InitializeComponent();
            conStr = ConfigInfo.GetConString("ConString");
            rdoCategory.Checked = true;
        }

        private void EnableAllQueryTypeRadioButtons()
        {
            rdoCategory.Enabled = true;
            rdoGroup.Enabled = true;
            rdoGpn.Enabled = true;
            rdoProduct.Enabled = true;
            rdoBrand.Enabled = true;
            rdoStore.Enabled = true;
        }

        private void DisableAllQueryTypeRadioButtonsExceptProduct()
        {
            rdoCategory.Enabled = false;
            rdoGroup.Enabled = false;
            rdoGpn.Enabled = false;
            rdoBrand.Enabled = false;
            rdoStore.Enabled = false;
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            rdoID.Checked = true;
            EnableAllQueryTypeRadioButtons();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            rdoName.Checked = true;
            EnableAllQueryTypeRadioButtons();
        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {
            rdoProduct.Checked = true;
            rdoBarcode.Checked = true;
            DisableAllQueryTypeRadioButtonsExceptProduct();
        }

        private void txtAll_Enter(object sender, EventArgs e)
        {
            rdoAll.Checked = true;
            EnableAllQueryTypeRadioButtons();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtID.Text, "[^0-9]"))
            {
                MessageBox.Show("ID must be a number");
                txtID.Text = txtID.Text.Remove(txtID.Text.Length - 1);
            }
        }
        private void rdoID_Click(object sender, EventArgs e)
        {
            EnableAllQueryTypeRadioButtons();
            txtID.Focus();
        }

        private void rdoName_Click(object sender, EventArgs e)
        {
            EnableAllQueryTypeRadioButtons();
            txtName.Focus();
        }
        private void rdoBarcode_Click(object sender, EventArgs e)
        {
            rdoProduct.Checked = true;

            DisableAllQueryTypeRadioButtonsExceptProduct();

            txtBarcode.Focus();
        }
        private void rdoAll_Click(object sender, EventArgs e)
        {
            EnableAllQueryTypeRadioButtons();
            btnSearch.Focus();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            DataGridView dgv = (DataGridView)(Utils.GetFirstControlOnForm(this, "dataGridView1"));
            if (dgv == null)
            {
                MessageBox.Show("The command cannot be completed because the DataGridView is null");
                return;
            }

            if (rdoID.Checked) {
                string id = Utils.GetFirstControlInGroup(this.grpSearchParameter, "txtID").Text;
                if (id == null)
                {
                    MessageBox.Show("The command cannot be completed because the ID is null");
                    return;
                }
                if (rdoCategory.Checked) dgv.DataSource = Queries.SearchCategoryByID(conStr, id);
                else if (rdoGroup.Checked) dgv.DataSource = Queries.SearchGroupByID(conStr, id);
                else if (rdoGpn.Checked) dgv.DataSource = Queries.SearchGpnByID(conStr, id);
                else if (rdoProduct.Checked) dgv.DataSource = Queries.SearchProductByID(conStr, id);
                else if (rdoBrand.Checked) dgv.DataSource = Queries.SearchBrandByID(conStr, id);
                else if (rdoStore.Checked) dgv.DataSource = Queries.SearchStoreByID(conStr, id);
            }
            else if (rdoName.Checked)
            {
                string name = Utils.GetFirstControlInGroup(this.grpSearchParameter, "txtName").Text;
                if (name == null)
                {
                    MessageBox.Show("The command cannot be completed because the Name is null");
                    return;
                }
                if (rdoCategory.Checked) dgv.DataSource = Queries.SearchCategoryByName(conStr, name);
                else if (rdoGroup.Checked) dgv.DataSource = Queries.SearchGroupByName(conStr, name);
                else if (rdoGpn.Checked) dgv.DataSource = Queries.SearchGpnByName(conStr, name);
                else if (rdoProduct.Checked) dgv.DataSource = Queries.SearchProductByName(conStr, name);
                else if (rdoBrand.Checked) dgv.DataSource = Queries.SearchBrandByName(conStr, name);
                else if (rdoStore.Checked) dgv.DataSource = Queries.SearchStoreByName(conStr, name);
            }
            else if (rdoBarcode.Checked)
            {
                string barcode = Utils.GetFirstControlInGroup(this.grpSearchParameter, "txtBarcode").Text;
                if (barcode == null)
                {
                    MessageBox.Show("The command cannot be completed because the Barcode is null");
                    return;
                }
                dgv.DataSource = Queries.SearchProductByBarcode(conStr, barcode);
            }
            else if (rdoAll.Checked)
            {
                if (rdoCategory.Checked) dgv.DataSource = Queries.SearchCategoryAllReturnCategoryList(conStr);
                else if (rdoGroup.Checked) dgv.DataSource = Queries.SearchGroupAll(conStr);
                else if (rdoGpn.Checked) dgv.DataSource = Queries.SearchGpnAll(conStr);
                else if (rdoProduct.Checked) dgv.DataSource = Queries.SearchProductAll(conStr);
                else if (rdoBrand.Checked) dgv.DataSource = Queries.SearchBrandAll(conStr);
                else if (rdoStore.Checked) dgv.DataSource = Queries.SearchStoreAll(conStr);
            }
        }
    }
}
