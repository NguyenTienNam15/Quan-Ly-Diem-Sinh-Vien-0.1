using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd
{
    class StudentInfor
    {
        private static StudentInfor instance;

        internal static StudentInfor Instance
        {
            get {if(instance == null) instance = new  StudentInfor() ; return StudentInfor.instance; }
            private set { instance = value; }
        }

        private StudentInfor() { }

        public string masv(string tendangnhap)
        {
            string query = @"EXEC GetSinhVienInfor @taikhoan = N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][0].ToString();
        }
        public string tensv(string tendangnhap)
        {
            string query = @"EXEC GetSinhVienInfor @taikhoan = N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][1].ToString();
        }
        public string gioitinh(string tendangnhap)
        {
            string query = @"EXEC GetSinhVienInfor @taikhoan = N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][2].ToString();
        }
        public string ngaysinh(string tendangnhap)
        {
            string query = @"EXEC GetSinhVienInfor @taikhoan = N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][3].ToString();
        }
        public string tongiao(string tendangnhap)
        {
            string query = @"EXEC GetSinhVienInfor @taikhoan = N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][4].ToString();
        }
        public string tenlop(string tendangnhap)
        {
            string query = @"EXEC GetSinhVienInfor @taikhoan = N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][5].ToString();
        }
        public string tenchuyennganh(string tendangnhap)
        {
            string query = @"EXEC GetSinhVienInfor @taikhoan = N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][6].ToString();
        }
        public string tenkhoa(string tendangnhap)
        {
            string query = @"EXEC GetSinhVienInfor @taikhoan = N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][7].ToString();
        }

        public string Diemtbhe10(string tendangnhap)
        { 
            string query = @"EXEC GetSinhVienInfor @taikhoan=N'"+ tendangnhap +"'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][8].ToString();
        }

        public string Diemtbhe4(string tendangnhap)
        {
            string query = @"EXEC GetSinhVienInfor @taikhoan=N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][9].ToString();
        }

        public string Tinchi(string tendangnhap)
        {
            string query = @"EXEC GetSinhVienInfor @taikhoan=N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][10].ToString();
        }

    }
}
