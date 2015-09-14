namespace Account
{
    partial class Category
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
            this.drpCategoryType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewExpenseCategory = new System.Windows.Forms.Button();
            this.txtExpenseCategoryDescription = new System.Windows.Forms.TextBox();
            this.lblExpenseCategoryDescription = new System.Windows.Forms.Label();
            this.txtExpenseCategoryName = new System.Windows.Forms.TextBox();
            this.lblExpenseCategoryName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblExpenseID = new System.Windows.Forms.Label();
            this.pnlExpenseCategoryGrid = new System.Windows.Forms.Panel();
            this.CategoryGrid = new System.Windows.Forms.DataGridView();
            this.btnPnlExpenseCategory = new System.Windows.Forms.Button();
            this.pnlExpenseCategoryForm.SuspendLayout();
            this.pnlExpenseCategoryGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlExpenseCategoryForm
            // 
            this.pnlExpenseCategoryForm.Controls.Add(this.drpCategoryType);
            this.pnlExpenseCategoryForm.Controls.Add(this.label1);
            this.pnlExpenseCategoryForm.Controls.Add(this.btnAddNewExpenseCategory);
            this.pnlExpenseCategoryForm.Controls.Add(this.txtExpenseCategoryDescription);
            this.pnlExpenseCategoryForm.Controls.Add(this.lblExpenseCategoryDescription);
            this.pnlExpenseCategoryForm.Controls.Add(this.txtExpenseCategoryName);
            this.pnlExpenseCategoryForm.Controls.Add(this.lblExpenseCategoryName);
            this.pnlExpenseCategoryForm.Controls.Add(this.btnUpdate);
            this.pnlExpenseCategoryForm.Controls.Add(this.btnCancel);
            this.pnlExpenseCategoryForm.Controls.Add(this.lblExpenseID);
            this.pnlExpenseCategoryForm.Location = new System.Drawing.Point(204, 62);
            this.pnlExpenseCategoryForm.Name = "pnlExpenseCategoryForm";
            this.pnlExpenseCategoryForm.Size = new System.Drawing.Size(536, 315);
            this.pnlExpenseCategoryForm.TabIndex = 0;
            this.pnlExpenseCategoryForm.Visible = false;
            // 
            // drpCategoryType
            // 
            this.drpCategoryType.FormattingEnabled = true;
            this.drpCategoryType.Items.AddRange(new object[] {
            "--Select one--",
            "Expense",
            "Income"});
            this.drpCategoryType.Location = new System.Drawing.Point(228, 200);
            this.drpCategoryType.Name = "drpCategoryType";
            this.drpCategoryType.Size = new System.Drawing.Size(166, 21);
            this.drpCategoryType.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // btnAddNewExpenseCategory
            // 
            this.btnAddNewExpenseCategory.Location = new System.Drawing.Point(228, 241);
            this.btnAddNewExpenseCategory.Name = "btnAddNewExpenseCategory";
            this.btnAddNewExpenseCategory.Size = new System.Drawing.Size(126, 36);
            this.btnAddNewExpenseCategory.TabIndex = 4;
            this.btnAddNewExpenseCategory.Text = "Add Category";
            this.btnAddNewExpenseCategory.UseVisualStyleBackColor = true;
            this.btnAddNewExpenseCategory.Click += new System.EventHandler(this.btnAddNewExpenseCategory_Click);
            // 
            // txtExpenseCategoryDescription
            // 
            this.txtExpenseCategoryDescription.Location = new System.Drawing.Point(228, 72);
            this.txtExpenseCategoryDescription.Multiline = true;
            this.txtExpenseCategoryDescription.Name = "txtExpenseCategoryDescription";
            this.txtExpenseCategoryDescription.Size = new System.Drawing.Size(166, 107);
            this.txtExpenseCategoryDescription.TabIndex = 3;
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
            // txtExpenseCategoryName
            // 
            this.txtExpenseCategoryName.Location = new System.Drawing.Point(228, 29);
            this.txtExpenseCategoryName.Name = "txtExpenseCategoryName";
            this.txtExpenseCategoryName.Size = new System.Drawing.Size(166, 20);
            this.txtExpenseCategoryName.TabIndex = 1;
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(228, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 36);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(97, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblExpenseID
            // 
            this.lblExpenseID.AutoSize = true;
            this.lblExpenseID.Location = new System.Drawing.Point(236, 238);
            this.lblExpenseID.Name = "lblExpenseID";
            this.lblExpenseID.Size = new System.Drawing.Size(0, 13);
            this.lblExpenseID.TabIndex = 6;
            this.lblExpenseID.Visible = false;
            // 
            // pnlExpenseCategoryGrid
            // 
            this.pnlExpenseCategoryGrid.Controls.Add(this.CategoryGrid);
            this.pnlExpenseCategoryGrid.Controls.Add(this.btnPnlExpenseCategory);
            this.pnlExpenseCategoryGrid.Location = new System.Drawing.Point(34, 25);
            this.pnlExpenseCategoryGrid.Name = "pnlExpenseCategoryGrid";
            this.pnlExpenseCategoryGrid.Size = new System.Drawing.Size(924, 409);
            this.pnlExpenseCategoryGrid.TabIndex = 1;
            // 
            // CategoryGrid
            // 
            this.CategoryGrid.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.CategoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryGrid.Location = new System.Drawing.Point(70, 66);
            this.CategoryGrid.Name = "CategoryGrid";
            this.CategoryGrid.Size = new System.Drawing.Size(799, 298);
            this.CategoryGrid.TabIndex = 1;
            this.CategoryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGrid_CellContentClick);
            // 
            // btnPnlExpenseCategory
            // 
            this.btnPnlExpenseCategory.Location = new System.Drawing.Point(722, 13);
            this.btnPnlExpenseCategory.Name = "btnPnlExpenseCategory";
            this.btnPnlExpenseCategory.Size = new System.Drawing.Size(166, 34);
            this.btnPnlExpenseCategory.TabIndex = 0;
            this.btnPnlExpenseCategory.Text = "Add Expense Category";
            this.btnPnlExpenseCategory.UseVisualStyleBackColor = true;
            this.btnPnlExpenseCategory.Click += new System.EventHandler(this.btnPnlExpenseCategory_Click);
            // 
            // Expense_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 456);
            this.Controls.Add(this.pnlExpenseCategoryGrid);
            this.Controls.Add(this.pnlExpenseCategoryForm);
            this.Name = "Category";
            this.Text = "Category";
            this.pnlExpenseCategoryForm.ResumeLayout(false);
            this.pnlExpenseCategoryForm.PerformLayout();
            this.pnlExpenseCategoryGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGrid)).EndInit();
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
        private System.Windows.Forms.ComboBox drpCategoryType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CategoryGrid;

        private System.Windows.Forms.Label lblExpenseID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}