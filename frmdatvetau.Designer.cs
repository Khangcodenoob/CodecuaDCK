namespace DetaiQUANLYVEXELUA
{
    partial class frmdatvetau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdatvetau));
            this.dgvDatve = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpbVe = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.bttTimkiem = new System.Windows.Forms.Button();
            this.bttSapxep = new System.Windows.Forms.Button();
            this.bttLuu = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMatau = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtLoaive = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgaygio = new System.Windows.Forms.DateTimePicker();
            this.cbonoiden = new System.Windows.Forms.ComboBox();
            this.cboNoidi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatve)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gpbVe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatve
            // 
            this.dgvDatve.AllowUserToAddRows = false;
            this.dgvDatve.AllowUserToDeleteRows = false;
            this.dgvDatve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatve.Location = new System.Drawing.Point(2, 357);
            this.dgvDatve.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatve.Name = "dgvDatve";
            this.dgvDatve.ReadOnly = true;
            this.dgvDatve.RowHeadersWidth = 51;
            this.dgvDatve.RowTemplate.Height = 24;
            this.dgvDatve.Size = new System.Drawing.Size(1200, 394);
            this.dgvDatve.TabIndex = 10;
            this.dgvDatve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatve_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gpbVe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDatve, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 398F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1204, 753);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // gpbVe
            // 
            this.gpbVe.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbVe.BackgroundImage = global::DetaiQUANLYVEXELUA.Properties.Resources._1000_1;
            this.gpbVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbVe.Controls.Add(this.txtTimkiem);
            this.gpbVe.Controls.Add(this.bttTimkiem);
            this.gpbVe.Controls.Add(this.bttSapxep);
            this.gpbVe.Controls.Add(this.bttLuu);
            this.gpbVe.Controls.Add(this.bttSua);
            this.gpbVe.Controls.Add(this.bttXoa);
            this.gpbVe.Controls.Add(this.button1);
            this.gpbVe.Controls.Add(this.txtMatau);
            this.gpbVe.Controls.Add(this.label12);
            this.gpbVe.Controls.Add(this.label11);
            this.gpbVe.Controls.Add(this.txtGia);
            this.gpbVe.Controls.Add(this.txtLoaive);
            this.gpbVe.Controls.Add(this.label10);
            this.gpbVe.Controls.Add(this.label9);
            this.gpbVe.Controls.Add(this.txtMaKH);
            this.gpbVe.Controls.Add(this.txtMave);
            this.gpbVe.Controls.Add(this.label8);
            this.gpbVe.Controls.Add(this.dtpNgaygio);
            this.gpbVe.Controls.Add(this.cbonoiden);
            this.gpbVe.Controls.Add(this.cboNoidi);
            this.gpbVe.Controls.Add(this.label7);
            this.gpbVe.Controls.Add(this.label6);
            this.gpbVe.Controls.Add(this.label5);
            this.gpbVe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpbVe.Location = new System.Drawing.Point(2, 2);
            this.gpbVe.Margin = new System.Windows.Forms.Padding(2);
            this.gpbVe.Name = "gpbVe";
            this.gpbVe.Padding = new System.Windows.Forms.Padding(2);
            this.gpbVe.Size = new System.Drawing.Size(1200, 351);
            this.gpbVe.TabIndex = 9;
            this.gpbVe.TabStop = false;
            this.gpbVe.Text = "Vé ";
            this.gpbVe.Enter += new System.EventHandler(this.gpbVe_Enter);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(385, 124);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(166, 23);
            this.txtTimkiem.TabIndex = 23;
            this.txtTimkiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // bttTimkiem
            // 
            this.bttTimkiem.Location = new System.Drawing.Point(282, 124);
            this.bttTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.bttTimkiem.Name = "bttTimkiem";
            this.bttTimkiem.Size = new System.Drawing.Size(99, 22);
            this.bttTimkiem.TabIndex = 22;
            this.bttTimkiem.Text = "Tìm kiếm";
            this.bttTimkiem.UseVisualStyleBackColor = true;
            this.bttTimkiem.Click += new System.EventHandler(this.bttTimkiem_Click);
            // 
            // bttSapxep
            // 
            this.bttSapxep.BackColor = System.Drawing.Color.Yellow;
            this.bttSapxep.Location = new System.Drawing.Point(151, 300);
            this.bttSapxep.Margin = new System.Windows.Forms.Padding(2);
            this.bttSapxep.Name = "bttSapxep";
            this.bttSapxep.Size = new System.Drawing.Size(105, 40);
            this.bttSapxep.TabIndex = 21;
            this.bttSapxep.Text = "Sắp xếp";
            this.bttSapxep.UseVisualStyleBackColor = false;
            this.bttSapxep.Click += new System.EventHandler(this.bttSapxep_Click);
            // 
            // bttLuu
            // 
            this.bttLuu.BackColor = System.Drawing.Color.Yellow;
            this.bttLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLuu.ForeColor = System.Drawing.Color.Black;
            this.bttLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttLuu.Location = new System.Drawing.Point(94, 251);
            this.bttLuu.Margin = new System.Windows.Forms.Padding(2);
            this.bttLuu.Name = "bttLuu";
            this.bttLuu.Size = new System.Drawing.Size(105, 45);
            this.bttLuu.TabIndex = 20;
            this.bttLuu.Text = "Lưu";
            this.bttLuu.UseVisualStyleBackColor = false;
            this.bttLuu.Click += new System.EventHandler(this.bttLuu_Click);
            // 
            // bttSua
            // 
            this.bttSua.BackColor = System.Drawing.Color.Yellow;
            this.bttSua.Location = new System.Drawing.Point(203, 251);
            this.bttSua.Margin = new System.Windows.Forms.Padding(2);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(105, 45);
            this.bttSua.TabIndex = 19;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = false;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.BackColor = System.Drawing.Color.Yellow;
            this.bttXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttXoa.ForeColor = System.Drawing.Color.Black;
            this.bttXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttXoa.Location = new System.Drawing.Point(203, 199);
            this.bttXoa.Margin = new System.Windows.Forms.Padding(2);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(105, 48);
            this.bttXoa.TabIndex = 18;
            this.bttXoa.Text = "Xoá";
            this.bttXoa.UseVisualStyleBackColor = false;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(94, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMatau
            // 
            this.txtMatau.Location = new System.Drawing.Point(94, 158);
            this.txtMatau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatau.Name = "txtMatau";
            this.txtMatau.Size = new System.Drawing.Size(162, 20);
            this.txtMatau.TabIndex = 16;
            this.txtMatau.Text = "SEBN";
            this.txtMatau.TextChanged += new System.EventHandler(this.txtMatau_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Mã tàu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Giá";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(94, 121);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(162, 20);
            this.txtGia.TabIndex = 13;
            this.txtGia.Text = "5.000.000";
            // 
            // txtLoaive
            // 
            this.txtLoaive.Location = new System.Drawing.Point(94, 84);
            this.txtLoaive.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoaive.Name = "txtLoaive";
            this.txtLoaive.Size = new System.Drawing.Size(162, 20);
            this.txtLoaive.TabIndex = 12;
            this.txtLoaive.Text = "Hạng Thương Gia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Loại vé";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(94, 50);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(162, 20);
            this.txtMaKH.TabIndex = 9;
            this.txtMaKH.Text = "1822040036";
            // 
            // txtMave
            // 
            this.txtMave.Location = new System.Drawing.Point(94, 19);
            this.txtMave.Margin = new System.Windows.Forms.Padding(2);
            this.txtMave.Name = "txtMave";
            this.txtMave.Size = new System.Drawing.Size(162, 20);
            this.txtMave.TabIndex = 8;
            this.txtMave.Text = "A01";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mã Vé";
            // 
            // dtpNgaygio
            // 
            this.dtpNgaygio.Location = new System.Drawing.Point(333, 86);
            this.dtpNgaygio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaygio.Name = "dtpNgaygio";
            this.dtpNgaygio.Size = new System.Drawing.Size(146, 20);
            this.dtpNgaygio.TabIndex = 5;
            // 
            // cbonoiden
            // 
            this.cbonoiden.FormattingEnabled = true;
            this.cbonoiden.Items.AddRange(new object[] {
            "Ga Hà Nội",
            "Ga Giáp Bát",
            "Ga Gia Lâm",
            "Ga Long Biên",
            "Ga Mỹ Đình",
            "Ga Yên Viên",
            "Ga Bắc Giang",
            "Ga Bắc Kạn",
            "Ga Cao Bằng",
            "Ga Hà Giang",
            "Ga Hải Dương",
            "Ga Hòa Bình",
            "Ga Hưng Yên",
            "Ga Lạng Sơn",
            "Ga Lào Cai",
            "Ga Nam Định",
            "Ga Ninh Bình",
            "Ga Phú Thọ",
            "Ga Hạ Long",
            "Ga Cẩm Phả",
            "Ga Uông Bí",
            "Ga Cửa Ông",
            "Ga Đông Triều",
            "Ga Thái Nguyên",
            "Ga Tuyên Quang",
            "Ga Vĩnh Yên",
            "Ga Đà Nẵng",
            "Ga Quy Nhơn",
            "Ga Đồng Hới",
            "Ga Tam Kỳ",
            "Ga Đà Nẵng",
            "Ga Quảng Ngãi",
            "Ga Huế",
            "Ga Đông Hà",
            "Ga Sài Gòn",
            "Ga Bình Triệu",
            "Ga Sài Gòn Chợ Lớn",
            "Ga Sài Gòn Thành Công",
            "Ga Sài Gòn Trạm Chùa",
            "Ga Sài Gòn Xa Lộ",
            "Ga Châu Đốc",
            "Ga Vũng Tàu",
            "Ga Bình Dương",
            "Ga Bình Phước",
            "Ga Biên Hòa",
            "Ga Long Thành",
            "Ga Cao Lãnh",
            "Ga Sa Đéc",
            "Ga Pleiku",
            "Ga Kon Tum",
            "Ga Đà Lạt",
            "Ga Tân An",
            "Ga Phan Rang",
            "Ga Tuy Hòa",
            "Ga Sóc Trăng",
            "Ga Tây Ninh",
            "Ga Mỹ Tho",
            "Ga Trà Vinh",
            "Ga Vĩnh Long"});
            this.cbonoiden.Location = new System.Drawing.Point(333, 52);
            this.cbonoiden.Margin = new System.Windows.Forms.Padding(2);
            this.cbonoiden.Name = "cbonoiden";
            this.cbonoiden.Size = new System.Drawing.Size(242, 21);
            this.cbonoiden.TabIndex = 4;
            this.cbonoiden.SelectedIndexChanged += new System.EventHandler(this.cbonoiden_SelectedIndexChanged);
            // 
            // cboNoidi
            // 
            this.cboNoidi.FormattingEnabled = true;
            this.cboNoidi.Items.AddRange(new object[] {
            "Ga Hà Nội",
            "Ga Giáp Bát",
            "Ga Gia Lâm",
            "Ga Long Biên",
            "Ga Mỹ Đình",
            "Ga Yên Viên",
            "Ga Bắc Giang",
            "Ga Bắc Kạn",
            "Ga Cao Bằng",
            "Ga Hà Giang",
            "Ga Hải Dương",
            "Ga Hòa Bình",
            "Ga Hưng Yên",
            "Ga Lạng Sơn",
            "Ga Lào Cai",
            "Ga Nam Định",
            "Ga Ninh Bình",
            "Ga Phú Thọ",
            "Ga Hạ Long",
            "Ga Cẩm Phả",
            "Ga Uông Bí",
            "Ga Cửa Ông",
            "Ga Đông Triều",
            "Ga Thái Nguyên",
            "Ga Tuyên Quang",
            "Ga Vĩnh Yên",
            "Ga Đà Nẵng",
            "Ga Quy Nhơn",
            "Ga Đồng Hới",
            "Ga Tam Kỳ",
            "Ga Đà Nẵng",
            "Ga Quảng Ngãi",
            "Ga Huế",
            "Ga Đông Hà",
            "Ga Sài Gòn",
            "Ga Bình Triệu",
            "Ga Sài Gòn Chợ Lớn",
            "Ga Sài Gòn Thành Công",
            "Ga Sài Gòn Trạm Chùa",
            "Ga Sài Gòn Xa Lộ",
            "Ga Châu Đốc",
            "Ga Vũng Tàu",
            "Ga Bình Dương",
            "Ga Bình Phước",
            "Ga Biên Hòa",
            "Ga Long Thành",
            "Ga Cao Lãnh",
            "Ga Sa Đéc",
            "Ga Pleiku",
            "Ga Kon Tum",
            "Ga Đà Lạt",
            "Ga Tân An",
            "Ga Phan Rang",
            "Ga Tuy Hòa",
            "Ga Sóc Trăng",
            "Ga Tây Ninh",
            "Ga Mỹ Tho",
            "Ga Trà Vinh",
            "Ga Vĩnh Long"});
            this.cboNoidi.Location = new System.Drawing.Point(333, 17);
            this.cboNoidi.Margin = new System.Windows.Forms.Padding(2);
            this.cboNoidi.Name = "cboNoidi";
            this.cboNoidi.Size = new System.Drawing.Size(242, 21);
            this.cboNoidi.TabIndex = 3;
            this.cboNoidi.SelectedIndexChanged += new System.EventHandler(this.cboNoidi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày Giờ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nơi Đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nơi đi";
            // 
            // frmdatvetau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmdatvetau";
            this.Text = "Đặt vé tàu ";
            this.Load += new System.EventHandler(this.Datvetau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatve)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gpbVe.ResumeLayout(false);
            this.gpbVe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbVe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaygio;
        private System.Windows.Forms.ComboBox cbonoiden;
        private System.Windows.Forms.ComboBox cboNoidi;
        private System.Windows.Forms.TextBox txtMave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtLoaive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMatau;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDatve;
        private System.Windows.Forms.Button bttLuu;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button bttTimkiem;
        private System.Windows.Forms.Button bttSapxep;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}