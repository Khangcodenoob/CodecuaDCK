using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DetaiQUANLYVEXELUA
{
    public partial class FrmChuyenTau : Form
    {
        List<ChuyenTau> chuyentaulist;
        int index;
        public FrmChuyenTau()
        {
            InitializeComponent();
            dgvchuyentau.RowsDefaultCellStyle.BackColor = Color.LightYellow;
            dgvchuyentau.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //TRỐNG.
        }

        private void FrmChuyenTau_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;          
            string csvFilePat = path + @"Chuyentau.csv";
            chuyentaulist = ChuyenTau.ReadFromCSV(csvFilePat);
            dgvchuyentau.DataSource = chuyentaulist;
        }

        private void bttXoachuyentau_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ko", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                chuyentaulist.RemoveAt(index);
                dgvchuyentau.DataSource = null;
                dgvchuyentau.DataSource = chuyentaulist;
            }
        }

        private void bttsua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn sửa nội dung mã chuyến tàu {txtMachuyentau.Text}? (Yes/No)", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            // Tìm Index - Vị trí của ID trong List
            int index = chuyentaulist.FindIndex(a => a.MaTau == (txtMachuyentau.Text));
            if (index >= 0)
            {
                dgvchuyentau.AutoGenerateColumns = false;

                chuyentaulist[index].MaTau = txtMachuyentau.Text;
                chuyentaulist[index].NoiDi = cbonoiDi.Text;
                chuyentaulist[index].Noiden = cbonoiDen.Text;
                dgvchuyentau.DataSource = chuyentaulist;

                dgvchuyentau.AutoGenerateColumns = true;

                // XỬ lý Select dòng cuối vừa sửa                
                dgvchuyentau.Rows[index].Selected = true;
            }
        }
        private void SearchChuyenTau(string TenCT)
        {
            TenCT = TenCT.ToUpper();
            var filtered = from Chuyenbay in chuyentaulist
                           where Chuyenbay.MaTau.ToUpper().Contains(TenCT) 
                           || Chuyenbay.Loaitau.ToUpper().Contains(TenCT)
                           select Chuyenbay;

            dgvchuyentau.DataSource = filtered.ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string tenCT = txtSearch.Text.Trim();
            SearchChuyenTau(tenCT);
        }

        private void dgvchuyentau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvchuyentau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //index = e.RowIndex;
            //if (index >= 0)
            //{
            //    txtMachuyentau.Text = chuyentaulist[index].MaTau.ToString();
            //    txtLoaiTau.Text = chuyentaulist[index].Loaitau.ToString();
            //    txtToa.Text = chuyentaulist[index].Toa.ToString();
            //    cbonoiDen.Text = chuyentaulist[index].Noiden.ToString();
            //    cbonoiDi.Text = chuyentaulist[index].NoiDi.ToString();
                
            //    cbohangtau.Text = chuyentaulist[index].Hangtau.ToString();
            //}
        }

        private void bttTHEM_Click(object sender, EventArgs e)
        {
         //trống
        }
        private void bttTHEM_Click_1(object sender, EventArgs e)
        {
            dgvchuyentau.AutoGenerateColumns = false;
            ChuyenTau chuyentau = new ChuyenTau();
            chuyentau.MaTau = txtMachuyentau.Text;
            chuyentau.Loaitau = txtLoaiTau.Text;
            chuyentau.Toa = txtToa.Text;
            chuyentau.Soghe = txtSoghe.Text;
            chuyentau.NoiDi = cbonoiDi.Text;
            chuyentau.Noiden = cbonoiDen.Text;
            chuyentau.ngayxuatphat = dateTimePicker1.Value;
            chuyentau.Hangtau = cbohangtau.Text;
            chuyentaulist.Add(chuyentau);
            dgvchuyentau.DataSource = null;
            dgvchuyentau.DataSource = chuyentaulist;
            dgvchuyentau.AutoGenerateColumns = true;
        }
        private void bttluuchuyentau_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string csvFilePat = path + @"\Chuyentau.csv";
            ChuyenTau.SaveToFile(chuyentaulist, csvFilePat, true);
            //File.WriteAllText(csvFilePat, string.Empty);
        }

        private void cbonoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbonoiDi.SelectedItem != null && cbonoiDen.SelectedItem != null)
            {
                if (cbonoiDi.SelectedItem.ToString() == cbonoiDen.SelectedItem.ToString())
                { 
                    MessageBox.Show("Không được chọn cùng một dữ liệu!", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    cbonoiDi.SelectedIndex = -1;
                }
            }
        }

        private void cbonoiDen_TextChanged(object sender, EventArgs e)
        {
            //trống
        }

        private void cbonoiDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbonoiDi.SelectedItem != null && cbonoiDen.SelectedItem != null)
            {
                if (cbonoiDi.SelectedItem.ToString() == cbonoiDen.SelectedItem.ToString())
                {
                    MessageBox.Show("Không được chọn cùng một dữ liệu!", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    cbonoiDen.SelectedIndex = -1;
                }
            }
        }

        private void cbohangtau_TextChanged(object sender, EventArgs e)
        {
            if (cbohangtau.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập thông tin cho mã chuyến bay ", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
