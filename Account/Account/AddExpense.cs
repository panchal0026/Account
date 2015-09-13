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
            bindExpenseGrid();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        public void bindExpenseGrid()
        {
            ExpenseDetailManager cl = new ExpenseDetailManager();
            DataSet ds = cl.ListExpenseDetails();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ExpenseGrid.AutoGenerateColumns = false;
                ExpenseGrid.DataSource = null;
                //Set Columns Count 
                ExpenseGrid.ColumnCount = 8;

                //Add Columns
                ExpenseGrid.Columns[0].Name = "Id";
                ExpenseGrid.Columns[0].HeaderText = "Id";
                ExpenseGrid.Columns[0].DataPropertyName = "TransactionID";

                ExpenseGrid.Columns[1].HeaderText = "Location Name";
                ExpenseGrid.Columns[1].Name = "LocationName";
                ExpenseGrid.Columns[1].DataPropertyName = "LocationID";

                ExpenseGrid.Columns[2].Name = "Address";
                ExpenseGrid.Columns[2].HeaderText = "Location Address";
                ExpenseGrid.Columns[2].DataPropertyName = "ClientID";

                ExpenseGrid.Columns[3].Name = "Address";
                ExpenseGrid.Columns[3].HeaderText = "Location Address";
                ExpenseGrid.Columns[3].DataPropertyName = "CategoryID";

                ExpenseGrid.Columns[4].Name = "Address";
                ExpenseGrid.Columns[4].HeaderText = "Location Address";
                ExpenseGrid.Columns[4].DataPropertyName = "PayTo";

                ExpenseGrid.Columns[5].Name = "Address";
                ExpenseGrid.Columns[5].HeaderText = "Location Address";
                ExpenseGrid.Columns[5].DataPropertyName = "Date";

                ExpenseGrid.Columns[6].Name = "Address";
                ExpenseGrid.Columns[6].HeaderText = "Location Address";
                ExpenseGrid.Columns[6].DataPropertyName = "Amount";

                ExpenseGrid.Columns[7].Name = "Address";
                ExpenseGrid.Columns[7].HeaderText = "Location Address";
                ExpenseGrid.Columns[7].DataPropertyName = "Note";



                ExpenseGrid.DataSource = ds.Tables[0];

                DataGridViewButtonColumn db = new DataGridViewButtonColumn();
                db.Text = "Delete";
                ExpenseGrid.Columns.Insert(8, (DataGridViewColumn)db);
            }
        }

        private void btnPnlAddExpense_Click(object sender, EventArgs e)
        {
            pnlExpenseGrid.Visible = false;
            pnlExpenseForm.Visible = true;
        }
    }
}
