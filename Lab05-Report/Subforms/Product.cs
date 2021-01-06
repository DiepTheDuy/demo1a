using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05_Report.Models;

namespace Lab05_Report.Subforms
{
    public partial class frmProduct : Form
    {
        List<Product> list;
        ProductContextDB context = new ProductContextDB();
        public frmProduct()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            list = context.Products.ToList();

            dgvThongTinSP.Rows.Clear();
            foreach (var o in list)
            {
                    int index = dgvThongTinSP.Rows.Add();
                    dgvThongTinSP.Rows[index].Cells[0].Value = index + 1;
                    dgvThongTinSP.Rows[index].Cells[1].Value = o.ProductID;
                    dgvThongTinSP.Rows[index].Cells[2].Value = o.ProductName;
                    dgvThongTinSP.Rows[index].Cells[3].Value = o.Unit;
                    dgvThongTinSP.Rows[index].Cells[4].Value = o.BuyPrice;
                    dgvThongTinSP.Rows[index].Cells[5].Value = o.SellPrice;
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadGrid();

            List<Product> listpr = context.Products.ToList();
            cbDVT.SelectedIndex = 1;
        }
        private void ResetValue()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtGiaMua.Text = "";
        }

        private void dgvThongTinSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvThongTinSP.Rows[e.RowIndex];
                txtMaSP.Text = dgvRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvRow.Cells[1].Value.ToString();                
                cbDVT.SelectedValue = dgvRow.Cells[2].Value;
                txtGiaBan.Text = dgvRow.Cells[3].Value.ToString();
                txtGiaMua.Text = dgvRow.Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = context.Products.FirstOrDefault(l => l.ProductID == txtMaSP.Text);
                if (p == null)
                {
                    if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtGiaMua.Text == "" || txtGiaBan.Text == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    }
                    var buy = Convert.ToDecimal(txtGiaMua.Text);
                    decimal sell = Convert.ToDecimal(txtGiaBan.Text);
                    Product newp = new Product() { ProductID = txtMaSP.Text, ProductName = txtTenSP.Text, Unit = cbDVT.Text.ToString(),  BuyPrice = buy, SellPrice = sell};
                    context.Products.Add(newp);
                    context.SaveChanges();
                    LoadGrid();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValue();
                }
                else
                {
                    if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtGiaMua.Text == "" || txtGiaBan.Text == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    }
                    p.ProductID = txtMaSP.Text;
                    p.ProductName = txtTenSP.Text;
                    p.Unit = cbDVT.SelectedValue.ToString();
                    p.BuyPrice = Convert.ToDecimal(txtGiaBan.Text);
                    p.SellPrice = Convert.ToDecimal(txtGiaMua.Text);
                    context.SaveChanges();
                    LoadGrid();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValue();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã SP cần xóa");
                }
                Product pDel = context.Products.FirstOrDefault(p => p.ProductID == txtMaSP.Text);
                if (pDel != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        context.Products.Remove(pDel);
                        context.SaveChanges();
                        LoadGrid();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetValue();
                    }
                }
                else
                {
                    throw new Exception("Không tìm thấy SP có mã này để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
