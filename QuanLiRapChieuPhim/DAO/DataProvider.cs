using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            
            private set { instance = value; }
        }

        private DataProvider() { }

        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiRapChieuPhim;Integrated Security=True";

        public DataTable ExcuteQuery(string query, object[] paramter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (paramter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramter[i]);
                            i++;
                        }
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                
                connection.Close();
            }

            return data;
        }

        public int ExcuteNonQuery(string query, object[] paramter = null)
        {
            int dataRow = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (paramter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramter[i]);
                            i++;
                        }
                }

                dataRow = command.ExecuteNonQuery();

                connection.Close();
            }

            return dataRow;
        }

        public object ExcuteScalar(string query, object[] paramter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (paramter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramter[i]);
                            i++;
                        }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

    }
}