﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }


        private string connectionSTR = @"Data Source=DESKTOP-J24RRH6\SQLEXPRESS;Initial Catalog=QuanLiRapChieuPhim;Integrated Security=True";
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter apdater = new SqlDataAdapter(command);

                apdater.Fill(data);

                connection.Close();
            }
            return data;
        }

        public  int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int dataRow = 0;
            using (System.Data.SqlClient.SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if(parameter!=null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                try
                {
                    dataRow = command.ExecuteNonQuery();
                }
                catch { }

                connection.Close();
            }
            return dataRow;
        }


        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (System.Data.SqlClient.SqlConnection connection = new SqlConnection(connectionSTR))
            {


                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

        string ID;

        public string GetID(string Username)
        {
            SqlDataReader da;
            System.Data.SqlClient.SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Account WHERE Username='"+Username+"'",connection);
            da = cmd.ExecuteReader();
            while (da.Read())
            {
                ID = da.GetValue(2).ToString();
            }   
            return ID;
        }

    }
}
