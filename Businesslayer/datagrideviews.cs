using Databaselayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class datagrideviewsbll
    {
        public DataTable GetTableDataForAdvancedGridView()
        {
            datagrideview dal = new datagrideview();
            return dal.GetTableDataForAdvancedGridView();
        }
    }
}
