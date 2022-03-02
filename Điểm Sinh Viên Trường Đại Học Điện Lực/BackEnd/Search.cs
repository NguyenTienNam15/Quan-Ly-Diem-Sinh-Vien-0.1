using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd
{
    class Search
    {
        private static Search instance;

        internal static Search Instance 
        {
            get {if(instance == null) instance = new Search() ; return Search.instance; }
            private set { instance = value; }
        }

        private Search() { }

        public DataTable TimSV(string masv)
        {
            string query = @"EXEC dbo.SearchStudent @masv = N'" + masv + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result;
        }
        public bool KiemtraTimSV(string masv)
        {
            string query = @"EXEC dbo.SearchStudent @masv = N'" + masv + "'";
            DataTable result = SQLConnect.Instance.ExcecuteQuery(query);

            return result.Rows.Count < 1;
        }

    }
}
