namespace DetaiQUANLYVEXELUA
{
    partial class frmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView));
            this.bttchuyenbay = new System.Windows.Forms.Button();
            this.cbonoi_den1 = new System.Windows.Forms.ComboBox();
            this.lblnoiden1 = new System.Windows.Forms.Label();
            this.cbonoixuat_phat1 = new System.Windows.Forms.ComboBox();
            this.lblnoi_khoi_hanh1 = new System.Windows.Forms.Label();
            this.lblloc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttdanhsach = new System.Windows.Forms.Button();
            this.dgvdulieu = new System.Windows.Forms.DataGridView();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdulieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttchuyenbay
            // 
            this.bttchuyenbay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttchuyenbay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttchuyenbay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttchuyenbay.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bttchuyenbay.Location = new System.Drawing.Point(697, 2);
            this.bttchuyenbay.Margin = new System.Windows.Forms.Padding(2);
            this.bttchuyenbay.Name = "bttchuyenbay";
            this.bttchuyenbay.Size = new System.Drawing.Size(691, 111);
            this.bttchuyenbay.TabIndex = 25;
            this.bttchuyenbay.Text = "Thông tin chuyến tàu ";
            this.bttchuyenbay.UseVisualStyleBackColor = true;
            this.bttchuyenbay.Click += new System.EventHandler(this.bttchuyenbay_Click);
            // 
            // cbonoi_den1
            // 
            this.cbonoi_den1.FormattingEnabled = true;
            this.cbonoi_den1.Items.AddRange(new object[] {
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
            this.cbonoi_den1.Location = new System.Drawing.Point(467, 62);
            this.cbonoi_den1.Margin = new System.Windows.Forms.Padding(2);
            this.cbonoi_den1.Name = "cbonoi_den1";
            this.cbonoi_den1.Size = new System.Drawing.Size(194, 21);
            this.cbonoi_den1.TabIndex = 24;
            this.cbonoi_den1.SelectedIndexChanged += new System.EventHandler(this.cbonoi_den1_SelectedIndexChanged);
            this.cbonoi_den1.SelectionChangeCommitted += new System.EventHandler(this.cbonoi_den1_SelectionChangeCommitted);
            // 
            // lblnoiden1
            // 
            this.lblnoiden1.AutoSize = true;
            this.lblnoiden1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblnoiden1.Location = new System.Drawing.Point(323, 62);
            this.lblnoiden1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnoiden1.Name = "lblnoiden1";
            this.lblnoiden1.Size = new System.Drawing.Size(64, 17);
            this.lblnoiden1.TabIndex = 23;
            this.lblnoiden1.Text = "Nơi đến";
            // 
            // cbonoixuat_phat1
            // 
            this.cbonoixuat_phat1.FormattingEnabled = true;
            this.cbonoixuat_phat1.Items.AddRange(new object[] {
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
            this.cbonoixuat_phat1.Location = new System.Drawing.Point(467, 27);
            this.cbonoixuat_phat1.Margin = new System.Windows.Forms.Padding(2);
            this.cbonoixuat_phat1.Name = "cbonoixuat_phat1";
            this.cbonoixuat_phat1.Size = new System.Drawing.Size(194, 21);
            this.cbonoixuat_phat1.TabIndex = 22;
            this.cbonoixuat_phat1.SelectedIndexChanged += new System.EventHandler(this.cbonoixuat_phat1_SelectedIndexChanged);
            this.cbonoixuat_phat1.SelectionChangeCommitted += new System.EventHandler(this.cbonoixuat_phat1_SelectionChangeCommitted);
            // 
            // lblnoi_khoi_hanh1
            // 
            this.lblnoi_khoi_hanh1.AutoSize = true;
            this.lblnoi_khoi_hanh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblnoi_khoi_hanh1.Location = new System.Drawing.Point(323, 30);
            this.lblnoi_khoi_hanh1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnoi_khoi_hanh1.Name = "lblnoi_khoi_hanh1";
            this.lblnoi_khoi_hanh1.Size = new System.Drawing.Size(108, 17);
            this.lblnoi_khoi_hanh1.TabIndex = 21;
            this.lblnoi_khoi_hanh1.Text = "Nơi khỏi hành";
            // 
            // lblloc
            // 
            this.lblloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblloc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblloc.Location = new System.Drawing.Point(170, 62);
            this.lblloc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblloc.Name = "lblloc";
            this.lblloc.Size = new System.Drawing.Size(136, 19);
            this.lblloc.TabIndex = 20;
            this.lblloc.Text = "Tìm Kiếm\r\n";
            this.lblloc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 27);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bttdanhsach
            // 
            this.bttdanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttdanhsach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttdanhsach.Location = new System.Drawing.Point(25, 20);
            this.bttdanhsach.Margin = new System.Windows.Forms.Padding(2);
            this.bttdanhsach.Name = "bttdanhsach";
            this.bttdanhsach.Size = new System.Drawing.Size(130, 58);
            this.bttdanhsach.TabIndex = 18;
            this.bttdanhsach.Text = "Danh Sách các khách hàng";
            this.bttdanhsach.UseVisualStyleBackColor = true;
            this.bttdanhsach.Click += new System.EventHandler(this.bttdanhsach_Click);
            // 
            // dgvdulieu
            // 
            this.dgvdulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdulieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdulieu.Location = new System.Drawing.Point(698, 118);
            this.dgvdulieu.Name = "dgvdulieu";
            this.dgvdulieu.RowHeadersWidth = 51;
            this.dgvdulieu.Size = new System.Drawing.Size(689, 731);
            this.dgvdulieu.TabIndex = 28;
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdanhsach.Location = new System.Drawing.Point(3, 118);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.RowHeadersWidth = 51;
            this.dgvdanhsach.Size = new System.Drawing.Size(689, 731);
            this.dgvdanhsach.TabIndex = 29;
            this.dgvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvdanhsach, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvdulieu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttchuyenbay, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.61502F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.38498F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1390, 852);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.bttdanhsach);
            this.groupBox1.Controls.Add(this.lblloc);
            this.groupBox1.Controls.Add(this.lblnoi_khoi_hanh1);
            this.groupBox1.Controls.Add(this.cbonoi_den1);
            this.groupBox1.Controls.Add(this.cbonoixuat_phat1);
            this.groupBox1.Controls.Add(this.lblnoiden1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 109);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 852);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmView";
            this.Text = "Thông tin khách hàng đặt vé ";
            this.Load += new System.EventHandler(this.frmView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdulieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttchuyenbay;
        private System.Windows.Forms.ComboBox cbonoi_den1;
        private System.Windows.Forms.Label lblnoiden1;
        private System.Windows.Forms.ComboBox cbonoixuat_phat1;
        private System.Windows.Forms.Label lblnoi_khoi_hanh1;
        private System.Windows.Forms.Label lblloc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttdanhsach;
        private System.Windows.Forms.DataGridView dgvdulieu;
        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}