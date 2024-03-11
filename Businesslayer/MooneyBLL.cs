using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Databaselayer;
namespace Businesslayer
{
    public class MooneyBLL
    {
        private MooneyDAL mooneyDAL;

        public MooneyBLL()
        {
            mooneyDAL = new MooneyDAL();
        }

        public List<string> GetColumnValues()
        {
           
            return mooneyDAL.GetColumnValues();
        }

        //method for insert master to the database using database layer.
        public bool InsertMooneyRecord(string sapcode, string batch_name, string vimin,string vimax,string vmmin, string vmmax,string ml4min,string ml4max)
        {
            

            // Call Data Access Layer to save data
            return mooneyDAL.InsertMooneyRecord(sapcode, batch_name, vimin, vimax, vmmin, vmmax, ml4min, ml4max);
        }

        // mothod to show data on screen  record for mooney.
        public SqlDataReader GetBatchDetails(string sapcode)
        {
            return mooneyDAL.GetBatchDetails(sapcode);
        }
        //update mooney master
        public bool UpdateMasterRecord(string sapcode, string name, string vih, string vil, string vmh, string vml, string ml4h, string ml4l)
        {
            mooneyDAL.UpdateMasterRecord(sapcode, name, vih, vil, vmh, vml, ml4h, ml4l);
        return true;
        }


    }
   
}

