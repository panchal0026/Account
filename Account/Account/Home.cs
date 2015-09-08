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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Locations l = new Locations();
            l.Show();
        }

        private void addExpenseCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense_Category ex = new Expense_Category();
            ex.Show();
        }

        private void addClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients cl = new Clients();
            cl.Show();
        }
    }
}
