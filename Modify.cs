using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PBL3_1._0_
{
    class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand; // truy van
        SqlDataReader dataReader; // doc du lieu
        public List<TaiKhoan> TaiKhoans(String query)
        {
            List<TaiKhoan> taikhoans = new List<TaiKhoan>();

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    taikhoans.Add(new TaiKhoan(dataReader.GetString(1), dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return taikhoans;

        }
        //thay doi doi thay thay doi
        
        

        public void Command(string query) // dung dang ki tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); // thuc thi cau truy van
                sqlConnection.Close();
            }
        }
    }
}
