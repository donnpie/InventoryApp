using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormUI.Helper
{
    public static class Utils
    {
        public static Control GetFirstControlOnForm(Form f, string controlName)
        {
            try
            {
                return f.Controls.Find(controlName, false)[0];

            }
            catch (IndexOutOfRangeException error)
            {
                MessageBox.Show($"An index of the Controls collection is out of range. The control name that threw the error is '{controlName}'. Check for valid control names. " + error.ToString()
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                );
                return null;
            }
        }

        public static Control GetFirstControlInGroup(GroupBox g, string controlName)
        {
            try
            {
                //Control.ControlCollection controls = f.Controls;
                return g.Controls.Find(controlName, false)[0];

            }
            catch (IndexOutOfRangeException error)
            {
                MessageBox.Show($"An index of the Controls collection is out of range. The control name that threw the error is '{controlName}'. Check for valid control names. " + error.ToString()
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                );
                return null;
            }
        }

        public static bool TextBoxValueIsNullOrEmpty(TextBox txtBox, string fieldName)
        {
            if (txtBox.Text is null || txtBox.Text == "")
            {
                MessageBoxError($"The {fieldName} field cannot be empty");
                txtBox.BackColor = System.Drawing.Color.LightPink;
                return true;
            }
            return false;
        }

        public static void MessageBoxError(string message)
        {
            MessageBox.Show(message
                , "Error"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Error
            );
        }

        public static void PopulateCategoryComboBox(ComboBox cmb, List<Category> catList)
        {
            cmb.DataSource = catList;
            cmb.ValueMember = "Id";
            cmb.DisplayMember = "Name";
        }

        public static void PopulateGroupComboBox(ComboBox cmb, List<Group> groupList)
        {
            cmb.DataSource = groupList;
            cmb.ValueMember = "Id";
            cmb.DisplayMember = "Name";
        }
        
        public static void PopulateGpnComboBox(ComboBox cmb, List<GenericProductName> gpnList)
        {
            cmb.DataSource = gpnList;
            cmb.ValueMember = "Id";
            cmb.DisplayMember = "Name";
        }
        
        public static void PopulateGroupComboBox(ComboBox cmb, List<Brand> brandList)
        {
            cmb.DataSource = brandList;
            cmb.ValueMember = "Id";
            cmb.DisplayMember = "Name";
        }
    }
}
