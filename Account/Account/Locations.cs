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

        }

        private void btnPnlAddLocation_Click(object sender, EventArgs e)
        {
            pnlLocationForm.Visible = true;
            pnlLocationGrid.Visible = false;
        }
    }
}
