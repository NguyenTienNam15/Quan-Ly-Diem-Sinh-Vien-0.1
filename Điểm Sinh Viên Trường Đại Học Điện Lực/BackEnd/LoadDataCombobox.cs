using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd
{
    class LoadDataCombobox
    {
        private static LoadDataCombobox instance;

        internal static LoadDataCombobox Instance 
        {
            get {if(instance == null) instance = new LoadDataCombobox() ; return instance; }
            private set { instance = value; }
        }

        private LoadDataCombobox() { }
       
        public DataTable DanhSachKhoa()
        {
            string query = @"SELECT tenkhoa FROM dbo.BangKhoa";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);
            
            return result;
        }

        public DataTable DanhSachChuyenNganh()
        {
            string query = @"SELECT tenchuyennganh FROM dbo.BangChuyennganh";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result;
        }

        public DataTable DanhSachLop(string tenchuyennganh)
        {
            string query = @"SELECT tenlop FROM dbo.BangLop WHERE tenchuyennganh = N'" + tenchuyennganh + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result;
        }

        public DataTable DanhSachMonHocCN(string machuyennganh)
        {
            string query1 = @"SELECT tenmon FROM dbo.BangMonhoc WHERE machuyennganh = N'" + machuyennganh + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query1);

            return result;
        }

        public DataTable DanhSachMonHoc(string tenchuyennganh)
        {
            string query1 = @"SELECT tenmon FROM dbo.BangMonhoc, dbo.BangChuyennganh WHERE dbo.BangMonhoc.machuyennganh = dbo.BangChuyennganh.machuyennganh AND  tenchuyennganh = N'"+tenchuyennganh+"'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query1);

            return result;
        }
        
        public DataTable DanhSachMonHocLop(string tenlop)
        {
            string query1 = @"SELECT tenmon FROM dbo.BangLop, dbo.BangMonhoc WHERE dbo.BangMonhoc.machuyennganh = dbo.BangLop.machuyennganh AND tenlop = N'"+ tenlop +"'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query1);

            return result;
        }
    }
}
