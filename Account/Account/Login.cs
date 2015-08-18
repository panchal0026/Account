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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = "admin";
            string pass = "admin";

            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                if (txtUserName.Text == userName && txtPassword.Text == pass)
                {
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            else 
            {
                MessageBox.Show("Enter Login Credentials");
            }
        }
    }
}
