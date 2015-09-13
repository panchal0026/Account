using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Account
{
    class IncomeDetailManager
    {
        public int TransactionID { get; set; }
        public string Name { get; set; }
        public int LocationID { get; set; }
        public DateTime Date { get; set; }
        public long Amount { get; set; }
        public string Note { get; set; }

        public IncomeDetailManager() 
        {

        }

        public IncomeDetailManager(string Name,int LocationID,long Amount,string Note) 
        {
            this.Name = Name;
            this.LocationID = LocationID;
            this.Amount = Amount;
            this.Note = Note;
        }

        public bool AddIncome(IncomeDetailManager newIncome) 
        {
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("@Name", newIncome.Name);
            sp[1] = new SqlParameter("@LocationID", newIncome.LocationID);
            sp[2] = new SqlParameter("@Date", newIncome.Date);
            sp[3] = new SqlParameter("@Amount", newIncome.Amount);
            sp[4] = new SqlParameter("@Note", newIncome.Note);
            return datalayer.Execute_NonQuery("sp_AddIncome", CommandType.StoredProcedure, sp);
        }

        public void UpdateIncome(IncomeDetailManager Income) 
        {
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@TransactionID", Income.TransactionID);
            sp[0] = new SqlParameter("@Name", Income.Name);
            sp[1] = new SqlParameter("@LocationID", Income.LocationID);
            sp[2] = new SqlParameter("@Date", DateTime.Now);
            sp[3] = new SqlParameter("@Amount", Income.Amount);
            sp[4] = new SqlParameter("@Note", Income.Note);
            datalayer.Execute_NonQuery("sp_UpdateIncome", CommandType.StoredProcedure, sp);
        }


        public DataSet ListIncomeDetails()
        {
            return datalayer.get_data("sp_ListIncomeDetail", CommandType.StoredProcedure, null);
        }

    }
}
