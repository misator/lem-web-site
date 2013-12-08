using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class UserModel
    {
        private string ConnStr = "";
        public List<String> GetGameNames()
        {
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.Open();

            SqlCommand command = Conn.CreateCommand();
            command.CommandText = "Select Name From Game";


            SqlDataReader reader = command.ExecuteReader();
            List<String> name = new List<string>();


            while (reader.Read())
            {
                name.Add(reader["emails"].ToString());
            }
            return name;
        }

        public int GetGameNumbers()
        {
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.Open();

            SqlCommand command = Conn.CreateCommand();
            command.CommandText = "Select Count(*) From Game";


            int count = Convert.ToInt32(command.ExecuteScalar());

            return count;
        }


        public int GetUserIdByYear(int year)
        {
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.Open();

            SqlCommand command = Conn.CreateCommand();
            command.CommandText = "Select Name From Games where year=" + year;

            int id = Convert.ToInt32(command.ExecuteScalar());
            return id;

        }

    }
}