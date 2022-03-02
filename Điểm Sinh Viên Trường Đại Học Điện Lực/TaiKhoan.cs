using Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực
{
    public partial class TaiKhoan : Form
    {
        public string taikhoan;
        public TaiKhoan()
        {
            InitializeComponent();
        }
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }
        private void LoadInfor()
        {
            this.LabelTenTk.Text = AccountInfor.Instance.tentk(taikhoan);
            this.LabelTenNd.Text = AccountInfor.Instance.tennguoidung(taikhoan);
        }

        public string Idtemp
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }

        private void ShowformDangNhap()
        {
            DangNhap frmDangNhap = new DangNhap();
            frmDangNhap.ShowDialog();
        }

        private void ShowformDieuHuong()
        {
            DieuHuong frmDieuHuong = new DieuHuong();
            frmDieuHuong.TempId = taikhoan;
            frmDieuHuong.ShowDialog();
        }    

        private void Button1_Click(object sender, EventArgs e)
        {
                Thread thread = new Thread(new ThreadStart(ShowformDieuHuong));
                thread.Start();
                this.Hide();    
        }

        void DoiMatKhau()
        {
            string tentaikhoan = LabelTenTk.Text;
            string tennguoidung = LabelTenNd.Text;
            string matkhau = PassWordsTextBox.Text;
            string matkhaumoi = newPassWordsTextBox.Text;
            string NhapLaimatkhaumoi = ReNewPassWordsTextBox.Text;

            if (!matkhaumoi.Equals(NhapLaimatkhaumoi))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu trùng với mật khẩu cũ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (Account.Instance.DoiMatKhau(tentaikhoan, tennguoidung, matkhau, matkhaumoi)== true)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mật khẩu", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
            PassWordsTextBox.Text = "";
            newPassWordsTextBox.Text = "";
            ReNewPassWordsTextBox.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDangNhap));
            thread.Start();
            this.Dispose();
        }
    }
}
