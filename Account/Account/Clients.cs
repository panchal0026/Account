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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            bindClientList();
            bindLocationDropDown();
        }

        #region Control Events
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string ClientName = txtClientName.Text;
            int LocationID = Convert.ToInt32(drpLocation.SelectedValue);
            string ClientEmail = txtClientEmail.Text;
            string ph = txtContactNo.Text;
            string address = txtAddress.Text;
            ClientManager cl = new ClientManager(ClientName, LocationID, ClientEmail, ph, address);
            bool res = cl.AddNewClient(cl);
            if (res)
            {
                MessageBox.Show("Record Inserted Succesfully.!");
                bindClientList();
                pnlClientGrid.Visible = true;
                pnlClientForm.Visible = false;
            }
            else
            {
                MessageBox.Show("Error.!");
            }
        }

        private void btnPnlAddClient_Click(object sender, EventArgs e)
        {
            pnlClientForm.Visible = true;
            pnlClientGrid.Visible = false;
        }
        #endregion

        #region Methods

        public void bindClientList() 
        {
            ClientManager cl = new ClientManager();
            DataSet ds = cl.getClientList();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ClientGrid.AutoGenerateColumns = false;
                ClientGrid.DataSource = null;
                //Set Columns Count 
                ClientGrid.ColumnCount = 6;

                //Add Columns
                ClientGrid.Columns[0].Name = "Id";
                ClientGrid.Columns[0].HeaderText = "Id";
                ClientGrid.Columns[0].DataPropertyName = "ClientID";

                ClientGrid.Columns[1].HeaderText = "Location Name";
                ClientGrid.Columns[1].Name = "LocationName";
                ClientGrid.Columns[1].DataPropertyName = "ClientName";

                ClientGrid.Columns[2].Name = "Address";
                ClientGrid.Columns[2].HeaderText = "Location Address";
                ClientGrid.Columns[2].DataPropertyName = "LocationID";

                ClientGrid.Columns[3].Name = "Address";
                ClientGrid.Columns[3].HeaderText = "Location Address";
                ClientGrid.Columns[3].DataPropertyName = "ClientEmail";

                ClientGrid.Columns[4].Name = "Address";
                ClientGrid.Columns[4].HeaderText = "Location Address";
                ClientGrid.Columns[4].DataPropertyName = "ClientPhoneNo";

                ClientGrid.Columns[5].Name = "Address";
                ClientGrid.Columns[5].HeaderText = "Location Address";
                ClientGrid.Columns[5].DataPropertyName = "ClientAddress";



                ClientGrid.DataSource = ds.Tables[0];

                DataGridViewButtonColumn db = new DataGridViewButtonColumn();
                db.Text = "Delete";
                ClientGrid.Columns.Insert(6, (DataGridViewColumn)db);
            }
        }

        public void bindLocationDropDown() 
        {
            LocationManager ls = new LocationManager();
            DataSet ds = ls.ListLocations();
            if (ds.Tables[0].Rows.Count > 0)
            {
              
                drpLocation.DisplayMember = "LocationName";
                drpLocation.ValueMember = "id";
                drpLocation.DataSource = ds.Tables[0];
            }
            else 
            {
                //drpLocation.Items.Add()
            }
        }

        #endregion

    }
}
