using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd
{
    class SubjectManage
    {
        private static SubjectManage instance;

        internal static SubjectManage Instance 
        {
            get { if (instance == null) instance = new SubjectManage() ; return SubjectManage.instance; }
            private set { instance = value; }
        }
        private SubjectManage() { }

        public bool KiemTraMonHoc(string mamon)
        {
            string query = @"SELECT * FROM dbo.BangMonHoc WHERE mamon = N'"+ mamon  +"'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool SubjectUpdate(string mamon, string tenmon, int tinchi)
        {
            string query = @"EXEC SubjectUpdate @mamon, @tenmonhoc, @tinchi";
            int result = SQLConnect.Instance.ExecuteNoneQuery(query, new object[] { mamon, tenmon, tinchi });

            return result > 0;
        }

    }
}
