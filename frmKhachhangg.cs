using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DetaiQUANLYVEXELUA
{
    public partial class frmKhachhangg : Form
    {

        List<Khachhang> khachhanglist;
        int index;
        public frmKhachhangg()
        {
            InitializeComponent();
            dgvkhachhang.RowsDefaultCellStyle.BackColor = Color.LightYellow;
            dgvkhachhang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
        }

        private void bttthemKH_Click(object sender, EventArgs e)
        {
            dgvkhachhang.AutoGenerateColumns = false;
            Khachhang khachhang = new Khachhang();
            if (khachhanglist.Any(emp => emp.MaKH == txtmakh.Text))
            {
                MessageBox.Show("Mã Khách Hàng đã tồn tại!" , "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (khachhanglist.Any(emp => emp.CCCD == txtcccd.Text))
            {
                MessageBox.Show("Căn cước này  đã đăng kí!", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (khachhanglist.Any(emp => emp.SĐT == txtSĐT.Text))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại!", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (khachhanglist.Any(emp => emp.Ten == txthovaten.Text))
            {
                MessageBox.Show("Tên này đã được nhập đã tồn tại!", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            khachhang.MaKH = txtmakh.Text;
            khachhang.Ten = txthovaten.Text;
            khachhang.CCCD = txtcccd.Text;
            khachhang.Ngaysinh = txtngaysinh.Text;
            khachhang.Gioitinh = txtgioitinh.Text;
            khachhang.Diachi = txtdiachiHK.Text;
            khachhang.Quequan = txtquequan.Text;
            khachhang.Quoctich = txtquoctich.Text;
            khachhang.Email = txtemail.Text;
            khachhang.SĐT = txtSĐT.Text;

            khachhanglist.Add(khachhang);
            dgvkhachhang.DataSource = null;
            dgvkhachhang.DataSource = khachhanglist;
            dgvkhachhang.AutoGenerateColumns = true;
        }

        private void frmKhachhangg_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string csvFilePat = path + @"ListKhachhang.csv";
            khachhanglist = Khachhang.ReadFromCSV(csvFilePat);
            dgvkhachhang.DataSource = khachhanglist;

        }

        private void bttXoaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ko", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                khachhanglist.RemoveAt(index);
                dgvkhachhang.DataSource = null;
                dgvkhachhang.DataSource = khachhanglist;
            }
        }

        private void bttSuaKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn sửa nội dung Vé {txtmakh.Text}? (Yes/No)", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            // Tìm Index - Vị trí của ID trong List
            int index = khachhanglist.FindIndex(a => a.MaKH == (txtmakh.Text));
            if (index >= 0)
            {
                dgvkhachhang.AutoGenerateColumns = false;

                khachhanglist[index].Ten = txthovaten.Text;
                khachhanglist[index].MaKH = txtmakh.Text;
                khachhanglist[index].SĐT = txtSĐT.Text;
                khachhanglist[index].CCCD = txtcccd.Text;
                khachhanglist[index].Diachi = txtdiachiHK.Text;
                khachhanglist[index].Gioitinh = txtgioitinh.Text;
                khachhanglist[index].Quoctich =txtquoctich.Text;
                khachhanglist[index].Quequan = txtquequan.Text;
                khachhanglist[index].Email = txtemail.Text;
                khachhanglist[index].Ngaysinh = txtngaysinh.Text;
              dgvkhachhang.DataSource = khachhanglist;

                dgvkhachhang.AutoGenerateColumns = true;

                // XỬ lý Select dòng cuối vừa sửa                
                dgvkhachhang.Rows[index].Selected = true;
            }
        }

        private void bttLuuKH_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string csvFilePat = path + @"\ListKhachhang.csv";
            Khachhang.SaveToFile(khachhanglist, csvFilePat, true);
            //File.WriteAllText(csvFilePat, string.Empty);
        }
        private void SearchKhachhang(string TenKH)
        {
            TenKH = TenKH.ToUpper();
            var filtered = from Chuyenbay in khachhanglist
                           where Chuyenbay.MaKH.ToUpper().Contains(TenKH)
                           || Chuyenbay.Ten.ToUpper().Contains(TenKH)
                           select Chuyenbay;

            dgvkhachhang.DataSource = filtered.ToList();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string tenKH = txttimkiem.Text.Trim();
            SearchKhachhang(tenKH);
        }
    }
}
