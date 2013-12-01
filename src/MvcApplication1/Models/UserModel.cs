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
    public  List<String> GetUserNames()
    {
        SqlConnection Conn = new SqlConnection (ConnStr);
        Conn.Open();

        SqlCommand command = Conn.CreateCommand();
        command.CommandText = "Select Email From User";

        
        SqlDataReader reader = command.ExecuteReader();
        List<String> emails = new List<string>();
        
        
       while (reader.Read())
        {
           emails.Add(reader["emails"].ToString());
        }
        return emails;
    }

     public int GetUserNumbers()
     {
             SqlConnection Conn = new SqlConnection (ConnStr);
                Conn.Open(); 

                SqlCommand command = Conn.CreateCommand();
                command.CommandText = "Select Count(*) From User";

        
                int count = Convert.ToInt32( command.ExecuteScalar());

         return count;
    }
}