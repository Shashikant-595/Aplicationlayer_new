using Databaselayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class loginbll
    {

    private readonly loginDll logindll;

        public loginbll()
        {
            logindll = new loginDll();
        }

        public bool ValidateUser(string Name, string password)
        {
            List<string> configurationValues = ConfigurationHandler.ReadConfigurationFile();
            string connectionString = configurationValues[0].Trim(); // Assuming the connection string is at index 2
            Console.WriteLine("connectionString:-"+connectionString);
            // Authenticate user using data from the database
            return logindll.ValidateUser( Name, password);
        }
    }

}

