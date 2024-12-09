using Databaselayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Timers;


namespace Businesslayer
{

  
    public class RheometerService
    {
        private static readonly DataAccessRheoservice dataAccess = new DataAccessRheoservice();
        private readonly FileSystemWatcher watcher = new FileSystemWatcher();
        private readonly Timer timer = new Timer();
        string plantNo;
        string machine;
        string datapassdate;
        public RheometerService()
        {
            var configurationValues = ConfigurationHandler.ReadConfigurationFile();

            // Extract PlantNo and Machine values
            plantNo = configurationValues[4]; // Index 4 corresponds to PlantNo
            machine = configurationValues[5]; // Index 5 corresponds to Machine

            // Start the file watcher
            StartFileWatcher();

            // Initialize and start the timer
            timer.Interval = 10000; // Adjust interval as needed (in milliseconds)
            timer.AutoReset = true;
            timer.Elapsed += TimerElapsed;
            timer.Start();
            DateTime date1 = DateTime.Now;

            // Define the format pattern
            string format = "yyyy-MM-dd HH:mm";

            // Format the date and time
            datapassdate = date1.ToString(format);
            
        }

        public void StartFileWatcher()
        {
            // Specify the directory to watch
            string directoryPath = @"C:\ProgramData\HEVEA\RHmeter\1.0.0.0";
            string fileName = "TestResults.csv";
            
            Console.WriteLine("send to sap ");
            // Configure the FileSystemWatcher
            watcher.Path = directoryPath;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = fileName;

            // Add event handlers
            watcher.Changed += OnFileChanged;

            // Start watching
            watcher.EnableRaisingEvents = true;
        }

        public void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            // Reset the timer upon file change event
            timer.Stop();
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                // Implement your logic to read and process the file changes
                string filePath = Path.Combine(watcher.Path, watcher.Filter);

                // Read the last 100 lines from the file
                string[] lines = File.ReadLines(filePath)
                                     .Reverse()
                                     .Take(10)
                                     .ToArray();

                foreach (string line in lines)
                {
                    Console.WriteLine("line======" + line);

                    try
                    {
                        // Process each line as needed
                        string[] fields = line.Split('~');
                        string Rheo_Date_Time= fields[3];
                        string sapcode = fields[4].Trim();
                        string batchNo = fields[5].Trim();
                        decimal ml, mh, ts2, tc50, tc90;
                        if (!decimal.TryParse(fields[14].Trim(), out ml))
                        {
                            // Handle parsing failure or empty field for fields[14]


                        }
                        if (!decimal.TryParse(fields[15].Trim(), out mh))
                        {
                            // Handle parsing failure or empty field for fields[15]



                        }
                        if (!decimal.TryParse(fields[18].Trim(), out ts2))
                        {
                            // Handle parsing failure or empty field for fields[18]


                        }
                        if (!decimal.TryParse(fields[20].Trim(), out tc50))
                        {
                            // Handle parsing failure or empty field for fields[20]


                        }
                        if (!decimal.TryParse(fields[21].Trim(), out tc90))
                        {
                            // Handle parsing failure or empty field for fields[21]


                        }


                       // Console.WriteLine($"Sapcode: {sapcode}, Rheo_Date_Time:{Rheo_Date_Time} Batch No: {batchNo}");

                        // Call a method to handle each line of data
                        //  dataAccess.StoreDataInDatabase(sapcode, batchNo, ml, mh, ts2, tc50, tc90);
                        if (machine.Equals("Rheo"))
                        {
                            try
                            {
                               // Console.WriteLine("for 1 machine method called ");
                                dataAccess.StoreDataInDatabase(Rheo_Date_Time, sapcode, batchNo, plantNo, ml, mh, ts2, tc50, tc90, datapassdate);
                                
                                Console.WriteLine("for rheo1 method is called ");
                            }
                            catch (Exception ex){ 
                            Console.WriteLine (ex.Message); 
                          
                            }
                           
                        }
                        else if (machine.Equals("Rheo2"))
                        {
                            String machineName;
                            String queryType;
                            List<object[]> datalist = new List<object[]>();
                            StringBuilder message = new StringBuilder();
                            StringBuilder Rejection = new StringBuilder();
                            // if second rheo values are arises then first call the batchmaster data and compere data and update direct status 
                            (machineName, queryType, datalist) = Entryscreendll.GetBatchmaster(sapcode);

                            // Iterate through dataList and process each row
                            foreach (object[] row in datalist)
                            {
                                      

                               
                                double mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardmin, hrdmax, sgmin, sgmax;
                                double mld, mhd, ts2d, tc50d, tc90d;
                                // Parse string values to doubles
                                double.TryParse(row[2]?.ToString(), out mlmin);
                                double.TryParse(row[3]?.ToString(), out mlmax);
                                double.TryParse(row[4]?.ToString(), out mhmin);
                                double.TryParse(row[5]?.ToString(), out mhmax);
                                double.TryParse(row[6]?.ToString(), out ts2min);
                                double.TryParse(row[7]?.ToString(), out ts2max);
                                double.TryParse(row[8]?.ToString(), out tc50min);
                                double.TryParse(row[9]?.ToString(), out tc50max);
                                double.TryParse(row[10]?.ToString(), out tc90min);
                                double.TryParse(row[11]?.ToString(), out tc90max);

                                double.TryParse(ml.ToString(), out mld);
                                double.TryParse(mh.ToString(), out mhd);
                                double.TryParse(ts2.ToString(), out ts2d);
                                double.TryParse(tc50.ToString(), out tc50d);
                                double.TryParse(tc90.ToString(), out tc90d);
                             
                                bool mlMinOk = mld >= mlmin && mld <= mlmax;
                                bool mhOk = mhd >= mhmin && mhd <= mhmax;
                                bool ts2Ok = ts2d >= ts2min && ts2d <= ts2max;
                                bool tc50Ok = tc50d >= tc50min && tc50d <= tc50max;
                                bool tc90Ok = tc90d >= tc90min && tc90d <= tc90max;
                               
                                if (mlMinOk == true)
                                {
                                    message.Append("ML is = ✓.\n");
                                }
                                if (mlMinOk == false)
                                {
                                    message.Append("ML is= ✗.\n");
                                    Rejection.Append("R1,");
                                }
                                if (mhOk == true)
                                {
                                    message.Append("MH is = ✓.\n");
                                }
                                if (mhOk == false)
                                {
                                    message.Append("MH is = ✗.\n");
                                    Rejection.Append("R2,");
                                }
                                if (ts2Ok == true)
                                {
                                    message.Append("Ts2 is = ✓.\n");
                                }
                                if (ts2Ok == false)
                                {
                                    message.Append("TS2 is = ✗.\n");
                                    Rejection.Append("R3,");
                                }
                                if (tc50Ok == true)
                                {
                                    message.Append("TC50 is = ✓.\n");
                                }
                                if (tc50Ok == false)
                                {
                                    message.Append("TC50 is = ✗.\n");
                                    Rejection.Append("R4,");
                                }
                                if (tc90Ok == true)
                                {
                                    message.Append("TC90 is = ✓.\n");
                                }
                                if (tc90Ok == false)
                                {
                                    message.Append("TC90 is = ✗.\n");
                                    Rejection.Append("R5,");
                                }
                                if (
                                     mld >= mlmin && mld <= mlmax
                                    && mhd >= mhmin && mhd <= mhmax
                                    && ts2d >= ts2min && ts2d <= ts2max
                                    && tc50d >= tc50min && tc50d <= tc50max
                                    && tc90d >= tc90min && tc90d <= tc90max)
                                {

                                    
                                    Console.WriteLine("plant======" + plantNo);
                                    string Message = "OK";
                                    // for update query with okk status 
                                    Entryscreendll.updateRecords(sapcode, batchNo,  plantNo, Message);
                                    Console.WriteLine("method exicuted ");
                                }
                                else
                                {
                                   

                                    string PassRejection = Rejection.ToString();
                                    Entryscreendll.updateRheo2rejection(sapcode, batchNo, plantNo, PassRejection);

                                }
                                // call the above parameter for validate  

                            }

                            Console.WriteLine("row data is " + Rheo_Date_Time, sapcode, batchNo, plantNo, ml, mh, ts2, tc50, tc90, datapassdate);
                            try
                            {
                                dataAccess.StoreRheo2DataInDatabase(Rheo_Date_Time, sapcode, batchNo, plantNo, ml, mh, ts2, tc50, tc90, datapassdate);
                                Console.WriteLine("calleddddddddddddddddddddddddddddd is " );
                            }
                            catch (Exception ex) { 
                            Console.WriteLine("ezxxxx is "+ex.StackTrace);
                            }
                            
                        }


                       
                    }
                    catch (FormatException ex)
                    {
                        // Handle parsing errors
                        Console.WriteLine($"Error parsing lin: {line}. {ex.StackTrace}");
                        // You can choose to skip the line or take other appropriate action
                    }

                }
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"Error processing line:  {ex.StackTrace}");
            }

        }

    }

}