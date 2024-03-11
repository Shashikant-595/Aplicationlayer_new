using Databaselayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class BothBll
    {
        private BothDll bothdll;
        public BothBll() {
            bothdll = new BothDll(); 
        
        }
        public bool insertBothrecord(string sapcode, string batch_name, string mlmin, string mlmax, string mhmin, string mhmax, string ts2min, string ts2max, string tc50min, string tc50max, string tc90min, string tc90max, string hardnessmin, string hardnessmax, string specificgravitymin, string specificgravitymax, string conductivitymin, string conductivitymax, string vimin, string vimax, string vmmin, string vmmax, string ml4min, string ml4max)
        {

            return bothdll.insertBothrecord(sapcode, batch_name, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardnessmin, hardnessmax, specificgravitymin, specificgravitymax, conductivitymin, conductivitymax, vimin, vimax, vmmin, vmmax, ml4min, ml4max);
        }


        public List<string> getBothSapcodes()
        {
            return bothdll.getBothSap();
        }
        public SqlDataReader GetBatchDetails(string sapcode)
        {
            return bothdll.GetBatchDetails(sapcode);
        }
        public bool updatBoth(string sapcode, string batch_name, string mlmin, string mlmax, string mhmin, string mhmax, string ts2min, string ts2max, string tc50min, string tc50max, string tc90min, string tc90max, string hardnessmin, string hardnessmax, string specificgravitymin, string specificgravitymax, string conmin, string conmax, string vih, string vil, string vmh, string vml, string ml4h, string ml4l)
        {

            bothdll.updateBoth(sapcode, batch_name, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardnessmin, hardnessmax, specificgravitymin, specificgravitymax, conmin, conmax, vih, vil, vmh, vml, ml4h, ml4l);
        return true;
        }

    }
}
