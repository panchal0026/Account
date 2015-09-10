using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Account
{
    public partial class MainAccount : Form
    {
        public MainAccount()
        {
            InitializeComponent();
            bindAccountInfo();
        }

        public void bindAccountInfo() 
        {
           DataSet ds = datalayer.get_data("sp_GetAccountInfo", CommandType.StoredProcedure, null);
           if (ds.Tables[0].Rows.Count > 0) 
           {
               lblAmount.Text = ds.Tables[0].Rows[0]["Balance"].ToString()+ " Rs/-";
               lblUpdatedDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["UpdatedDate"].ToString()).ToShortDateString();
           }
        }
    }
}
