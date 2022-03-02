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
    public partial class DiemSinhVien : Form
    {

        private string taikhoan;
        public DiemSinhVien()
        {
            InitializeComponent();
        }
        private void DiemSinhVien_Load(object sender, EventArgs e)
        {
            LoadInfor();
            LoadDGV();
        }

        public string TempId
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }

        private void LoadInfor()
        {
            LabelMaSv.Text = StudentInfor.Instance.masv(taikhoan);
            LabelTenSv.Text = StudentInfor.Instance.tensv(taikhoan);
            LabelGioiTinh.Text = StudentInfor.Instance.gioitinh(taikhoan);
            LabelLopSv.Text = StudentInfor.Instance.tenlop(taikhoan);
            LabelNganhSv.Text = StudentInfor.Instance.tenchuyennganh(taikhoan);
            LabelNgaySinh.Text = StudentInfor.Instance.ngaysinh(taikhoan);
            LabelKhoaSv.Text = StudentInfor.Instance.tenkhoa(taikhoan);
            labelTongiao.Text = StudentInfor.Instance.tongiao(taikhoan);
            LabelDiemtb10.Text = StudentInfor.Instance.Diemtbhe10(taikhoan);
            LabelDiemtb4.Text = StudentInfor.Instance.Diemtbhe4(taikhoan);
            LabelTinchi.Text = StudentInfor.Instance.Tinchi(taikhoan);
        }    

        private void ShowformDangNhap()
        {
            DangNhap frmDangNhap = new DangNhap();
            frmDangNhap.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel);
            if(h == DialogResult.OK)
            {
                Application.Exit(); 
            }    
        }

        private void LoadDGV()
        {
            string masv = StudentInfor.Instance.masv(taikhoan);
            string query = @"EXEC DiemSinhVien @masv = N'" + masv + "'";
            DataTable data = SQLConnect.Instance.ExcecuteQuery(query);
            DGVDiemSinhVien.DataSource = data;
            DGVDiemSinhVien.AutoResizeColumns();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            DialogResult h = MessageBox.Show("Bạn đang đăng xuất chương trình", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                Thread thread = new Thread(new ThreadStart(ShowformDangNhap));
                thread.Start();
                this.Dispose();
            }
        }

        
    }
}
