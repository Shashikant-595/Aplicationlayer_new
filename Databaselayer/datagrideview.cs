﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databaselayer
{
    public class datagrideview
    {
         //  private string connectionString = "Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS;Initial Catalog=Mixing;Integrated Security=True";
        private string connectionString = "Data Source=192.168.20.70,1433;Initial Catalog=Mixing;User ID=admin;Password=Fores@123;";

        public DataTable GetTableDataForAdvancedGridView()
        {
            DataTable tableData = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("Fetchdatafordatagirde", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(tableData);
                    }
                    catch (Exception ex) {
                    Console.WriteLine(ex.ToString());   
                    }

                    
                }
            }

            return tableData;
        }
    }
}
