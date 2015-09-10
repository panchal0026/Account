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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.drpLocationList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drpClientList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drpCategoryList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSaveExpenseDetail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveExpenseDetail);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPayTo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.drpCategoryList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.drpClientList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.drpLocationList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(107, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 393);
            this.panel1.TabIndex = 0;
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
            // drpLocationList
            // 
            this.drpLocationList.FormattingEnabled = true;
            this.drpLocationList.Location = new System.Drawing.Point(290, 16);
            this.drpLocationList.Name = "drpLocationList";
            this.drpLocationList.Size = new System.Drawing.Size(233, 21);
            this.drpLocationList.TabIndex = 1;
            this.drpLocationList.SelectedIndexChanged += new System.EventHandler(this.drpLocationList_SelectedIndexChanged);
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
            // drpClientList
            // 
            this.drpClientList.FormattingEnabled = true;
            this.drpClientList.Location = new System.Drawing.Point(290, 54);
            this.drpClientList.Name = "drpClientList";
            this.drpClientList.Size = new System.Drawing.Size(233, 21);
            this.drpClientList.TabIndex = 3;
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
            // drpCategoryList
            // 
            this.drpCategoryList.FormattingEnabled = true;
            this.drpCategoryList.Location = new System.Drawing.Point(290, 98);
            this.drpCategoryList.Name = "drpCategoryList";
            this.drpCategoryList.Size = new System.Drawing.Size(233, 21);
            this.drpCategoryList.TabIndex = 5;
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
            // txtPayTo
            // 
            this.txtPayTo.Location = new System.Drawing.Point(290, 132);
            this.txtPayTo.Name = "txtPayTo";
            this.txtPayTo.Size = new System.Drawing.Size(233, 20);
            this.txtPayTo.TabIndex = 7;
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
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(290, 172);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(233, 20);
            this.txtAmount.TabIndex = 9;
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
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(290, 220);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(233, 82);
            this.txtNote.TabIndex = 11;
            // 
            // btnSaveExpenseDetail
            // 
            this.btnSaveExpenseDetail.Location = new System.Drawing.Point(290, 330);
            this.btnSaveExpenseDetail.Name = "btnSaveExpenseDetail";
            this.btnSaveExpenseDetail.Size = new System.Drawing.Size(102, 36);
            this.btnSaveExpenseDetail.TabIndex = 12;
            this.btnSaveExpenseDetail.Text = "Save";
            this.btnSaveExpenseDetail.UseVisualStyleBackColor = true;
            this.btnSaveExpenseDetail.Click += new System.EventHandler(this.btnSaveExpenseDetail_Click);
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 489);
            this.Controls.Add(this.panel1);
            this.Name = "AddExpense";
            this.Text = "AddExpense";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}