using System;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;
using Businesslayer;

namespace AplicationLayer
{
    internal static class Program
    {
        static RheometerService rheometerService;

        [STAThread]
        static void Main()
        {
            // Start the service
           
            // Instantiate RheometerService
           RheometerService rheometerService = new RheometerService();

            // Start the file watcher
           rheometerService.StartFileWatcher();

          

            ConfigurationHandler.CreateConfigurationFile();
            ConfigurationHandler.ReadConfigurationFile();

            // Subscribe to the ApplicationExit event
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login loginForm = new login();

            // Subscribe to the FormClosing event of the login form
           loginForm.FormClosing += LoginForm_FormClosing;

            // Run the application with the login form
            Application.Run(loginForm);



        }


        private static void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if there are other open forms
            if (Application.OpenForms.Count > 1) // Assuming more than just the login form is open
            {
                // If other forms are open, do not close the application
                e.Cancel = true;
            }
            else
            {
                // If no other forms are open, allow the application to close
                e.Cancel = false;
            }
        }



    }
}
