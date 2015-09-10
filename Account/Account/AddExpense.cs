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
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
            bindData();
        }

        private void btnSaveExpenseDetail_Click(object sender, EventArgs e)
        {
            ExpenseDetailManager newExpense = new ExpenseDetailManager();
            newExpense.LocationID = Convert.ToInt32(drpLocationList.SelectedValue);
            newExpense.ClientID = Convert.ToInt32(drpClientList.SelectedValue);
            newExpense.CategoryID = Convert.ToInt32(drpCategoryList.SelectedValue);
            newExpense.PayTo = txtPayTo.Text;
            newExpense.Amount = Convert.ToInt32(txtAmount.Text);
            newExpense.Note = txtNote.Text;

            bool restult = newExpense.AddExpense(newExpense);

            if (restult)
            {
                MessageBox.Show("Record Inserted Succesfully.!");
                //bindLocation();
                
            }
            else
            {
                MessageBox.Show("Error.!");
            }
        }

        public void bindData() 
        {
            bindLocationDropDown();

            bindExpenseCateGory();
        }

        public void bindLocationDropDown()
        {
            LocationManager ls = new LocationManager();
            DataSet ds = ls.ListLocations();
            if (ds.Tables[0].Rows.Count > 0)
            {

                drpLocationList.DisplayMember = "LocationName";
                drpLocationList.ValueMember = "id";
                drpLocationList.DataSource = ds.Tables[0];
            }
            else
            {
                //drpLocation.Items.Add()
            }
        }

        public void bindExpenseCateGory() 
        {
            CategoryManager cs = new CategoryManager();
            DataSet ds = cs.listAllCategory(1);
            if (ds.Tables[0].Rows.Count > 0)
            {

                drpCategoryList.DisplayMember = "CategoryName";
                drpCategoryList.ValueMember = "CategoryID";
                drpCategoryList.DataSource = ds.Tables[0];
            }
            else
            {
                //drpLocation.Items.Add()
            }
        }

        public void bindClientList(int LocationID) 
        {
            ClientManager cm = new ClientManager();
            DataSet ds = cm.getClientByLocationID(LocationID);
            if (ds.Tables[0].Rows.Count > 0)
            {

                drpClientList.DisplayMember = "ClientName";
                drpClientList.ValueMember = "ClientID";
                drpClientList.DataSource = ds.Tables[0];
            }
            else
            {
                //drpLocation.Items.Add()
            }
        }

        private void drpLocationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindClientList(Convert.ToInt32(drpLocationList.SelectedValue));
        }
    }
}
