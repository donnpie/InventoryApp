using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI.Forms
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = ((TextBox)sender);
            string input = txt.Text;
            DateTime d;
            bool chValidity = DateTime.TryParseExact(
                input,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out d
             );

            if (chValidity)
            {
                textBox2.Text = $"{input} OK";
            }
            else textBox2.Text = $"{input} Error";

            //string regex = "^20[0-3][0-9]-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01]){1}";
            //if (Regex.IsMatch(input, regex))
            //{
            //    textBox2.Text = $"{input} OK";
            //}
            //else textBox2.Text = $"{input} Error";
        }
    }
}
