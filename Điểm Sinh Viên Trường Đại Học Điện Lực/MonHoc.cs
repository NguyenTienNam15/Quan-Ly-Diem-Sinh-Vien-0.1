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
using System.Windows.Forms.VisualStyles;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực
{
    public partial class MonHoc : Form
    {

        private string ID;
        public MonHoc()
        {
            InitializeComponent();
        }

        public string Temp
        {
            get { return ID; }
            set { ID = value; }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (TextAddBoxMaMonHoc.Text == null || TextAddBoxMaMonHoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã môn học", "Thông báo", MessageBoxButtons.OK);
            }
            else {
                string mamon = TextAddBoxMaMonHoc.Text;
                if (SubjectManage.Instance.KiemTraMonHoc(mamon) == true)
                {
                    groupBox3.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai mã môn học", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mamon = textBoxMaMon.Text;
            string tenmon = textBoxTenMon.Text;
            int tinchi = Convert.ToInt32(TinChi.Value.ToString());
            if (SubjectManage.Instance.SubjectUpdate(mamon, tenmon, tinchi) == true)
            {
                MessageBox.Show("Thay đổi môn học thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void MonHoc_Load(object sender, EventArgs e)
        {
            string query = @"SELECT mamon AS[Mã môn học], tenmon AS[Tên môn học], tinchi AS[Tín chỉ] FROM dbo.BangMonhoc WHERE machuyennganh = N'" + ID +"'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            DGVMonHoc.DataSource = result;
            DGVMonHoc.AutoResizeColumns();
        }

        
    }
}
