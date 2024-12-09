using Databaselayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace Businesslayer
{

    public class Entryscreenbll
    {
        static string plantNo = null;
        private Bitmap combinedImage;
        static Entryscreenbll()
        {
            List<string> configurationValues = ConfigurationHandler.ReadConfigurationFile();

            plantNo = configurationValues[4];
            Console.WriteLine(plantNo);

        }

        static string sapcode;
        static string batchno;
        static double vmval;
        static double vival;
        static double ml4val;
        static double mlValue;
        static double mhValue;
        static double ts2Value;
        static double tc50Value;
        static double tc90Value;
        static double C1val;
        static double C2val;
        static double C3val;
        static double C4val;
        static double H1val;
        static double H2val;
        static double H3val;
        static double H4val;
        static double sgval;
        static double dtval;
        static double wtval;
        static double hrdmean;
        static double conmean;

        public static void callBoth(string sap, string batch_no, string vm, string vi, string ml4, string ml, string mh, string ts2, string tc50, string tc90, string H1, string H2, string H3, string H4, string sg, string wt, string dt)
        {
            sapcode = sap;
            batchno = batch_no;
            double.TryParse(vm, out vmval);
            double.TryParse(vi, out vival);
            double.TryParse(ml4, out ml4val);
            double.TryParse(ml, out mlValue);
            double.TryParse(mh, out mhValue);
            double.TryParse(ts2, out ts2Value);
            double.TryParse(tc50, out tc50Value);
            double.TryParse(tc90, out tc90Value);
            double.TryParse(H1, out H1val);
            double.TryParse(H2, out H2val);
            double.TryParse(H3, out H3val);
            double.TryParse(H4, out H4val);
            double.TryParse(sg, out sgval);
            double.TryParse(dt, out dtval);
            double.TryParse(wt, out wtval);
            hrdmean = (H1val + H2val + H3val + H4val) / 4;
            hrdmean = Math.Floor(hrdmean + 0.50);
        }

        public static void callBothcon(string sap, string batch_no, string vm, string vi, string ml4, string ml, string mh, string ts2, string tc50, string tc90, string H1, string H2, string H3, string H4, string sg, string c1, string c2, string c3, string c4, string wt, string dt)
        {
            sapcode = sap;
            batchno = batch_no;
            double.TryParse(vm, out vmval);
            double.TryParse(vi, out vival);
            double.TryParse(ml4, out ml4val);
            double.TryParse(ml, out mlValue);
            double.TryParse(mh, out mhValue);
            double.TryParse(ts2, out ts2Value);
            double.TryParse(tc50, out tc50Value);
            double.TryParse(tc90, out tc90Value);
            double.TryParse(H1, out H1val);
            double.TryParse(H2, out H2val);
            double.TryParse(H3, out H3val);
            double.TryParse(H4, out H4val);
            double.TryParse(sg, out sgval);
            double.TryParse(c1, out C1val);
            double.TryParse(c2, out C2val);
            double.TryParse(c3, out C3val);
            double.TryParse(c4, out C4val);
            double.TryParse(dt, out dtval);
            double.TryParse(wt, out wtval);
            hrdmean = (H1val + H2val + H3val + H4val) / 4;
            hrdmean = Math.Floor(hrdmean + 0.50);
            conmean = (C1val + C2val + C3val + C4val) / 4;
            Console.WriteLine("conductivity mean=" + conmean);
        }

        public static void callmoony(string vm, string vi, string ml4)
        {

            vmval = Convert.ToDouble(vm);
            vival = Convert.ToDouble(vi);
            ml4val = Convert.ToDouble(ml4);
            Console.WriteLine("asined values vmval in bll= " + vmval);

        }

        public static void callRheo(string sap, string batch_no, string ml, string mh, string ts2, string tc50, string tc90, string H1, string H2, string H3, string H4, string sg, string wt, string dt)
        {
            sapcode = sap;
            batchno = batch_no;
            double.TryParse(ml, out mlValue);
            double.TryParse(mh, out mhValue);
            double.TryParse(ts2, out ts2Value);
            double.TryParse(tc50, out tc50Value);
            double.TryParse(tc90, out tc90Value);
            double.TryParse(H1, out H1val);
            double.TryParse(H2, out H2val);
            double.TryParse(H3, out H3val);
            double.TryParse(H4, out H4val);
            double.TryParse(sg, out sgval);
            double.TryParse(dt, out dtval);
            double.TryParse(wt, out wtval);
            hrdmean = (H1val + H2val + H3val + H4val) / 4;
            hrdmean = Math.Floor(hrdmean + 0.50);
            Console.WriteLine("hrdmen" + hrdmean);


        }
        public static void callRheocon(string sap, string batch_no, string ml, string mh, string ts2, string tc50, string tc90, string H1, string H2, string H3, string H4, string sg, string c1, string c2, string c3, string c4, string wt, string dt)
        {
            sapcode = sap;
            batchno = batch_no;
            double.TryParse(ml, out mlValue);
            double.TryParse(mh, out mhValue);
            double.TryParse(ts2, out ts2Value);
            double.TryParse(tc50, out tc50Value);
            double.TryParse(tc90, out tc90Value);
            double.TryParse(H1, out H1val);
            double.TryParse(H2, out H2val);
            double.TryParse(H3, out H3val);
            double.TryParse(H4, out H4val);
            double.TryParse(sg, out sgval);
            double.TryParse(c1, out C1val);
            double.TryParse(c2, out C2val);
            double.TryParse(c3, out C3val);
            double.TryParse(c4, out C4val);
            double.TryParse(dt, out dtval);
            double.TryParse(wt, out wtval);
            hrdmean = (H1val + H2val + H3val + H4val) / 4;
            hrdmean = Math.Floor(hrdmean + 0.50);
            conmean = (C1val + C2val + C3val + C4val) / 4;
            Console.WriteLine("hrdmen" + hrdmean);


        }
        public static (string machineName, string queryType, List<object[]> dataList) RetrieveDataFromTable(string sapCode, string batchNo)
        {
            string machineName = "";
            string queryType = "";
            List<object[]> dataList = new List<object[]>();

            // Call DAL method to execute stored procedure
            (machineName, queryType, dataList) = Entryscreendll.RetrieveDataFromTable(sapCode, batchNo);

            return (machineName, queryType, dataList);
        }

        public static (string machineName, string queryType, StringBuilder message) validaeteMaster(string sapCode)
        {

            // Call DAL method to execute stored procedure and retrieve results
            List<object[]> dataList = new List<object[]>();
            string machineName = "";
            string queryType = "";
            StringBuilder message = new StringBuilder();
            StringBuilder Rejection = new StringBuilder();
            // Call DAL method to execute stored procedure
            (machineName, queryType, dataList) = Entryscreendll.GetBatchmaster(sapCode);
            if (machineName.Equals("moony") && queryType.Equals("moony"))
            {

                // Iterate through dataList and process each row
                foreach (object[] row in dataList)
                {
                    double vmmin, vmmax, vimin, vimax, ml4min, ml4max;
                    double.TryParse(row[18]?.ToString(), out vmmin);
                    double.TryParse(row[19]?.ToString(), out vmmax);
                    double.TryParse(row[20]?.ToString(), out vimin);
                    double.TryParse(row[21]?.ToString(), out vimax);
                    double.TryParse(row[22]?.ToString(), out ml4min);
                    double.TryParse(row[23]?.ToString(), out ml4max);

                }
            }
            else if (machineName.Equals("rheo") && queryType.Equals("rheo"))
            {

                // Call DAL method to execute stored procedure
                (machineName, queryType, dataList) = Entryscreendll.GetBatchmaster(sapCode);

                // Iterate through dataList and process each row
                foreach (object[] row in dataList)
                {

                    string sapcode = row[0]?.ToString() ?? string.Empty;
                    double mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardmin, hrdmax, sgmin, sgmax;

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
                    double.TryParse(row[12]?.ToString(), out hardmin);
                    double.TryParse(row[13]?.ToString(), out hrdmax);
                    double.TryParse(row[14]?.ToString(), out sgmin);
                    double.TryParse(row[15]?.ToString(), out sgmax);

                    bool hrdmeanOk = hrdmean >= hardmin && hrdmean <= hrdmax;
                  //  bool specGravityOk = sgval >= sgmin && sgval <= sgmax;
                    bool mlMinOk = mlValue >= mlmin && mlValue <= mlmax;
                    bool mhOk = mhValue >= mhmin && mhValue <= mhmax;
                    bool ts2Ok = ts2Value >= ts2min && ts2Value <= ts2max;
                  //  bool tc50Ok = tc50Value >= tc50min && tc50Value <= tc50max;
                    bool tc90Ok = tc90Value >= tc90min && tc90Value <= tc90max;
                    Console.WriteLine("hrdmeanOk" + hrdmeanOk);

                    if (hrdmeanOk == true)
                    {
                        message.Append("Hardness is = ✓.\n");
                    }
                    if (hrdmeanOk == false)
                    {
                        message.Append("Hardness is = ✗.\n");
                        Rejection.Append("H1,");
                    }

                    //if (specGravityOk == true)
                    //{
                    //    message.Append("Specific Gravity is = ✓.\n");
                    //}
                    //if (specGravityOk == false)
                    //{
                    //    message.Append("Specific Gravity is = ✗.\n");
                    //    Rejection.Append("S1,");
                    //}
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
                    //if (tc50Ok == true)
                    //{
                    //    message.Append("TC50 is = ✓.\n");
                    //}
                    //if (tc50Ok == false)
                    //{
                    //    message.Append("TC50 is = ✗.\n");
                    //    Rejection.Append("R4,");
                    //}
                    if (tc90Ok == true)
                    {
                        message.Append("TC90 is = ✓.\n");
                    }
                    if (tc90Ok == false)
                    {
                        message.Append("TC90 is = ✗.\n");
                        Rejection.Append("R5,");
                    }
                    if (hrdmean >= hardmin && hrdmean <= hrdmax

                        //&& sgval >= sgmin && sgval <= sgmax
                        && mlValue >= mlmin && mlValue <= mlmax
                        && mhValue >= mhmin && mhValue <= mhmax
                        && ts2Value >= ts2min && ts2Value <= ts2max
                       // && tc50Value >= tc50min && tc50Value <= tc50max
                        && tc90Value >= tc90min && tc90Value <= tc90max)
                    {

                        Console.WriteLine("method block get ");
                        Console.WriteLine("plant======" + plantNo);
                        string Message = "OK";
                        // for update query with okk status 
                        Entryscreendll.updateRecords(sapcode, batchno, H1val, H2val, H3val, H4val, sgval, wtval, dtval, plantNo, Message);
                        Entryscreenbll callqr = new Entryscreenbll();
                      
                        callqr.printQrcode(sapcode, batchno, wtval, ts2Value, tc90Value, hrdmean, sgval, 0);
                        string rheodate = Entryscreendll.senddate(sapcode, batchno, plantNo);
                        Saptranfer.sendTosap(sapcode, batchno, mlValue, mhValue, ts2Value, tc50Value, tc90Value, hrdmean, sgval, wtval, plantNo, rheodate);

                        Console.WriteLine("method exicuted ");

                    }
                    else
                    {
                        Console.WriteLine("plant======" + plantNo);

                        string PassRejection = Rejection.ToString();

                        Entryscreendll.updateRecordswithrejection(sapcode, batchno, H1val, H2val, H3val, H4val, sgval, wtval, dtval, plantNo, PassRejection);

                    }
                    // call the above parameter for validate  

                }
            }
            else if (machineName.Equals("rheo") && queryType.Equals("rheocon"))
            {
                // call method for only rheocon

                (machineName, queryType, dataList) = Entryscreendll.GetBatchmaster(sapCode);

                // Iterate through dataList and process each row
                foreach (object[] row in dataList)
                {

                    string sapcode = row[0]?.ToString() ?? string.Empty;
                    double mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardmin, hrdmax, sgmin, sgmax, conmin, conmax;

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
                    double.TryParse(row[12]?.ToString(), out hardmin);
                    double.TryParse(row[13]?.ToString(), out hrdmax);
                    double.TryParse(row[14]?.ToString(), out sgmin);
                    double.TryParse(row[15]?.ToString(), out sgmax);
                    double.TryParse(row[16]?.ToString(), out conmin);
                    double.TryParse(row[17]?.ToString(), out conmax);

                    bool hrdmeanOk = hrdmean >= hardmin && hrdmean <= hrdmax;
                    bool conmeanok = conmean >= conmin && conmean <= conmax;
                    //bool specGravityOk = sgval >= sgmin && sgval <= sgmax;
                    bool mlMinOk = mlValue >= mlmin && mlValue <= mlmax;
                    bool mhOk = mhValue >= mhmin && mhValue <= mhmax;
                    bool ts2Ok = ts2Value >= ts2min && ts2Value <= ts2max;
                    //bool tc50Ok = tc50Value >= tc50min && tc50Value <= tc50max;
                    bool tc90Ok = tc90Value >= tc90min && tc90Value <= tc90max;
                    Console.WriteLine("hrdmeanOk" + hrdmeanOk);
                    Console.WriteLine("rheocon test ======" + conmeanok);

                    if (hrdmeanOk == true)
                    {
                        message.Append("Hardness is = ✓.\n");
                    }
                    if (hrdmeanOk == false)
                    {
                        message.Append("Hardness is = ✗.\n");
                        Rejection.Append("H1,");
                    }
                    if (conmeanok == true)
                    {
                        message.Append("Condutivity is =✓.\n");
                    }
                    if (conmeanok == false)
                    {
                        message.Append("Conductivity is = ✗.\n");
                        Rejection.Append("C1,");
                    }
                    //if (specGravityOk == true)
                    //{
                    //    message.Append("Specific Gravity is = ✓.\n");
                    //}
                    //if (specGravityOk == false)
                    //{
                    //    message.Append("Specific Gravity is = ✗.\n");
                    //    Rejection.Append("S1,");
                    //}
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
                    //if (tc50Ok == true)
                    //{
                    //    message.Append("TC50 is = ✓.\n");
                    //}
                    //if (tc50Ok == false)
                    //{
                    //    message.Append("TC50 is = ✗.\n");
                    //    Rejection.Append("R4,");
                    //}
                    if (tc90Ok == true)
                    {
                        message.Append("TC90 is = ✓.\n");
                    }
                    if (tc90Ok == false)
                    {
                        message.Append("TC90 is = ✗.\n");
                        Rejection.Append("R5,");
                    }
                    if (hrdmean >= hardmin && hrdmean <= hrdmax

                        && conmean >= conmin && conmean <= conmax
                       // && sgval >= sgmin && sgval <= sgmax
                        && mlValue >= mlmin && mlValue <= mlmax
                        && mhValue >= mhmin && mhValue <= mhmax
                        && ts2Value >= ts2min && ts2Value <= ts2max
                      //  && tc50Value >= tc50min && tc50Value <= tc50max
                        && tc90Value >= tc90min && tc90Value <= tc90max)
                    {
                        // for update query with okk status 

                        string Message = "OK";
                        // for update query with okk status 
                        Entryscreendll.updateRecords(sapcode, batchno, H1val, H2val, H3val, H4val, C1val, C2val, C3val, C4val, sgval, wtval, dtval, plantNo, Message);
                        Entryscreenbll callqr = new Entryscreenbll();
                        callqr.printQrcode(sapcode, batchno, wtval, ts2Value, tc90Value, hrdmean, sgval, 0);
                        string rheodate = Entryscreendll.senddate(sapcode, batchno, plantNo);
                        Saptranfer.sendTosap(sapcode, batchno, mlValue, mhValue, ts2Value, tc50Value, tc90Value, hrdmean, sgval, wtval, plantNo, rheodate);

                        Console.WriteLine("method exicuted ");


                    }
                    else
                    {
                        // for rejection

                        string PassRejection = Rejection.ToString();
                        Entryscreendll.updateRecordswithrejection(sapcode, batchno, H1val, H2val, H3val, H4val, C1val, C2val, C3val, C4val, sgval, wtval, dtval, plantNo, PassRejection);

                    }


                }
            }
            else if (machineName.Equals("both") && queryType.Equals("both"))


            {

                // Call DAL method to execute stored procedure
                (machineName, queryType, dataList) = Entryscreendll.GetBatchmaster(sapCode);

                // Iterate through dataList and process each row
                foreach (object[] row in dataList)
                {

                    string sapcode = row[0]?.ToString() ?? string.Empty;
                    double vmmin, vmmax, vimin, vimax, ml4min, ml4max, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardmin, hrdmax, sgmin, sgmax;

                    // Parse string values to doubles

                    double.TryParse(row[18]?.ToString(), out vmmin);
                    double.TryParse(row[19]?.ToString(), out vmmax);
                    double.TryParse(row[20]?.ToString(), out vimin);
                    double.TryParse(row[21]?.ToString(), out vimax);
                    double.TryParse(row[22]?.ToString(), out ml4min);
                    double.TryParse(row[23]?.ToString(), out ml4max);
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
                    double.TryParse(row[12]?.ToString(), out hardmin);
                    double.TryParse(row[13]?.ToString(), out hrdmax);
                    double.TryParse(row[14]?.ToString(), out sgmin);
                    double.TryParse(row[15]?.ToString(), out sgmax);

                    //bool vmok = vmval >= vmmin && vmval <= vmmax;
                    //bool viok = vival >= vimin && vival <= vimax;
                    // bool ml4ok = ml4val >= ml4min && ml4val <= ml4max;
                    Console.WriteLine("ml4val" + ml4val +" maxis ------------="+ ml4max);
                    bool ml4ok =  ml4val <= ml4max && ml4val!=0;
                    bool hrdmeanOk = hrdmean >= hardmin && hrdmean <= hrdmax;
                    //bool specGravityOk = sgval >= sgmin && sgval <= sgmax;
                    bool mlMinOk = mlValue >= mlmin && mlValue <= mlmax;
                    bool mhOk = mhValue >= mhmin && mhValue <= mhmax;
                    bool ts2Ok = ts2Value >= ts2min && ts2Value <= ts2max;
                  //  bool tc50Ok = tc50Value >= tc50min && tc50Value <= tc50max;
                    bool tc90Ok = tc90Value >= tc90min && tc90Value <= tc90max;
                    Console.WriteLine("hrdmeanOk" + hrdmeanOk);
                    //if (viok == true)
                    //{
                    //    message.Append("VI is = ✓.\n");
                    //}
                    //if (viok == false)
                    //{
                    //    message.Append("VI is = ✗.\n");
                    //    Rejection.Append("M1,");
                    //}
                    //if (vmok == true)
                    //{
                    //    message.Append("VM is = ✓.\n");
                    //}
                    //if (vmok == false)
                    //{
                    //    message.Append("VM is = ✗.\n");
                    //    Rejection.Append("M2,");
                    //}
                    if (ml4ok == true)
                    {
                        message.Append("ML+4 is = ✓.\n");
                    }
                    if (ml4ok == false)
                    {
                        message.Append("ML+4 is = ✗.\n");
                        Rejection.Append("M3,");
                    }
                    if (hrdmeanOk == true)
                    {
                        message.Append("Hardness is = ✓.\n");
                    }
                    if (hrdmeanOk == false)
                    {
                        message.Append("Hardness is = ✗.\n");
                        Rejection.Append("H1,");
                    }

                    //if (specGravityOk == true)
                    //{
                    //    message.Append("Specific Gravity is = ✓.\n");
                    //}
                    //if (specGravityOk == false)
                    //{
                    //    message.Append("Specific Gravity is = ✗.\n");
                    //    Rejection.Append("S1,");
                    //}
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
                    //if (tc50Ok == true)
                    //{
                    //    message.Append("TC50 is = ✓.\n");
                    //}
                    //if (tc50Ok == false)
                    //{
                    //    message.Append("TC50 is = ✗.\n");
                    //    Rejection.Append("R4,");
                    //}
                    if (tc90Ok == true)
                    {
                        message.Append("TC90 is = ✓.\n");
                    }
                    if (tc90Ok == false)
                    {
                        message.Append("TC90 is = ✗.\n");
                        Rejection.Append("R5,");
                    }
                    if (hrdmean >= hardmin && hrdmean <= hrdmax

                       // && sgval >= sgmin && sgval <= sgmax
                        && mlValue >= mlmin && mlValue <= mlmax
                        && mhValue >= mhmin && mhValue <= mhmax
                        && ts2Value >= ts2min && ts2Value <= ts2max
                        //&& vmval >= vmmin && vmval <= vmmax
                        //&& vival >= vimin && vival <= vimax
                        //&& ml4val >= ml4min && ml4val <= ml4max
                         && ml4val <= ml4max && ml4val!=0
                        //  && tc50Value >= tc50min && tc50Value <= tc50max
                        && tc90Value >= tc90min && tc90Value <= tc90max)
                    {
                        // for update query with okk status 
                        string Message = "OK";
                        // for update query with okk status 
                        Entryscreendll.updateRecords(sapcode, batchno, H1val, H2val, H3val, H4val, sgval, wtval, dtval, plantNo, Message);
                        Entryscreenbll callqr = new Entryscreenbll();
                        callqr.printQrcode(sapcode, batchno, wtval, ts2Value, tc90Value, hrdmean, sgval, ml4val);
                        string rheodate = Entryscreendll.senddate(sapcode, batchno, plantNo);
                        Console.WriteLine("before  exicuted ");
                       
                            Saptranfer.sendTosap(sapcode, batchno, mlValue, mhValue, ts2Value, tc50Value, tc90Value, hrdmean, sgval, wtval, ml4val, plantNo, rheodate);

                      
                        Console.WriteLine("method exicuted ");
                    }
                    else
                    {
                        // for re
                        string PassRejection = Rejection.ToString();
                        Entryscreendll.updateRecordswithrejection(sapcode, batchno, H1val, H2val, H3val, H4val, sgval, wtval, dtval, plantNo, PassRejection);


                    }
                    // call the above parameter for validate  

                }


            }
            else if (machineName.Equals("both") && queryType.Equals("bothcon"))
            {

                // Call DAL method to execute stored procedure
                (machineName, queryType, dataList) = Entryscreendll.GetBatchmaster(sapCode);

                // Iterate through dataList and process each row
                foreach (object[] row in dataList)
                {

                    string sapcode = row[0]?.ToString() ?? string.Empty;
                    double vmmin, vmmax, vimin, vimax, ml4min, ml4max, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardmin, hrdmax, sgmin, sgmax, conmin, conmax;

                    // Parse string values to doubles

                    double.TryParse(row[18]?.ToString(), out vmmin);
                    double.TryParse(row[19]?.ToString(), out vmmax);
                    double.TryParse(row[20]?.ToString(), out vimin);
                    double.TryParse(row[21]?.ToString(), out vimax);
                    double.TryParse(row[22]?.ToString(), out ml4min);
                    double.TryParse(row[23]?.ToString(), out ml4max);
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
                    double.TryParse(row[12]?.ToString(), out hardmin);
                    double.TryParse(row[13]?.ToString(), out hrdmax);
                    double.TryParse(row[14]?.ToString(), out sgmin);
                    double.TryParse(row[15]?.ToString(), out sgmax);
                    double.TryParse(row[16]?.ToString(), out conmin);
                    double.TryParse(row[17]?.ToString(), out conmax);

                    //bool vmok = vmval >= vmmin && vmval <= vmmax;
                    //bool viok = vival >= vimin && vimax <= vmmax;
                   // bool ml4ok = ml4val >= ml4min &&ml4val <= ml4max;
                    bool ml4ok = ml4val <= ml4max && ml4val!=0;
                    bool hrdmeanOk = hrdmean >= hardmin && hrdmean <= hrdmax;
                   // bool specGravityOk = sgval >= sgmin && sgval <= sgmax;
                    bool conmeanok = conmean >= conmin && conmean <= conmax;
                    Console.WriteLine("status" + conmeanok);
                    Console.WriteLine("conmin=" + conmin + "conmax=" + conmax);

                    bool mlMinOk = mlValue >= mlmin && mlValue <= mlmax;
                    bool mhOk = mhValue >= mhmin && mhValue <= mhmax;
                    bool ts2Ok = ts2Value >= ts2min && ts2Value <= ts2max;
                   // bool tc50Ok = tc50Value >= tc50min && tc50Value <= tc50max;
                    bool tc90Ok = tc90Value >= tc90min && tc90Value <= tc90max;
                    Console.WriteLine("hrdmeanOk" + hrdmeanOk);
                    Console.WriteLine("both con======" + conmeanok);
                    //if (viok == true)
                    //{
                    //    message.Append("VI is = ✓.\n");
                    //}
                    //if (viok == false)
                    //{
                    //    message.Append("VI is = ✗.\n");
                    //    Rejection.Append("M1,");
                    //}
                    //if (vmok == true)
                    //{
                    //    message.Append("VM is = ✓.\n");
                    //}
                    //if (vmok == false)
                    //{
                    //    message.Append("VM is = ✗.\n");
                    //    Rejection.Append("M2,");
                    //}
                    if (ml4ok == true)
                    {
                        message.Append("ML+4 is = ✓.\n");
                    }
                    if (ml4ok == false)
                    {
                        message.Append("ML+4 is = ✗.\n");
                        Rejection.Append("M3,");
                    }
                    if (hrdmeanOk == true)
                    {
                        message.Append("Hardness is = ✓.\n");
                    }
                    if (hrdmeanOk == false)
                    {
                        message.Append("Hardness is = ✗.\n");
                        Rejection.Append("H1,");
                    }

                    //if (specGravityOk == true)
                    //{
                    //    message.Append("Specific Gravity is = ✓.\n");
                    //}
                    //if (specGravityOk == false)
                    //{
                    //    message.Append("Specific Gravity is = ✗.\n");
                    //    Rejection.Append("S1,");
                    //}
                    if (conmeanok == true)
                    {
                        message.Append("Condutivity is =✓.\n");
                        Console.WriteLine("con ok exicuted ");
                    }
                    if (conmeanok == false)
                    {
                        message.Append("Conductivity is = ✗.\n");
                        Rejection.Append("C1,");
                        Console.WriteLine("con rejecction exicuted ");
                    }
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
                    //if (tc50Ok == true)
                    //{
                    //    message.Append("TC50 is = ✓.\n");
                    //}
                    //if (tc50Ok == false)
                    //{
                    //    message.Append("TC50 is = ✗.\n");
                    //    Rejection.Append("R4,");
                    //}
                    if (tc90Ok == true)
                    {
                        message.Append("TC90 is = ✓.\n");
                    }
                    if (tc90Ok == false)
                    {
                        message.Append("TC90 is = ✗.\n");
                        Rejection.Append("R5,");
                    }
                    if (hrdmean >= hardmin && hrdmean <= hrdmax
                        && conmean >= conmin && conmean <= conmax
                      //  && sgval >= sgmin && sgval <= sgmax
                        && mlValue >= mlmin && mlValue <= mlmax
                        && mhValue >= mhmin && mhValue <= mhmax
                        && ts2Value >= ts2min && ts2Value <= ts2max
                        //&& vmval >= vmmin && vmval <= vmmax
                        //&& vival >= vimin && vival <= vimax
                       // && ml4val >= ml4min && ml4val <= ml4max
                         && ml4val <= ml4max && ml4val != 0
                        //   && tc50Value >= tc50min && tc50Value <= tc50max
                        && tc90Value >= tc90min && tc90Value <= tc90max)
                    {
                        // for update query with okk status 

                        string Message = "OK";
                        // for update query with okk status 
                        Entryscreendll.updateRecords(sapcode, batchno, H1val, H2val, H3val, H4val, C1val, C2val, C3val, C4val, sgval, wtval, dtval, plantNo, Message);
                        Entryscreenbll callqr = new Entryscreenbll();
                        callqr.printQrcode(sapcode, batchno, wtval, ts2Value, tc90Value, hrdmean, sgval, ml4val);
                        string rheodate = Entryscreendll.senddate(sapcode, batchno, plantNo);
                        Saptranfer.sendTosap(sapcode, batchno, mlValue, mhValue, ts2Value, tc50Value, tc90Value, hrdmean, sgval, wtval, ml4val, plantNo, rheodate);

                        Console.WriteLine("method exicuted ");
                    }
                    else
                    {
                        

                        string PassRejection = Rejection.ToString();
                        Entryscreendll.updateRecordswithrejection(sapcode, batchno, H1val, H2val, H3val, H4val, C1val, C2val, C3val, C4val, sgval, wtval, dtval, plantNo, PassRejection);

                    }
                    // call the above parameter for validate  

                }
            }

            return (machineName, queryType, message);
        }


        // write a method to print qr code in mixing location 
        public static bool CheckStatus(string sapcode, string batchno)
        {
        bool status= Entryscreendll.CheckStatus(sapcode, batchno);

        return status;
        }
            public void printQrcode(string sapcode, string batchno, double bweight, double t2, double t90, double hrd,double Spgrt,double ml4)
        {
            // string date = Entryscreendll.getExpirtdate(sapcode, batchno, plantNo);

            //write logic for printing the qrcode
           string expdate= Entryscreendll.getExpiryDate(sapcode, batchno, plantNo);
           string batchdesc = Entryscreendll.getbatchDescription(sapcode);
           double ccweight = bweight * 1000 / Spgrt;
           ccweight = Math.Ceiling(ccweight);
            string temp_batch = batchno.Length > 12 ? batchno.Substring(0, 12) : batchno;

            string combinedValue = $"{sapcode}/{temp_batch}/{ccweight}/{expdate}";

            // Adjust the QR code size as needed 
            int qrCodeSize = 130; // Increase the size of the QR code
                                  // Adjust the width of your paper
            int paperWidth = 314;
            // Adjust the height of your paper
            int paperHeight = 250;



            // Generate QR code bitmap
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = new ZXing.Common.EncodingOptions
            {
                Width = qrCodeSize,
                Height = qrCodeSize
            };
            Bitmap qrCodeImage = writer.Write(combinedValue);



            combinedImage = new Bitmap(paperWidth, paperHeight);
            using (Graphics g = Graphics.FromImage(combinedImage))
            {
                g.Clear(Color.White);




                // Draw current date and time at the top of the sticker
                // string ExDate = "Use Before            " + DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");
                using (Font font = new Font("Arial Black", 10))
                {
                    using (SolidBrush brush = new SolidBrush(Color.Black))
                    {
                        // Drawing the "Expiry date" label
                        SizeF desc = g.MeasureString("Use Before", font);
                        int topX1 = 17; // Horizontal position for the label
                        int topY1 = 170; // Vertical position for the label
                        g.DrawString("Use Before", font, brush, topX1, topY1);

                        // Drawing the actual expiry date
                        SizeF textSize = g.MeasureString(expdate, font);
                        int topX = 50+(int)desc.Width;
                        int topY = topY1; // Vertical position for the date, shifted down by the height of the label
                        g.DrawString(expdate, font, brush, topX, topY);

                        // Drawing the material description
                        string matDesc = "Mat.Desc. " + "       " + batchdesc;
                        SizeF matDescSize = g.MeasureString(matDesc, font);
                        int matDescX = 20; // Horizontal position for the material description
                        int matDescY = 10; // Vertical position for the material description
                        g.DrawString(matDesc, font, brush, matDescX, matDescY);
                    }
                }


                int qrCodeX = -10;
                int qrCodeY = 40; // Adjusted position of the QR code
                g.DrawImage(qrCodeImage, qrCodeX, qrCodeY, qrCodeSize, qrCodeSize);

                List<string> textLines = new List<string>
    {
        

        "Batch NO  " +" "+ temp_batch,
        "Wt(KG)/CC " +" "+bweight +"/"+ccweight,
        "TS2/TC90  " +" "+ t2+"/"+t90,
        "HRD       " +"      "+ hrd,
        "SPG       " +"      "+Spgrt,
        "ML+4      " +"     "+ml4

    };

                // Position of the text
                int textX = 106; // Shift the text to the left
                int textY = 45; // Adjusted position of the text

                using (Font font = new Font("Arial Black", 9 , FontStyle.Bold))
                {
                    using (SolidBrush brush = new SolidBrush(Color.Black))
                    {
                        foreach (string line in textLines)
                        {
                            g.DrawString(line, font, brush, textX, textY);
                            textY += 20;
                        }

                        int matDescHorizontalLineStartX = qrCodeX;
                        int matDescHorizontalLineStartY = 38; // Slightly below the matdesc code
                        int matDescHorizontalLineEndX = paperWidth; // End point adjusted to the width of the sticker
                        int matDescHorizontalLineEndY = 38; // Adjusted to be just above the text

                      
                        using (Pen boldPen = new Pen(Color.Black, 2)) // 2 is the width of the pen, adjust as needed
                        {
                            // Draw the horizontal line between the matdesc 
                            g.DrawLine(boldPen, matDescHorizontalLineStartX, matDescHorizontalLineStartY, matDescHorizontalLineEndX, matDescHorizontalLineEndY);

                        }

                        // Draw a horizontal  line below the text
                        int horizontalLineStartX = qrCodeX;
                        int horizontalLineStartY = textY  ; // Slightly below the text
                        int horizontalLineEndX = paperWidth; // End point adjusted to the width of the sticker
                        int horizontalLineEndY = horizontalLineStartY;

                        
                        using (Pen boldPen = new Pen(Color.Black, 2)) // 2 is the width of the pen, adjust as needed
                        {
                            // Draw the vertical line between the QR code and text
                            g.DrawLine(boldPen, horizontalLineStartX, horizontalLineStartY, horizontalLineEndX, horizontalLineEndY);

                        }

                        // Draw a vertical dotted line between the QR code and text
                        int verticalLineStartX = 105;
                        int verticalLineStartY = 0;
                        int verticalLineEndX = verticalLineStartX;
                        int verticalLineEndY = paperHeight;

                        using (Pen boldPen = new Pen(Color.Black, 2)) // 2 is the width of the pen, adjust as needed
                        {
                            // Draw the vertical line between the QR code and text
                            g.DrawLine(boldPen, verticalLineStartX, verticalLineStartY, verticalLineEndX, verticalLineEndY);

                        }


                        // Draw a vertical dotted line between the text  and text
                        int verticalLineStartX1 = 177;
                        int verticalLineStartY1 = 38;
                        int verticalLineEndX1 = verticalLineStartX1;
                        int verticalLineEndY1 = paperHeight-84;

                     

                        using (Pen boldPen = new Pen(Color.Black, 2)) // 2 is the width of the pen, adjust as needed
                        {
                            // Draw the vertical line between the QR code and text
                            g.DrawLine(boldPen, verticalLineStartX1, verticalLineStartY1, verticalLineEndX1, verticalLineEndY1);

                        }
                    }
                }

            }
            // Print the combined image without showing the printer dialog
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Set the printer settings to use the default printer
            printDocument.PrinterSettings.PrinterName = new PrinterSettings().PrinterName;
          
            printDocument.PrinterSettings.PrintToFile = false;

            printDocument.PrintController = new StandardPrintController(); // This line hides the dialog

            printDocument.Print();

        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (combinedImage != null)
            {
                e.Graphics.DrawImage(combinedImage, 0, 0, combinedImage.Width, combinedImage.Height);
            }
        }
    } 

           




}
    
