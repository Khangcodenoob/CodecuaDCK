namespace DetaiQUANLYVEXELUA
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.bttDangnhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.bttthoat = new System.Windows.Forms.Button();
            this.blcheck = new System.Windows.Forms.Label();
            this.chkkiemtra = new System.Windows.Forms.CheckBox();
            this.bttreset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttDangnhap
            // 
            this.bttDangnhap.BackColor = System.Drawing.Color.Yellow;
            this.bttDangnhap.Location = new System.Drawing.Point(268, 357);
            this.bttDangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.bttDangnhap.Name = "bttDangnhap";
            this.bttDangnhap.Size = new System.Drawing.Size(108, 40);
            this.bttDangnhap.TabIndex = 0;
            this.bttDangnhap.Text = "Đăng nhập";
            this.bttDangnhap.UseVisualStyleBackColor = false;
            this.bttDangnhap.Click += new System.EventHandler(this.bttDangnhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(239, 218);
            this.txttendangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.txttendangnhap.Multiline = true;
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(274, 20);
            this.txttendangnhap.TabIndex = 4;
            this.txttendangnhap.Text = "khangbedu";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(239, 280);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(274, 20);
            this.txtmatkhau.TabIndex = 5;
            // 
            // bttthoat
            // 
            this.bttthoat.Location = new System.Drawing.Point(387, 357);
            this.bttthoat.Margin = new System.Windows.Forms.Padding(2);
            this.bttthoat.Name = "bttthoat";
            this.bttthoat.Size = new System.Drawing.Size(116, 37);
            this.bttthoat.TabIndex = 7;
            this.bttthoat.Text = "Thoát";
            this.bttthoat.UseVisualStyleBackColor = true;
            this.bttthoat.Click += new System.EventHandler(this.bttthoat_Click);
            // 
            // blcheck
            // 
            this.blcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blcheck.ForeColor = System.Drawing.Color.Red;
            this.blcheck.Location = new System.Drawing.Point(248, 312);
            this.blcheck.Name = "blcheck";
            this.blcheck.Size = new System.Drawing.Size(100, 23);
            this.blcheck.TabIndex = 8;
            this.blcheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkkiemtra
            // 
            this.chkkiemtra.AutoSize = true;
            this.chkkiemtra.Location = new System.Drawing.Point(312, 317);
            this.chkkiemtra.Name = "chkkiemtra";
            this.chkkiemtra.Size = new System.Drawing.Size(48, 17);
            this.chkkiemtra.TabIndex = 10;
            this.chkkiemtra.Text = "Hiện";
            this.chkkiemtra.UseVisualStyleBackColor = true;
            this.chkkiemtra.CheckedChanged += new System.EventHandler(this.chkkiemtra_CheckedChanged);
            this.chkkiemtra.TextChanged += new System.EventHandler(this.checkBox1_TextChanged);
            // 
            // bttreset
            // 
            this.bttreset.Location = new System.Drawing.Point(143, 357);
            this.bttreset.Name = "bttreset";
            this.bttreset.Size = new System.Drawing.Size(108, 40);
            this.bttreset.TabIndex = 11;
            this.bttreset.Text = "Reset";
            this.bttreset.UseVisualStyleBackColor = true;
            this.bttreset.Click += new System.EventHandler(this.bttreset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1236, 793);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DetaiQUANLYVEXELUA.Properties.Resources.z4288914352184_974b3faa76b80dd71583e80d34ef2ed9;
            this.pictureBox1.Location = new System.Drawing.Point(621, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 787);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bttthoat);
            this.groupBox1.Controls.Add(this.bttDangnhap);
            this.groupBox1.Controls.Add(this.bttreset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkkiemtra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttendangnhap);
            this.groupBox1.Controls.Add(this.blcheck);
            this.groupBox1.Controls.Add(this.txtmatkhau);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 787);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 71);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đăng nhập tại đây !!\r\n|\r\nv\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1236, 793);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttDangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button bttthoat;
        private System.Windows.Forms.Label blcheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkkiemtra;
        private System.Windows.Forms.Button bttreset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}