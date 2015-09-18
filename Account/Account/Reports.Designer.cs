namespace Account
{
    partial class Reports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.pnlIncomeChart = new System.Windows.Forms.Panel();
            this.IncomeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnIncomeClearSearch = new System.Windows.Forms.Button();
            this.btnIncomeSearch = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.drpLocationList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.pnlIncomeChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1245, 483);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.pnlIncomeChart);
            this.xtraTabPage1.Controls.Add(this.btnIncomeClearSearch);
            this.xtraTabPage1.Controls.Add(this.btnIncomeSearch);
            this.xtraTabPage1.Controls.Add(this.dateTimePicker2);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.dateTimePicker1);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.drpLocationList);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1239, 455);
            this.xtraTabPage1.Text = "Income";
            // 
            // pnlIncomeChart
            // 
            this.pnlIncomeChart.Controls.Add(this.IncomeChart);
            this.pnlIncomeChart.Location = new System.Drawing.Point(366, 23);
            this.pnlIncomeChart.Name = "pnlIncomeChart";
            this.pnlIncomeChart.Size = new System.Drawing.Size(855, 425);
            this.pnlIncomeChart.TabIndex = 8;
            // 
            // IncomeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.IncomeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.IncomeChart.Legends.Add(legend1);
            this.IncomeChart.Location = new System.Drawing.Point(29, 21);
            this.IncomeChart.Name = "IncomeChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Month";
            this.IncomeChart.Series.Add(series1);
            this.IncomeChart.Size = new System.Drawing.Size(805, 381);
            this.IncomeChart.TabIndex = 0;
            this.IncomeChart.Text = "chart1";
            // 
            // btnIncomeClearSearch
            // 
            this.btnIncomeClearSearch.Location = new System.Drawing.Point(39, 218);
            this.btnIncomeClearSearch.Name = "btnIncomeClearSearch";
            this.btnIncomeClearSearch.Size = new System.Drawing.Size(93, 36);
            this.btnIncomeClearSearch.TabIndex = 7;
            this.btnIncomeClearSearch.Text = "Clear Search";
            this.btnIncomeClearSearch.UseVisualStyleBackColor = true;
            // 
            // btnIncomeSearch
            // 
            this.btnIncomeSearch.Location = new System.Drawing.Point(201, 218);
            this.btnIncomeSearch.Name = "btnIncomeSearch";
            this.btnIncomeSearch.Size = new System.Drawing.Size(107, 36);
            this.btnIncomeSearch.TabIndex = 6;
            this.btnIncomeSearch.Text = "Search";
            this.btnIncomeSearch.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(108, 153);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "To Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Date";
            // 
            // drpLocationList
            // 
            this.drpLocationList.FormattingEnabled = true;
            this.drpLocationList.Location = new System.Drawing.Point(108, 20);
            this.drpLocationList.Name = "drpLocationList";
            this.drpLocationList.Size = new System.Drawing.Size(200, 21);
            this.drpLocationList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1239, 455);
            this.xtraTabPage2.Text = "Expense";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1239, 455);
            this.xtraTabPage3.Text = "ClientDetail";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 483);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.pnlIncomeChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.ComboBox drpLocationList;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlIncomeChart;
        private System.Windows.Forms.Button btnIncomeClearSearch;
        private System.Windows.Forms.Button btnIncomeSearch;
        private System.Windows.Forms.DataVisualization.Charting.Chart IncomeChart;



    }
}