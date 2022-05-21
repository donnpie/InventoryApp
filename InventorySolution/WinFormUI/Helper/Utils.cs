using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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

        public static void PopulateGroupComboBox(ComboBox cmb, List<ModelLibrary.Models.Group> groupList)
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

        public static void PopulateStoreComboBox(ComboBox cmb, List<Store> storeList)
        {
            cmb.DataSource = storeList;
            cmb.ValueMember = "Id";
            cmb.DisplayMember = "Name";
        }

        public static void AllowDigitsOnly(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void AllowDigitsAndFullStop(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public static void ValidateIntegerTextBox(TextBox txt, int quantityLimit)
        {
            if (txt.Text.Length > 2)
            {
                int qty = Int32.Parse(txt.Text);

                IntegerTextBoxIsLessThanMaximum(txt, quantityLimit, qty);
            }
            else txt.BackColor = Color.White;
        }

        public static void ValidateDecimalTextBox(TextBox txt)
        {
            string input = txt.Text;
            string regex = "^[0-9]+\\.[0-9]{1,2}$";
            int dotCount = input.Count(ch => ch == '.');

            if (dotCount > 1)
            {
                input = input.Substring(0, input.Length - 1);
                txt.Text = input;
                txt.SelectionStart = txt.Text.Length;
                txt.SelectionLength = 0;
            }
            if (!Regex.Match(input, regex).Success)
            {
                //txtProductComments.Text = $"{input} Error, dots: {dotCount}";
                txt.BackColor = Color.Pink;
            }
            else
            {
                //txtProductComments.Text = $"{input} OK, dots: {dotCount}";
                txt.BackColor = Color.White;
            }
        }

        public static bool IntegerTextBoxIsLessThanMaximum(TextBox txt, int quantityLimit, int qty)
        {
            if (qty > quantityLimit)
            {
                Utils.MessageBoxError($"Maximum value for Quantity is {quantityLimit}");
                txt.BackColor = Color.Pink;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool TextBoxIsNullOrEmpty(TextBox txt, string fieldName)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                Utils.MessageBoxError($"{fieldName} field cannot be empty");
                txt.BackColor = Color.Pink;
                return true;
            }
            else
            {
                txt.BackColor = Color.White;
                return false;
            }
        }

        public static bool IntegerTextBoxIsValidInteger(TextBox txt, out int quantity)
        {
            if (!Int32.TryParse(txt.Text, out quantity))
            {
                Utils.MessageBoxError($"Value entered for quantity is not valid");
                txt.BackColor = Color.Pink;
                return false;
            }
            else { txt.BackColor = Color.White; return true; }
        }

        public static bool FloatTextBoxIsValidFloat(TextBox txt, out float value, string fieldname)
        {
            if (!float.TryParse(txt.Text, out value))
            {
                Utils.MessageBoxError($"Value entered for {fieldname} is not valid");
                txt.BackColor = Color.Pink;
                return false;
            }
            else { txt.BackColor = Color.White; return true; }
        }

        public static bool BarcodeIsValid(TextBox txt, Product prod)
        {
            if (prod is null)
            {
                Utils.MessageBoxError($"Barcode not found. If this is a new product you must add it first");
                txt.BackColor = Color.Pink;
                return false;
            }
            else { txt.BackColor = Color.White; return true; }
        }
    }
}
