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

            btnUpdate.Visible = false;
            btnCancel.Visible = false;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int category_id = Convert.ToInt32(lblExpenseID.Text);
            string categoryName = txtExpenseCategoryName.Text;
            string categoryDesc = txtExpenseCategoryDescription.Text;
            int catTypeID = drpCategoryType.SelectedIndex;
            string catType = drpCategoryType.SelectedItem.ToString();
            CategoryManager cm = new CategoryManager(category_id,categoryName,categoryDesc,catTypeID,catType);
            if (!string.IsNullOrEmpty(categoryName))
            {
                try
                {
                    cm.UpdateCategoryWithType(cm);
                    MessageBox.Show("Category Updated Succesfully.!");
                    bindCategory();
                    pnlExpenseCategoryGrid.Visible = true;
                    pnlExpenseCategoryForm.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter Category Name");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlExpenseCategoryForm.Visible = false;
            pnlExpenseCategoryGrid.Visible = true;
        }

        private void CategoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int category_id = 0;

            if (e.ColumnIndex == 4)
            {

                txtExpenseCategoryName.Text = CategoryGrid.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
                txtExpenseCategoryDescription.Text = CategoryGrid.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                lblExpenseID.Text = CategoryGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                
                if (CategoryGrid.Rows[e.RowIndex].Cells["CategoryType"].Value.ToString() == "Expense")
                {
                    drpCategoryType.SelectedIndex = 1;
                }
                else if (CategoryGrid.Rows[e.RowIndex].Cells["CategoryType"].Value.ToString() == "Income")
                {
                    drpCategoryType.SelectedIndex= 2;
                }

                pnlExpenseCategoryForm.Visible = true;
                pnlExpenseCategoryGrid.Visible = false;
                btnPnlExpenseCategory.Visible = false;

                btnUpdate.Visible = true;
                btnCancel.Visible = true;

            }
            if (e.ColumnIndex == 5)
            {
                category_id = Convert.ToInt32(CategoryGrid.Rows[e.RowIndex].Cells["Id"].Value);

                CategoryManager cat_manager = new CategoryManager();
                cat_manager.DeleteCategory(category_id);
                bindCategory();

                pnlExpenseCategoryForm.Visible = false;
                pnlExpenseCategoryGrid.Visible = true;
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

                CategoryGrid.Columns[1].HeaderText = "Category Name";
                CategoryGrid.Columns[1].Name = "CategoryName";
                CategoryGrid.Columns[1].DataPropertyName = "CategoryName";

                CategoryGrid.Columns[2].Name = "Description";
                CategoryGrid.Columns[2].HeaderText = "Category Description";
                CategoryGrid.Columns[2].DataPropertyName = "CategoryDesc";

                CategoryGrid.Columns[3].Name = "CategoryType";
                CategoryGrid.Columns[3].HeaderText = "Category Type";
                CategoryGrid.Columns[3].DataPropertyName = "CategoryType";



                CategoryGrid.DataSource = ds.Tables[0];


                //Buttons

                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkForEditColumn";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                CategoryGrid.Columns.Add(Editlink);

                DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                Deletelink.UseColumnTextForLinkValue = true;
                Deletelink.HeaderText = "delete";
                Deletelink.DataPropertyName = "lnkForDeleteColumn";
                Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                Deletelink.Text = "Delete";
                CategoryGrid.Columns.Add(Deletelink); 


                //DataGridViewButtonColumn db = new DataGridViewButtonColumn();
                //db.Text = "Delete";
                //CategoryGrid.Columns.Insert(4, (DataGridViewColumn)db);
            }
        }

        #endregion
    }
}
