namespace Account
{
    partial class AddExpense
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
            this.pnlExpenseForm = new System.Windows.Forms.Panel();
            this.btnSaveExpenseDetail = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPayTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drpCategoryList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drpClientList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drpLocationList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlExpenseGrid = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ExpenseGrid = new System.Windows.Forms.DataGridView();
            this.btnPnlAddExpense = new System.Windows.Forms.Button();
            this.pnlExpenseForm.SuspendLayout();
            this.pnlExpenseGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlExpenseForm
            // 
            this.pnlExpenseForm.Controls.Add(this.btnCancel);
            this.pnlExpenseForm.Controls.Add(this.btnUpdate);
            this.pnlExpenseForm.Controls.Add(this.btnSaveExpenseDetail);
            this.pnlExpenseForm.Controls.Add(this.txtNote);
            this.pnlExpenseForm.Controls.Add(this.label6);
            this.pnlExpenseForm.Controls.Add(this.txtAmount);
            this.pnlExpenseForm.Controls.Add(this.label5);
            this.pnlExpenseForm.Controls.Add(this.txtPayTo);
            this.pnlExpenseForm.Controls.Add(this.label4);
            this.pnlExpenseForm.Controls.Add(this.drpCategoryList);
            this.pnlExpenseForm.Controls.Add(this.label3);
            this.pnlExpenseForm.Controls.Add(this.drpClientList);
            this.pnlExpenseForm.Controls.Add(this.label2);
            this.pnlExpenseForm.Controls.Add(this.drpLocationList);
            this.pnlExpenseForm.Controls.Add(this.label1);
            this.pnlExpenseForm.Location = new System.Drawing.Point(131, 50);
            this.pnlExpenseForm.Name = "pnlExpenseForm";
            this.pnlExpenseForm.Size = new System.Drawing.Size(648, 393);
            this.pnlExpenseForm.TabIndex = 0;
            // 
            // btnSaveExpenseDetail
            // 
            this.btnSaveExpenseDetail.Location = new System.Drawing.Point(290, 336);
            this.btnSaveExpenseDetail.Name = "btnSaveExpenseDetail";
            this.btnSaveExpenseDetail.Size = new System.Drawing.Size(102, 36);
            this.btnSaveExpenseDetail.TabIndex = 12;
            this.btnSaveExpenseDetail.Text = "Save";
            this.btnSaveExpenseDetail.UseVisualStyleBackColor = true;
            this.btnSaveExpenseDetail.Click += new System.EventHandler(this.btnSaveExpenseDetail_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(290, 220);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(233, 82);
            this.txtNote.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Note";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(290, 172);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(233, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // txtPayTo
            // 
            this.txtPayTo.Location = new System.Drawing.Point(290, 132);
            this.txtPayTo.Name = "txtPayTo";
            this.txtPayTo.Size = new System.Drawing.Size(233, 20);
            this.txtPayTo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pay To";
            // 
            // drpCategoryList
            // 
            this.drpCategoryList.FormattingEnabled = true;
            this.drpCategoryList.Location = new System.Drawing.Point(290, 98);
            this.drpCategoryList.Name = "drpCategoryList";
            this.drpCategoryList.Size = new System.Drawing.Size(233, 21);
            this.drpCategoryList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // drpClientList
            // 
            this.drpClientList.FormattingEnabled = true;
            this.drpClientList.Location = new System.Drawing.Point(290, 54);
            this.drpClientList.Name = "drpClientList";
            this.drpClientList.Size = new System.Drawing.Size(233, 21);
            this.drpClientList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client";
            // 
            // drpLocationList
            // 
            this.drpLocationList.FormattingEnabled = true;
            this.drpLocationList.Location = new System.Drawing.Point(290, 16);
            this.drpLocationList.Name = "drpLocationList";
            this.drpLocationList.Size = new System.Drawing.Size(233, 21);
            this.drpLocationList.TabIndex = 1;
            this.drpLocationList.SelectedIndexChanged += new System.EventHandler(this.drpLocationList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // pnlExpenseGrid
            // 
            this.pnlExpenseGrid.Controls.Add(this.ExpenseGrid);
            this.pnlExpenseGrid.Location = new System.Drawing.Point(22, 40);
            this.pnlExpenseGrid.Name = "pnlExpenseGrid";
            this.pnlExpenseGrid.Size = new System.Drawing.Size(846, 447);
            this.pnlExpenseGrid.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(290, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 36);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ExpenseGrid
            // 
            this.ExpenseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpenseGrid.Location = new System.Drawing.Point(0, 0);
            this.ExpenseGrid.Name = "ExpenseGrid";
            this.ExpenseGrid.Size = new System.Drawing.Size(846, 447);
            this.ExpenseGrid.TabIndex = 0;
            // 
            // btnPnlAddExpense
            // 
            this.btnPnlAddExpense.Location = new System.Drawing.Point(721, 2);
            this.btnPnlAddExpense.Name = "btnPnlAddExpense";
            this.btnPnlAddExpense.Size = new System.Drawing.Size(147, 34);
            this.btnPnlAddExpense.TabIndex = 2;
            this.btnPnlAddExpense.Text = "Add New Expense";
            this.btnPnlAddExpense.UseVisualStyleBackColor = true;
            this.btnPnlAddExpense.Click += new System.EventHandler(this.btnPnlAddExpense_Click);
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 489);
            this.Controls.Add(this.btnPnlAddExpense);
            this.Controls.Add(this.pnlExpenseGrid);
            this.Controls.Add(this.pnlExpenseForm);
            this.Name = "AddExpense";
            this.Text = "AddExpense";
            this.pnlExpenseForm.ResumeLayout(false);
            this.pnlExpenseForm.PerformLayout();
            this.pnlExpenseGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExpenseForm;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPayTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drpCategoryList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drpClientList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpLocationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveExpenseDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlExpenseGrid;
        private System.Windows.Forms.DataGridView ExpenseGrid;
        private System.Windows.Forms.Button btnPnlAddExpense;
    }
}