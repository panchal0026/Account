using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Account
{
    class CategoryManager
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int CategoryTypeID { get; set; }
        public string CategoryType { get; set; }

        public CategoryManager() 
        {

        }

        public CategoryManager(string CategoryName,string CategoryDescription,int CategoryTypeID,string CategoryType) 
        {
            this.CategoryName = CategoryName;
            this.CategoryDescription = CategoryDescription;
            this.CategoryTypeID = CategoryTypeID;
            this.CategoryType = CategoryType;
        }

        public void AddNewCategory(CategoryManager newCategory) 
        {
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@CategoryName", newCategory.CategoryName);
            sp[1] = new SqlParameter("@CategoryDescription", newCategory.CategoryDescription);
            sp[2] = new SqlParameter("@CategoryTypeID", newCategory.CategoryTypeID);
            sp[3] = new SqlParameter("@CategoryType", newCategory.CategoryType);

            datalayer.Execute_NonQuery("sp_AddCaegory", CommandType.StoredProcedure, sp);
        }

        public void UpdateCategory(CategoryManager category) 
        {
            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@CategoryID", category.CategoryID);
            sp[1] = new SqlParameter("@CategoryName", category.CategoryName);
            sp[2] = new SqlParameter("@CategoryDescription", category.CategoryDescription);

            datalayer.Execute_NonQuery("sp_UpdateCategory", CommandType.StoredProcedure, sp);
        }

        public void DeleteCategory(int CategoryID) 
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@CategoryID", CategoryID);

            datalayer.Execute_NonQuery("sp_DeleteCategory", CommandType.StoredProcedure, sp);
        }

        public DataSet listAllCategory(int CategoryTypeID) 
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@CategoryTypeID", CategoryTypeID);
            return datalayer.get_data("sp_ListCategoryByCategoryType", CommandType.StoredProcedure, sp);
        }

        public DataSet getCategoryByID(int CategoryID) 
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@CategoryID", CategoryID);
            return datalayer.get_data("sp_getCategoryByID", CommandType.StoredProcedure, sp);
        }
    }
}
