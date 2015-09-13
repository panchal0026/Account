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
            bindLocation();
        }

        #region Click Events

        private void btnAddNewLoaction_Click(object sender, EventArgs e)
        {
            string LocationName = txtLoactionName.Text;
            string LocationAddress = txtLocationAddress.Text;
            LocationManager ls = new LocationManager(LocationName,LocationAddress);
            if (!string.IsNullOrEmpty(LocationName))
            {
                bool res = ls.AddLocation(ls);
                if (res)
                {
                    MessageBox.Show("Record Inserted Succesfully.!");
                    bindLocation();
                    pnlLocationGrid.Visible = true;
                    pnlLocationForm.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error.!");
                }
            }
            else 
            {
                MessageBox.Show("Enter Location Name");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int LocationID = Convert.ToInt32(lblLocationID.Text);
            string LocationName = txtLoactionName.Text;
            string LocationAddress = txtLocationAddress.Text;
            LocationManager ls = new LocationManager(LocationID,LocationName, LocationAddress);
            if (!string.IsNullOrEmpty(LocationName))
            {
                try
                {
                    ls.UpdateLocation(ls);
                    MessageBox.Show("Location Updated Succesfully.!");
                    bindLocation();
                    pnlLocationGrid.Visible = true;
                    pnlLocationForm.Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter Location Name");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlLocationForm.Visible = false;
            pnlLocationGrid.Visible = true;
        }

        private void btnPnlAddLocation_Click(object sender, EventArgs e)
        {
            pnlLocationForm.Visible = true;
            pnlLocationGrid.Visible = false;

            btnAddNewLoaction.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }

        private void LocationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int location_id = 0;
            
            if (e.ColumnIndex == 3)
            {
                
                txtLoactionName.Text = LocationGrid.Rows[e.RowIndex].Cells["LocationName"].Value.ToString();
                txtLocationAddress.Text = LocationGrid.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                lblLocationID.Text = LocationGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                pnlLocationForm.Visible = true;
                pnlLocationGrid.Visible = false;
                btnAddNewLoaction.Visible = false;
                
            }
            if (e.ColumnIndex == 4)
            {
                location_id = Convert.ToInt32(LocationGrid.Rows[e.RowIndex].Cells["Id"].Value);

                LocationManager loc_manager = new LocationManager();
                loc_manager.DeleteLocation(location_id);
                bindLocation();

                pnlLocationForm.Visible = false;
                pnlLocationGrid.Visible = true;
            }
        }

        #endregion

        #region Methods

        public void bindLocation() 
        {
            LocationManager ls = new LocationManager();
            DataSet ds = ls.ListLocations();
            if (ds.Tables[0].Rows.Count > 0) 
            {
                LocationGrid.AutoGenerateColumns = false;
                LocationGrid.DataSource = null;
                //Set Columns Count 
                LocationGrid.ColumnCount = 3;

                //Add Columns
                LocationGrid.Columns[0].Name = "Id";
                LocationGrid.Columns[0].HeaderText = "Id";
                LocationGrid.Columns[0].DataPropertyName = "id";

                LocationGrid.Columns[1].HeaderText = "Location Name";
                LocationGrid.Columns[1].Name = "LocationName";
                LocationGrid.Columns[1].DataPropertyName = "LocationName";

                LocationGrid.Columns[2].Name = "Address";
                LocationGrid.Columns[2].HeaderText = "Location Address";
                LocationGrid.Columns[2].DataPropertyName = "LocationAddress";

                LocationGrid.DataSource = ds.Tables[0];

                //Buttons

                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkForEditColumn";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                LocationGrid.Columns.Add(Editlink);

                DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                Deletelink.UseColumnTextForLinkValue = true;
                Deletelink.HeaderText = "delete";
                Deletelink.DataPropertyName = "lnkForDeleteColumn";
                Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                Deletelink.Text = "Delete";
                LocationGrid.Columns.Add(Deletelink); 

                //DataGridViewButtonColumn db = new DataGridViewButtonColumn();
                //db.Text = "Delete";
                //LocationGrid.Columns.Insert(3, (DataGridViewColumn)db);                
            }
        }

        
        

        #endregion
    }
}
