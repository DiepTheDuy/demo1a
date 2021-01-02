using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Student> GetTempListStudents()
        {
            List<Student> listStudent = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student temp = new Student();
                temp.StudentID = "CNTT0120" + i;
                temp.FullName = "Nguyen Van" + i;
                temp.Birthday = new DateTime(2000, 1, 1);
                temp.Address = "Dia chi" + i;

                listStudent.Add(temp);

            }
            return listStudent;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> listStudent = GetTempListStudents();
            ReportDataSource rds = new ReportDataSource("DataSetStudent", listStudent);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
