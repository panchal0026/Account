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

        private void btnPnlAddLocation_Click(object sender, EventArgs e)
        {
            pnlLocationForm.Visible = true;
            pnlLocationGrid.Visible = false;
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

                DataGridViewButtonColumn db = new DataGridViewButtonColumn();
                db.Text = "Delete";
                LocationGrid.Columns.Insert(3, (DataGridViewColumn)db);                
            }
        }

        #endregion
    }
}
