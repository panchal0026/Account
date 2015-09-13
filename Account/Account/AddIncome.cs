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

        }

        private void btnAddNewIncome_Click(object sender, EventArgs e)
        {
            IncomeDetailManager income = new IncomeDetailManager();
            income.LocationID = Convert.ToInt32(drpLocationList.SelectedValue);
            income.Name = txtName.Text;
            income.Date = DateTime.Now;
            income.Amount = Convert.ToInt32(txtAmount.Text);
            income.Note = txtNote.Text;
            bool res = income.AddIncome(income);

            if (res)
            {
                MessageBox.Show("Record Inserted Succesfully.!");
                //bindLocation();

            }
            else
            {
                MessageBox.Show("Error.!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

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
                IncomeDetailGrid.Columns[0].Name = "Id";
                IncomeDetailGrid.Columns[0].HeaderText = "Id";
                IncomeDetailGrid.Columns[0].DataPropertyName = "TransactionID";

                IncomeDetailGrid.Columns[1].HeaderText = "Location Name";
                IncomeDetailGrid.Columns[1].Name = "LocationName";
                IncomeDetailGrid.Columns[1].DataPropertyName = "Name";

                IncomeDetailGrid.Columns[2].Name = "Address";
                IncomeDetailGrid.Columns[2].HeaderText = "Location Address";
                IncomeDetailGrid.Columns[2].DataPropertyName = "LocationID";

                IncomeDetailGrid.Columns[3].Name = "Address";
                IncomeDetailGrid.Columns[3].HeaderText = "Location Address";
                IncomeDetailGrid.Columns[3].DataPropertyName = "Date";

                IncomeDetailGrid.Columns[4].Name = "Address";
                IncomeDetailGrid.Columns[4].HeaderText = "Location Address";
                IncomeDetailGrid.Columns[4].DataPropertyName = "Amount";

                IncomeDetailGrid.Columns[5].Name = "Address";
                IncomeDetailGrid.Columns[5].HeaderText = "Location Address";
                IncomeDetailGrid.Columns[5].DataPropertyName = "Note";

                

                IncomeDetailGrid.DataSource = ds.Tables[0];

                DataGridViewButtonColumn db = new DataGridViewButtonColumn();
                db.Text = "Delete";
                IncomeDetailGrid.Columns.Insert(6, (DataGridViewColumn)db);
            }
        }

        private void btnPnlAddNewIncome_Click(object sender, EventArgs e)
        {
            pnlAddIncomeForm.Visible = true;
            PnlIncomeGrid.Visible = false;
        }
    }
}
