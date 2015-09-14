using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Account
{
    class ExpenseDetailManager
    {
        public int TransactionID { get; set; }
        public int LocationID { get; set; }
        public int ClientID { get; set; }
        public int CategoryID { get; set; }
        public string PayTo { get; set; }
        
        public long Amount { get; set; }
        public string Note { get; set; }

        public ExpenseDetailManager() 
        {
            
        }

        public ExpenseDetailManager(int LocationID,int ClientID, int CategoryID, string payto, long Amount, string note) 
        {
            this.LocationID = LocationID;
            this.ClientID = ClientID;
            this.CategoryID = CategoryID;
            this.PayTo = payto;
            this.Amount = Amount;
            this.Note = note;
        }

        public bool AddExpense(ExpenseDetailManager newExpense) 
        {
            SqlParameter[] sp = new SqlParameter[8];
            sp[0] = new SqlParameter("@LocationID", newExpense.LocationID);
            sp[1] = new SqlParameter("@ClientID", newExpense.ClientID);
            sp[2] = new SqlParameter("@CategoryID", newExpense.CategoryID);
            sp[3] = new SqlParameter("@payTo", newExpense.PayTo);
            sp[4] = new SqlParameter("@Date", DateTime.Now);
            sp[5] = new SqlParameter("@Amount", newExpense.Amount);
            sp[6] = new SqlParameter("@Note", newExpense.Note);
            sp[7] = new SqlParameter("@IsDeleted", false);
            return datalayer.Execute_NonQuery("sp_AddExpense", CommandType.StoredProcedure, sp);
        }

        public bool UpdateExpense(ExpenseDetailManager expense)
        {
            SqlParameter[] sp = new SqlParameter[7];
            sp[0] = new SqlParameter("@TransactionID", expense.TransactionID);
            sp[1] = new SqlParameter("@ClientID", expense.ClientID);
            sp[2] = new SqlParameter("@CategoryID", expense.CategoryID);
            sp[3] = new SqlParameter("@payTo", expense.PayTo);
            sp[4] = new SqlParameter("@Date", DateTime.Now);
            sp[5] = new SqlParameter("@Amount", expense.Amount);
            sp[6] = new SqlParameter("@Note", expense.Note);
            return datalayer.Execute_NonQuery("sp_UpdateExpense", CommandType.StoredProcedure, sp);
        }

        public DataSet ListExpenseDetails()
        {
            return datalayer.get_data("sp_ListExpenseDetail", CommandType.StoredProcedure, null);
        }

        public void DeleteExpense(int TransactionID)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@TransactionID", TransactionID);
            datalayer.Execute_NonQuery("sp_DeleteExpense", CommandType.StoredProcedure, sp);
        }
    }
}
