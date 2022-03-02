using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Điểm_Sinh_Viên_Trường_Đại_Học_Điện_Lực.BackEnd
{
    class SQLConnect
    {
        private static SQLConnect instance;
        private string DataBaseConnect = @"Data Source=DESKTOP-CCFIGBC\SQLEXPRESS;Initial Catalog=DiemSinhVien;Integrated Security=True";
        internal static SQLConnect Instance
        {
            get { if (instance == null) instance = new SQLConnect(); return SQLConnect.instance; }
            private set { SQLConnect.instance = value; }
        }
        private SQLConnect() { }

        public DataTable ExcecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(DataBaseConnect))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if(parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string items in listpara)
                    {
                        if (items.Contains('@'))
                        {
                            command.Parameters.AddWithValue(items, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
        }

        
        public int ExecuteNoneQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connect = new SqlConnection(DataBaseConnect))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string items in listpara)
                    {
                        if (items.Contains('@'))
                        {
                            command.Parameters.AddWithValue(items, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connect.Close();
            }
            return data;
        }
        public object ExcecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connect = new SqlConnection(DataBaseConnect))
            {
                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string items in listpara)
                    {
                        if (items.Contains('@'))
                        {
                            command.Parameters.AddWithValue(items, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connect.Close();
            }

            return data;
        }
    }
}
