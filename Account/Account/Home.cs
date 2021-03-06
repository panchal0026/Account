﻿using System;
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
            Category ex = new Category();
            ex.Show();
        }

        private void addClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients cl = new Clients();
            cl.Show();
        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainAccount ma = new MainAccount();
            ma.Show();
        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExpense expense = new AddExpense();
            expense.Show();
        }

        private void addIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIncome income = new AddIncome();
            income.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
        }
    }
}
