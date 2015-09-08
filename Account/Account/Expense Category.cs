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
    public partial class Expense_Category : Form
    {
        public Expense_Category()
        {
            InitializeComponent();
            bindCategory();
        }

        #region Click Events
        private void btnPnlExpenseCategory_Click(object sender, EventArgs e)
        {
            pnlExpenseCategoryForm.Visible = true;
            pnlExpenseCategoryGrid.Visible = false;
        }

        private void btnAddNewExpenseCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtExpenseCategoryName.Text;
            string categoryDesc = txtExpenseCategoryDescription.Text;
            int catTypeID = drpCategoryType.SelectedIndex;
            string catType = drpCategoryType.SelectedItem.ToString();
            CategoryManager cs = new CategoryManager(categoryName, categoryDesc, catTypeID, catType);
            bool res = cs.AddNewCategory(cs);

            if (res)
            {
                MessageBox.Show("Record Inserted Succesfully.!");
                bindCategory();
                pnlExpenseCategoryGrid.Visible = true;
                pnlExpenseCategoryForm.Visible = false;
            }
            else
            {
                MessageBox.Show("Error.!");
            }

        }
        #endregion

        #region Methods

        public void bindCategory() 
        {
            CategoryManager cs = new CategoryManager();
            DataSet ds = cs.listAllCategory();
            if (ds.Tables[0].Rows.Count > 0)
            {
                CategoryGrid.AutoGenerateColumns = false;
                CategoryGrid.DataSource = null;
                //Set Columns Count 
                CategoryGrid.ColumnCount = 4;

                //Add Columns
                CategoryGrid.Columns[0].Name = "Id";
                CategoryGrid.Columns[0].HeaderText = "Id";
                CategoryGrid.Columns[0].DataPropertyName = "CategoryID";

                CategoryGrid.Columns[1].HeaderText = "Location Name";
                CategoryGrid.Columns[1].Name = "LocationName";
                CategoryGrid.Columns[1].DataPropertyName = "CategoryName";

                CategoryGrid.Columns[2].Name = "Address";
                CategoryGrid.Columns[2].HeaderText = "Location Address";
                CategoryGrid.Columns[2].DataPropertyName = "CategoryDesc";

                CategoryGrid.Columns[3].Name = "Address";
                CategoryGrid.Columns[3].HeaderText = "Location Address";
                CategoryGrid.Columns[3].DataPropertyName = "CategoryType";



                CategoryGrid.DataSource = ds.Tables[0];

                DataGridViewButtonColumn db = new DataGridViewButtonColumn();
                db.Text = "Delete";
                CategoryGrid.Columns.Insert(4, (DataGridViewColumn)db);
            }
        }

        #endregion
    }
}
