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
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();
        }

        private void btnAddNewLoaction_Click(object sender, EventArgs e)
        {
            string LocationName = txtLoactionName.Text;
            string LocationAddress = txtLocationAddress.Text;
            //string query = "insert into tblLocation values(@LocName,@LocAddress)";
            //OleDbParameter[] ob = new OleDbParameter[2];
            //ob[0] = new OleDbParameter("@LocName",LocationName);
            //ob[1] = new OleDbParameter("@LocAddress",LocationAddress);
            //int  i =  OleDbHelper.ExecuteNonQuery(OleDbHelper.con, CommandType.Text, query, ob);
            //if (i > 0)
            //{
            //    lblMessage.Text = "Location Added Successfully";
            //}
            //else 
            //{
            //    lblMessage.Text = "An Error Occured Please Try Agin";
            //}
        }

        private void btnPnlAddLocation_Click(object sender, EventArgs e)
        {
            pnlLocationForm.Visible = true;
            pnlLocationGrid.Visible = false;
        }
    }
}
