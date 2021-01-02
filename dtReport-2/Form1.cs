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

namespace dtReport_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=LAPTOP-EF9NKRVE\SQLEXPRESS;Initial Catalog=dtSorceStudent;Integrated Security=True ";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(" Select * From Student", cnn);
            DataTable dt = new DataTable("DataSet1");
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);






            // TODO: This line of code loads data into the 'dtSorceStudentDataSet.Student' table. You can move, or remove it, as needed.
            this.StudentTableAdapter.Fill(this.dtSorceStudentDataSet.Student);

            this.reportViewer1.RefreshReport();

            cnn.Close();

        }
    }
}
