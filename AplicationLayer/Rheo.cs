using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Businesslayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicationLayer
{
    public partial class Rheo : Form
    {
        public Rheo()
        {
            InitializeComponent();
            getsapcodes();
        }
        RheoBll rheobusinessclass = new RheoBll();
        private void btnsave_Click(object sender, EventArgs e)
        {

            string sapcode = txtsacode.Text;
            string batch_name = txtcompcode.Text;
            string mlmin = txtml_min.Text;
            string mlmax = txtml_max.Text;
            string mhmin = txtmh_min.Text;
            string mhmax = txtmh_max.Text;
            string ts2min = txtts2_min.Text;
            string ts2max = txtts2_max.Text;
            string tc50min = txttc50_min.Text;
            string tc50max = txttc50_max.Text;
            string tc90min = txttc90_min.Text;
            string tc90max = txttc90_max.Text;
            string hardnessmin=txthrd_min.Text; 
            string hardnessmax =txthrd_max.Text; 
            string specificgravitymin = txtgrt_min.Text;
            string specificgravitymax = txtgrt_max.Text;
            string conductivitymin = txtcon_min.Text;
            string conductivitymax = txtcon_max.Text;

            if (!concheck.Checked)
            {
                conductivitymin = "100.0";
                conductivitymax = "100.0";

                Console.WriteLine("not has condutivity");
            }



            // according to rheo machine 
            bool isSuccess = rheobusinessclass.insertRheorecord(sapcode, batch_name, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardnessmin, hardnessmax, specificgravitymin, specificgravitymax, conductivitymin, conductivitymax);
            if (isSuccess) 
            { 
                MessageBox.Show("record is inserted");
            
            }else
            {
                MessageBox.Show("oops Eroor to insert record !!");
            }


        }
        private void cleareTextboxes()
        {
            
        }
       

        private void Rheo_Load(object sender, EventArgs e)
        {
            conpane.Hide();
        }

        private void concheck_CheckedChanged_1(object sender, EventArgs e)
        {

            if (concheck.Checked)
            {
                conpane.Show();

            }
            else
            {
                conpane.Hide();
            }
            
        }

        private void getsapcodes()
        {
            // Populate dropdown with column values
            List<string> columnValues = rheobusinessclass.getrheoSapcodes();
            string defaultValue = "SAPCODE"; // Replace this with your desired default value
            columnValues.Insert(0, defaultValue);

            // Set the modified list as the DataSource
            comborheo.DataSource = columnValues;

            // Set default value to item at index 0
            comborheo.SelectedIndex = 0;
        }

        private void comborheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sapcode = comborheo.SelectedItem.ToString();
            SqlDataReader reader = rheobusinessclass.GetBatchDetails(sapcode);
            if (reader.Read())
            {
                txtcompcode.Text = reader["batch_name"].ToString();
                txtsacode.Text = reader["sapcode"].ToString();
                txtml_max.Text = reader["mlmax"].ToString();
                txtml_min.Text = reader["mlmin"].ToString();
                txtmh_max.Text = reader["mhmax"].ToString();
                txtmh_min.Text = reader["mhmin"].ToString();
                txtts2_max.Text = reader["ts2max"].ToString();
                txtts2_min.Text = reader["ts2min"].ToString();
                txttc90_max.Text = reader["tc90max"].ToString();
                txttc90_min.Text = reader["tc90min"].ToString();
                txttc50_max.Text = reader["tc50max"].ToString();
                txttc50_min.Text = reader["tc50min"].ToString();
                txthrd_min.Text = reader["hardnessmin"].ToString() ;
                txthrd_max.Text = reader["hardnessmax"].ToString();
                txtgrt_min.Text = reader["specificgravitymin"].ToString();
                txtgrt_max.Text = reader["specificgravitymax"].ToString();
                txtcon_max.Text = reader["conductivitymax"].ToString();
                txtcon_min.Text = reader["conductivitymin"].ToString();

            }
            reader.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sapcode = txtsacode.Text;
            string batch_name = txtcompcode.Text;
            string mlmin = txtml_min.Text;
            string mlmax = txtml_max.Text;
            string mhmin = txtmh_min.Text;
            string mhmax = txtmh_max.Text;
            string ts2min = txtts2_min.Text;
            string ts2max = txtts2_max.Text;
            string tc50min = txttc50_min.Text;
            string tc50max = txttc50_max.Text;
            string tc90min = txttc90_min.Text;
            string tc90max = txttc90_max.Text;
            string hardnessmin = txthrd_min.Text;
            string hardnessmax = txthrd_max.Text;
            string specificgravitymin = txtgrt_min.Text;
            string specificgravitymax = txtgrt_max.Text;
            string conmin = txtcon_min.Text;
            string conmax = txtcon_max.Text;


                 try
            {
               bool success= rheobusinessclass.updateRheo(sapcode, batch_name, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardnessmin, hardnessmax, specificgravitymin, specificgravitymax, conmin, conmax);
               if (success )
                {
                    MessageBox.Show("Record updated successfully!!!");

                }
                else
                {
                    MessageBox.Show("Error while updating record!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("OopsError: " + ex.Message);
            }
        }
    }
}
