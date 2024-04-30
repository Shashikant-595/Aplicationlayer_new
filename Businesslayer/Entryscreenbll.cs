using Databaselayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
   
    public class Entryscreenbll
    {
       static string plantNo = null;
        static Entryscreenbll()
        {
            List<string> configurationValues = ConfigurationHandler.ReadConfigurationFile();

            plantNo = configurationValues[4];
            Console.WriteLine(plantNo);

        }




        // Extract PlantNo and Machine values



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
       
        public static void callBoth(string sap,string batch_no, string vm, string vi, string ml4, string ml, string mh, string ts2, string tc50, string tc90, string H1, string H2, string H3, string H4, string sg, string wt,string dt)
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
            conmean = (C1val + C2val + C3val + C4val) / 4;
            Console.WriteLine("conductivity mean=" + conmean);
        }

        public static void callmoony(string  vm, string vi, string ml4 )
        {

            vmval = Convert.ToDouble(vm);
            vival = Convert.ToDouble(vi);
            ml4val = Convert.ToDouble(ml4);
            Console.WriteLine("asined values vmval in bll= " + vmval);
           
        }

        public static void callRheo(string sap, string batch_no, string ml, string mh, string ts2, string tc50, string tc90,string H1,string H2,string H3,string H4,string sg, string wt,string dt)
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

            Console.WriteLine("hrdmen"+ hrdmean);


        }
        public static void callRheocon(string sap, string batch_no, string ml, string mh, string ts2, string tc50, string tc90, string H1, string H2, string H3, string H4, string sg,string c1,string c2, string c3, string c4, string wt, string dt)
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

        public static (string machineName, string queryType,StringBuilder message) validaeteMaster(string sapCode)
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
                    bool specGravityOk = sgval >= sgmin && sgval <= sgmax;
                    bool mlMinOk = mlValue >= mlmin && mlValue <= mlmax;
                    bool mhOk = mhValue >= mhmin && mhValue <= mhmax;
                    bool ts2Ok = ts2Value >= ts2min && ts2Value <= ts2max;
                    bool tc50Ok = tc50Value >= tc50min && tc50Value <= tc50max;
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

                    if (specGravityOk == true)
                    {
                        message.Append("Specific Gravity is = ✓.\n");
                    }
                    if (specGravityOk == false)
                    {
                        message.Append("Specific Gravity is = ✗.\n");
                        Rejection.Append("S1,");
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
                    if (tc50Ok == true)
                    {
                        message.Append("TC50 is = ✓.\n");
                    }
                    if (tc50Ok == false)
                    {
                        message.Append("TC50 is = ✗.\n");
                        Rejection.Append("R4,");
                    }
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

                        && sgval >= sgmin && sgval <= sgmax
                        && mlValue >= mlmin && mlValue <= mlmax
                        && mhValue >= mhmin && mhValue <= mhmax
                        && ts2Value >= ts2min && ts2Value <= ts2max
                        && tc50Value >= tc50min && tc50Value <= tc50max
                        && tc90Value >= tc90min && tc90Value <= tc90max)
                    {

                        Console.WriteLine("method block get ");
                        Console.WriteLine("plant======" + plantNo);
                        string Message = "OK";
                        // for update query with okk status 
                        Entryscreendll.updateRecords(sapcode, batchno, H1val, H2val, H3val, H4val,sgval, wtval, dtval, plantNo,Message);
                        Console.WriteLine("method exicuted ");




                    }
                    else
                    {
                        Console.WriteLine("plant======"+plantNo);

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
                    bool specGravityOk = sgval >= sgmin && sgval <= sgmax;
                    bool mlMinOk = mlValue >= mlmin && mlValue <= mlmax;
                    bool mhOk = mhValue >= mhmin && mhValue <= mhmax;
                    bool ts2Ok = ts2Value >= ts2min && ts2Value <= ts2max;
                    bool tc50Ok = tc50Value >= tc50min && tc50Value <= tc50max;
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
                    if (specGravityOk == true)
                    {
                        message.Append("Specific Gravity is = ✓.\n");
                    }
                    if (specGravityOk == false)
                    {
                        message.Append("Specific Gravity is = ✗.\n");
                        Rejection.Append("S1,");
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
                    if (tc50Ok == true)
                    {
                        message.Append("TC50 is = ✓.\n");
                    }
                    if (tc50Ok == false)
                    {
                        message.Append("TC50 is = ✗.\n");
                        Rejection.Append("R4,");
                    }
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
                        && sgval >= sgmin && sgval <= sgmax
                        && mlValue >= mlmin && mlValue <= mlmax
                        && mhValue >= mhmin && mhValue <= mhmax
                        && ts2Value >= ts2min && ts2Value <= ts2max
                        && tc50Value >= tc50min && tc50Value <= tc50max
                        && tc90Value >= tc90min && tc90Value <= tc90max)
                    {
                        // for update query with okk status 

                        string Message = "OK";
                        // for update query with okk status 
                        Entryscreendll.updateRecords(sapcode, batchno, H1val, H2val, H3val, H4val,C1val,C2val,C3val,C4val, sgval, wtval, dtval, plantNo, Message);
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
                    double vmmin,vmmax,vimin,vimax,ml4min,ml4max,mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardmin, hrdmax, sgmin, sgmax;

                    // Parse string values to doubles

                    double.TryParse(row[18]?.ToString(),out vmmin);
                    double.TryParse(row[19]?.ToString(),out vmmax);
                    double.TryParse(row[20]?.ToString(),out vimin);
                    double.TryParse(row[21]?.ToString(),out vimax);
                    double.TryParse(row[22]?.ToString(),out ml4min);
                    double.TryParse(row[22]?.ToString(),out ml4max);
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

                    bool vmok = vmval >= vmmin && vmval <= vmmax;
                    bool viok = vival >= vimin && vival <= vimax;
                    bool ml4ok = ml4val >= ml4min && ml4val <=ml4max;
                    bool hrdmeanOk = hrdmean >= hardmin && hrdmean <= hrdmax;
                    bool specGravityOk = sgval >= sgmin && sgval <= sgmax;
                    bool mlMinOk = mlValue >= mlmin && mlValue <= mlmax;
                    bool mhOk = mhValue >= mhmin && mhValue <= mhmax;
                    bool ts2Ok = ts2Value >= ts2min && ts2Value <= ts2max;
                    bool tc50Ok = tc50Value >= tc50min && tc50Value <= tc50max;
                    bool tc90Ok = tc90Value >= tc90min && tc90Value <= tc90max;
                    Console.WriteLine("hrdmeanOk" + hrdmeanOk);
                    if (viok == true)
                    {
                        message.Append("VI is = ✓.\n");
                    }
                    if (viok == false)
                    {
                        message.Append("VI is = ✗.\n");
                        Rejection.Append("M1,");
                    }
                    if (vmok == true)
                    {
                        message.Append("VM is = ✓.\n");
                    }
                    if (vmok == false)
                    {
                        message.Append("VM is = ✗.\n");
                        Rejection.Append("M2,");
                    }
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

                    if (specGravityOk == true)
                    {
                        message.Append("Specific Gravity is = ✓.\n");
                    }
                    if (specGravityOk == false)
                    {
                        message.Append("Specific Gravity is = ✗.\n");
                        Rejection.Append("S1,");
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
                    if (tc50Ok == true)
                    {
                        message.Append("TC50 is = ✓.\n");
                    }
                    if (tc50Ok == false)
                    {
                        message.Append("TC50 is = ✗.\n");
                        Rejection.Append("R4,");
                    }
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

                        && sgval >= sgmin && sgval <= sgmax
                        && mlValue >= mlmin && mlValue <= mlmax
                        && mhValue >= mhmin && mhValue <= mhmax
                        && ts2Value >= ts2min && ts2Value <= ts2max
                        && tc50Value >= tc50min && tc50Value <= tc50max
                        && tc90Value >= tc90min && tc90Value <= tc90max)
                    {
                        // for update query with okk status 
                        string Message = "OK";
                        // for update query with okk status 
                        Entryscreendll.updateRecords(sapcode, batchno, H1val, H2val, H3val, H4val, sgval, wtval, dtval,plantNo, Message);
                        Console.WriteLine("method exicuted ");
                    }
                    else
                    {
                        // for re
                        string PassRejection = Rejection.ToString();
                        Entryscreendll.updateRecordswithrejection(sapcode, batchno, H1val, H2val, H3val, H4val,sgval, wtval, dtval, plantNo, PassRejection);


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
                    double.TryParse(row[22]?.ToString(), out ml4max);
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

                    bool vmok = vmval >= vmmin && vmval <= vmmax;
                    bool viok = vival >= vmmin && vival <= vmmax;
                    bool ml4ok = ml4val >= ml4min && ml4val <= vmmax;
                    bool hrdmeanOk = hrdmean >= hardmin && hrdmean <= hrdmax;
                    bool specGravityOk = sgval >= sgmin && sgval <= sgmax;
                    bool conmeanok = conmean >= conmin && conmean <= conmax;
                    Console.WriteLine("status" + conmeanok);
                    Console.WriteLine("conmin=" + conmin+"conmax="+ conmax);

                    bool mlMinOk = mlValue >= mlmin && mlValue <= mlmax;
                    bool mhOk = mhValue >= mhmin && mhValue <= mhmax;
                    bool ts2Ok = ts2Value >= ts2min && ts2Value <= ts2max;
                    bool tc50Ok = tc50Value >= tc50min && tc50Value <= tc50max;
                    bool tc90Ok = tc90Value >= tc90min && tc90Value <= tc90max;
                    Console.WriteLine("hrdmeanOk" + hrdmeanOk);
                    Console.WriteLine("both con======" + conmeanok);
                    if (viok == true)
                    {
                        message.Append("VI is = ✓.\n");
                    }
                    if (viok == false)
                    {
                        message.Append("VI is = ✗.\n");
                        Rejection.Append("M1,");
                    }
                    if (vmok == true)
                    {
                        message.Append("VM is = ✓.\n");
                    }
                    if (vmok == false)
                    {
                        message.Append("VM is = ✗.\n");
                        Rejection.Append("M2,");
                    }
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

                    if (specGravityOk == true)
                    {
                        message.Append("Specific Gravity is = ✓.\n");
                    }
                    if (specGravityOk == false)
                    {
                        message.Append("Specific Gravity is = ✗.\n");
                        Rejection.Append("S1,");
                    }
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
                    if (tc50Ok == true)
                    {
                        message.Append("TC50 is = ✓.\n");
                    }
                    if (tc50Ok == false)
                    {
                        message.Append("TC50 is = ✗.\n");
                        Rejection.Append("R4,");
                    }
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
                        && sgval >= sgmin && sgval <= sgmax
                        && mlValue >= mlmin && mlValue <= mlmax
                        && mhValue >= mhmin && mhValue <= mhmax
                        && ts2Value >= ts2min && ts2Value <= ts2max
                        && tc50Value >= tc50min && tc50Value <= tc50max
                        && tc90Value >= tc90min && tc90Value <= tc90max)
                    {
                        // for update query with okk status 

                        string Message = "OK";
                        // for update query with okk status 
                        Entryscreendll.updateRecords(sapcode, batchno, H1val, H2val, H3val, H4val, C1val, C2val, C3val, C4val, sgval, wtval, dtval, plantNo, Message);
                        Console.WriteLine("method exicuted ");
                    }
                    else
                    {
                        // for re

                        string PassRejection = Rejection.ToString();
                        Entryscreendll.updateRecordswithrejection(sapcode, batchno, H1val, H2val, H3val, H4val, C1val, C2val, C3val, C4val, sgval, wtval,dtval, plantNo, PassRejection);

                    }
                    // call the above parameter for validate  

                }
            }

            return (machineName, queryType, message);
        }


       

    }
            

            //make methods for machine wise calls 




        }
    
