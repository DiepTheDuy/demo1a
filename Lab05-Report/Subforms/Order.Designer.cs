
namespace Lab05_Report.Subforms
{
    partial class frmOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theo HĐ số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày giao hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(305, 56);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(129, 20);
            this.txtOrderID.TabIndex = 5;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(305, 90);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(98, 20);
            this.dtpOrderDate.TabIndex = 6;
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(537, 90);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(98, 20);
            this.dtpDeliveryDate.TabIndex = 7;
            this.dtpDeliveryDate.ValueChanged += new System.EventHandler(this.dtpDeliveryDate_ValueChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(305, 127);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(264, 50);
            this.txtNote.TabIndex = 8;
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvListProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvListProduct.Location = new System.Drawing.Point(12, 192);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListProduct.Size = new System.Drawing.Size(776, 222);
            this.dgvListProduct.TabIndex = 9;
            this.dgvListProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProduct_CellValueChanged);
            this.dgvListProduct.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvListProduct_RowsAdded);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(13, 418);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(94, 418);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng cộng";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Location = new System.Drawing.Point(678, 420);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.Size = new System.Drawing.Size(110, 20);
            this.txtTotalMoney.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã SP";
            this.Column2.Name = "Column2";
            this.Column2.Width = 85;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên SP";
            this.Column3.Name = "Column3";
            this.Column3.Width = 195;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ĐVT";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng";
            this.Column5.Name = "Column5";
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Giá bán";
            this.Column6.Name = "Column6";
            this.Column6.Width = 75;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvListProduct);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOrder";
            this.Text = "Quản Lý Đơn Hàng";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}