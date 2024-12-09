using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Databaselayer
{
    public  class Saptranfer
    {
        private static string connectionString = "Data Source=192.168.20.70,1433;Initial Catalog=Mixing;User ID=admin;Password=Fores@123;";
        public static void sendTosap(string sapcode,string batchno, double ml, double mh, double ts2, double tc50, double tc90, double hrd, double grt, double wt ,string plant, string testDate)
        {
            string originalbatch= batchno.Substring(0,12);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("connection done");
                    // Construct your SQL command for insertion
                    string query = "INSERT INTO sapTranfer (sapcode, batchno, ml, mh, ts2, tc50, tc90, hrd ,grt , wt ,plant, testDate) VALUES (@sapcode, @batchno, @ml, @mh, @ts2, @tc50, @tc90, @hrd , @grt , @wt, @plant,@testDate )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@sapcode", sapcode);
                        command.Parameters.AddWithValue("@batchno", originalbatch);
                        command.Parameters.AddWithValue("@ml", ml);
                        command.Parameters.AddWithValue("@mh", mh);
                        command.Parameters.AddWithValue("@ts2", ts2);
                        command.Parameters.AddWithValue("@tc50", tc50);
                        command.Parameters.AddWithValue("@tc90", tc90);
                        command.Parameters.AddWithValue("@hrd", hrd);
                        command.Parameters.AddWithValue("@grt", grt);
                        command.Parameters.AddWithValue("@wt", wt);
                        command.Parameters.AddWithValue("@plant", plant);
                        command.Parameters.AddWithValue("@testDate", testDate);
                       
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("error to send sap transferrrrrrrrrr"+ex.Message);
                Console.WriteLine("connection rrro");
                // Handle exceptions or log them
                
            }

        }

        public static void sendTosap(string sapcode, string batchno, double ml, double mh, double ts2, double tc50, double tc90, double hrd, double grt, double wt, double ml4, string plant,string testDate)
        {
            string originalbatch = batchno.Substring(0, 12);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("connection done");
                    // Construct your SQL command for insertion
                    string query = "INSERT INTO sapTranfer (sapcode, batchno, ml, mh, ts2, tc50, tc90, hrd, grt, wt, ml4, plant,testDate) VALUES (@sapcode, @batchno, @ml, @mh, @ts2, @tc50, @tc90, @hrd , @grt , @wt, @ml4, @plant, @testDate )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@sapcode", sapcode);
                        command.Parameters.AddWithValue("@batchno", originalbatch);
                        command.Parameters.AddWithValue("@ml", ml);
                        command.Parameters.AddWithValue("@mh", mh);
                        command.Parameters.AddWithValue("@ts2", ts2);
                        command.Parameters.AddWithValue("@tc50", tc50);
                        command.Parameters.AddWithValue("@tc90", tc90);
                        command.Parameters.AddWithValue("@hrd", hrd);
                        command.Parameters.AddWithValue("@grt", grt);
                        command.Parameters.AddWithValue("@wt", wt);
                        command.Parameters.AddWithValue("@ml4", ml4);
                        command.Parameters.AddWithValue("@plant", plant);
                        command.Parameters.AddWithValue("@testDate", testDate);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error to send sap transferrrrrrrrrr" + ex.Message);
                Console.WriteLine("connection rrro");
                // Handle exceptions or log them

            }



        }

    }
}
