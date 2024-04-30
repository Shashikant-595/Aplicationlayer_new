using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Databaselayer
{
    public class Entryscreendll
    {
      //   private static string connectionString = "Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS;Initial Catalog=Mixing;Integrated Security=True";
        private static string connectionString = "Data Source=192.168.20.70,1433;Initial Catalog=Mixing;User ID=admin;Password=Fores@123;";

        public static (string machineName, string queryType, List<object[]> dataList) RetrieveDataFromTable(string sapCode, string batchNo)
        {
            string machineName = "";
            string queryType = "";
            List<object[]> dataList = new List<object[]>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("RetrieveDataFromTables", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SapCode", sapCode);
                    command.Parameters.AddWithValue("@BatchNo", batchNo);

                    // Output parameters
                    SqlParameter machineNameParam = command.Parameters.Add("@MachineName", SqlDbType.NVarChar, 50);
                    machineNameParam.Direction = ParameterDirection.Output;

                    SqlParameter queryTypeParam = command.Parameters.Add("@QueryType", SqlDbType.NVarChar, 50);
                    queryTypeParam.Direction = ParameterDirection.Output;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Retrieve output parameters
                        machineName = machineNameParam.Value.ToString();
                        queryType = queryTypeParam.Value.ToString();

                        // Populate dataList with attribute values
                        foreach (DataRow row in dataTable.Rows)
                        {
                            object[] rowData = row.ItemArray; // Get all values in the row as an array
                            dataList.Add(rowData);
                        }
                    }
                }
            }

            return (machineName, queryType, dataList);
        }

        //create second methode to validate the master parameters with manual parameters.
        public static (string machineName, string queryType, List<object[]> dataList) GetBatchmaster(string sapCode)
        {
            string machineName = "";
            string queryType = "";
            List<object[]> dataList = new List<object[]>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("BatchQuality_master", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input parameter
                    command.Parameters.AddWithValue("@sapcode", sapCode);

                    // Output parameters
                    SqlParameter machineNameParam = command.Parameters.Add("@MachineName", SqlDbType.NVarChar, 50);
                    machineNameParam.Direction = ParameterDirection.Output;

                    SqlParameter queryTypeParam = command.Parameters.Add("@QueryType", SqlDbType.NVarChar, 50);
                    queryTypeParam.Direction = ParameterDirection.Output;

                    // Execute the command
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Retrieve output parameters
                        machineName = machineNameParam.Value.ToString();
                        queryType = queryTypeParam.Value.ToString();
                        Console.WriteLine("dllmachine" + machineName);
                        Console.WriteLine("dllmachine" + queryType);

                        // Convert DataTable to List<object[]>
                        foreach (DataRow row in dataTable.Rows)
                        {
                            dataList.Add(row.ItemArray);
                        }
                    }
                }
            }

            return (machineName, queryType, dataList);
        }
        // create single method and according to its parameters overloading  it 
        public static void updateRecords(String sapcode, String Batch_no, double h1, double h2, double h3, double h4, double sg, double wt, double dt, string plant, string message)
        {
            // record without conductivity

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE " + sapcode + "  SET Hardness_1 = @h1, Hardness_2 = @h2, Hardness_3 = @h3, Hardness_4 = @h4,  SpecificGravity = @sg, Dump_Temp = @dt,Batch_Weight = @wt, status = @message WHERE Batch_No = @Batch_no AND plant = @plant";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SQL command
                    command.Parameters.AddWithValue("@h1", h1);
                    command.Parameters.AddWithValue("@h2", h2);
                    command.Parameters.AddWithValue("@h3", h3);
                    command.Parameters.AddWithValue("@h4", h4);

                    command.Parameters.AddWithValue("@sg", sg);
                    command.Parameters.AddWithValue("@dt", dt);
                    command.Parameters.AddWithValue("@wt", wt);
                    command.Parameters.AddWithValue("@Batch_no", Batch_no);
                    command.Parameters.AddWithValue("@plant", plant);
                    command.Parameters.AddWithValue("@message", message);

                    try
                    {
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                        Console.WriteLine("Error updating records: " + ex.Message);
                    }
                }
            }

        }
        public static void updateRecords(string sapcode, string Batch_no, double h1, double h2, double h3, double h4, double c1, double c2, double c3, double c4, double sg, double wt, double dt, string plant, string message)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE " + sapcode + "  SET Hardness_1 = @h1, Hardness_2 = @h2, Hardness_3 = @h3, Hardness_4 = @h4, Conductivity_1 = @c1, Conductivity_2 = @c2, Conductivity_3 = @c3, Conductivity_4 = @c4, SpecificGravity = @sg, Dump_Temp = @dt,Batch_Weight = @wt, status = @message WHERE Batch_No = @Batch_no AND plant = @plant";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SQL command
                    command.Parameters.AddWithValue("@h1", h1);
                    command.Parameters.AddWithValue("@h2", h2);
                    command.Parameters.AddWithValue("@h3", h3);
                    command.Parameters.AddWithValue("@h4", h4);
                    command.Parameters.AddWithValue("@c1", c1);
                    command.Parameters.AddWithValue("@c2", c2);
                    command.Parameters.AddWithValue("@c3", c3);
                    command.Parameters.AddWithValue("@c4", c4);
                    command.Parameters.AddWithValue("@sg", sg);
                    command.Parameters.AddWithValue("@dt", dt);
                    command.Parameters.AddWithValue("@wt", wt);
                    command.Parameters.AddWithValue("@Batch_no", Batch_no);
                    command.Parameters.AddWithValue("@plant", plant);
                    command.Parameters.AddWithValue("@message", message);

                    try
                    {
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                        Console.WriteLine("Error updating records: " + ex.Message);
                    }
                }
            }
        }
        public static void updateRecordswithrejection(String sapcode, String Batch_no, double h1, double h2, double h3, double h4, double sg, double wt, double dt, string plant, string message)
        {
            // record without conductivity

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE " + sapcode + "  SET Hardness_1 = @h1, Hardness_2 = @h2, Hardness_3 = @h3, Hardness_4 = @h4,  SpecificGravity = @sg, Dump_Temp = @dt,Batch_Weight = @wt, status = @message WHERE Batch_No = @Batch_no AND plant = @plant";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SQL command
                    command.Parameters.AddWithValue("@h1", h1);
                    command.Parameters.AddWithValue("@h2", h2);
                    command.Parameters.AddWithValue("@h3", h3);
                    command.Parameters.AddWithValue("@h4", h4);

                    command.Parameters.AddWithValue("@sg", sg);
                    command.Parameters.AddWithValue("@dt", dt);
                    command.Parameters.AddWithValue("@wt", wt);
                    command.Parameters.AddWithValue("@Batch_no", Batch_no);
                    command.Parameters.AddWithValue("@plant", plant);
                    command.Parameters.AddWithValue("@message", message);

                    try
                    {
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                        Console.WriteLine("Error updating records: " + ex.Message);
                    }
                }
            }

        }
        public static void updateRecordswithrejection(string sapcode, string Batch_no, double h1, double h2, double h3, double h4, double c1, double c2, double c3, double c4, double sg, double wt, double dt,  string plant, string message)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE " + sapcode + "  SET Hardness_1 = @h1, Hardness_2 = @h2, Hardness_3 = @h3, Hardness_4 = @h4, Conductivity_1 = @c1, Conductivity_2 = @c2, Conductivity_3 = @c3, Conductivity_4 = @c4, SpecificGravity = @sg, Dump_Temp = @dt,Batch_Weight = @wt, status = @message WHERE Batch_No = @Batch_no AND plant = @plant";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SQL command
                    command.Parameters.AddWithValue("@h1", h1);
                    command.Parameters.AddWithValue("@h2", h2);
                    command.Parameters.AddWithValue("@h3", h3);
                    command.Parameters.AddWithValue("@h4", h4);
                    command.Parameters.AddWithValue("@c1", c1);
                    command.Parameters.AddWithValue("@c2", c2);
                    command.Parameters.AddWithValue("@c3", c3);
                    command.Parameters.AddWithValue("@c4", c4);
                    command.Parameters.AddWithValue("@sg", sg);
                    command.Parameters.AddWithValue("@dt", dt);
                    command.Parameters.AddWithValue("@wt", wt);
                    command.Parameters.AddWithValue("@Batch_no", Batch_no);
                    command.Parameters.AddWithValue("@plant", plant);
                    command.Parameters.AddWithValue("@message", message);

                    try
                    {
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                        Console.WriteLine("Error updating records: " + ex.Message);
                    }
                }
            }
        }

        public static void updateRecords(String sapcode, string batchno, string plant, string message)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE " + sapcode + "  SET  status = @message WHERE Batch_No = @Batch_no AND plant = @plant";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SQL command

                    
                    command.Parameters.AddWithValue("@Batch_no", batchno);
                    command.Parameters.AddWithValue("@plant", plant);
                    command.Parameters.AddWithValue("@message", message);

                    try
                    {
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                        Console.WriteLine("Error updating records: " + ex.Message);
                    }
                }
            }
        }

        public static void updateRheo2rejection(String sapcode, string batchno, string plant, string message)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE " + sapcode + "  SET status = @message WHERE Batch_No = @Batch_no AND plant = @plant";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                  
                   
                    command.Parameters.AddWithValue("@Batch_no", batchno);
                    command.Parameters.AddWithValue("@plant", plant);
                    command.Parameters.AddWithValue("@message", message);

                    try
                    {
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                        Console.WriteLine("Error updating records: " + ex.Message);
                    }


                }

            }
        }
    }
}
