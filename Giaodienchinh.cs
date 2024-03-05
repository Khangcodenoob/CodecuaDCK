using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetaiQUANLYVEXELUA
{

    public partial class Giaodienchinh : Form
    {
        private Form currrenchidlen;
        public Giaodienchinh()
        {
            InitializeComponent();
        }

        private void cácQuyĐịnhNhàGaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Quydinh();
            frm.ShowDialog();
        }

        private void đặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmdatvetau();
            frm.ShowDialog();
        }

        private void tuyếnTàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmChuyenTau();
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmKhachhangg();
            frm.ShowDialog();
        }

        private void timergiaodien_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss tt");         
        }
        private void Giaodienchinh_Load(object sender, EventArgs e)
        {
            this.Text = "Tôi tên là DCK".PadLeft(200);

            timergiaodien.Enabled = true;
            timergiaodien.Interval = 100;

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            //trống
        }

        private void thôngTinKháchHàngĐặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmView();
            frm.ShowDialog();
        }
        //public void OpenChild(Form childForm)
        //{
        //    if (currrenchidlen != null)
        //    {
        //        currrenchidlen.Close();
        //    }
        //    currrenchidlen = childForm;
        //    childForm.TopLevel = false;
        //    childForm.Dock = DockStyle.Fill;
        //    tableLayoutPanel1.Controls.Add(childForm);
        //    tableLayoutPanel1.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}
    }
}
