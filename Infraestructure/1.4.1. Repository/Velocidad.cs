using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities._1._6._3._Repository_Base;
using Utilities.Data_Base;

namespace Infraestructure.Repository
{
    public class Velocidad : RepositoryBase
    {
        public override Data ProcessRequest(Data data)
        {
            Data response = new Data();
            response = data;
            double result = double.Parse(data.DataItems[0].Value.ToString()) / double.Parse(data.DataItems[1].Value.ToString());
            response.DataItems.Add(new DataItem() { Name = "Resultado", Value = result.ToString() });
            return response;
        }
    }
}
