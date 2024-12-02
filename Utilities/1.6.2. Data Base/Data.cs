using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Data_Base
{
    public class Data
    {
        public Data()
        {
            DataItems = new List<DataItem>();
        }

        public string NombreMetodo;
        public List<DataItem> DataItems;
    }
}
