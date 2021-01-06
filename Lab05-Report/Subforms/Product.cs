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
            dgvThongTinSP.DataSource = list;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadGrid();

            List<Product> listpr = context.Products.ToList();
            cbDVT.DataSource = listpr;
            cbDVT.ValueMember = "";
            cbDVT.DisplayMember = "";
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
    }
}
