﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Databaselayer
{
    public class RheoDll
    {
       // private string connectionString = "Data Source=10.0.0.4,1433;Initial Catalog=Mixing;User ID=Sa;Password=Fores@123;";

        private string connectionString = "Data Source=192.168.20.70,1433;Initial Catalog=Mixing;User ID=admin;Password=Fores@123;";

       // private string connectionString = "Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS;Initial Catalog=Mixing;Integrated Security=True";
        string machine = "rheo";
        public bool insertRheorecord(string sapcode, string batch_name, string mlmin, string mlmax, string mhmin, string mhmax, string ts2min, string ts2max, string tc50min, string tc50max, string tc90min, string tc90max,string hardnessmin, string hardnessmax,string specificgravitymin,string specificgravitymax, string conductivitymin, string conductivitymax)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("connection done");
                    // Construct your SQL command for insertion
                    string query = "INSERT INTO Master (sapcode, batch_name, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max,tc50min,tc50max,tc90min,tc90max,hardnessmin,hardnessmax,specificgravitymin,specificgravitymax,conductivitymin,conductivitymax,machine) VALUES (@sapcode, @batch_name, @mlmin, @mlmax, @mhmin, @mhmax, @ts2min, @ts2max,@tc50min,@tc50max,@tc90min,@tc90max,@hrdmin,@hrdmax,@spgravitymin,@spgravitymax,@conductivitymin,@conductivitymax,@machine)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@sapcode", sapcode);
                        command.Parameters.AddWithValue("@batch_name", batch_name);
                        command.Parameters.AddWithValue("@mlmin", mlmin);
                        command.Parameters.AddWithValue("@mlmax", mlmax);
                        command.Parameters.AddWithValue("@mhmin", mhmin);
                        command.Parameters.AddWithValue("@mhmax", mhmax);
                        command.Parameters.AddWithValue("@ts2min", ts2min);
                        command.Parameters.AddWithValue("@ts2max", ts2max);
                        command.Parameters.AddWithValue("@tc50min", tc50min);
                        command.Parameters.AddWithValue("@tc50max", tc50max);
                        command.Parameters.AddWithValue("@tc90min", tc90min);
                        command.Parameters.AddWithValue("@tc90max", tc90max);
                        command.Parameters.AddWithValue("@hrdmin", hardnessmin);
                        command.Parameters.AddWithValue("@hrdmax", hardnessmax);
                        command.Parameters.AddWithValue("@spgravitymin", specificgravitymin);
                        command.Parameters.AddWithValue("@spgravitymax", specificgravitymax);
                        command.Parameters.AddWithValue("@conductivitymin", conductivitymin);
                        command.Parameters.AddWithValue("@conductivitymax", conductivitymax);
                        command.Parameters.AddWithValue("@machine", machine);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
                return true;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("connection rrro");
                // Handle exceptions or log them
                return false;
            }
        }


        //
        public List<string> getrheoSap()
        {
            List<string> columnValues = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectsapcodes = "SELECT sapcode FROM Master WHERE machine = 'rheo'";

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
        public bool updateRheo(string sapcode, string batch_name, string mlmin, string mlmax, string mhmin, string mhmax, string ts2min, string ts2max, string tc50min, string tc50max, string tc90min, string tc90max, string hardnessmin, string hardnessmax, string specificgravitymin, string specificgravitymax, string conductivitymin, string conductivitymax)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("connection okkk");
                    string query = "UPDATE master SET  batch_name = @batch_name, mlmin = @mlmin , mlmax =  @mlmax, mhmin = @mhmin , mhmax = @mhmax , ts2min = @ts2min, ts2max = @ts2max,tc50min = @tc50min ,tc50max = @tc50max,tc90min = @tc90min,tc90max=@tc90max,hardnessmin=@hrdmin,hardnessmax = @hrdmax, specificgravitymin = @spgravitymin,specificgravitymax = @spgravitymax,conductivitymin = @conmin,conductivitymax = @conmax WHERE sapcode=@sapcode";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@batch_name", batch_name);
                        cmd.Parameters.AddWithValue("@mlmin", mlmin);
                        cmd.Parameters.AddWithValue("@mlmax", mlmax);
                        cmd.Parameters.AddWithValue("@mhmin", mhmin);
                        cmd.Parameters.AddWithValue("@mhmax", mhmax);
                        cmd.Parameters.AddWithValue("@ts2min", ts2min);
                        cmd.Parameters.AddWithValue("@ts2max", ts2max);
                        cmd.Parameters.AddWithValue("@tc50min", tc50min);
                        cmd.Parameters.AddWithValue("@tc50max", tc50max);
                        cmd.Parameters.AddWithValue("@tc90min", tc90min);
                        cmd.Parameters.AddWithValue("@tc90max", tc90max);
                        cmd.Parameters.AddWithValue("@hrdmin", hardnessmin);
                        cmd.Parameters.AddWithValue("@hrdmax", hardnessmax);
                        cmd.Parameters.AddWithValue("@spgravitymin", specificgravitymin);
                        cmd.Parameters.AddWithValue("@spgravitymax", specificgravitymax);
                        cmd.Parameters.AddWithValue("@conmin", conductivitymin);
                        cmd.Parameters.AddWithValue("@conmax", conductivitymax);
                        cmd.Parameters.AddWithValue("@sapcode", sapcode);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);  
            }

            return true;
        }

        public SqlDataReader getBatchdataRheo(string sapcode)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM master WHERE sapcode = @sapcode", conn);
            cmd.Parameters.AddWithValue("@sapcode", sapcode);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}