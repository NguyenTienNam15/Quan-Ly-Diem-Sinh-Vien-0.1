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
    public partial class DieuHuong : Form
    {
        public string taikhoan;
        public DieuHuong()
        {
            InitializeComponent();
        }

        public string TempId
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }

        private void ShowformTaiKhoan()
        {
            TaiKhoan frmTaiKhoan = new TaiKhoan();
            frmTaiKhoan.Idtemp = taikhoan;
            frmTaiKhoan.ShowDialog();
        }

        private void ShowformTrangChu()
        {
            TrangChu frmTrangChu = new TrangChu();
            frmTrangChu.ShowDialog();
        }

        private void ShowformDiemSV()
        {
            DiemSinhVien frmDiemSinhVien = new DiemSinhVien();
            frmDiemSinhVien.TempId = taikhoan;
            frmDiemSinhVien.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string quyen = Account.Instance.quyen(taikhoan);
            if (quyen == "hocsinh")
            {
                Thread thread = new Thread(new ThreadStart(ShowformDiemSV));
                thread.Start();
                this.Close();
            }
            if(quyen == "giaovien")
            {
                Thread thread = new Thread(new ThreadStart(ShowformTrangChu));
                thread.Start();
                this.Close();
            }    
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformTaiKhoan));
            thread.Start();
            this.Close();
        }
    }
}
