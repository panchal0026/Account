using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Account
{
    class MyAccount
    {
        public int AccountID { get; set; }
        public long Amount { get; set; }

        public MyAccount() 
        {

        }

        public long getBalance() 
        {
            DataSet ds =  datalayer.get_data("sp_getMainBalance", CommandType.StoredProcedure, null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Amount = Convert.ToInt32(ds.Tables[0].Rows[0]["Balance"]);
                return Amount;
            }
            else 
            {
                return 0;
            }
        }

        public void updatebalance(long balance) 
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@Balance", balance);
            sp[1] = new SqlParameter("@UpdatedDate", DateTime.Now);

            datalayer.Execute_NonQuery("sp_UpdateBalance", CommandType.StoredProcedure, sp);
        }
    }
}
