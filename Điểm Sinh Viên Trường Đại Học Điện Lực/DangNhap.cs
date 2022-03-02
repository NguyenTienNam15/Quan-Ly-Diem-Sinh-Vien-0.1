using Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo);
            if(h == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }

        private void ShowformDieuHuong()
        {
            DieuHuong frmDieuHuong = new DieuHuong();
            frmDieuHuong.TempId = IdBox.Text;
            frmDieuHuong.ShowDialog();
        }

        bool Login(string taikhoan, string matkhau)
        {
            return Account.Instance.Login(taikhoan, matkhau);
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            string taikhoan = IdBox.Text;
            string matkhau = PassWordBox.Text;

            if(Login(taikhoan,matkhau) == true)
            {
                Thread thread = new Thread(new ThreadStart(ShowformDieuHuong));
                this.Hide();
                thread.Start();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
            }
            
        }
    }
}
