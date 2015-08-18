namespace Account
{
    partial class Expense_Category
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlExpenseCategoryForm = new System.Windows.Forms.Panel();
            this.lblExpenseCategoryName = new System.Windows.Forms.Label();
            this.txtExpenseCategoryName = new System.Windows.Forms.TextBox();
            this.lblExpenseCategoryDescription = new System.Windows.Forms.Label();
            this.txtExpenseCategoryDescription = new System.Windows.Forms.TextBox();
            this.btnAddNewExpenseCategory = new System.Windows.Forms.Button();
            this.pnlExpenseCategoryGrid = new System.Windows.Forms.Panel();
            this.btnPnlExpenseCategory = new System.Windows.Forms.Button();
            this.pnlExpenseCategoryForm.SuspendLayout();
            this.pnlExpenseCategoryGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlExpenseCategoryForm
            // 
            this.pnlExpenseCategoryForm.Controls.Add(this.btnAddNewExpenseCategory);
            this.pnlExpenseCategoryForm.Controls.Add(this.txtExpenseCategoryDescription);
            this.pnlExpenseCategoryForm.Controls.Add(this.lblExpenseCategoryDescription);
            this.pnlExpenseCategoryForm.Controls.Add(this.txtExpenseCategoryName);
            this.pnlExpenseCategoryForm.Controls.Add(this.lblExpenseCategoryName);
            this.pnlExpenseCategoryForm.Location = new System.Drawing.Point(204, 62);
            this.pnlExpenseCategoryForm.Name = "pnlExpenseCategoryForm";
            this.pnlExpenseCategoryForm.Size = new System.Drawing.Size(536, 315);
            this.pnlExpenseCategoryForm.TabIndex = 0;
            this.pnlExpenseCategoryForm.Visible = false;
            // 
            // lblExpenseCategoryName
            // 
            this.lblExpenseCategoryName.AutoSize = true;
            this.lblExpenseCategoryName.Location = new System.Drawing.Point(111, 37);
            this.lblExpenseCategoryName.Name = "lblExpenseCategoryName";
            this.lblExpenseCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lblExpenseCategoryName.TabIndex = 0;
            this.lblExpenseCategoryName.Text = "Category Name";
            // 
            // txtExpenseCategoryName
            // 
            this.txtExpenseCategoryName.Location = new System.Drawing.Point(228, 29);
            this.txtExpenseCategoryName.Name = "txtExpenseCategoryName";
            this.txtExpenseCategoryName.Size = new System.Drawing.Size(166, 20);
            this.txtExpenseCategoryName.TabIndex = 1;
            // 
            // lblExpenseCategoryDescription
            // 
            this.lblExpenseCategoryDescription.AutoSize = true;
            this.lblExpenseCategoryDescription.Location = new System.Drawing.Point(114, 80);
            this.lblExpenseCategoryDescription.Name = "lblExpenseCategoryDescription";
            this.lblExpenseCategoryDescription.Size = new System.Drawing.Size(60, 13);
            this.lblExpenseCategoryDescription.TabIndex = 2;
            this.lblExpenseCategoryDescription.Text = "Description";
            // 
            // txtExpenseCategoryDescription
            // 
            this.txtExpenseCategoryDescription.Location = new System.Drawing.Point(228, 72);
            this.txtExpenseCategoryDescription.Multiline = true;
            this.txtExpenseCategoryDescription.Name = "txtExpenseCategoryDescription";
            this.txtExpenseCategoryDescription.Size = new System.Drawing.Size(166, 107);
            this.txtExpenseCategoryDescription.TabIndex = 3;
            // 
            // btnAddNewExpenseCategory
            // 
            this.btnAddNewExpenseCategory.Location = new System.Drawing.Point(228, 207);
            this.btnAddNewExpenseCategory.Name = "btnAddNewExpenseCategory";
            this.btnAddNewExpenseCategory.Size = new System.Drawing.Size(94, 27);
            this.btnAddNewExpenseCategory.TabIndex = 4;
            this.btnAddNewExpenseCategory.Text = "Add Category";
            this.btnAddNewExpenseCategory.UseVisualStyleBackColor = true;
            // 
            // pnlExpenseCategoryGrid
            // 
            this.pnlExpenseCategoryGrid.Controls.Add(this.btnPnlExpenseCategory);
            this.pnlExpenseCategoryGrid.Location = new System.Drawing.Point(38, 25);
            this.pnlExpenseCategoryGrid.Name = "pnlExpenseCategoryGrid";
            this.pnlExpenseCategoryGrid.Size = new System.Drawing.Size(920, 409);
            this.pnlExpenseCategoryGrid.TabIndex = 1;
            // 
            // btnPnlExpenseCategory
            // 
            this.btnPnlExpenseCategory.Location = new System.Drawing.Point(722, 13);
            this.btnPnlExpenseCategory.Name = "btnPnlExpenseCategory";
            this.btnPnlExpenseCategory.Size = new System.Drawing.Size(166, 23);
            this.btnPnlExpenseCategory.TabIndex = 0;
            this.btnPnlExpenseCategory.Text = "Add Expense Category";
            this.btnPnlExpenseCategory.UseVisualStyleBackColor = true;
            // 
            // Expense_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 456);
            this.Controls.Add(this.pnlExpenseCategoryGrid);
            this.Controls.Add(this.pnlExpenseCategoryForm);
            this.Name = "Expense_Category";
            this.Text = "Expense_Category";
            this.pnlExpenseCategoryForm.ResumeLayout(false);
            this.pnlExpenseCategoryForm.PerformLayout();
            this.pnlExpenseCategoryGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExpenseCategoryForm;
        private System.Windows.Forms.Label lblExpenseCategoryDescription;
        private System.Windows.Forms.TextBox txtExpenseCategoryName;
        private System.Windows.Forms.Label lblExpenseCategoryName;
        private System.Windows.Forms.TextBox txtExpenseCategoryDescription;
        private System.Windows.Forms.Button btnAddNewExpenseCategory;
        private System.Windows.Forms.Panel pnlExpenseCategoryGrid;
        private System.Windows.Forms.Button btnPnlExpenseCategory;
    }
}