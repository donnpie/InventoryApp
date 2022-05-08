using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlLibrary.Queries
{
    public static class Queries
    {
        #region Helper functions
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

        private static DataTable CreateDataAdapter(string conStr, string query)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        private static DataTable SearchTableByID(string conStr, string id, string storedProcedureName)
        {
            if (StringIsNull(id, "ID")) { return null; }
            if (StringIsNull(conStr, "Connection string")) { return null; }
            string query = $"EXEC {storedProcedureName} {id}";

            return CreateDataAdapter(conStr, query);
        }

        private static DataTable SearchTableByName(string conStr, string name, string storedProcedureName)
        {
            if (StringIsNull(name, "Name")) { return null; }
            if (StringIsNull(conStr, "Connection string")) { return null; }
            string query = $"EXEC {storedProcedureName} '{name}'";

            return CreateDataAdapter(conStr, query);
        }

        private static DataTable SearchTableByBarcode(string conStr, string barcode, string storedProcedureName)
        {
            if (StringIsNull(barcode, "Barcode")) { return null; }
            if (StringIsNull(conStr, "Connection string")) { return null; }
            string query = $"EXEC {storedProcedureName} {barcode}";

            return CreateDataAdapter(conStr, query);
        }

        private static DataTable SearchTableAll(string conStr, string storedProcedureName)
        {
            if (StringIsNull(conStr, "Connection string")) { return null; }
            string query = $"EXEC {storedProcedureName}";

            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        private static bool InsertIntoTable(string conStr, string query)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                return (rowsAffected == 1);
            }
            catch (SqlException e)
            {
                return (false);
            }
            finally
            {
                conn.Close();
            }
            
            
        }
        #endregion

        #region Search by ID
        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given ID
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable SearchCategoryByID(string conStr, string id)
        {
            return SearchTableByID(conStr, id, "SpSelectCategoryById");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given ID
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable SearchGroupByID(string conStr, string id)
        {
            return SearchTableByID(conStr, id, "SpSelectGroupById");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given ID
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable SearchGpnByID(string conStr, string id)
        {
            return SearchTableByID(conStr, id, "SpSelectGenericProductNameById");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given ID
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable SearchProductByID(string conStr, string id)
        {
            return SearchTableByID(conStr, id, "SpSelectProductById");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given ID
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable SearchBrandByID(string conStr, string id)
        {
            return SearchTableByID(conStr, id, "SpSelectBrandById");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given ID
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable SearchStoreByID(string conStr, string id)
        {
            return SearchTableByID(conStr, id, "SpSelectStoreById");
        }
        #endregion

        #region Search by Name
        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given Name
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable SearchCategoryByName(string conStr, string name)
        {
            return SearchTableByName(conStr, name, "SpSelectCategoryByName");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given Name
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable SearchGroupByName(string conStr, string name)
        {
            return SearchTableByName(conStr, name, "SpSelectGroupByName");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given Name
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable SearchGpnByName(string conStr, string name)
        {
            return SearchTableByName(conStr, name, "SpSelectGenericProductNameByName");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given Name
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable SearchProductByName(string conStr, string name)
        {
            return SearchTableByName(conStr, name, "SpSelectProductByName");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given Name
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable SearchBrandByName(string conStr, string name)
        {
            return SearchTableByName(conStr, name, "SpSelectBrandByName");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given Name
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable SearchStoreByName(string conStr, string name)
        {
            return SearchTableByName(conStr, name, "SpSelectStoreByName");
        }

        #endregion

        #region Search by Barcode
        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing a single row matching the given Barcode
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable SearchProductByBarcode(string conStr, string barcode)
        {
            return SearchTableByBarcode(conStr, barcode, "SpSelectProductByBarcode");
        }
        #endregion

        #region Search all
        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchCategoryAll(string conStr)
        {
            return SearchTableAll(conStr, "SpSelectCategoryAll");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchGroupAll(string conStr)
        {
            return SearchTableAll(conStr, "SpSelectGroupAll");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchGpnAll(string conStr)
        {
            return SearchTableAll(conStr, "SpSelectGenericProductNameAll");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchProductAll(string conStr)
        {
            return SearchTableAll(conStr, "SpSelectProductAll");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchBrandAll(string conStr)
        {
            return SearchTableAll(conStr, "SpSelectBrandAll");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchStoreAll(string conStr)
        {
            return SearchTableAll(conStr, "SpSelectStoreAll");
        }
        #endregion

        #region Insert into
        /// <summary>
        /// Inserts a record into the specified table
        /// </summary>
        /// <param name="conStr">The sql connection string</param>
        /// <param name="name">The name field of the record</param>
        /// <param name="description">The description field of the record</param>
        /// <returns></returns>
        public static bool InsertCategory(string conStr, string name, string description)
        {
            if (StringIsNull(conStr, "Connection string")) { return false; }
            if (StringIsNull(name, "Name")) { return false; }
            string query = $"EXEC SpInsertCategory '{name}', '{description}'";

            return InsertIntoTable(conStr, query);
        }

        public static bool InsertBrand(string conStr, string name, string description)
        {
            if (StringIsNull(conStr, "Connection string")) { return false; }
            if (StringIsNull(name, "Name")) { return false; }
            string query = $"EXEC SpInsertBrand '{name}', '{description}'";

            return InsertIntoTable(conStr, query);
        }

        public static bool InsertStore(string conStr, string name, string description)
        {
            if (StringIsNull(conStr, "Connection string")) { return false; }
            if (StringIsNull(name, "Name")) { return false; }
            string query = $"EXEC SpInsertStore '{name}', '{description}'";

            return InsertIntoTable(conStr, query);
        }


        #endregion

    }
}
