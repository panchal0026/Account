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
        public int ClientID { get; set; }
        public int CategoryID { get; set; }
        public string PayTo { get; set; }
        public long Amount { get; set; }
        public string Note { get; set; }

        public ExpenseDetailManager() 
        {
            
        }

        public ExpenseDetailManager(int ClientID, int CategoryID, string payto, long Amount, string note) 
        {
            this.ClientID = ClientID;
            this.CategoryID = CategoryID;
            this.PayTo = payto;
            this.Amount = Amount;
            this.Note = note;
        }

        public void AddExpense(ExpenseDetailManager newExpense) 
        {
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@ClientID", newExpense.ClientID);
            sp[1] = new SqlParameter("@CategoryID", newExpense.CategoryID);
            sp[2] = new SqlParameter("@payTo", newExpense.PayTo);
            sp[3] = new SqlParameter("@Date", DateTime.Now);
            sp[4] = new SqlParameter("@Amount", newExpense.Amount);
            sp[5] = new SqlParameter("@Note", newExpense.Note);

            datalayer.Execute_NonQuery("sp_AddExpense", CommandType.StoredProcedure, sp);
        }

        public void UpdateExpense(ExpenseDetailManager expense)
        {
            SqlParameter[] sp = new SqlParameter[7];
            sp[0] = new SqlParameter("@TransactionID", expense.TransactionID);
            sp[1] = new SqlParameter("@ClientID", expense.ClientID);
            sp[2] = new SqlParameter("@CategoryID", expense.CategoryID);
            sp[3] = new SqlParameter("@payTo", expense.PayTo);
            sp[4] = new SqlParameter("@Date", DateTime.Now);
            sp[5] = new SqlParameter("@Amount", expense.Amount);
            sp[6] = new SqlParameter("@Note", expense.Note);
            datalayer.Execute_NonQuery("sp_UpdateExpense", CommandType.StoredProcedure, sp);
        }
    }
}
