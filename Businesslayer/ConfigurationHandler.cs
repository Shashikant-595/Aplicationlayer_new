using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public static class ConfigurationHandler
    {
        public static readonly string CONFIG_FILE_PATH = @"C:\ProgramData\Configurationfile.properties";

        public static void CreateConfigurationFile()
        {
            try
            {
                FileInfo configFile = new FileInfo(CONFIG_FILE_PATH);

                if (configFile.Exists)
                {
                    Console.WriteLine("Configuration file already exists.");
                    return;
                }

                var properties = new Dictionary<string, string>
            {
                {"Connectionstring", @"Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS;Initial Catalog=Mixing;Integrated Security=True"},
                {"password", ""},
                {"url", ""},
                {"TestResultCsvFilePath", @"C:\ProgramData\HEVEA\RHmeter\1.0.0.0\Testresult.csv"},
                {"PlantNo", ""},
                {"Machine", ""}
            };

                using (StreamWriter writer = new StreamWriter(configFile.FullName))
                {
                    foreach (var property in properties)
                    {
                        writer.WriteLine($"{property.Key}-{property.Value}");
                    }
                }

                Console.WriteLine("Configuration file created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }

        public static List<string> ReadConfigurationFile()
        {
            List<string> configurationValues = new List<string>();
            try
            {
                var properties = new Dictionary<string, string>();

                using (StreamReader reader = new StreamReader(CONFIG_FILE_PATH))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split only at the first occurrence of '-'
                        int index = line.IndexOf('-');
                        if (index != -1)
                        {
                            string key = line.Substring(0, index);
                            string value = line.Substring(index + 1);
                            properties[key] = value;
                        }
                    }
                }

                // Fetch values from the properties dictionary
                configurationValues.Add(properties.ContainsKey("Connectionstring") ? properties["Connectionstring"] : "");
                configurationValues.Add(properties.ContainsKey("password") ? properties["password"] : "");
                configurationValues.Add(properties.ContainsKey("url") ? properties["url"] : "");
                configurationValues.Add(properties.ContainsKey("TestResultCsvFilePath") ? properties["TestResultCsvFilePath"] : "");
                configurationValues.Add(properties.ContainsKey("PlantNo") ? properties["PlantNo"] : "");
                configurationValues.Add(properties.ContainsKey("Machine") ? properties["Machine"] : "");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred while reading the configuration file: {e.Message}");
            }

            Console.WriteLine("configurationValues: " + string.Join(", ", configurationValues));
            return configurationValues;
        }
    }
}
