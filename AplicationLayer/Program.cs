using System;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;
using Businesslayer;
using OfficeOpenXml;

namespace AplicationLayer
{
    internal static class Program
    {
        static RheometerService rheometerService;

        [STAThread]
        static void Main()
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // or LicenseContext.Commercial
                ConfigurationHandler.CreateConfigurationFile();
                ConfigurationHandler.ReadConfigurationFile();

               
                // Instantiate RheometerService
             
                RheometerService rheometerService = new RheometerService();

                // Start the file watcher
                rheometerService.StartFileWatcher();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                login loginForm = new login();

                // Subscribe to the FormClosing event of the login form
                loginForm.FormClosing += LoginForm_FormClosing;

                // Run the application with the login form
                Application.Run(loginForm);

           }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("argumentexception" + e.StackTrace);

            }
            catch (SqlException ex){
                MessageBox.Show("sqlexception" + ex.StackTrace);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("index out of bound" + ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errrororo" + ex.StackTrace);
            }
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
