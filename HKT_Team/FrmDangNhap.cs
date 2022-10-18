using HKT_Team.BusinessLayer;
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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();

        }
        BLLUser bd;
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(string.Format(@"{0}\Users.ini", Application.StartupPath));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
            trangThaiDongForm = true;
            Application.Exit();//Đóng cả chương trình
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                    {
                        trangThaiDongForm = true;
                        ClsMain.taiKhoan = txtTaiKhoan.Text;
                        ClsMain.users = bd.GetUsers();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hay mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTaiKhoan.ResetText();
                        txtMatKhau.ResetText();
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu chưa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản chưa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
        }

        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            return bd.KiemTraTaiKhoan(taiKhoan, matKhau);

        }
        bool trangThaiDongForm = false;
   
     private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThaiDongForm == true)
                e.Cancel = false;//Cho phép đóng form
            else
                e.Cancel = true;//không cho phép đóng form
        }

        // an hien password
        private void pica_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                picb.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void picb_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                pica.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }
     

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
