using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using System.Collections;

namespace DetaiQUANLYVEXELUA
{
    public partial class frmdatvetau : Form
    {
        List<Datve> datveList;       
        int index;

        public frmdatvetau()
        {
            InitializeComponent();
            datveList = new List<Datve>();
            //Tạo style cho datagridview
            dgvDatve.RowsDefaultCellStyle.BackColor = Color.LightYellow;
            dgvDatve.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
        }
        // Button thêm 
        private void button1_Click(object sender, EventArgs e)
        {
            dgvDatve.AutoGenerateColumns = false;
            Datve dv = new Datve();
            //Kiểm tra điều kiện xem Mã khách hàng và mã vé có tồn tại chưa , nếu đã tồn tại thì yêu cầu nhập lại 
            if (datveList.Any(emp => emp.MaKH == txtMaKH.Text))
            {
                MessageBox.Show("Mã Khách Hàng đã tồn tại!", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }          
            if (datveList.Any(emp => emp.Mave == txtMave.Text))
            {
                MessageBox.Show("Mã vé này đã tồn tại!", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            // Gán giá trị từ các điều khiển trên giao diện vào đối tượng Datve
            dv.Mave = txtMave.Text;
            dv.Loaive = txtLoaive.Text;
            dv.MaKH = txtMaKH.Text;
            dv.MaTau = txtMatau.Text;         
            dv.Noiden = cbonoiden.Text;
            dv.NoiDi = cboNoidi.Text;
            dv.Ngayxuatphat = dtpNgaygio.Value;
            dv.Tien = Convert.ToDouble(txtGia.Text);
            //Them doi tuong datve vao danh sách 
            datveList.Add(dv);
            dgvDatve.DataSource = null;
            //Gán danh sách mới vào dự liệu 
            dgvDatve.DataSource = datveList;
            //Đặt lại chế độ tự tạo cột trong datagrid view 
            dgvDatve.AutoGenerateColumns = true;

        }
        //Form Load
        private void Datvetau_Load(object sender, EventArgs e)
        {
            // Lấy đường dẫn của ứng dụng hiện tại,Ghép đường dẫn với tên tệp tin CSV
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string csvFilePat = path +  @"datvetau.csv";
            // Đọc dữ liệu từ tệp tin CSV và gán vào danh sách datveList
            datveList = Datve.ReadFormCSV(csvFilePat);       
            dgvDatve.DataSource = datveList;
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            //Nêu điều kiện , nếu nhấn button xoá sẽ đưa ra cảnh báo , chọn ok để xoá 
            if (MessageBox.Show("Bạn có muốn xóa không", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                datveList.RemoveAt(index);
                dgvDatve.DataSource = null;
                dgvDatve.DataSource = datveList;
            }
        }

        private void dgvDatve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txtMave.Text = datveList[index].Mave.ToString();
                txtLoaive.Text = datveList[index].Loaive.ToString();
                txtMaKH.Text = datveList[index].MaKH.ToString();
                cbonoiden.Text = datveList[index].Noiden.ToString();
                cboNoidi.Text = datveList[index].NoiDi.ToString();
                dtpNgaygio.Text = datveList[index].Ngayxuatphat.ToString();
                txtGia.Text = datveList[index].Tien.ToString();
            }
        }

        private void gpbCanhan_Enter(object sender, EventArgs e)
        {
            //trống
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string csvFilePat = path + @"\Datvetau.csv";         
            Datve.SaveToFile(datveList, csvFilePat, true);
            //File.WriteAllText(csvFilePat, string.Empty);
        }

        private void bttTimkiem_Click(object sender, EventArgs e)
        {
            //trống
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string TenKH = txtTimkiem.Text.Trim();
            Searchthongtin(TenKH);
        }
        private void Searchthongtin(string tenKH)
        {
            //Chuyển đổi chuỗi tìm kiếm và các giá trị trong danh sách thành chữ hoa để thực hiện tìm kiếm không phân biệt chữ hoa và thường
            tenKH = tenKH.ToUpper();
            // Sử dụng LINQ để lọc các đối tượng Datve theo điều kiện tìm kiếm
            var filtered = from Datve in datveList
                           where Datve.Mave.ToUpper().Contains(tenKH) || Datve.MaTau.ToUpper().Contains(tenKH)
                           select Datve;
            //Cập nhật dữ liệu của datagridview để hiển thị 
            dgvDatve.DataSource = filtered.ToList();
            //LINQ(Language - Integrated Query) là một phần của .NET Framework được thiết kế để thực hiện các truy vấn dữ liệu
            //trong môi trường lập trình .NET.LINQ giúp làm cho việc truy vấn và xử lý dữ liệu trở nên linh hoạt và thuận tiện

        }

        private void bttSapxep_Click(object sender, EventArgs e)
        {
            datveList.Sort((a, b) => a.Mave.CompareTo(b.Mave));
            datveList.Sort((a, b) => a.MaKH.CompareTo(b.MaKH));
            datveList.Sort((a, b) => a.MaTau.CompareTo(b.MaTau));
            datveList.Sort((a, b) => a.Loaive.CompareTo(b.Loaive));
            dgvDatve.DataSource = null;
            dgvDatve.DataSource = datveList;
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn sửa nội dung? (Yes/No)", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            // Tìm Index - Vị trí của ID trong List
            int index = datveList.FindIndex(a => a.MaKH == (txtMaKH.Text));
            if (index >= 0)
            {
                dgvDatve.AutoGenerateColumns = false;

                datveList[index].Mave = txtMave.Text;
                datveList[index].MaKH = txtMaKH.Text;
                datveList[index].MaTau= txtMatau.Text;
                datveList[index].NoiDi = cboNoidi.Text;
                datveList[index].Noiden = cbonoiden.Text;
                datveList[index].Tien = Convert.ToDouble(txtGia.Text);
                datveList[index].Loaive = txtLoaive.Text;
                datveList[index].Ngayxuatphat = dtpNgaygio.Value;               
                dgvDatve.DataSource = datveList;

                dgvDatve.AutoGenerateColumns = true;

                // XỬ lý Select dòng cuối vừa sửa                
                dgvDatve.Rows[index].Selected = true;
            }
        }

        private void cboNoidi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNoidi.SelectedItem != null && cbonoiden.SelectedItem != null)
            {
                if (cboNoidi.SelectedItem.ToString() == cbonoiden.SelectedItem.ToString())
                {
                    MessageBox.Show("Không được chọn cùng một dữ liệu!", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    cboNoidi.SelectedIndex = -1; 
                }
            }
        }

        private void cbonoiden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNoidi.SelectedItem != null && cbonoiden.SelectedItem != null)
            {
                if (cboNoidi.SelectedItem.ToString() == cbonoiden.SelectedItem.ToString())
                {
                    MessageBox.Show("Không được chọn cùng một dữ liệu!", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    cbonoiden.SelectedIndex = -1;
                }
            }
        }

        private void txtMatau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatau.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập thông tin cho mã chuyến bay ");
                return;
            }
        }

        private void gpbVe_Enter(object sender, EventArgs e)
        {

        }
    }
}
