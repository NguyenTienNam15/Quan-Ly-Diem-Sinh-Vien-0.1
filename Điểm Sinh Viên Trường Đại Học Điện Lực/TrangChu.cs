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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            comboBox5.SelectedIndex = 0;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowformDangNhap()
        {
            DangNhap frmDangNhap = new DangNhap();
            frmDangNhap.ShowDialog();
        }

        private void ShowformDiemChuyenNganhCNPM()
        {
            DiemChuyenNganh frmChuyenNganhCNPM = new DiemChuyenNganh();
            frmChuyenNganhCNPM.LabelMaChuyenNganh.Text = "CTNN-CNPM";
            frmChuyenNganhCNPM.LabelTenChuyenNganh.Text = "Công Nghệ Phần Mềm";
            frmChuyenNganhCNPM.ShowDialog();
        }

        private void ShowformDiemChuyenNganhTMDT()
        {
            DiemChuyenNganh frmChuyenNganhCNPM = new DiemChuyenNganh();
            frmChuyenNganhCNPM.LabelMaChuyenNganh.Text = "CNTT-TMDT";
            frmChuyenNganhCNPM.LabelTenChuyenNganh.Text = "Hệ Thống Thương Mại Điện Tử";
            frmChuyenNganhCNPM.ShowDialog();
        }

        private void ShowformDiemChuyenNganhQTANM()
        {
            DiemChuyenNganh frmChuyenNganhCNPM = new DiemChuyenNganh();
            frmChuyenNganhCNPM.LabelMaChuyenNganh.Text = "CNTT-QTANM";
            frmChuyenNganhCNPM.LabelTenChuyenNganh.Text = "Quản Trị An Ninh Mạng";
            frmChuyenNganhCNPM.ShowDialog();
        }

        private void ShowformMonHoc()
        {
            MonHoc frmMonHoc = new MonHoc();
            frmMonHoc.ShowDialog();

        }
        private void ShowformDiemLopCNPM1()
        {
            DiemLop frmDiemLop = new DiemLop();
            frmDiemLop.LabelMaLop.Text = "CNTT-CNPM1";
            frmDiemLop.LabelTenLop.Text = "Công Nghệ Phần Mềm 1";
            frmDiemLop.ShowDialog();
        }
        private void ShowformDiemLopCNPM2()
        {
            DiemLop frmDiemLop = new DiemLop();
            frmDiemLop.LabelMaLop.Text = "CNTT-CNPM2";
            frmDiemLop.LabelTenLop.Text = "Công Nghệ Phần Mềm 2";
            frmDiemLop.ShowDialog();
        }
        private void ShowformDiemLopCNPM3()
        {
            DiemLop frmDiemLop = new DiemLop();
            frmDiemLop.LabelMaLop.Text = "CNTT-CNPM3";
            frmDiemLop.LabelTenLop.Text = "Công Nghệ Phần Mềm 3";
            frmDiemLop.ShowDialog();
        }

        private void ShowformDiemLopTMDT1()
        {
            DiemLop frmDiemLop = new DiemLop();
            frmDiemLop.LabelMaLop.Text = "CNTT-TMDT1";
            frmDiemLop.LabelTenLop.Text = "Hệ Thống Thương Mại Điện Tử 1";
            frmDiemLop.ShowDialog();
        }
        private void ShowformDiemLopTMDT2()
        {
            DiemLop frmDiemLop = new DiemLop();
            frmDiemLop.LabelMaLop.Text = "CNTT-TMDT2";
            frmDiemLop.LabelTenLop.Text = "Hệ Thống Thương Mại Điện Tử 2";
            frmDiemLop.ShowDialog();
        }
        private void ShowformDiemLopTMDT3()
        {
            DiemLop frmDiemLop = new DiemLop();
            frmDiemLop.LabelMaLop.Text = "CNTT-TMDT3";
            frmDiemLop.LabelTenLop.Text = "Hệ Thống Thương Mại Điện Tử 3";
            frmDiemLop.ShowDialog();
        }
        private void ShowformDiemLopQTANM1()
        {
            DiemLop frmDiemLop = new DiemLop();
            frmDiemLop.LabelMaLop.Text = "CNTT-QTANM1";
            frmDiemLop.LabelTenLop.Text = "Quản Trị An Ninh Mạng 1";
            frmDiemLop.ShowDialog();
        }
        private void ShowformDiemLopQTANM2()
        {
            DiemLop frmDiemLop = new DiemLop();
            frmDiemLop.LabelMaLop.Text = "CNTT-QTANM2";
            frmDiemLop.LabelTenLop.Text = "Quản Trị An Ninh Mạng 2";
            frmDiemLop.ShowDialog();
        }
        private void ShowformDiemLopQTANM3()
        {
            DiemLop frmDiemLop = new DiemLop();
            frmDiemLop.LabelMaLop.Text = "CNTT-QTANM3";
            frmDiemLop.LabelTenLop.Text = "Quản Trị An Ninh Mạng 3";
            frmDiemLop.ShowDialog();
        }
        private void ThốngKêĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemChuyenNganhCNPM));
            thread.Start();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn đang đăng xuất khỏi tài khoản", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                Thread thread = new Thread(new ThreadStart(ShowformDangNhap));
                thread.Start();
                this.Dispose();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel);
            if(h == DialogResult.OK)
            {
                Application.Exit();
            }    
        }

        
        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn đang đăng xuất khỏi tài khoản", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                Thread thread = new Thread(new ThreadStart(ShowformDangNhap));
                thread.Start();
                this.Dispose();
            }
        }

        private void DanhSáchChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowformMonHoc();
        }

        private void lớpCNPM1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemLopCNPM1));
            thread.Start();
            this.Close();
        }

        private void lớpCNPM2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemLopCNPM2));
            thread.Start();
            this.Close();
        }

        private void lớpCNPM3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemLopCNPM3));
            thread.Start();
            this.Close();
        }

        private void ThốngKêĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemChuyenNganhTMDT));
            thread.Start();
            this.Close();
        }

        private void ChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowformMonHoc();
        }

        private void lớpTMDT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemLopTMDT1));
            thread.Start();
            this.Close();
        }

        private void lớpTMDT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemLopTMDT2));
            thread.Start();
            this.Close();
        }

        private void lớpTMDT3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemLopTMDT3));
            thread.Start();
            this.Close();
        }

        private void ThốngKêĐiểmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemChuyenNganhQTANM));
            thread.Start();
            this.Close();
        }

        private void ChuyênNgànhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowformMonHoc();
        }

        private void lớpQTANM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemLopQTANM1));
            thread.Start();
            this.Close();
        }

        private void lớpQTANM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemLopQTANM2));
            thread.Start();
            this.Close();
        }

        private void lớpQTANM3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowformDiemLopQTANM3));
            thread.Start();
            this.Close();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            string tenkhoa = ComboBoxDsKhoa.Text;
            string tenchuyennganh = ComboBoxDsNganh.Text;
            string tenlop = ComboBoxLop.Text;
            string tenmon = ComboBoxMonHoc.Text;


            if (tenkhoa == "")
            {
                MessageBox.Show("Bạn chưa chọn danh mục nào", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string query = @"EXEC DiemKhoaData @tenkhoa";
                DataTable data = SQLConnect.Instance.ExcecuteQuery(query, new object[] { tenkhoa });
                dgvBangDiem.DataSource = data;
                dgvBangDiem.AutoResizeColumns();

                if(tenchuyennganh != "(Trống)")
                {
                    
                    string query1 = @"EXEC ChuyenNganhData @tenchuyennganh = N'" + tenchuyennganh + "', @tenmon = N''";
                    dgvBangDiem.DataSource = SQLConnect.Instance.ExcecuteQuery(query1);
                    dgvBangDiem.AutoResizeColumns();

                    if (tenlop != "(Trống)")
                    {

                        string query2 = @"EXEC DiemLopData @tenlop = N'" + tenlop + "', @tenmon = N''";
                        dgvBangDiem.DataSource = SQLConnect.Instance.ExcecuteQuery(query2);
                        dgvBangDiem.AutoResizeColumns();
                    }
                    else
                    {
                        string query3 = @"EXEC DiemLopData @tenlop = N'" + tenlop + "', @tenmon = N'" + tenmon + "'";
                        dgvBangDiem.DataSource = SQLConnect.Instance.ExcecuteQuery(query3);
                        dgvBangDiem.AutoResizeColumns();
                    }
                }
                else
                {
                    string query2 = @"EXEC ChuyenNganhData @tenchuyennganh , @tenmon ";
                    dgvBangDiem.DataSource = SQLConnect.Instance.ExcecuteQuery(query2, new object[] { tenchuyennganh, tenmon });
                    dgvBangDiem.AutoResizeColumns();
                }      
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string masv = TextBoxtkMaSv.Text;
            if (masv == null || masv == "")
                {
                    MessageBox.Show("Bạn không được để trống mã sinh viên", "Thông báo", MessageBoxButtons.OK);
                dgvBangDiem.DataSource = null;
                }
            if (Search.Instance.KiemtraTimSV(masv) && masv != "" && masv != null)
                {
                    MessageBox.Show("Không tồn tại mã sinh viên mà bạn cần tìm. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                    TextBoxtkMaSv.Text = "";
                dgvBangDiem.DataSource = null;
                }
            if (masv != null && masv != " ")
            {
                dgvBangDiem.DataSource = Search.Instance.TimSV(masv);
            }
        }

        
        private void ComboBoxDsKhoa_MouseClick(object sender, MouseEventArgs e)
        {
            ComboBoxDsKhoa.DataSource = LoadDataCombobox.Instance.DanhSachKhoa();
            ComboBoxDsKhoa.DisplayMember = "tenkhoa";

          
            DataTable DsCN = LoadDataCombobox.Instance.DanhSachChuyenNganh();
            List<string> DsChuyenNganh = new List<string>();
            DsChuyenNganh.Add("(Trống)");
            for(int i=0; i< DsCN.Rows.Count; i++)
            {
                string cn = DsCN.Rows[i][0].ToString();
                DsChuyenNganh.Add(cn);
            }    
            ComboBoxDsNganh.DataSource = DsChuyenNganh;


            string tenchuyennganh = ComboBoxDsNganh.Text;
            DataTable DsLop = LoadDataCombobox.Instance.DanhSachLop(tenchuyennganh);
            List<string> dslop = new List<string>();
            dslop.Add("(Trống)");
            for(int i=0; i< DsLop.Rows.Count; i++)
            {
                string lop = DsLop.Rows[i][0].ToString();
                dslop.Add(lop);
            }
            ComboBoxLop.DataSource = dslop;


            string tenlop = ComboBoxLop.Text;
            DataTable DsMonHoc = LoadDataCombobox.Instance.DanhSachMonHoc(tenlop);
            List<string> dsmonhoc = new List<string>();
            dsmonhoc.Add("(Trống)");
            for (int i = 0; i < DsMonHoc.Rows.Count; i++)
            {
                string mh = DsMonHoc.Rows[i][0].ToString();
                dsmonhoc.Add(mh);
            }
            ComboBoxMonHoc.DataSource = dsmonhoc;
        }

        private void ComboBoxDsNganh_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DsCN = LoadDataCombobox.Instance.DanhSachChuyenNganh();
            List<string> DsChuyenNganh = new List<string>();
            DsChuyenNganh.Add("(Trống)");
            for (int i = 0; i < DsCN.Rows.Count; i++)
            {
                string cn = DsCN.Rows[i][0].ToString();
                DsChuyenNganh.Add(cn);
            }
            ComboBoxDsNganh.DataSource = DsChuyenNganh;
        }

        private void ComboBoxDsNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenchuyennganh = ComboBoxDsNganh.Text;
            DataTable DsLop = LoadDataCombobox.Instance.DanhSachLop(tenchuyennganh);
            List<string> dslop = new List<string>();
            dslop.Add("(Trống)");
            for (int i = 0; i < DsLop.Rows.Count; i++)
            {
                string lop = DsLop.Rows[i][0].ToString();
                dslop.Add(lop);
            }
            ComboBoxLop.DataSource = dslop;


            DataTable DsMonHoc = LoadDataCombobox.Instance.DanhSachMonHoc(tenchuyennganh);
            List<string> dsmonhoc = new List<string>();
            dsmonhoc.Add("(Trống)");
            for (int j = 0; j < DsMonHoc.Rows.Count; j++)
            {
                string mh = DsMonHoc.Rows[j][0].ToString();
                dsmonhoc.Add(mh);
            }
            ComboBoxMonHoc.DataSource = dsmonhoc;
        }


        

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            string ComboboxIdx = comboBox5.SelectedIndex.ToString();
            if (ComboboxIdx == "0")
            {
                string tenkhoa = LabelTenKhoa.Text;
                string query = @"EXEC DiemKhoaData @tenkhoa";
                DataTable data = SQLConnect.Instance.ExcecuteQuery(query, new object[] { tenkhoa });
                DGVDiemKhoa.DataSource = data;
                DGVDiemKhoa.AutoResizeColumns();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Reporting frmreport = new Reporting();
            frmreport.ShowDialog();
        }
    }
}
