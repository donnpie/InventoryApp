using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLibrary.Queries
{
    public static class Queries
    {
        #region Helper functions
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
            if (Helper.Helper.StringIsNull(id, "ID")) { return null; }
            if (Helper.Helper.StringIsNull(conStr, "Connection string")) { return null; }
            string query = $"EXEC {storedProcedureName} {id}";

            return CreateDataAdapter(conStr, query);
        }

        private static DataTable SearchTableByName(string conStr, string name, string storedProcedureName)
        {
            if (Helper.Helper.StringIsNull(name, "Name")) { return null; }
            if (Helper.Helper.StringIsNull(conStr, "Connection string")) { return null; }
            string query = $"EXEC {storedProcedureName} '{name}'";

            return CreateDataAdapter(conStr, query);
        }

        private static DataTable SearchTableByBarcode(string conStr, string barcode, string storedProcedureName)
        {
            if (Helper.Helper.StringIsNull(barcode, "Barcode")) { return null; }
            if (Helper.Helper.StringIsNull(conStr, "Connection string")) { return null; }
            string query = $"EXEC {storedProcedureName} {barcode}";

            return CreateDataAdapter(conStr, query);
        }

        private static DataTable SearchTableAll(string conStr, string storedProcedureName)
        {
            if (Helper.Helper.StringIsNull(conStr, "Connection string")) { return null; }
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
    }
}
