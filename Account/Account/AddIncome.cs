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
    public partial class AddIncome : Form
    {
        public AddIncome()
        {
            InitializeComponent();
            bindLocationDropDown();
            bindIncomeGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IncomeDetailManager income = new IncomeDetailManager();
            income.TransactionID = Convert.ToInt32(lblTransactionID.Text);
            income.LocationID = Convert.ToInt32(drpLocationList.SelectedValue);
            income.Name = txtName.Text;
            income.Date = Convert.ToDateTime(dateTime.Text);
            income.Amount = Convert.ToInt32(txtAmount.Text);
            income.Note = txtNote.Text;

            bool res = income.UpdateIncome(income);

            if (res)
            {
                MessageBox.Show("Record Updated Succesfully.!");
                bindIncomeGrid();
                pnlAddIncomeForm.Visible = false;
                PnlIncomeGrid.Visible = true;

            }
            else
            {
                MessageBox.Show("Error.!");
            }
        }

        private void btnAddNewIncome_Click(object sender, EventArgs e)
        {
            IncomeDetailManager income = new IncomeDetailManager();
            income.LocationID = Convert.ToInt32(drpLocationList.SelectedValue);
            income.Name = txtName.Text;
            income.Date = Convert.ToDateTime(dateTime.Text);
            income.Amount = Convert.ToInt32(txtAmount.Text);
            income.Note = txtNote.Text;
            bool res = income.AddIncome(income);

            if (res)
            {
                MessageBox.Show("Record Inserted Succesfully.!");
                bindIncomeGrid();

                pnlAddIncomeForm.Visible = false;
                PnlIncomeGrid.Visible = true;

            }
            else
            {
                MessageBox.Show("Error.!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddIncomeForm.Visible = false;
            PnlIncomeGrid.Visible = true;
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

        public void bindIncomeGrid()
        {
            IncomeDetailManager cl = new IncomeDetailManager();
            DataSet ds = cl.ListIncomeDetails();
            if (ds.Tables[0].Rows.Count > 0)
            {
                IncomeDetailGrid.AutoGenerateColumns = false;
                IncomeDetailGrid.DataSource = null;
                //Set Columns Count 
                IncomeDetailGrid.ColumnCount = 6;

                //Add Columns
                IncomeDetailGrid.Columns[0].Name = "TransactionID";
                IncomeDetailGrid.Columns[0].HeaderText = "Transaction ID";
                IncomeDetailGrid.Columns[0].DataPropertyName = "TransactionID";

                IncomeDetailGrid.Columns[1].HeaderText = "Name";
                IncomeDetailGrid.Columns[1].Name = "Name";
                IncomeDetailGrid.Columns[1].DataPropertyName = "Name";

                IncomeDetailGrid.Columns[2].Name = "LocationID";
                IncomeDetailGrid.Columns[2].HeaderText = "Location";
                IncomeDetailGrid.Columns[2].DataPropertyName = "LocationID";

                IncomeDetailGrid.Columns[3].Name = "Date";
                IncomeDetailGrid.Columns[3].HeaderText = "Date";
                IncomeDetailGrid.Columns[3].DataPropertyName = "Date";

                IncomeDetailGrid.Columns[4].Name = "Amount";
                IncomeDetailGrid.Columns[4].HeaderText = "Amount";
                IncomeDetailGrid.Columns[4].DataPropertyName = "Amount";

                IncomeDetailGrid.Columns[5].Name = "Note";
                IncomeDetailGrid.Columns[5].HeaderText = "Note";
                IncomeDetailGrid.Columns[5].DataPropertyName = "Note";

                

                IncomeDetailGrid.DataSource = ds.Tables[0];

                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkForEditColumn";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                IncomeDetailGrid.Columns.Add(Editlink);

                DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                Deletelink.UseColumnTextForLinkValue = true;
                Deletelink.HeaderText = "delete";
                Deletelink.DataPropertyName = "lnkForDeleteColumn";
                Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                Deletelink.Text = "Delete";
                IncomeDetailGrid.Columns.Add(Deletelink); 
                //DataGridViewButtonColumn db = new DataGridViewButtonColumn();
                //db.Text = "Delete";
                //IncomeDetailGrid.Columns.Insert(6, (DataGridViewColumn)db);
            }
        }

        private void btnPnlAddNewIncome_Click(object sender, EventArgs e)
        {
            pnlAddIncomeForm.Visible = true;
            PnlIncomeGrid.Visible = false;
        }

        private void IncomeDetailGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int TransactionID = 0;

            if (e.ColumnIndex == 6)
            {

                txtName.Text = IncomeDetailGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                drpLocationList.SelectedValue = Convert.ToInt32(IncomeDetailGrid.Rows[e.RowIndex].Cells["LocationID"].Value.ToString());
                lblTransactionID.Text = IncomeDetailGrid.Rows[e.RowIndex].Cells["TransactionID"].Value.ToString();
                txtAmount.Text = IncomeDetailGrid.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                dateTime.Text = IncomeDetailGrid.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                txtNote.Text = IncomeDetailGrid.Rows[e.RowIndex].Cells["Note"].Value.ToString();
                
                pnlAddIncomeForm.Visible = true;
                PnlIncomeGrid.Visible = false;
                btnAddNewIncome.Visible = false;
                btnUpdate.Visible = true;

            }
            if (e.ColumnIndex == 7)
            {
                TransactionID = Convert.ToInt32(IncomeDetailGrid.Rows[e.RowIndex].Cells["TransactionID"].Value);

                IncomeDetailManager cm = new IncomeDetailManager();
                cm.DeleteIncome(TransactionID);
                bindIncomeGrid();

                pnlAddIncomeForm.Visible = false;
                PnlIncomeGrid.Visible = true;
            }
        }
    }
}
