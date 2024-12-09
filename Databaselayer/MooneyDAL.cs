using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Databaselayer
{
    public class MooneyDAL
    {
        //string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        private string connectionString = "Data Source=192.168.20.70,1433;Initial Catalog=Mixing;User ID=admin;Password=Fores@123;";
        //private string connectionString = "Data Source=10.0.0.4,1433;Initial Catalog=Mixing;User ID=Sa;Password=Fores@123;";

        // private string connectionString = "Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS;Initial Catalog=Mixing;Integrated Security=True";
        string machine = "moony"; 
        public bool InsertMooneyRecord(string sapcode, string batch_name, string vimin, string vimax, string vmmin, string vmmax, string ml4min, string ml4max)
        {
            try
            {
              
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("connection done");
                    // Construct your SQL command for insertion
                    string query = "INSERT INTO Master (sapcode, batch_name, vimin, vimax, vmmin, vmmax, ml4min, ml4max,machine) VALUES (@sapcode, @batch_name, @vimin, @vimax, @vmmin, @vmmax, @ml4min, @ml4max,@machine)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@sapcode", sapcode);
                        command.Parameters.AddWithValue("@batch_name", batch_name);
                        command.Parameters.AddWithValue("@vimin", vimin);
                        command.Parameters.AddWithValue("@vimax", vimax);
                        command.Parameters.AddWithValue("@vmmin", vmmin);
                        command.Parameters.AddWithValue("@vmmax", vmmax);
                        command.Parameters.AddWithValue("@ml4min", ml4min);
                        command.Parameters.AddWithValue("@ml4max", ml4max);
                        command.Parameters.AddWithValue("@machine", machine);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("connection rrro");
                // Handle exceptions or log them
                return false;
            }
        }

        //create method to handle next update record get spacode from dropdwon and 
        //select show and update master .
        public List<string> GetColumnValues()
        {
            List<string> columnValues = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectsapcodes = "SELECT sapcode FROM Master WHERE machine = 'moony'";

                using (SqlCommand command = new SqlCommand(selectsapcodes, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Retrieve the value from the 'spacode' column
                            string value = reader.GetString(0); // Assuming spacode is the first column
                            columnValues.Add(value);
                        }
                    }
                }
            }

            // Print the retrieved values to the console
            Console.WriteLine("sapcodes: " + string.Join(", ", columnValues));

            return columnValues;
        }


        //  update the mooney master 
        public SqlDataReader GetBatchDetails(string sapcode)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM master WHERE sapcode = @sapcode", conn);
            cmd.Parameters.AddWithValue("@sapcode", sapcode);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }


        //update mooney master
        public void UpdateMasterRecord(string sapcode, string name, string vih, string vil, string vmh, string vml, string ml4h, string ml4l)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE master SET batch_name=@name, vimin=@vil, vimax=@vih, vmmin=@vml, vmmax=@vmh, ml4min=@ml4l, ml4max=@ml4h WHERE sapcode=@sapcode";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@vil", vil);
                    cmd.Parameters.AddWithValue("@vih", vih);
                    cmd.Parameters.AddWithValue("@vml", vml);
                    cmd.Parameters.AddWithValue("@vmh", vmh);
                    cmd.Parameters.AddWithValue("@ml4l", ml4l);
                    cmd.Parameters.AddWithValue("@ml4h", ml4h);
                    cmd.Parameters.AddWithValue("@sapcode", sapcode);
                    cmd.ExecuteNonQuery();
                }
            }
        }
   

    }
}
