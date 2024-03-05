using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetaiQUANLYVEXELUA
{
    public partial class frmView : Form
    {
        List<Datve> datvelist = new List<Datve>();
        List<ChuyenTau> Chuyentaulist = new List<ChuyenTau>();
        List<Khachhang> khachhanglist = new List<Khachhang>();
        //List<int> makhList = new List<int>();
        //List<int> machuyentauList = new List<int>();
        public frmView()
        {
            InitializeComponent();        
            dgvdanhsach.RowsDefaultCellStyle.BackColor = Color.LightYellow;
            dgvdanhsach.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgvdulieu.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvdulieu.AlternatingRowsDefaultCellStyle.BackColor = Color.LightPink;
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string csvFilePat = path + @"ListKhachhang.csv";
            khachhanglist = Khachhang.ReadFromCSV(csvFilePat);
            csvFilePat = path + @"Chuyentau.csv";
            Chuyentaulist = ChuyenTau.ReadFromCSV(csvFilePat);
            csvFilePat = path + @"datvetau.csv";
            datvelist = Datve.ReadFormCSV(csvFilePat);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string timkiem = textBox1.Text.Trim();
            Searchthongtin(timkiem);
            //// Tạo một danh sách tạm thời để lưu kết quả tìm kiếm
            //List<Khachhang> timkiem = new List<Khachhang>();
            //// Loại bỏ các phần tử trùng lặp trong danh sách kết quả
            //timkiem = timkiem.Distinct().ToList();
            //// Xóa dữ liệu hiện tại trên DataGridView
            //foreach( Khachhang tk in timkiem)
            //{
            //    string  tenKH = khachhanglist.FirstOrDefault(k => k.Ten ==  tk.Ten)?.MaKH ??"";
            //    dgvdanhsach.Rows.Add(tk.Ten, tk.MaKH, tk.CCCD, tk.Diachi, tk.Gioitinh, tk.Ngaysinh, tk.Email);
            //}
        }
        private void Searchthongtin(string tenKH)
        {
            tenKH = tenKH.ToUpper();
            var filtered = from Khachhang in khachhanglist
                           where Khachhang.MaKH.ToUpper().Contains(tenKH) || Khachhang.Ten.ToUpper().Contains(tenKH)
                           select Khachhang;
            dgvdanhsach.DataSource = filtered.ToList();
        }
        private void Searchthongtin1(string text)
        {
            text = text.Trim();
            var emp = from s in datvelist
                      join p in khachhanglist on s.MaKH equals p.MaKH
                      join e in Chuyentaulist on s.MaTau equals e.MaTau
                      where s.NoiDi.ToUpper().Contains(text)
                      select khachhanglist;
                      //{
                      //    s.MaKH,
                      //    s.MaTau,
                      //    p.Ten,
                      //    p.CCCD,
                      //    s.Mave,
                      //    s.Ngayxuatphat,
                      //    s.NoiDi,
                      //    s.Noiden, 
                      //    p.Gioitinh,
                      //    s.Tien,
                          
                      //};

            dgvdanhsach.DataSource = emp.ToList();        
                     
        }
        private void Searchthongtin2(string text)
        {
            text = text.Trim();
            var emp = from s in datvelist
                      join p in khachhanglist on s.MaKH equals p.MaKH
                      join e in Chuyentaulist on s.MaTau equals e.MaTau
                      where s.NoiDi.ToUpper().Contains(text)
                      select khachhanglist;
                      //{
                      //    s.MaKH,
                      //    s.MaTau,
                      //    p.Ten,
                      //    p.CCCD,
                      //    s.Mave,
                      //    s.Ngayxuatphat,
                      //    s.NoiDi,
                      //    s.Noiden,
                      //    p.Gioitinh,
                      //    s.Tien,

                      //};
            dgvdanhsach.DataSource = emp.ToList();

        }
        private void cbonoixuat_phat1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbonoixuat_phat1.SelectedItem != null && cbonoi_den1.SelectedItem != null)
            {
                if (cbonoixuat_phat1.SelectedItem.ToString() == cbonoi_den1.SelectedItem.ToString())
                {
                    MessageBox.Show("Không được chọn cùng một dữ liệu!", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    cbonoi_den1.SelectedIndex = -1; // Xóa lựa chọn của combobox Noi xuat phat
                }
            }
            string noidi = cbonoixuat_phat1.Text.Trim();
            Searchthongtin1(noidi);
        }

        private void cbonoi_den1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbonoixuat_phat1.SelectedItem != null && cbonoi_den1.SelectedItem != null)
            {
                if (cbonoixuat_phat1.SelectedItem.ToString() == cbonoi_den1.SelectedItem.ToString())
                {
                    MessageBox.Show("Không được chọn cùng một dữ liệu!", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    cbonoixuat_phat1.SelectedIndex = -1; // Xóa lựa chọn của combobox Noi den
                }
            }
            string noiden = cbonoi_den1.Text.Trim();
            Searchthongtin2(noiden);

        }

        private void bttchuyenbay_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string csvFilePat = path + @"Chuyentau.csv";
            Chuyentaulist = ChuyenTau.ReadFromCSV(csvFilePat);
            dgvdulieu.DataSource = Chuyentaulist;
        }
               
        private void bttdanhsach_Click(object sender, EventArgs e)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory;
            //string csvFilePat = path + @"ListKhachhang.csv";
            //khachhanglist = Khachhang.ReadFromCSV(csvFilePat);
            //dgvdanhsach.DataSource = khachhanglist;
            var result =
                datvelist.Join(khachhanglist, emp => emp.MaKH, p => p.MaKH,(ts1, ts2) =>
                {
                    return new
                    {
                        ts2.MaKH,
                        ts2.Ten,
                        ts2.CCCD,
                        ts1.MaTau,                       
                        ts1.Mave,
                        ts2.Gioitinh,
                        ts2.Diachi,
                        ts2.SĐT,                       
                        ts2.Quoctich,
                        ts2.Ngaysinh,
                        ts1.Noiden,
                        ts1.NoiDi,
                    };
                });
            dgvdanhsach.DataSource = result.ToList();
            if (!result.Any())
            {
                MessageBox.Show("Thông Tin của Khách Hàng hiện Tại bị xóa mời cập nhật lại thông tin");
            }         
            //dgvdanhsach.DataSource = khachhanglist;
        }
        private void cbonoixuat_phat1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int noixuatphat = cbonoixuat_phat1.SelectedIndex;
            var result =
             datvelist.Join(khachhanglist, nd => nd.MaKH, cv => cv.MaKH, 
             (ts3, ts4) =>
             {
                 return new
                 {
                     ts4.MaKH,
                     ts4.Ten,
                     ts4.CCCD,
                     ts3.MaTau,
                     ts3.Mave,
                     ts4.Gioitinh,                  
                     ts4.Quoctich,
                     ts4.Ngaysinh,
                     ts3.Noiden,
                     ts3.NoiDi,
                 };
             });
            dgvdanhsach.DataSource = result.ToList();
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow ROW = dgvdanhsach.Rows[e.RowIndex];
            //    string MaKH  = ROW.Cells["MaTau"].Value?.ToString();

            //    LayThongTin(MaKH);
            //}
        }

        private void cbonoi_den1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int noixuatdent = cbonoi_den1.SelectedIndex;
            var result =
            datvelist.Join(khachhanglist, nd => nd.MaKH, cv => cv.MaKH,
            (ts3, ts4) =>
            { 
                  return new
                  {
                    ts4.MaKH,
                    ts4.Ten,
                    ts4.CCCD,
                    ts3.MaTau,
                    ts3.Mave,
                    ts4.Gioitinh,
                    ts4.Quoctich,
                    ts4.Ngaysinh,
                    ts3.Noiden,
                    ts3.NoiDi,
                  };
             });
            dgvdanhsach.DataSource = result.ToList();
        }
    }
}
