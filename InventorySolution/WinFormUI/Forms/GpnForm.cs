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

namespace WinFormUI.Forms
{
    public partial class GpnForm : Form
    {
        string conStr;
        List<Category> catList;
        Category selectedCategory;
        List<Group> groupList;
        Group selectedGroup;
        public GpnForm()
        {
            InitializeComponent();
            //this.Name = "Add new Generic Product Name";
            //cmbCategoryName.Enabled = true;
            //cmbGroupName.Enabled = true;

            conStr = Helper.ConfigInfo.GetConString("ConString");
            catList = Queries.SearchCategoryAllReturnCategoryList(conStr);
            selectedCategory = catList[0];
            cmbCategoryName.DataSource = catList;
            cmbCategoryName.ValueMember = "Id";
            cmbCategoryName.DisplayMember = "Name";
            //this.Show();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{cmbCategoryName.Enabled.ToString()}");
        }

        private void cmbCategoryName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedCategory = cmbCategoryName.SelectedItem as Category;
            groupList = Queries.SearchGroupByCategoryID(conStr, selectedCategory);
            if (groupList.Count > 0)
            {
                cmbGroupName.DataSource = groupList;
                cmbGroupName.ValueMember = "Id";
                cmbGroupName.DisplayMember = "Name";
                selectedGroup = groupList[0];
                //MessageBox.Show($"{selectedGroup.Id} {selectedGroup.Name}");
            }
                
        }
    }
}
