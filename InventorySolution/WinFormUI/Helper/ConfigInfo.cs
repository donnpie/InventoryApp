using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormUI.Forms;

namespace WinFormUI.Helper
{
    public static class ConfigInfo
    {
        public static string GetConString(string conString)
        {
            return ConfigurationManager.ConnectionStrings[conString].ConnectionString;
            //return "Server=localhost\\SQLEXPRESS;Database=Inventory;Trusted_Connection=True;";

        }
        public static string GetImageDirectory(string imageFileDirectory)
        {
            //return ConfigurationManager.ConnectionStrings[conString].ConnectionString;
            return ConfigurationManager.AppSettings[imageFileDirectory];
            //return "Server=localhost\\SQLEXPRESS;Database=Inventory;Trusted_Connection=True;";

        }

        //public static void SearchDb(BasicSearchForm f)
        //{
        //    string conStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        //    SqlConnection conn = new SqlConnection(conStr);
        //    string query = "Select * from categories where ID = @ID;";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    TextBox txt = new TextBox();
        //    txt = (TextBox)(f.Controls.Find("textBox1", false)[0]);
        //    cmd.Parameters.AddWithValue("@ID", int.Parse(txt.Text));
        //    conn.Open();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    conn.Close();

        //    DataGridView dgv = new DataGridView();
        //    dgv = (DataGridView)(f.Controls.Find("dataGridView1", false)[0]);
        //    dgv.DataSource = dt; 
        //}


    }
}