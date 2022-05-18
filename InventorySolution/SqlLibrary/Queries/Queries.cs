using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace SqlLibrary.Queries
{
    public static class Queries
    {
        #region Helper functions
        public static bool StringIsNullOrEmpty(string s)
        {
            return (s is null || s == "");
        }

        private static DataTable CreateDataTable(string conStr, string query)
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
            if (StringIsNullOrEmpty(id)) { return null; }
            if (StringIsNullOrEmpty(conStr)) { return null; }
            string query = $"EXEC {storedProcedureName} {id}";

            return CreateDataTable(conStr, query);
        }

        private static DataTable SearchTableByName(string conStr, string name, string storedProcedureName)
        {
            if (StringIsNullOrEmpty(name)) { return null; }
            if (StringIsNullOrEmpty(conStr)) { return null; }
            string query = $"EXEC {storedProcedureName} '{name}'";

            return CreateDataTable(conStr, query);
        }

        private static DataTable SearchTableByBarcode(string conStr, string barcode, string storedProcedureName)
        {
            if (StringIsNullOrEmpty(barcode)) { return null; }
            if (StringIsNullOrEmpty(conStr)) { return null; }
            string query = $"EXEC {storedProcedureName} {barcode}";

            return CreateDataTable(conStr, query);
        }

        private static DataTable SearchTableAllReturnDataTable(string conStr, string storedProcedureName)
        {
            if (StringIsNullOrEmpty(conStr)) { return null; }
            string query = $"EXEC {storedProcedureName}";

            return CreateDataTable(conStr, query);
        }

        private static List<Category> SearchCategoryTableAllReturnCategoryList(string conStr, string storedProcedureName)
        {
            if (StringIsNullOrEmpty(conStr)) { return null; }
            string query = $"EXEC {storedProcedureName}";
            return CreateCategoryList(conStr, query);
        }

        private static List<Category> CreateCategoryList(string conStr, string query)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            var list = new List<Category>();
            while (reader.Read())
            {
                IDataRecord rcd = (IDataRecord)reader;
                list.Add(new Category((int)rcd[0], (string)rcd[1], (string)rcd[2]));
            }
            conn.Close();

            return list;
        }
        
        private static List<Brand> SearchBrandTableAllReturnBrandList(string conStr, string storedProcedureName)
        {
            if (StringIsNullOrEmpty(conStr)) { return null; }
            string query = $"EXEC {storedProcedureName}";
            return CreateBrandList(conStr, query);
        }

        private static List<Brand> CreateBrandList(string conStr, string query)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            var list = new List<Brand>();
            while (reader.Read())
            {
                IDataRecord rcd = (IDataRecord)reader;
                list.Add(new Brand((int)rcd[0], (string)rcd[1], (string)rcd[2]));
            }
            conn.Close();

            return list;
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
                return false;
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

        public static Category SearchCategoryByIdReturnCategory(string conStr, string id)
        {
            if (StringIsNullOrEmpty(id)) { return null; }
            if (StringIsNullOrEmpty(conStr)) { return null; }
            string query = $"EXEC SpSelectCategoryById {id}";

            List<Category> catList = CreateCategoryList(conStr, query);
            return catList[0];
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

        public static List<Group> SearchGroupByCategoryID(string conStr, Category cat)
        {
            SqlConnection con = new SqlConnection(conStr);
            string query = $"EXEC SpSelectGroupByCategoryId {cat.Id}";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            List<Group> grpList = new List<Group>();
            while (reader.Read())
            {
                IDataRecord rcd = reader;
                grpList.Add(new Group((int)rcd[0], (string)rcd[1], (string)rcd[2], cat));
            }
            con.Close();
            return grpList;
        }

        
        public static List<GenericProductName> SearchGpnByGroupID(string conStr, Group group)
        {
            SqlConnection con = new SqlConnection(conStr);
            string query = $"EXEC SpSelectGenericProductNameByGroupId {group.Id}";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            List<GenericProductName> gpnList = new List<GenericProductName>();
            while (reader.Read())
            {
                IDataRecord rcd = reader;
                gpnList.Add(new GenericProductName((int)rcd[0], (string)rcd[1], group));
            }
            con.Close();
            return gpnList;
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
        public static DataTable SearchCategoryAllReturnDataTable(string conStr)
        {
            return SearchTableAllReturnDataTable(conStr, "SpSelectCategoryAll");
        }

        public static List<Category> SearchCategoryAllReturnCategoryList(string conStr)
        {
            return SearchCategoryTableAllReturnCategoryList(conStr, "SpSelectCategoryAll");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchGroupAll(string conStr)
        {
            return SearchTableAllReturnDataTable(conStr, "SpSelectGroupAll");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchGpnAll(string conStr)
        {
            return SearchTableAllReturnDataTable(conStr, "SpSelectGenericProductNameAll");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchProductAll(string conStr)
        {
            return SearchTableAllReturnDataTable(conStr, "SpSelectProductAll");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchBrandAll(string conStr)
        {
            return SearchTableAllReturnDataTable(conStr, "SpSelectBrandAll");
        }

        
        public static List<Brand> SearchBrandAllReturnBrandList(string conStr)
        {
            return SearchBrandTableAllReturnBrandList(conStr, "SpSelectBrandAll");
        }

        /// <summary>
        /// Returns a <seealso cref="DataTable"></seealso> containing all rows for the given table
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable SearchStoreAll(string conStr)
        {
            return SearchTableAllReturnDataTable(conStr, "SpSelectStoreAll");
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
            if (StringIsNullOrEmpty(conStr)) { return false; }
            if (StringIsNullOrEmpty(name)) { return false; }
            string query = $"EXEC SpInsertCategory '{name}', '{description}'";

            return InsertIntoTable(conStr, query);
        }

        public static bool InsertGroup(string conStr, Group group)
        {
            if (StringIsNullOrEmpty(conStr)) { return false; }
            if (StringIsNullOrEmpty(group.Name)) { return false; }
            if (StringIsNullOrEmpty(group.Category.Name)) { return false; }
            if (group.Category.Id < 1) { return false; }
            string query = $"EXEC SpInsertGroup '{group.Name}', '{group.Description}', {group.Category.Id}";

            return InsertIntoTable(conStr, query);
        }

        public static bool InsertBrand(string conStr, string name, string description)
        {
            if (StringIsNullOrEmpty(conStr)) { return false; }
            if (StringIsNullOrEmpty(name)) { return false; }
            string query = $"EXEC SpInsertBrand '{name}', '{description}'";

            return InsertIntoTable(conStr, query);
        }

        public static bool InsertStore(string conStr, string name, string description)
        {
            if (StringIsNullOrEmpty(conStr)) { return false; }
            if (StringIsNullOrEmpty(name)) { return false; }
            string query = $"EXEC SpInsertStore '{name}', '{description}'";

            return InsertIntoTable(conStr, query);
        }

        public static bool InsertGpn(string conStr, GenericProductName gpn)
        {
            if (StringIsNullOrEmpty(conStr)) { return false; }
            if (gpn is null) { return false; }
            if (gpn.Group.Id == 0) { return false; }
            string query = $"EXEC SpInsertGenericProductName '{gpn.Name}', '', {gpn.Group.Id}";

            return InsertIntoTable(conStr, query);
        }

        public static bool InsertProduct(string conStr, Product prod)
        {
            if (StringIsNullOrEmpty(conStr)) { return false; }
            if (prod is null) { return false; }
            if (prod.Gpn.Id == 0) { return false; }
            if (prod.Brand.Id == 0) { return false; }
            string query = $"EXEC SpInsertProduct '{prod.Barcode}', {prod.Gpn.Id}, '{prod.Brand.Id}', '{prod.Name}', '{prod.Comments}', '{prod.ImageFileName}'";

            return InsertIntoTable(conStr, query);
        }


        #endregion

    }
}
