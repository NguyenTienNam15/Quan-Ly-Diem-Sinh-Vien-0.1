using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd
{
    class WinformInfor
    {
        private static WinformInfor instance;

        internal static WinformInfor Instance 
        {
            get { if (instance == null) instance = new WinformInfor(); return WinformInfor.instance; }
            private set { instance = value; }
        }

        private WinformInfor() { }

        public string makhoa()
        {
            string query = @"SELECT makhoa FROM dbo.BangKhoa";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][0].ToString();
        }
        public string tenkhoa()
        {
            string query = @"SELECT tenkhoa FROM dbo.BangKhoa";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][0].ToString();
        }

        public string machuyenngang(string malop)
        {
            string query = @"SELECT machuyennganh FROM dbo.BangLop WHERE malop =N'"+ malop +"'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][2].ToString();
        }

        public string tenchuyennganh()
        {
            string query = @"SELECT tenchuyenngang FROM dbo.BangChuyennganh";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][0].ToString();
        }

        public string tenlop()
        {
            string query = @"SELECT tenchuyenngang FROM dbo.BangChuyennganh";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][0].ToString();
        }

        public string malop()
        {
            string query = @"SELECT tenchuyenngang FROM dbo.BangChuyennganh";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows[0][0].ToString();
        }
    }
}
