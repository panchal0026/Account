using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace Account
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            loadChart();
      //      BindChart();
        }

        public void loadChart() 
        {
            bindIncomeChart();
            bindExpenseChart();
        }

        public void bindIncomeChart() 
        {
            //IncomeDetailManager im = new IncomeDetailManager();
            //DataSet ds= im.getIncomeChartData(0, null, null);
            //string[] inc = { "5000", "10000", "15000", "20000"," 25000", "30000 "};
            //IncomeChart.Series.Add("Income");
            //IncomeChart.Series["Income"].XValueMember = "Month";
            //IncomeChart.Series["Income"].XValueMember = "TransactionID";
            //IncomeChart.DataSource = ds.Tables[0];
            //IncomeChart.DataBind();
        }

        public void bindExpenseChart() 
        {

        }

       //public void BindChart(){

       //     // Generate a data table and bind the chart to it.
       //     chart.DataSource = CreateChartData();

       //     // Specify data members to bind the chart's series template.
       //     chart.SeriesDataMember = "Month";
       //     chart.SeriesTemplate.ArgumentDataMember = "Month";
       //     //chart.SeriesTemplate.ArgumentDataMember = "Section";
       //     chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] {"Value"});

       //     // Specify the template's series view.
       //     chart.SeriesTemplate.View = new StackedBarSeriesView();

       //     // Specify the template's name prefix.
       //     chart.SeriesNameTemplate.BeginText = "Month: ";

       //     // Dock the chart into its parent, and add it to the current form.
       //     chart.Dock = DockStyle.Fill;
       //     this.Controls.Add(chart);

       // }

       //   private DataTable CreateChartData() {
       //     // Create an empty table.
       //     DataTable table = new DataTable("Table1");

       //     // Add three columns to the table.
       //     table.Columns.Add("Month", typeof(String));
       //    // table.Columns.Add("Section", typeof(String));
       //     table.Columns.Add("Value", typeof(Int32));

       //     // Add data rows to the table.
       //     table.Rows.Add(new object[] { "Jan", 10 });
       //     table.Rows.Add(new object[] { "Jan", 20 });
       //     table.Rows.Add(new object[] { "Feb", 20 });
       //     table.Rows.Add(new object[] { "Feb", 30 });
       //     table.Rows.Add(new object[] { "March", 15 });
       //     table.Rows.Add(new object[] { "March", 25 });

       //     return table;
       // }

       
    }
}
