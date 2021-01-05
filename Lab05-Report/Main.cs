using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05_Report.Subforms;

namespace Lab05_Report
{
    public partial class frmQLDH : Form
    {
        public frmQLDH()
        {
            InitializeComponent();
        }

        private void msInputProduct_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.Show();
        }

        private void msQLSP_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            product.Show();
        }

        private void msReport_Click(object sender, EventArgs e)
        {
            frmReportProduct reportProduct = new frmReportProduct();
            reportProduct.Show();
        }
    }
}
