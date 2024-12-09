using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Businesslayer;

namespace AplicationLayer
{
    public partial class Entryscreen2 : Form
    {
 
        public Entryscreen2()
        {
            InitializeComponent();

        }

        private void Entryscreen2_Load(object sender, EventArgs e)
        {
           
            txtscaner.Select();

        }

        private void h1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string text = h1.Text;

            if (!char.IsDigit(c) && c != '.' && c != '\b' || text.Length >= 4 && c != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnrecords_Click(object sender, EventArgs e)
        {

            // call the report 

            //Reports callreports = new Reports();
            //callreports.Show();
            General_report callrepo = new General_report(); 
            callrepo.Show();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // get manual input and then compare with master using stored procedure and then gerate status according to batch.
            String sapcode=txtsacode.Text;  
            String batchno=txtbatchno.Text;
            String vm=txtvm.Text; 
            String vi=txtvi.Text;
            String ml4=txtml4.Text;
            String ml=txtml.Text;
            String mh=txtmh.Text;
            String ts2=txtts2.Text;
            String tc50=txttc50.Text;
            String tc90=txttc90.Text;
            String C1 = c1.Text;
            String C2 = c2.Text;
            String C3 = c3.Text;
            String C4 = c4.Text;
            String H1 = h1.Text;
            String H2 = h2.Text;
            String H3 = h3.Text;
            String H4 = h4.Text;
            String sg=txtsg.Text;
            String dt=txtdt.Text;
            String wt=txtwt.Text;

            var (machineName, queryType, dataList) = Entryscreenbll.RetrieveDataFromTable(sapcode, batchno);
           Console.WriteLine(machineName, queryType, dataList);
            Console.WriteLine( queryType, dataList);

            if (machineName.Equals("moony"))
            {
                // callmethod for moony to get the master 
                Entryscreenbll.callmoony(vm, vi, ml4);

            }
            else if (machineName.Equals("rheo") && queryType.Equals("rheo"))
            {
                if (string.IsNullOrEmpty(sapcode) || string.IsNullOrEmpty(ml) || string.IsNullOrEmpty(mh) ||
                    string.IsNullOrEmpty(ts2) || string.IsNullOrEmpty(tc50) || string.IsNullOrEmpty(tc90) ||
                    string.IsNullOrEmpty(H1) || string.IsNullOrEmpty(H2) || string.IsNullOrEmpty(H3) ||
                    string.IsNullOrEmpty(H4) || string.IsNullOrEmpty(sg) || string.IsNullOrEmpty(dt) ||
                    string.IsNullOrEmpty(wt))

                {
                    MessageBox.Show("Some parameters are empty or contain whitespace. Please fill all the parameters or check for whitespace.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                  
                    // Repeat for other variables
                }
                else
                {
                    // call method for only rheomachine
                    Entryscreenbll.callRheo(sapcode, batchno, ml, mh, ts2, tc50, tc90, H1, H2, H3, H4, sg, wt, dt );

                    // call qrcode print method and pass data in to ok table

                    var (machine, querytype, message) = Entryscreenbll.validaeteMaster(sapcode);
                    Console.WriteLine("machine from ui layer" + machine);
                    MessageBox.Show(message.ToString(), "Batch Quality Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsacode.Text = "";
                    txtbatchno.Text = "";                   
                    txtml.Text = "";
                    txtmh.Text = "";
                    txtts2.Text = "";
                    txttc50.Text = "";
                    txttc90.Text = "";       
                    h1.Text = "";
                    h2.Text = "";
                    h3.Text = "";
                    h4.Text = "";
                    txtsg.Text = "";
                    txtdt.Text = "";
                    txtwt.Text = "";
                }
            }
            else if (machineName.Equals("rheo") && queryType.Equals("rheocon"))
            {
                if (string.IsNullOrEmpty(sapcode) || string.IsNullOrEmpty(ml) || string.IsNullOrEmpty(mh) ||
                    string.IsNullOrEmpty(ts2)|| string.IsNullOrEmpty(tc50) || string.IsNullOrEmpty(tc90) ||
                    string.IsNullOrEmpty(H1) || string.IsNullOrEmpty(H2) || string.IsNullOrEmpty(H3) ||
                    string.IsNullOrEmpty(H4) || string.IsNullOrEmpty(sg) || string.IsNullOrEmpty(C1) ||
                    string.IsNullOrEmpty(C2) || string.IsNullOrEmpty(C3) || string.IsNullOrEmpty(C4) ||
                    string.IsNullOrEmpty(dt) || string.IsNullOrEmpty(wt))
                {
                    MessageBox.Show("Some parameters are empty. Please fill all the required fields.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // call method for only rheocon
                    Entryscreenbll.callRheocon(sapcode, batchno, ml, mh, ts2, tc50, tc90, H1, H2, H3, H4, sg, C1, C2, C3, C4, wt, dt);


                    var (machine, querytype, message) = Entryscreenbll.validaeteMaster(sapcode);
                    Console.WriteLine("machine from ui layer" + machine);
                    MessageBox.Show(message.ToString(), "Batch Quality Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtsacode.Text = "";
                    txtbatchno.Text = "";                
                    txtml.Text = "";
                    txtmh.Text = "";
                    txtts2.Text = "";
                    txttc50.Text = "";
                    txttc90.Text = "";
                    c1.Text = "";
                    c2.Text = "";
                    c3.Text = "";
                    c4.Text = "";
                    h1.Text = "";
                    h2.Text = "";
                    h3.Text = "";
                    h4.Text = "";
                    txtsg.Text = "";
                    txtdt.Text = "";
                    txtwt.Text = "";

                }

            }
            else if (machineName.Equals("both") && queryType.Equals("Both"))
            {

                if (string.IsNullOrEmpty(sapcode) 
                     || string.IsNullOrEmpty(ml) || string.IsNullOrEmpty(mh) ||
                    string.IsNullOrEmpty(ts2) || string.IsNullOrEmpty(tc50) || string.IsNullOrEmpty(tc90) ||
                    string.IsNullOrEmpty(H1) || string.IsNullOrEmpty(H2) || string.IsNullOrEmpty(H3) ||
                    string.IsNullOrEmpty(H4) || string.IsNullOrEmpty(sg) || string.IsNullOrEmpty(dt) ||
                    string.IsNullOrEmpty(wt))
                {
                    MessageBox.Show("Some parameters are empty. Please fill all the parameters.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // call method for only both
                    Entryscreenbll.callBoth(sapcode, batchno, vm, vi, ml4, ml, mh, ts2, tc50, tc90, H1, H2, H3, H4, sg, wt, dt);
                    var (machine, querytype, message) = Entryscreenbll.validaeteMaster(sapcode);
                    Console.WriteLine("machine from ui layer" + machine);
                    MessageBox.Show(message.ToString(), "Batch Quality Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsacode.Text = "";
                    txtbatchno.Text = "";
                    txtvm.Text = "";
                    txtvi.Text = "";
                    txtml4.Text = "";
                    txtml.Text = "";
                    txtmh.Text = "";
                    txtts2.Text = "";
                    txttc50.Text = "";
                    txttc90.Text = "";      
                    h1.Text = "";
                    h2.Text = "";
                    h3.Text = "";
                    h4.Text = "";
                    txtsg.Text = "";
                    txtdt.Text = "";
                    txtwt.Text = "";

                }

            }
            else if (machineName.Equals("both") && queryType.Equals("Bothcon"))
            {
                if (string.IsNullOrEmpty(sapcode) || 
                    string.IsNullOrEmpty(ml) || string.IsNullOrEmpty(mh) ||
                    string.IsNullOrEmpty(ts2) || string.IsNullOrEmpty(tc50) || string.IsNullOrEmpty(tc90) ||
                    string.IsNullOrEmpty(H1) || string.IsNullOrEmpty(H2) || string.IsNullOrEmpty(H3) ||
                    string.IsNullOrEmpty(H4) || string.IsNullOrEmpty(sg) || string.IsNullOrEmpty(C1) ||
                    string.IsNullOrEmpty(C2) || string.IsNullOrEmpty(C3) || string.IsNullOrEmpty(C4) ||
                    string.IsNullOrEmpty(dt) || string.IsNullOrEmpty(wt))
                {
                    MessageBox.Show("Some parameters are empty. Please Check all the parameters .",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // call method for only both
                    Entryscreenbll.callBothcon(sapcode, batchno, vm, vi, ml4, ml, mh, ts2, tc50, tc90, H1, H2, H3, H4, sg, C1, C2, C3, C4, wt, dt);
                    var (machine, querytype, message) = Entryscreenbll.validaeteMaster(sapcode);
                    Console.WriteLine("machine from ui layer" + machine);
                    MessageBox.Show(message.ToString(), "Batch Quality Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the TextBox controls after the method call
                    txtsacode.Text = "";
                    txtbatchno.Text = "";
                    txtvm.Text = "";
                    txtvi.Text = "";
                    txtml4.Text = "";
                    txtml.Text = "";
                    txtmh.Text = "";
                    txtts2.Text = "";
                    txttc50.Text = "";
                    txttc90.Text = "";
                    c1.Text = "";
                    c2.Text = "";
                    c3.Text = "";
                    c4.Text = "";
                    h1.Text = "";
                    h2.Text = "";
                    h3.Text = "";
                    h4.Text = "";
                    txtsg.Text = "";
                    txtdt.Text = "";
                    txtwt.Text = "";
                }

            }

        }

        private async void txtscaner_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var data = txtscaner.Text;
                var Getscannerdata = data.Split('/');
                String sapcode = Getscannerdata[0];
                String btchNo = Getscannerdata[1];
                String wt= Getscannerdata[2];
                Console.WriteLine("2nd" + wt);
                // await Task.Delay(3000);

             bool status = Entryscreenbll.CheckStatus(sapcode, btchNo);

                if (status)
                {
                    // Call BLL method to retrieve data
                    var (machineName, queryType, dataList) = Entryscreenbll.RetrieveDataFromTable(sapcode, btchNo);

                    // Display machine name and query type
                    // MessageBox.Show($"Machine Name: {machineName}\nQuery Type: {queryType}\n datalist{dataList}");
                    // Based on the above data i need to hide and show data according to machine 
                    Console.WriteLine("selected data from tables " + dataList);
                    if (machineName.Equals("rheo") && queryType.Equals("rheocon"))
                    {
                        mooneypane.Hide();
                        rheopane.Show();
                        conpane.Show();
                        hardnesspane.Show();
                        txtsg.Show();
                        lblgrt.Show();
                        mooneypane.Hide();
                        object vm = null, vi = null, ml4 = null, ml = null, mh = null, ts2 = null, tc50 = null, tc90 = null;
                        // no pane is required to hide 
                        if (!dataList.Any())
                        {
                            // data list is empty 
                            MessageBox.Show("No Record found");

                        }
                        foreach (object[] row in dataList)
                        {

                            ml = row[3];
                            mh = row[4];
                            ts2 = row[5];
                            tc50 = row[6];
                            tc90 = row[7];
                        }

                        txtbatchno.Text = btchNo.ToString();
                        txtsacode.Text = sapcode;
                        txtml.Text = ml.ToString();
                        txtmh.Text = mh.ToString();
                        txtts2.Text = ts2.ToString();
                        txttc50.Text = tc50.ToString();
                        txttc90.Text = tc90.ToString();
                        txtwt.Text = wt;
                        // hide paneof mooney and  and hrd

                    }
                    else if (machineName.Equals("rheo") && queryType.Equals("rheo"))
                    {
                        mooneypane.Hide();
                        rheopane.Show();
                        hardnesspane.Show();
                        txtsg.Show();
                        lblgrt.Show();
                        conpane.Hide();
                        //hide pane of mooney as well as con 
                        object vm = null, vi = null, ml4 = null, ml = null, mh = null, ts2 = null, tc50 = null, tc90 = null;
                        // no pane is required to hide 
                        if (!dataList.Any())
                        {
                            // data list is empty 
                            MessageBox.Show("No Record found");

                        }
                        foreach (object[] row in dataList)
                        {
                            ml = row[3];
                            mh = row[4];
                            ts2 = row[5];
                            tc50 = row[6];
                            tc90 = row[7];
                        }
                        txtbatchno.Text = btchNo.ToString();
                        txtsacode.Text = sapcode;
                        txtml.Text = ml.ToString();
                        txtmh.Text = mh.ToString();
                        txtts2.Text = ts2.ToString();
                        txttc50.Text = tc50.ToString();
                        txttc90.Text = tc90.ToString();
                        txtwt.Text = wt;
                    }
                    else if (machineName.Equals("moony") && queryType.Equals("moony"))
                    {
                        //mooney
                        rheopane.Hide();
                        conpane.Hide();
                        lblgrt.Hide();
                        txtsg.Hide();
                        hardnesspane.Hide();
                        intensivepane.Hide();
                        mooneypane.Show();

                        //hide pane except mooney 

                        object vm = null, vi = null, ml4 = null;
                        if (!dataList.Any())
                        {
                            // data list is empty 
                            MessageBox.Show("No Record found");

                        }
                        foreach (object[] row in dataList)
                        {
                            Console.WriteLine("row" + row[0].ToString());
                            vm = row[3];
                            vi = row[4];
                            ml4 = row[5];

                        }
                        txtsacode.Text = sapcode;
                        txtbatchno.Text = btchNo;
                        txtvm.Text = vm.ToString();
                        txtvi.Text = vi.ToString();
                        txtml4.Text = ml4.ToString();
                    }
                    else if (machineName.Equals("both") && queryType.Equals("Both"))
                    {
                        //both           
                        rheopane.Show();
                        hardnesspane.Show();
                        txtsg.Show();
                        lblgrt.Show();
                        mooneypane.Show();
                        conpane.Hide();
                        object vm = null, vi = null, ml4 = null, ml = null, mh = null, ts2 = null, tc50 = null, tc90 = null;
                        // no pane is required to hide 
                        if (!dataList.Any())
                        {
                            // data list is empty 
                            MessageBox.Show("No Record found");

                        }
                        foreach (object[] row in dataList)
                        {

                            vm = row[3];
                            vi = row[4];
                            ml4 = row[5];
                            ml = row[6];
                            mh = row[7];
                            ts2 = row[8];
                            tc50 = row[9];
                            tc90 = row[10];
                        }
                        txtvm.Text = vm.ToString();
                        txtvi.Text = vi.ToString();
                        txtml4.Text = ml4.ToString();
                        txtbatchno.Text = btchNo.ToString();
                        txtsacode.Text = sapcode;
                        txtml.Text = ml.ToString();
                        txtmh.Text = mh.ToString();
                        txtts2.Text = ts2.ToString();
                        txttc50.Text = tc50.ToString();
                        txttc90.Text = tc90.ToString();
                        txtwt.Text = wt;

                    }
                    else if (machineName.Equals("both") && queryType.Equals("Bothcon"))
                    {
                        //both with con             
                        Console.WriteLine("blockget");
                        rheopane.Show();
                        hardnesspane.Show();
                        txtsg.Show();
                        lblgrt.Show();
                        conpane.Show();
                        mooneypane.Show();
                        object vm = null, vi = null, ml4 = null, ml = null, mh = null, ts2 = null, tc50 = null, tc90 = null;
                        // no pane is required to hide 

                        if (!dataList.Any())
                        {
                            // data list is empty 
                            MessageBox.Show("No Record found");

                        }
                        foreach (object[] row in dataList)
                        {
                            vm = row[3];
                            vi = row[4];
                            ml4 = row[5];
                            ml = row[6];
                            mh = row[7];
                            ts2 = row[8];
                            tc50 = row[9];
                            tc90 = row[10];
                        }
                        txtvm.Text = vm.ToString();
                        txtvi.Text = vi.ToString();
                        txtml4.Text = ml4.ToString();
                        txtbatchno.Text = btchNo.ToString();
                        txtsacode.Text = sapcode;
                        txtml.Text = ml.ToString();
                        txtmh.Text = mh.ToString();
                        txtts2.Text = ts2.ToString();
                        txttc50.Text = tc50.ToString();
                        txttc90.Text = tc90.ToString();
                        txtwt.Text = wt;

                    }


                }
                else
                {

                    MessageBox.Show("Data entry is done !!");
                }




            }
            catch (Exception ex)
            {
                Console.WriteLine("bothcon"+ex.Message);
            }

        }

       

       

        private void h2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string text = h2.Text;

            if (!char.IsDigit(c) && c != '.' && c != '\b' || text.Length >= 4 && c != '\b')
            {
                e.Handled = true;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtml4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
