namespace PhanMem_QuanLyKhachSan
{
    partial class Phong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTinh = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.Label();
            this.cbMaDV = new System.Windows.Forms.ComboBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimMaPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(2, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 270);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Phòng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Phòng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Loại Phòng";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tình Trạng";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "MaDV";
            this.Column6.Name = "Column6";
            this.Column6.Width = 120;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.txtTinh);
            this.panel2.Controls.Add(this.txtTinhTrang);
            this.panel2.Controls.Add(this.cbMaDV);
            this.panel2.Controls.Add(this.txtLoaiPhong);
            this.panel2.Controls.Add(this.txtTenPhong);
            this.panel2.Controls.Add(this.txtMaPhong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 169);
            this.panel2.TabIndex = 1;
            // 
            // txtTinh
            // 
            this.txtTinh.Location = new System.Drawing.Point(111, 137);
            this.txtTinh.Name = "txtTinh";
            this.txtTinh.Size = new System.Drawing.Size(157, 20);
            this.txtTinh.TabIndex = 4;
            this.txtTinh.TextChanged += new System.EventHandler(this.txtTimTenPhong_TextChanged);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.AutoSize = true;
            this.txtTinhTrang.Location = new System.Drawing.Point(28, 140);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(62, 13);
            this.txtTinhTrang.TabIndex = 12;
            this.txtTinhTrang.Text = "Tình Trạng:";
            // 
            // cbMaDV
            // 
            this.cbMaDV.FormattingEnabled = true;
            this.cbMaDV.Location = new System.Drawing.Point(290, 58);
            this.cbMaDV.Name = "cbMaDV";
            this.cbMaDV.Size = new System.Drawing.Size(120, 21);
            this.cbMaDV.TabIndex = 11;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(111, 99);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(157, 20);
            this.txtLoaiPhong.TabIndex = 10;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(111, 62);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(157, 20);
            this.txtTenPhong.TabIndex = 9;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(111, 18);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(157, 20);
            this.txtMaPhong.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Dịch Vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Phong:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Phong:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoa.Location = new System.Drawing.Point(431, 122);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSua.Location = new System.Drawing.Point(431, 69);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 32);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(431, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtTimMaPhong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(556, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txtTimMaPhong
            // 
            this.txtTimMaPhong.Location = new System.Drawing.Point(82, 76);
            this.txtTimMaPhong.Name = "txtTimMaPhong";
            this.txtTimMaPhong.Size = new System.Drawing.Size(138, 20);
            this.txtTimMaPhong.TabIndex = 3;
            this.txtTimMaPhong.TextChanged += new System.EventHandler(this.txtTimMaPhong_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Phòng:";
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phong";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbMaDV;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTinh;
        private System.Windows.Forms.TextBox txtTimMaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}