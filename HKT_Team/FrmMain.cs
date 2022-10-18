using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HKT_Team
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadFormLogin();
        }

        private void LoadFormLogin()
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();
            lblTaiKhoan.Text = string.Format("Hệ thống đăng nhập bởi: {0}", ClsMain.taiKhoan);

            lblThoiGian.Text = string.Format("Thời gian: {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            {
                lblThoiGian.Text = string.Format("Thời gian: {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
        }

        private void mnuDangXuat_Click_1(object sender, EventArgs e)
        {
            LoadFormLogin();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }

        private void functionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuQuanLyNguoiDung_Click_1(object sender, EventArgs e)
        {
            {
                FrmQuanLyUser_Main frmQuanLyUser_Main = new FrmQuanLyUser_Main();
                frmQuanLyUser_Main.ShowDialog();
            }
        }
    }
}
