﻿namespace _03022024.QLSanPham
{
    partial class ucSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblTenDanhMuc;
            System.Windows.Forms.Label lblTenSanPham;
            System.Windows.Forms.Label lblMaSanPham;
            System.Windows.Forms.Label lblDonGia;
            System.Windows.Forms.Label lblDonViTinh;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgSanPham = new System.Windows.Forms.DataGridView();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblTenDanhMuc = new System.Windows.Forms.Label();
            lblTenSanPham = new System.Windows.Forms.Label();
            lblMaSanPham = new System.Windows.Forms.Label();
            lblDonGia = new System.Windows.Forms.Label();
            lblDonViTinh = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenDanhMuc
            // 
            lblTenDanhMuc.AutoSize = true;
            lblTenDanhMuc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblTenDanhMuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblTenDanhMuc.Location = new System.Drawing.Point(9, 196);
            lblTenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTenDanhMuc.Name = "lblTenDanhMuc";
            lblTenDanhMuc.Size = new System.Drawing.Size(153, 24);
            lblTenDanhMuc.TabIndex = 15;
            lblTenDanhMuc.Text = "Tên danh mục";
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.AutoSize = true;
            lblTenSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblTenSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblTenSanPham.Location = new System.Drawing.Point(9, 151);
            lblTenSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new System.Drawing.Size(151, 24);
            lblTenSanPham.TabIndex = 10;
            lblTenSanPham.Text = "Tên sản phẩm";
            // 
            // lblMaSanPham
            // 
            lblMaSanPham.AutoSize = true;
            lblMaSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblMaSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblMaSanPham.Location = new System.Drawing.Point(9, 106);
            lblMaSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMaSanPham.Name = "lblMaSanPham";
            lblMaSanPham.Size = new System.Drawing.Size(144, 24);
            lblMaSanPham.TabIndex = 14;
            lblMaSanPham.Text = "Mã sản phẩm";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblDonGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblDonGia.Location = new System.Drawing.Point(560, 151);
            lblDonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new System.Drawing.Size(87, 24);
            lblDonGia.TabIndex = 16;
            lblDonGia.Text = "Đơn giá";
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblDonViTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblDonViTinh.Location = new System.Drawing.Point(560, 106);
            lblDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new System.Drawing.Size(120, 24);
            lblDonViTinh.TabIndex = 19;
            lblDonViTinh.Text = "Đơn vị tính";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(999, 1015);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.txtDonViTinh);
            this.panel1.Controls.Add(lblDonGia);
            this.panel1.Controls.Add(lblDonViTinh);
            this.panel1.Controls.Add(this.txtTenDanhMuc);
            this.panel1.Controls.Add(this.txtTenSanPham);
            this.panel1.Controls.Add(this.txtMaSanPham);
            this.panel1.Controls.Add(lblTenDanhMuc);
            this.panel1.Controls.Add(lblTenSanPham);
            this.panel1.Controls.Add(lblMaSanPham);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.ForeColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 238);
            this.panel1.TabIndex = 0;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonGia.Location = new System.Drawing.Point(722, 151);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(245, 32);
            this.txtDonGia.TabIndex = 18;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonViTinh.Location = new System.Drawing.Point(722, 106);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(245, 32);
            this.txtDonViTinh.TabIndex = 17;
            this.txtDonViTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonViTinh_KeyPress);
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(198, 196);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(324, 32);
            this.txtTenDanhMuc.TabIndex = 13;
            this.txtTenDanhMuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDanhMuc_KeyPress);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSanPham.Location = new System.Drawing.Point(198, 151);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(324, 32);
            this.txtTenSanPham.TabIndex = 12;
            this.txtTenSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSanPham_KeyPress);
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSanPham.Location = new System.Drawing.Point(198, 106);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(324, 32);
            this.txtMaSanPham.TabIndex = 11;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Location = new System.Drawing.Point(188, 18);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(566, 57);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "THÔNG TIN SẢN PHẨM";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(4, 250);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 54);
            this.panel2.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(241, 7);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 37);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(123, 7);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 37);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(5, 7);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 37);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.dgSanPham);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 312);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 699);
            this.panel3.TabIndex = 2;
            // 
            // dgSanPham
            // 
            this.dgSanPham.AllowUserToAddRows = false;
            this.dgSanPham.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl1,
            this.cl2,
            this.cl3,
            this.cl4,
            this.cl5});
            this.dgSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgSanPham.Name = "dgSanPham";
            this.dgSanPham.ReadOnly = true;
            this.dgSanPham.RowHeadersVisible = false;
            this.dgSanPham.RowHeadersWidth = 51;
            this.dgSanPham.RowTemplate.Height = 24;
            this.dgSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSanPham.Size = new System.Drawing.Size(991, 699);
            this.dgSanPham.TabIndex = 0;
            this.dgSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSanPham_CellClick);
            this.dgSanPham.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgSanPham_CellFormatting);
            // 
            // cl1
            // 
            this.cl1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl1.DataPropertyName = "MaSanPham";
            this.cl1.HeaderText = "Mã sản phẩm";
            this.cl1.MinimumWidth = 6;
            this.cl1.Name = "cl1";
            this.cl1.ReadOnly = true;
            this.cl1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cl2
            // 
            this.cl2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl2.DataPropertyName = "TenSanPham";
            this.cl2.HeaderText = "Tên sản phẩm";
            this.cl2.MinimumWidth = 6;
            this.cl2.Name = "cl2";
            this.cl2.ReadOnly = true;
            this.cl2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cl3
            // 
            this.cl3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl3.DataPropertyName = "TenDVT";
            this.cl3.HeaderText = "Đơn vị tính";
            this.cl3.MinimumWidth = 6;
            this.cl3.Name = "cl3";
            this.cl3.ReadOnly = true;
            this.cl3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cl4
            // 
            this.cl4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl4.DataPropertyName = "TenDanhMuc";
            this.cl4.HeaderText = "Tên danh mục";
            this.cl4.MinimumWidth = 6;
            this.cl4.Name = "cl4";
            this.cl4.ReadOnly = true;
            this.cl4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cl5
            // 
            this.cl5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl5.DataPropertyName = "DonGia";
            this.cl5.HeaderText = "Đơn giá";
            this.cl5.MinimumWidth = 6;
            this.cl5.Name = "cl5";
            this.cl5.ReadOnly = true;
            this.cl5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucSanPham";
            this.Size = new System.Drawing.Size(999, 1015);
            this.Load += new System.EventHandler(this.ucSanPham_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgSanPham;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl5;
    }
}