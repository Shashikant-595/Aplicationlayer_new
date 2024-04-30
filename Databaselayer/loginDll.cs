using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Databaselayer
{
    public class loginDll
    {

     //   private string connectionString = "Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS;Initial Catalog=Mixing;Integrated Security=True";
        private string connectionString = "Data Source=192.168.20.70,1433;Initial Catalog=Mixing;User ID=admin;Password=Fores@123;";

        public bool ValidateUser( string Name, string password)
        { 
            bool isAuthenticated = false;
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                string query = "SELECT * FROM admin WHERE Name=@Username AND password=@Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Name);
                command.Parameters.AddWithValue("@Password", password);
                Console.WriteLine("connectionString done "+connectionString);
                  connection.Open();
                    Console.WriteLine("connection Open ");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // If any rows are returned, the user is authenticated
                        isAuthenticated = reader.HasRows;
                    }
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("dlll" + ex.Message);
            }

            return isAuthenticated;
        }
    }
}
