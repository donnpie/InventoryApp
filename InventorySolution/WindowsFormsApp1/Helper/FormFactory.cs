using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormUI.Forms;

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

        public static CategoryForm MakeCategoryForm(
            string title = "Category",
            string okButtonText = "OK",
            bool[] canEditFields = null
        )
        {
            CategoryForm f = new CategoryForm();
            f.Text = title;
            System.Windows.Forms.Control[] controls = f.Controls.Find("btnOk", true);
            if(controls.Length == 1) ((System.Windows.Forms.Button)controls[0]).Text = okButtonText;


            if (canEditFields.Length == 3)
            {
                System.Windows.Forms.Control[] c = f.Controls.Find("txtID", true);
                ((System.Windows.Forms.TextBox)c[0]).Enabled = (c.Length == 1 && canEditFields[0]) ? true : false;
                System.Windows.Forms.Control[] c1 = f.Controls.Find("txtName", true);
                ((System.Windows.Forms.TextBox)c1[0]).Enabled = (c1.Length == 1 && canEditFields[1]) ? true : false;
                System.Windows.Forms.Control[] c2 = f.Controls.Find("txtDescription", true);
                ((System.Windows.Forms.TextBox)c2[0]).Enabled = (c2.Length == 1 && canEditFields[2]) ? true : false;

            }


            //Debug.Print(f.Controls.ContainsKey("txtID").ToString());
            return f;
        }
    }
}
