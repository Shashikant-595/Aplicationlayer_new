using Businesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AplicationLayer
{
    public partial class Mooney : Form
    {



        public Mooney()
        {
            InitializeComponent();
            getsapcodes();
        }
        MooneyBLL mooneyBLL = new MooneyBLL();
        private void btnsave_Click(object sender, EventArgs e)
        {  // Get the data from the UI controls
            string sapcode = txtsacode.Text;
            string batch_name = txtcompcode.Text;
            string vimin = txtvi_min.Text;
            string vimax=txtvi_max.Text;
            string vmmin=txtvm_min.Text;
            string vmmax=txtvm_max.Text;
            string ml4min=txtml4_min.Text;
            string ml4max=txtml4_max.Text;


            // Call the method in BLL to insert the record
            bool isSuccess = mooneyBLL.InsertMooneyRecord(sapcode, batch_name, vimin, vimax,vmmin, vmmax, ml4min, ml4max);

            // Display a message based on the success status
            if (isSuccess)
            {
                MessageBox.Show("Record inserted successfully.");
                // Optionally, clear the UI controls or perform other actions
            }
            else
            {
                MessageBox.Show("Failed to insert the record. Please try again.");
            }
        }

        //call second method to update mooney data .
        private void getsapcodes ()
        {
            // Populate dropdown with column values
            List<string> columnValues = mooneyBLL.GetColumnValues();
            string defaultValue = "SAPCODE"; // Replace this with your desired default value
            columnValues.Insert(0, defaultValue);

            // Set the modified list as the DataSource
            combomooney.DataSource = columnValues;

            // Set default value to item at index 0
            combomooney.SelectedIndex = 0;
        }

        private void combomooney_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sapcode = combomooney.SelectedItem.ToString();
            SqlDataReader reader = mooneyBLL.GetBatchDetails(sapcode);
            if (reader.Read())
            {
                txtcompcode.Text = reader["batch_name"].ToString();
                txtsacode.Text = reader["sapcode"].ToString();
                txtvi_max.Text = reader["vimax"].ToString();
                txtvi_min.Text = reader["vimin"].ToString();
                txtvm_max.Text = reader["vmmax"].ToString();
                txtvm_min.Text = reader["vmmin"].ToString();
                txtml4_max.Text = reader["ml4max"].ToString();
                txtml4_min.Text = reader["ml4min"].ToString();
               
            }
            reader.Close();

        }
        private void btnmooneyupdate_Click(object sender, EventArgs e)
        {
            string sapcode = combomooney.SelectedItem.ToString();
            string name = txtcompcode.Text;
            string vih = txtvi_max.Text;
            string vil = txtvi_min.Text;
            string vmh = txtvm_max.Text;
            string vml = txtvm_min.Text;
            string ml4h = txtml4_max.Text;
            string ml4l = txtml4_min.Text;

            try
            {
              bool success =  mooneyBLL.UpdateMasterRecord(sapcode, name, vih, vil, vmh, vml, ml4h, ml4l);
              if (success)
                {
                    MessageBox.Show("Record updated successfully!!!");
                }
                else
                {
                    MessageBox.Show("Error while updating the record!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("OopsError: " + ex.Message);
            }
        }
    }
}
