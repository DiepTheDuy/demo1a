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
using Lab05_Report.Models;

namespace Lab05_Report
{
    public partial class frmQLDH : Form
    {
        ProductContextDB context = new ProductContextDB();
        List<Order> list = new List<Order>();
        public frmQLDH()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            list = context.Orders.ToList();
            decimal total = 0;

            dgvList.Rows.Clear();
            foreach (Order o in list)
            {
                DateTime idate = o.Invoice.DeliveryDate.Date;
                if (DateTime.Compare(dtpStart.Value.Date, idate) <= 0 && DateTime.Compare(dtpEnd.Value.Date, idate) >= 0)
                {
                    int index = dgvList.Rows.Add();
                    dgvList.Rows[index].Cells[0].Value = index + 1;
                    dgvList.Rows[index].Cells[1].Value = o.InvoiceNo;
                    dgvList.Rows[index].Cells[2].Value = o.Invoice.OrderDate;
                    dgvList.Rows[index].Cells[3].Value = o.Invoice.DeliveryDate;
                    dgvList.Rows[index].Cells[4].Value = o.Price;

                    total += o.Price;
                }
            }
            txtTotal.Text = total.ToString();
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

        private void msExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowAll.Checked == true)
            {
                //list = context.Invoices.ToList();
                //foreach (Invoice i in list)
                //{

                //}

                //============TRƯỜNG HỢP DÙNG THÁNG HIỆN TẠI CỦA HỆ THỐNG====================
                int month = DateTime.Now.Month;
                int year = DateTime.Now.Year;

                //============TRƯỜNG HỢP DÙNG THÁNG TRONG DATE TIME PICKER====================
                //int month = dtpStart.Value.Month;
                //int year = dtpStart.Value.Year;


                DateTime dt = Convert.ToDateTime(year + "/" + month + "/1");
                dtpStart.Value = dt;

                int lastday = DateTime.DaysInMonth(year, month);
                dt = Convert.ToDateTime(year + "/" + month + "/" + lastday);
                dtpEnd.Value = dt;

                dtpStart.Enabled = false;
                dtpEnd.Enabled = false;
            }
            else
            {
                dtpStart.Enabled = true;
                dtpEnd.Enabled = true;
                dtpStart.Value = dtpEnd.Value = DateTime.Now;
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Compare(dtpStart.Value, dtpEnd.Value) > 0)
                {
                    dtpStart.Value = dtpEnd.Value;
                    throw new Exception("Ngày đặt hàng không được lớn hơn ngày giao hàng");
                }
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Compare(dtpStart.Value, dtpEnd.Value) > 0)
                {
                    dtpEnd.Value = dtpStart.Value;
                    throw new Exception("Ngày đặt hàng không được lớn hơn ngày giao hàng");
                }
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQLDH_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrder o = new frmOrder();
            o.Show();
        }
    }
}
