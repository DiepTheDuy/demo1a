using Lab05_Report.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Report.Subforms
{
    public partial class frmOrder : Form
    {
        ProductContextDB context = new ProductContextDB();
        public frmOrder()
        {
            InitializeComponent();
        }

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Compare(dtpOrderDate.Value, dtpDeliveryDate.Value) > 0)
                {
                    dtpOrderDate.Value = dtpDeliveryDate.Value;
                    throw new Exception("Ngày đặt hàng không được lớn hơn ngày giao hàng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Compare(dtpOrderDate.Value, dtpDeliveryDate.Value) > 0)
                {
                    dtpDeliveryDate.Value = dtpOrderDate.Value;
                    throw new Exception("Ngày đặt hàng không được lớn hơn ngày giao hàng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    int row = e.RowIndex;

                if (e.ColumnIndex == 1 && dgvListProduct.Rows.Count -1 != 0)
                {
                    string proid = dgvListProduct.Rows[row].Cells[1].Value.ToString();
                    Product find = context.Products.FirstOrDefault(p=>p.ProductID == proid);

                    dgvListProduct.Rows[row].Cells[2].Value = find.ProductName;
                    dgvListProduct.Rows[row].Cells[3].Value = find.Unit;
                    dgvListProduct.Rows[row].Cells[5].Value = find.SellPrice;
                }
                if (e.ColumnIndex == 4 && dgvListProduct.Rows.Count - 1 != 0)
                {
                    double sl = Convert.ToDouble(dgvListProduct.Rows[row].Cells[4].Value);
                    double sell = Convert.ToDouble(dgvListProduct.Rows[row].Cells[5].Value);
                    dgvListProduct.Rows[row].Cells[6].Value = sl * sell;
                }

                int totalMoney = 0;
                for (int i = 0; i < dgvListProduct.Rows.Count - 1; i++)
                {
                    totalMoney += Convert.ToInt32(dgvListProduct.Rows[i].Cells[6].Value);
                }
                txtTotalMoney.Text = totalMoney.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int index = e.RowIndex;
            dgvListProduct.Rows[index].Cells[0].Value = index + 1;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            dgvListProduct.Rows[0].Cells[0].Value = 1;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderID.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã HĐ");
                }
                if (dgvListProduct.Rows.Count - 1 == 0)
                {
                    throw new Exception("Phải có ít nhất 1 SP trong danh sách");
                }

                string hd = txtOrderID.Text;
                string note = txtNote.Text;
                int no = context.Orders.ToList().Count;
                Invoice i = new Invoice() { InvoiceNo = hd, OrderDate = dtpOrderDate.Value, DeliveryDate = dtpDeliveryDate.Value, Note = txtNote.Text };
                context.Invoices.Add(i);

                List<Order> lorder = new List<Order>();
                for (int j = 0; j < dgvListProduct.Rows.Count - 1; j++)
                {
                    string pid = dgvListProduct.Rows[j].Cells[1].Value.ToString();
                    string pname = dgvListProduct.Rows[j].Cells[2].Value.ToString();
                    string dvt = dgvListProduct.Rows[j].Cells[3].Value.ToString();
                    int sl = Convert.ToInt32(dgvListProduct.Rows[j].Cells[4].Value);
                    decimal total = Convert.ToDecimal(dgvListProduct.Rows[j].Cells[6].Value);

                    Order o = new Order() { ProductID = pid, ProductName = pname, Unit = dvt, Quantity = sl, Price = total, InvoiceNo = hd, No = no + j + 1};
                    context.Orders.Add(o);
                }
                
                context.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
