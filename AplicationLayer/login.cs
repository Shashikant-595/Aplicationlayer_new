using Businesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationLayer
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        loginbll logincall =new loginbll(); 
      
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string Name = txtuser.Text;
            string password = txtpass.Text;

            bool isAuthenticated = logincall.ValidateUser(Name, password);

            if (isAuthenticated)
            {
                // Navigate to the appropriate form based on user role
                // For example:
                if (Name.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Login successful");
                    // Open Master1 form
                    // Master1Form master1Form = new Master1Form();
                    // master1Form.Show();
                    Batchquality_master call = new Batchquality_master();
                    call.Show();
                }
                else if (Name.StartsWith("U", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Login successful");
                    // Open MixingEntryScreen form
                    // MixingEntryScreenForm mixingEntryScreenForm = new MixingEntryScreenForm();
                    // mixingEntryScreenForm.Show();
                    Entryscreen2 call = new Entryscreen2();
                    call.Show();

                }
                else
                {
                    MessageBox.Show("Please provide a valid username");
                }
            }
            else
            {
                MessageBox.Show("Please provide correct password or username");
            }
        }
    

    private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
