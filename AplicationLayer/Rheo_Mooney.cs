using Businesslayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationLayer
{
    public partial class Rheo_Mooney : Form
    {
        public Rheo_Mooney()
        {
            InitializeComponent();
            getsapcodes();
        }
        BothBll BothBll = new BothBll();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Rheo_Mooney_Load(object sender, EventArgs e)
        {
            conpane.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void concheck_CheckedChanged(object sender, EventArgs e)
        {
            if (concheck.Checked)
            {
            conpane.Show();

            }
            else
            {
                conpane.Hide() ;    
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // call method to save data in to data base .


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
            string conductivitymin = txtcon_min.Text;
            string conductivitymax = txtcon_max.Text;
            string vimin = txtvi_min.Text;
            string vimax = txtvi_max.Text;
            string vmmin = txtvm_min.Text;
            string vmmax = txtvm_max.Text;
            string ml4min = txtml4_min.Text;
            string ml4max = txtml4_max.Text;
            if (!concheck.Checked)
            {
                conductivitymin = "100.0";
                conductivitymax = "100.0";

                Console.WriteLine("not has condutivity");
            }
           
            
            bool isSuccess = BothBll.insertBothrecord(sapcode, batch_name, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardnessmin, hardnessmax, specificgravitymin, specificgravitymax, conductivitymin, conductivitymax, vimin, vimax, vmmin, vmmax, ml4min, ml4max);

            if (isSuccess)
            {
                MessageBox.Show("record is inserted");

            }
            else
            {
                MessageBox.Show("oops Eroor to insert record !!");
            }
        }
        private void getsapcodes()
        {
            List<string> columnValues = BothBll.getBothSapcodes();

            // Insert default value at index 0
            string defaultValue = "SAPCODE"; // Replace this with your desired default value
            columnValues.Insert(0, defaultValue);

            // Set the modified list as the DataSource
            comboboth.DataSource = columnValues;

            // Set default value to item at index 0
            comboboth.SelectedIndex = 0;



        }

        private void comboboth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sapcode = comboboth.SelectedItem.ToString();
            SqlDataReader reader = BothBll.GetBatchDetails(sapcode);
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
                txthrd_min.Text = reader["hardnessmin"].ToString();
                txthrd_max.Text = reader["hardnessmax"].ToString();
                txtgrt_min.Text = reader["specificgravitymin"].ToString();
                txtgrt_max.Text = reader["specificgravitymax"].ToString();
                txtcon_max.Text = reader["conductivitymax"].ToString();
                txtcon_min.Text = reader["conductivitymin"].ToString();
                txtvi_max.Text = reader["vimax"].ToString();
                txtvi_min.Text = reader["vimin"].ToString();
                txtvm_max.Text = reader["vmmax"].ToString();
                txtvm_min.Text = reader["vmmin"].ToString();
                txtml4_max.Text = reader["ml4max"].ToString();
                txtml4_min.Text = reader["ml4min"].ToString();

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
            string vih = txtvi_max.Text;
            string vil = txtvi_min.Text;
            string vmh = txtvm_max.Text;
            string vml = txtvm_min.Text;
            string ml4h = txtml4_max.Text;
            string ml4l = txtml4_min.Text;


            try
            {
             bool suceess=   BothBll.updatBoth(sapcode, batch_name, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardnessmin, hardnessmax, specificgravitymin, specificgravitymax, conmin, conmax, vih, vil, vmh, vml, ml4h, ml4l);
                
              if (suceess )
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
