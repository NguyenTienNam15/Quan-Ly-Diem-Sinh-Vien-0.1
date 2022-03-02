using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd
{
    class AccountInfor
    {
        private static AccountInfor instance;

        internal static AccountInfor Instance
        {
            get { if (instance == null) instance = new AccountInfor(); return AccountInfor.instance; }
            private set { instance = value; }
        }

        private AccountInfor() { }
        public string tentk(string tendangnhap)
        {
            string query = @"SELECT taikhoan, tennguoidung FROM dbo.DangNhap WHERE taikhoan = N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);
            return result.Rows[0][0].ToString();

        }
        public string tennguoidung(string tendangnhap)
        {
            string query = @"SELECT taikhoan, tennguoidung FROM dbo.DangNhap WHERE taikhoan = N'" + tendangnhap + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);
            return result.Rows[0][1].ToString();

        }
    }
}
