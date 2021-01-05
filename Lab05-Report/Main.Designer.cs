namespace Lab05_Report
{
    partial class frmQLDH
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msInputProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msQLSP = new System.Windows.Forms.ToolStripMenuItem();
            this.msReport = new System.Windows.Forms.ToolStripMenuItem();
            this.cbShowAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đơnHàngToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msInputProduct,
            this.msExit});
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đơnHàngToolStripMenuItem.Text = "Đơn Hàng";
            // 
            // msInputProduct
            // 
            this.msInputProduct.Name = "msInputProduct";
            this.msInputProduct.Size = new System.Drawing.Size(180, 22);
            this.msInputProduct.Text = "Nhập Đơn Hàng";
            this.msInputProduct.Click += new System.EventHandler(this.msInputProduct_Click);
            // 
            // msExit
            // 
            this.msExit.Name = "msExit";
            this.msExit.Size = new System.Drawing.Size(180, 22);
            this.msExit.Text = "Thoát";
            this.msExit.Click += new System.EventHandler(this.msExit_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msQLSP,
            this.msReport});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // msQLSP
            // 
            this.msQLSP.Name = "msQLSP";
            this.msQLSP.Size = new System.Drawing.Size(197, 22);
            this.msQLSP.Text = "Quản Lý Sản Phẩm";
            this.msQLSP.Click += new System.EventHandler(this.msQLSP_Click);
            // 
            // msReport
            // 
            this.msReport.Name = "msReport";
            this.msReport.Size = new System.Drawing.Size(197, 22);
            this.msReport.Text = "Xuất Báo Giá Sản Phẩm";
            this.msReport.Click += new System.EventHandler(this.msReport_Click);
            // 
            // cbShowAll
            // 
            this.cbShowAll.AutoSize = true;
            this.cbShowAll.Location = new System.Drawing.Point(52, 24);
            this.cbShowAll.Name = "cbShowAll";
            this.cbShowAll.Size = new System.Drawing.Size(134, 17);
            this.cbShowAll.TabIndex = 1;
            this.cbShowAll.Text = "Xem tất cả trong tháng";
            this.cbShowAll.UseVisualStyleBackColor = true;
            this.cbShowAll.CheckedChanged += new System.EventHandler(this.cbShowAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(165, 51);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(99, 20);
            this.dtpStart.TabIndex = 3;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(311, 51);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(97, 20);
            this.dtpEnd.TabIndex = 4;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F);
            this.label2.Location = new System.Drawing.Point(279, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "~";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbShowAll);
            this.groupBox1.Location = new System.Drawing.Point(32, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 102);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.OrderDate,
            this.DeliveryDate,
            this.Total});
            this.dgvList.Location = new System.Drawing.Point(32, 140);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(716, 215);
            this.dgvList.TabIndex = 7;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // ID
            // 
            this.ID.HeaderText = "Số HĐ";
            this.ID.Name = "ID";
            this.ID.Width = 120;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Ngày đặt hàng";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 135;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "Ngày giao hàng";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Width = 135;
            // 
            // Total
            // 
            this.Total.HeaderText = "Thành tiền";
            this.Total.Name = "Total";
            this.Total.Width = 200;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(32, 361);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "In/Xem";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm đơn hàng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng cộng";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(636, 364);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(112, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmQLDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 391);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQLDH";
            this.Text = "Quản Lý Đơn Hàng";
            this.Load += new System.EventHandler(this.frmQLDH_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msInputProduct;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msQLSP;
        private System.Windows.Forms.ToolStripMenuItem msReport;
        private System.Windows.Forms.CheckBox cbShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

