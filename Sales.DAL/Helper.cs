using Sales.DAL.models;
using System.Data;
using System.Data.SqlClient;

namespace Sales.DAL
    {
    public static class Helper
        {
        static SqlConnection sqlcon;

        //constarctor
        static Helper()
            {
            sqlcon = new SqlConnection("server=DESKTOP-PHREQO0\\SQLEXPRESS;Database=Sales;Integrated Security=true; Encrypt=false");

            }
        // method 1 select

        public static bool ExecuteDml(string command)
            {

            using (SqlCommand sqlCommand = new SqlCommand(command, sqlcon))
                {
                sqlcon.Open();
                int numrowsAfected = sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                return numrowsAfected > 0;
                }

            }

        // method 2 get

        public static DataTable ExcuteSelect(string query)
            {
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlcon))
                {
                using (SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlCommand))
                    {
                    DataTable Dtbl = new DataTable();
                    sqldataadapter.Fill(Dtbl);
                    return Dtbl;
                    }
                }
            }


        }
    }
