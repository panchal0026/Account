namespace Account
{
    partial class Locations
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
            this.pnlLocationForm = new System.Windows.Forms.Panel();
            this.lblLoactionName = new System.Windows.Forms.Label();
            this.txtLoactionName = new System.Windows.Forms.TextBox();
            this.txtLocationAddress = new System.Windows.Forms.TextBox();
            this.lblLoactionAddress = new System.Windows.Forms.Label();
            this.btnAddNewLoaction = new System.Windows.Forms.Button();
            this.pnlLocationGrid = new System.Windows.Forms.Panel();
            this.btnPnlAddLocation = new System.Windows.Forms.Button();
            this.pnlLocationForm.SuspendLayout();
            this.pnlLocationGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLocationForm
            // 
            this.pnlLocationForm.Controls.Add(this.btnAddNewLoaction);
            this.pnlLocationForm.Controls.Add(this.txtLocationAddress);
            this.pnlLocationForm.Controls.Add(this.lblLoactionAddress);
            this.pnlLocationForm.Controls.Add(this.txtLoactionName);
            this.pnlLocationForm.Controls.Add(this.lblLoactionName);
            this.pnlLocationForm.Location = new System.Drawing.Point(166, 26);
            this.pnlLocationForm.Name = "pnlLocationForm";
            this.pnlLocationForm.Size = new System.Drawing.Size(768, 410);
            this.pnlLocationForm.TabIndex = 0;
            this.pnlLocationForm.Visible = false;
            // 
            // lblLoactionName
            // 
            this.lblLoactionName.AutoSize = true;
            this.lblLoactionName.Location = new System.Drawing.Point(234, 101);
            this.lblLoactionName.Name = "lblLoactionName";
            this.lblLoactionName.Size = new System.Drawing.Size(79, 13);
            this.lblLoactionName.TabIndex = 0;
            this.lblLoactionName.Text = "Location Name";
            // 
            // txtLoactionName
            // 
            this.txtLoactionName.Location = new System.Drawing.Point(373, 94);
            this.txtLoactionName.Name = "txtLoactionName";
            this.txtLoactionName.Size = new System.Drawing.Size(150, 20);
            this.txtLoactionName.TabIndex = 1;
            // 
            // txtLocationAddress
            // 
            this.txtLocationAddress.Location = new System.Drawing.Point(373, 138);
            this.txtLocationAddress.Name = "txtLocationAddress";
            this.txtLocationAddress.Size = new System.Drawing.Size(150, 20);
            this.txtLocationAddress.TabIndex = 3;
            // 
            // lblLoactionAddress
            // 
            this.lblLoactionAddress.AutoSize = true;
            this.lblLoactionAddress.Location = new System.Drawing.Point(234, 145);
            this.lblLoactionAddress.Name = "lblLoactionAddress";
            this.lblLoactionAddress.Size = new System.Drawing.Size(89, 13);
            this.lblLoactionAddress.TabIndex = 2;
            this.lblLoactionAddress.Text = "Location Address";
            // 
            // btnAddNewLoaction
            // 
            this.btnAddNewLoaction.Location = new System.Drawing.Point(373, 190);
            this.btnAddNewLoaction.Name = "btnAddNewLoaction";
            this.btnAddNewLoaction.Size = new System.Drawing.Size(150, 23);
            this.btnAddNewLoaction.TabIndex = 4;
            this.btnAddNewLoaction.Text = "Add Location";
            this.btnAddNewLoaction.UseVisualStyleBackColor = true;
            this.btnAddNewLoaction.Click += new System.EventHandler(this.btnAddNewLoaction_Click);
            // 
            // pnlLocationGrid
            // 
            this.pnlLocationGrid.Controls.Add(this.btnPnlAddLocation);
            this.pnlLocationGrid.Location = new System.Drawing.Point(29, 13);
            this.pnlLocationGrid.Name = "pnlLocationGrid";
            this.pnlLocationGrid.Size = new System.Drawing.Size(1095, 447);
            this.pnlLocationGrid.TabIndex = 1;
            // 
            // btnPnlAddLocation
            // 
            this.btnPnlAddLocation.Location = new System.Drawing.Point(942, 13);
            this.btnPnlAddLocation.Name = "btnPnlAddLocation";
            this.btnPnlAddLocation.Size = new System.Drawing.Size(139, 34);
            this.btnPnlAddLocation.TabIndex = 0;
            this.btnPnlAddLocation.Text = "Add Locaton";
            this.btnPnlAddLocation.UseVisualStyleBackColor = true;
            this.btnPnlAddLocation.Click += new System.EventHandler(this.btnPnlAddLocation_Click);
            // 
            // Loactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 472);
            this.Controls.Add(this.pnlLocationGrid);
            this.Controls.Add(this.pnlLocationForm);
            this.Name = "Loactions";
            this.Text = "Loactions";
            this.pnlLocationForm.ResumeLayout(false);
            this.pnlLocationForm.PerformLayout();
            this.pnlLocationGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLocationForm;
        private System.Windows.Forms.TextBox txtLocationAddress;
        private System.Windows.Forms.Label lblLoactionAddress;
        private System.Windows.Forms.TextBox txtLoactionName;
        private System.Windows.Forms.Label lblLoactionName;
        private System.Windows.Forms.Button btnAddNewLoaction;
        private System.Windows.Forms.Panel pnlLocationGrid;
        private System.Windows.Forms.Button btnPnlAddLocation;
    }
}