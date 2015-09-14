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
            int ClientID = Convert.ToInt32(lblClientID.Text);
            string ClientName = txtClientName.Text;
            int LocationID = Convert.ToInt32(drpLocation.SelectedValue);
            string ClientEmail = txtClientEmail.Text;
            string ph = txtContactNo.Text;
            string address = txtAddress.Text;
            ClientManager cl = new ClientManager(ClientName, LocationID, ClientEmail, ph, address);
            cl.ClientID = ClientID;
            bool res = cl.updateClient(cl);
            if (res)
            {
                MessageBox.Show("Record Updated Succesfully.!");
                bindClientList();
                pnlClientGrid.Visible = true;
                pnlClientForm.Visible = false;
                btnUpdate.Visible = false;
            }
            else
            {
                MessageBox.Show("Error.!");
            }
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
                ClientGrid.Columns[0].Name = "ClientID";
                ClientGrid.Columns[0].HeaderText = "Client ID";
                ClientGrid.Columns[0].DataPropertyName = "ClientID";

                ClientGrid.Columns[1].HeaderText = "Client Name";
                ClientGrid.Columns[1].Name = "ClientName";
                ClientGrid.Columns[1].DataPropertyName = "ClientName";

                ClientGrid.Columns[2].Name = "LocationID";
                ClientGrid.Columns[2].HeaderText = "Location ID";
                ClientGrid.Columns[2].DataPropertyName = "LocationID";

                ClientGrid.Columns[3].Name = "ClientEmail";
                ClientGrid.Columns[3].HeaderText = "Client Email";
                ClientGrid.Columns[3].DataPropertyName = "ClientEmail";

                ClientGrid.Columns[4].Name = "ClientPhoneNo";
                ClientGrid.Columns[4].HeaderText = "Contac No";
                ClientGrid.Columns[4].DataPropertyName = "ClientPhoneNo";

                ClientGrid.Columns[5].Name = "ClientAddress";
                ClientGrid.Columns[5].HeaderText = "Client Address";
                ClientGrid.Columns[5].DataPropertyName = "ClientAddress";



                ClientGrid.DataSource = ds.Tables[0];


                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkForEditColumn";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                ClientGrid.Columns.Add(Editlink);

                DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                Deletelink.UseColumnTextForLinkValue = true;
                Deletelink.HeaderText = "delete";
                Deletelink.DataPropertyName = "lnkForDeleteColumn";
                Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                Deletelink.Text = "Delete";
                ClientGrid.Columns.Add(Deletelink); 
                //DataGridViewButtonColumn db = new DataGridViewButtonColumn();
                //db.Text = "Delete";
                //ClientGrid.Columns.Insert(6, (DataGridViewColumn)db);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlClientForm.Visible = false;
            pnlClientGrid.Visible = true;
        }

        private void ClientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Client_ID = 0;

            if (e.ColumnIndex == 6)
            {
                
                txtClientName.Text = ClientGrid.Rows[e.RowIndex].Cells["ClientName"].Value.ToString();
                drpLocation.SelectedValue= Convert.ToInt32(ClientGrid.Rows[e.RowIndex].Cells["LocationID"].Value.ToString());
                lblClientID.Text = ClientGrid.Rows[e.RowIndex].Cells["ClientID"].Value.ToString();
                txtClientEmail.Text = ClientGrid.Rows[e.RowIndex].Cells["ClientEmail"].Value.ToString();
                txtContactNo.Text = ClientGrid.Rows[e.RowIndex].Cells["ClientPhoneNo"].Value.ToString();
                txtAddress.Text = ClientGrid.Rows[e.RowIndex].Cells["ClientAddress"].Value.ToString();
                pnlClientForm.Visible = true;
                pnlClientGrid.Visible = false;
                btnAddClient.Visible = false;
                btnUpdate.Visible = true;

            }
            if (e.ColumnIndex == 7)
            {
                Client_ID = Convert.ToInt32(ClientGrid.Rows[e.RowIndex].Cells["ClientID"].Value);

                ClientManager cm  = new ClientManager();
                cm.DeleteClient(Client_ID);
                bindClientList();

                pnlClientForm.Visible = false;
                pnlClientGrid.Visible = true;
            }
        }

    }
}
