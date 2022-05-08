using System;
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

        public static void MessageBoxError(string message)
        {
            MessageBox.Show(message
                , "Error"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Error
            );
        }
    }
}
