namespace Account
{
    partial class AddIncome
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
            this.pnlAddIncomeForm = new System.Windows.Forms.Panel();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNewIncome = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drpLocationList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlIncomeGrid = new System.Windows.Forms.Panel();
            this.IncomeDetailGrid = new System.Windows.Forms.DataGridView();
            this.btnPnlAddNewIncome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.pnlAddIncomeForm.SuspendLayout();
            this.PnlIncomeGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDetailGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddIncomeForm
            // 
            this.pnlAddIncomeForm.Controls.Add(this.dateTime);
            this.pnlAddIncomeForm.Controls.Add(this.label5);
            this.pnlAddIncomeForm.Controls.Add(this.lblTransactionID);
            this.pnlAddIncomeForm.Controls.Add(this.btnCancel);
            this.pnlAddIncomeForm.Controls.Add(this.btnAddNewIncome);
            this.pnlAddIncomeForm.Controls.Add(this.btnUpdate);
            this.pnlAddIncomeForm.Controls.Add(this.txtNote);
            this.pnlAddIncomeForm.Controls.Add(this.label4);
            this.pnlAddIncomeForm.Controls.Add(this.txtAmount);
            this.pnlAddIncomeForm.Controls.Add(this.label3);
            this.pnlAddIncomeForm.Controls.Add(this.txtName);
            this.pnlAddIncomeForm.Controls.Add(this.label2);
            this.pnlAddIncomeForm.Controls.Add(this.drpLocationList);
            this.pnlAddIncomeForm.Controls.Add(this.label1);
            this.pnlAddIncomeForm.Location = new System.Drawing.Point(210, 65);
            this.pnlAddIncomeForm.Name = "pnlAddIncomeForm";
            this.pnlAddIncomeForm.Size = new System.Drawing.Size(555, 381);
            this.pnlAddIncomeForm.TabIndex = 0;
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Location = new System.Drawing.Point(106, 366);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(0, 13);
            this.lblTransactionID.TabIndex = 11;
            this.lblTransactionID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(106, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNewIncome
            // 
            this.btnAddNewIncome.Location = new System.Drawing.Point(224, 329);
            this.btnAddNewIncome.Name = "btnAddNewIncome";
            this.btnAddNewIncome.Size = new System.Drawing.Size(94, 30);
            this.btnAddNewIncome.TabIndex = 9;
            this.btnAddNewIncome.Text = "Save";
            this.btnAddNewIncome.UseVisualStyleBackColor = true;
            this.btnAddNewIncome.Click += new System.EventHandler(this.btnAddNewIncome_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(224, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(224, 216);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(206, 94);
            this.txtNote.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Note";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(224, 138);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(206, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(224, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // drpLocationList
            // 
            this.drpLocationList.FormattingEnabled = true;
            this.drpLocationList.Location = new System.Drawing.Point(224, 42);
            this.drpLocationList.Name = "drpLocationList";
            this.drpLocationList.Size = new System.Drawing.Size(206, 21);
            this.drpLocationList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // PnlIncomeGrid
            // 
            this.PnlIncomeGrid.Controls.Add(this.IncomeDetailGrid);
            this.PnlIncomeGrid.Location = new System.Drawing.Point(31, 53);
            this.PnlIncomeGrid.Name = "PnlIncomeGrid";
            this.PnlIncomeGrid.Size = new System.Drawing.Size(917, 426);
            this.PnlIncomeGrid.TabIndex = 1;
            // 
            // IncomeDetailGrid
            // 
            this.IncomeDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeDetailGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncomeDetailGrid.Location = new System.Drawing.Point(0, 0);
            this.IncomeDetailGrid.Name = "IncomeDetailGrid";
            this.IncomeDetailGrid.Size = new System.Drawing.Size(917, 426);
            this.IncomeDetailGrid.TabIndex = 0;
            this.IncomeDetailGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IncomeDetailGrid_CellContentClick);
            // 
            // btnPnlAddNewIncome
            // 
            this.btnPnlAddNewIncome.Location = new System.Drawing.Point(780, 12);
            this.btnPnlAddNewIncome.Name = "btnPnlAddNewIncome";
            this.btnPnlAddNewIncome.Size = new System.Drawing.Size(168, 33);
            this.btnPnlAddNewIncome.TabIndex = 2;
            this.btnPnlAddNewIncome.Text = "Add New Income";
            this.btnPnlAddNewIncome.UseVisualStyleBackColor = true;
            this.btnPnlAddNewIncome.Click += new System.EventHandler(this.btnPnlAddNewIncome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(224, 175);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 13;
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 491);
            this.Controls.Add(this.btnPnlAddNewIncome);
            this.Controls.Add(this.PnlIncomeGrid);
            this.Controls.Add(this.pnlAddIncomeForm);
            this.Name = "AddIncome";
            this.Text = "AddIncome";
            this.pnlAddIncomeForm.ResumeLayout(false);
            this.pnlAddIncomeForm.PerformLayout();
            this.PnlIncomeGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDetailGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddIncomeForm;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpLocationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNewIncome;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel PnlIncomeGrid;
        private System.Windows.Forms.DataGridView IncomeDetailGrid;
        private System.Windows.Forms.Button btnPnlAddNewIncome;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label5;
    }
}