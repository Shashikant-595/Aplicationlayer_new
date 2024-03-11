using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaselayer
{
    public class DataAccessRheoservice
    {
        // private static readonly string connectionString = "Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS;Initial Catalog=Mixing;Integrated Security=True";
        private string connectionString = "Data Source=192.168.20.70,1433;Initial Catalog=Mixing;User ID=admin;Password=Fores@123;";

        public void StoreDataInDatabase(string Rheo_Date_Time, string sap, string batch_no, string plant, decimal ml, decimal mh, decimal ts2, decimal tc50, decimal tc90,string datapassdate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                // Construct the MERGE statement
                command.CommandText = @"
                 MERGE INTO " + sap + @" AS target
                 USING (VALUES (@Rheo_Date_Time, @sap, @batch_no, @plant, @ml, @mh, @ts2, @tc50, @tc90,@datapassdate)) AS source (Rheo_Date_Time, sap, batch_no, plant, ml, mh, ts2, tc50, tc90,datapassdate)
                 ON target.batch_no = source.batch_no AND target.plant = source.plant
                 WHEN MATCHED THEN
        UPDATE SET
            target.Reho_Date_Time = source.Rheo_Date_Time,
            target.R_ml = source.ml,
            target.R_mh = source.mh,
            target.R_ts2 = source.ts2,
            target.R_tc50 = source.tc50,
            target.R_tc90 = source.tc90
           
         WHEN NOT MATCHED THEN
        INSERT (Reho_Date_Time, batch_no, plant, R_ml, R_mh, R_ts2, R_tc50, R_tc90,date)
        VALUES (source.Rheo_Date_Time, source.batch_no, source.plant, source.ml, source.mh, source.ts2, source.tc50, source.tc90,source.datapassdate);";

                // Set parameter values
                command.Parameters.AddWithValue("@sap", sap);
                command.Parameters.AddWithValue("@Rheo_Date_Time", Rheo_Date_Time);
                command.Parameters.AddWithValue("@batch_no", batch_no);
                command.Parameters.AddWithValue("@plant", plant);
                command.Parameters.AddWithValue("@ml", ml );
                command.Parameters.AddWithValue("@mh", mh );
                command.Parameters.AddWithValue("@ts2", ts2 * 60);
                command.Parameters.AddWithValue("@tc50", tc50 * 60);
                command.Parameters.AddWithValue("@tc90", tc90 * 60);
                command.Parameters.AddWithValue("@datapassdate", datapassdate);

                // Execute the command
                command.ExecuteNonQuery();
            }
        }

        // second rheo2 machine implementation

        public void StoreRheo2DataInDatabase(string Rheo_Date_Time, string sap, string batch_no, string plant, decimal ml, decimal mh, decimal ts2, decimal tc50, decimal tc90, string datapassdate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();





                // Construct the MERGE statement
                command.CommandText = @"
                MERGE INTO " + sap + @" AS target
                USING (VALUES (@Rheo_Date_Time, @sap, @batch_no, @plant, @ml, @mh, @ts2, @tc50, @tc90,@datapassdate)) AS source (Rheo_Date_Time, sap, batch_no, plant, ml, mh, ts2, tc50, tc90,datapassdate)
                ON target.batch_no = source.batch_no AND target.plant = source.plant
                WHEN MATCHED THEN
                    UPDATE SET
                     target.Reho_Date_Time = source.Rheo_Date_Time,
                     target.R2_ml = source.ml,
                     target.R2_mh = source.mh,
                     target.R2_ts2 = source.ts2,
                     target.R2_tc50 = source.tc50,
                     target.R2_tc90 = source.tc90
           
                WHEN NOT MATCHED THEN
                INSERT (Reho_Date_Time, batch_no, plant, R2_ml, R2_mh, R2_ts2, R2_tc50, R2_tc90,date)
                VALUES (source.Rheo_Date_Time, source.batch_no, source.plant, source.ml, source.mh, source.ts2, source.tc50, source.tc90,source.datapassdate);";

              // Set parameter values
                command.Parameters.AddWithValue("@sap", sap);
                command.Parameters.AddWithValue("@Rheo_Date_Time", Rheo_Date_Time);
                command.Parameters.AddWithValue("@batch_no", batch_no);
                command.Parameters.AddWithValue("@plant", plant);
                command.Parameters.AddWithValue("@ml", ml );
                command.Parameters.AddWithValue("@mh", mh );
                command.Parameters.AddWithValue("@ts2", ts2 * 60);
                command.Parameters.AddWithValue("@tc50", tc50 * 60);
                command.Parameters.AddWithValue("@tc90", tc90 * 60);
                command.Parameters.AddWithValue("@datapassdate", datapassdate);

              // Execute the command
                command.ExecuteNonQuery();
            }
        }





    }
}
