namespace Account
{
    partial class Clients
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
            this.pnlClientForm = new System.Windows.Forms.Panel();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drpLocation = new System.Windows.Forms.ComboBox();
            this.Location = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlClientGrid = new System.Windows.Forms.Panel();
            this.ClientGrid = new System.Windows.Forms.DataGridView();
            this.btnPnlAddClient = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClientID = new System.Windows.Forms.Label();
            this.pnlClientForm.SuspendLayout();
            this.pnlClientGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientForm
            // 
            this.pnlClientForm.Controls.Add(this.lblClientID);
            this.pnlClientForm.Controls.Add(this.btnCancel);
            this.pnlClientForm.Controls.Add(this.btnAddClient);
            this.pnlClientForm.Controls.Add(this.btnUpdate);
            this.pnlClientForm.Controls.Add(this.txtAddress);
            this.pnlClientForm.Controls.Add(this.label4);
            this.pnlClientForm.Controls.Add(this.txtContactNo);
            this.pnlClientForm.Controls.Add(this.label3);
            this.pnlClientForm.Controls.Add(this.txtClientEmail);
            this.pnlClientForm.Controls.Add(this.label2);
            this.pnlClientForm.Controls.Add(this.drpLocation);
            this.pnlClientForm.Controls.Add(this.Location);
            this.pnlClientForm.Controls.Add(this.txtClientName);
            this.pnlClientForm.Controls.Add(this.label1);
            this.pnlClientForm.Location = new System.Drawing.Point(264, 72);
            this.pnlClientForm.Name = "pnlClientForm";
            this.pnlClientForm.Size = new System.Drawing.Size(548, 356);
            this.pnlClientForm.TabIndex = 0;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(226, 268);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(89, 32);
            this.btnAddClient.TabIndex = 11;
            this.btnAddClient.Text = "Save";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(226, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(226, 184);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(210, 58);
            this.txtAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(226, 148);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(210, 20);
            this.txtContactNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact No";
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(226, 108);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(210, 20);
            this.txtClientEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // drpLocation
            // 
            this.drpLocation.FormattingEnabled = true;
            this.drpLocation.Location = new System.Drawing.Point(226, 66);
            this.drpLocation.Name = "drpLocation";
            this.drpLocation.Size = new System.Drawing.Size(210, 21);
            this.drpLocation.TabIndex = 3;
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(127, 73);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(48, 13);
            this.Location.TabIndex = 2;
            this.Location.Text = "Location";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(226, 21);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(210, 20);
            this.txtClientName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            // 
            // pnlClientGrid
            // 
            this.pnlClientGrid.Controls.Add(this.ClientGrid);
            this.pnlClientGrid.Controls.Add(this.btnPnlAddClient);
            this.pnlClientGrid.Location = new System.Drawing.Point(44, 27);
            this.pnlClientGrid.Name = "pnlClientGrid";
            this.pnlClientGrid.Size = new System.Drawing.Size(999, 423);
            this.pnlClientGrid.TabIndex = 1;
            // 
            // ClientGrid
            // 
            this.ClientGrid.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.ClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGrid.Location = new System.Drawing.Point(40, 73);
            this.ClientGrid.Name = "ClientGrid";
            this.ClientGrid.Size = new System.Drawing.Size(917, 325);
            this.ClientGrid.TabIndex = 1;
            this.ClientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGrid_CellContentClick);
            // 
            // btnPnlAddClient
            // 
            this.btnPnlAddClient.Location = new System.Drawing.Point(786, 15);
            this.btnPnlAddClient.Name = "btnPnlAddClient";
            this.btnPnlAddClient.Size = new System.Drawing.Size(171, 34);
            this.btnPnlAddClient.TabIndex = 0;
            this.btnPnlAddClient.Text = "Add New Client";
            this.btnPnlAddClient.UseVisualStyleBackColor = true;
            this.btnPnlAddClient.Click += new System.EventHandler(this.btnPnlAddClient_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(115, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(115, 307);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(0, 13);
            this.lblClientID.TabIndex = 13;
            this.lblClientID.Visible = false;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 462);
            this.Controls.Add(this.pnlClientGrid);
            this.Controls.Add(this.pnlClientForm);
            this.Name = "Clients";
            this.Text = "Clients";
            this.pnlClientForm.ResumeLayout(false);
            this.pnlClientForm.PerformLayout();
            this.pnlClientGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClientForm;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpLocation;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlClientGrid;
        private System.Windows.Forms.Button btnPnlAddClient;
        private System.Windows.Forms.DataGridView ClientGrid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblClientID;
    }
}