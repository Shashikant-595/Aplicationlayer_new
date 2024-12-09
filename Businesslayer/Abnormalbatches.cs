using Databaselayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class Abnormalbatches
    {

        //  this class is for to colect the abnormal batckes from mixing .
        // every 7 am mail is fired so get all batches and compare to its master 
        public static void get_Batchdata(string sapcode, string batchno,decimal ml, decimal mh,decimal ts2,decimal tc50,decimal tc90)
        {
            double ML, MH, TS2, TC50, TC90;
          ML= Convert.ToDouble(ml);
            MH= Convert.ToDouble(mh);
            TS2= Convert.ToDouble(ts2);
            TC50= Convert.ToDouble(tc50);
            TC90= Convert.ToDouble(tc90);
           
            //get actual batch data of batch 
            string machineName = "";
            string queryType = "";
            List<object[]> dataList = new List<object[]>();

            (machineName, queryType, dataList) = Entryscreendll.GetBatchmaster(sapcode);
            if (machineName.Equals("both") || machineName.Equals("rheo"))
            {

                foreach (object[] row in dataList)
                {

                    sapcode = row[0]?.ToString() ?? string.Empty;
                    double mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max;

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

                }

                //validate batch here using master data 


            }
            //write batch in excel file as abnormal








        }
    }
}
