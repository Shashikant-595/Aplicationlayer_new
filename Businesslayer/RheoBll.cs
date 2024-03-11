using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Databaselayer;

namespace Businesslayer
{
    public class RheoBll
    {

        private RheoDll rheoDll;
        public RheoBll()
        {
            // constructure for 

            rheoDll = new RheoDll();

        }


        //rheo bll logic here .
        public bool insertRheorecord(string sapcode, string batch_name, string mlmin, string mlmax, string mhmin, string mhmax, string ts2min, string ts2max, string tc50min, string tc50max, string tc90min, string tc90max, string hardnessmin, string hardnessmax, string specificgravitymin, string specificgravitymax, string conductivitymin, string conductivitymax)
        {

            return rheoDll.insertRheorecord(sapcode, batch_name, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max, tc50min, tc50max, tc90min, tc90max, hardnessmin, hardnessmax, specificgravitymin, specificgravitymax, conductivitymin, conductivitymax);
        }


        public List<string> getrheoSapcodes()
        {
            return rheoDll.getrheoSap();
        }


        public SqlDataReader GetBatchDetails(string sapcode)
        {
            return rheoDll.getBatchdataRheo(sapcode);
        }

        public bool updateRheo(string sapcode, string batch_name, string mlmin, string mlmax, string mhmin, string mhmax, string ts2min, string ts2max, string tc50min, string tc50max, string tc90min, string tc90max, string hardnessmin, string hardnessmax, string specificgravitymin, string specificgravitymax, string conmin, string conmax)
        {

            rheoDll.updateRheo( sapcode, batch_name, mlmin, mlmax, mhmin, mhmax, ts2min, ts2max,tc50min,  tc50max,  tc90min, tc90max, hardnessmin, hardnessmax, specificgravitymin,specificgravitymax, conmin, conmax);
            return true;
        }
    }
}