using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd
{
    class Account
    {
        private static Account instance;

        internal static Account Instance
        {
            get {if(instance == null) instance = new Account() ; return Account.instance; }
            private set { instance = value; }
        }

        private Account() { }

        public bool Login(string taikhoan, string matkhau)
        {
            string query = @"EXEC USP_Login  @taikhoan , @matkhau";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query, new object[]{ taikhoan , matkhau});

            return result.Rows.Count > 0;
        }
        public string quyen (string taikhoan)
        {
            string query = @"EXEC Quyen  @taikhoan";

            DataTable result = SQLConnect.Instance.ExcecuteQuery(query, new object[]{taikhoan});

            return result.Rows[0][3].ToString();
        }
        public bool DoiMatKhau(string taikhoan, string tennguoidung, string matkhau, string matkhaumoi)
        {
            string query = @"EXEC ChangePassWord @taikhoan , @tennguoidung , @matkhau , @matkhaumoi";
            int result = SQLConnect.Instance.ExecuteNoneQuery(query, new object[] { taikhoan, tennguoidung, matkhau, matkhaumoi });

            return result > 0;
        }

        public string dieuhuong(string taikhoan)
        {
            string query = @"SELECT * FROM dbo.DangNhap WHERE taikhoan = N'" + taikhoan + "'";

            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][3].ToString();
        }
    }
}
