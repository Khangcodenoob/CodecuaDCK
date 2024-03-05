using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetaiQUANLYVEXELUA
{
    public partial class frmLogin : Form
    {
      
        string taikhoan = "khangbedu";
        string matkhau = "khang123";
        public frmLogin()
        {
            InitializeComponent();                    
        }
        bool kiemtra(string taikhoan, string matkhau)
        {
            if (taikhoan == this.taikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }
        private void bttDangnhap_Click(object sender, EventArgs e)
        {
            if (kiemtra(txttendangnhap.Text,txtmatkhau.Text))
            {
                Giaodienchinh f = new Giaodienchinh();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng Kiểm Tra lại tên tài khoản và mật khẩu", "Lỗi đăng nhập" , MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txttendangnhap.Focus();
                txtmatkhau.Focus();
            }
        }

        private void bttthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_TextChanged(object sender, EventArgs e)
        {
            //trống
        }
        private void chkkiemtra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkkiemtra.Checked == true)
            {
                txtmatkhau.PasswordChar = '\0';
            }
            else
                txtmatkhau.PasswordChar = '*';
        }
        private void bttreset_Click(object sender, EventArgs e)
        {
            txttendangnhap.Text = "";
            txttendangnhap.Focus();
            txtmatkhau.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //trống 
        }
    }
}
