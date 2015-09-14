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
                bindExpenseGrid();
                pnlExpenseGrid.Visible = true;
                pnlExpenseForm.Visible = false;
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
                ExpenseGrid.Columns[0].Name = "TransactionID";
                ExpenseGrid.Columns[0].HeaderText = "Transaction ID";
                ExpenseGrid.Columns[0].DataPropertyName = "TransactionID";

                ExpenseGrid.Columns[1].HeaderText = "Location ID";
                ExpenseGrid.Columns[1].Name = "LocationID";
                ExpenseGrid.Columns[1].DataPropertyName = "LocationID";

                ExpenseGrid.Columns[2].Name = "ClientID";
                ExpenseGrid.Columns[2].HeaderText = "Client ID";
                ExpenseGrid.Columns[2].DataPropertyName = "ClientID";

                ExpenseGrid.Columns[3].Name = "CategoryID";
                ExpenseGrid.Columns[3].HeaderText = "Category ID";
                ExpenseGrid.Columns[3].DataPropertyName = "CategoryID";

                ExpenseGrid.Columns[4].Name = "PayTo";
                ExpenseGrid.Columns[4].HeaderText = "Pay To";
                ExpenseGrid.Columns[4].DataPropertyName = "PayTo";

                ExpenseGrid.Columns[5].Name = "Date";
                ExpenseGrid.Columns[5].HeaderText = "Date";
                ExpenseGrid.Columns[5].DataPropertyName = "Date";

                ExpenseGrid.Columns[6].Name = "Amount";
                ExpenseGrid.Columns[6].HeaderText = "Amount";
                ExpenseGrid.Columns[6].DataPropertyName = "Amount";

                ExpenseGrid.Columns[7].Name = "Note";
                ExpenseGrid.Columns[7].HeaderText = "Note";
                ExpenseGrid.Columns[7].DataPropertyName = "Note";



                ExpenseGrid.DataSource = ds.Tables[0];

                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkForEditColumn";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                ExpenseGrid.Columns.Add(Editlink);

                DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                Deletelink.UseColumnTextForLinkValue = true;
                Deletelink.HeaderText = "delete";
                Deletelink.DataPropertyName = "lnkForDeleteColumn";
                Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                Deletelink.Text = "Delete";
                ExpenseGrid.Columns.Add(Deletelink); 
                //DataGridViewButtonColumn db = new DataGridViewButtonColumn();
                //db.Text = "Delete";
                //ExpenseGrid.Columns.Insert(8, (DataGridViewColumn)db);
            }
        }

        private void btnPnlAddExpense_Click(object sender, EventArgs e)
        {
            pnlExpenseGrid.Visible = false;
            pnlExpenseForm.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ExpenseDetailManager newExpense = new ExpenseDetailManager();
            newExpense.TransactionID = Convert.ToInt32(lblTransactionID.Text);
            newExpense.LocationID = Convert.ToInt32(drpLocationList.SelectedValue);
            newExpense.ClientID = Convert.ToInt32(drpClientList.SelectedValue);
            newExpense.CategoryID = Convert.ToInt32(drpCategoryList.SelectedValue);
            newExpense.PayTo = txtPayTo.Text;
            newExpense.Amount = Convert.ToInt32(txtAmount.Text);
            newExpense.Note = txtNote.Text;

            bool restult = newExpense.UpdateExpense(newExpense);

            if (restult)
            {
                MessageBox.Show("Record Updated Succesfully.!");
                bindExpenseGrid();
                pnlExpenseForm.Visible = false;
                pnlExpenseGrid.Visible = true;
                btnUpdate.Visible = false;

            }
            else
            {
                MessageBox.Show("Error.!");
            }
        }

        private void ExpenseGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int TransactionID = 0;

            if (e.ColumnIndex == 8)
            {

                drpClientList.SelectedValue = Convert.ToInt32(ExpenseGrid.Rows[e.RowIndex].Cells["ClientID"].Value.ToString());
                drpLocationList.SelectedValue = Convert.ToInt32(ExpenseGrid.Rows[e.RowIndex].Cells["LocationID"].Value.ToString());
                drpCategoryList.SelectedValue = Convert.ToInt32(ExpenseGrid.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString());
                lblTransactionID.Text = ExpenseGrid.Rows[e.RowIndex].Cells["TransactionID"].Value.ToString();
                txtPayTo.Text = ExpenseGrid.Rows[e.RowIndex].Cells["PayTo"].Value.ToString();
                txtAmount.Text = ExpenseGrid.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                txtNote.Text = ExpenseGrid.Rows[e.RowIndex].Cells["Note"].Value.ToString();

                pnlExpenseForm.Visible = true;
                pnlExpenseGrid.Visible = false;
                btnSaveExpenseDetail.Visible = false;
                btnUpdate.Visible = true;

            }
            if (e.ColumnIndex == 9)
            {
                TransactionID = Convert.ToInt32(ExpenseGrid.Rows[e.RowIndex].Cells["TransactionID"].Value);

                ExpenseDetailManager cm = new ExpenseDetailManager();
                cm.DeleteExpense(TransactionID);
                bindExpenseGrid();

                pnlExpenseForm.Visible = false;
                pnlExpenseGrid.Visible = true;
            }
        }
    }
}
