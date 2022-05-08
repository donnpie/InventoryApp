using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlLibrary.Helper
{
    public static class Helper
    {
        public static bool StringIsNull(string s, string fieldName)
        {
            if (s == null || s == "")
            {
                MessageBox.Show($"{fieldName} field cannot be empty"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                );
                return true;
            }
            return false;
        }



    }
}
