using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Report.Subforms
{
    public partial class frmReportProduct : Form
    {
        public frmReportProduct()
        {
            InitializeComponent();
        }

        private void frmReportProduct_Load(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=LAPTOP-11052000\SQLEXPRESS;Initial Catalog=ProductOrder;User ID=sa;Password=demo123";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(" Select * From Product", cnn);
            DataTable dt = new DataTable("DataSetProduct");
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSetProduct", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();

            cnn.Close();
        }
    }
}
