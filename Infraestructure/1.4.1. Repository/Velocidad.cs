using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Data_Base;
using Utilities._1._6._3._Repository_Base;

namespace Infraestructure.Repository
{
    public class Velocidad : RepositoryBase
    {
        public override Data ProcessRequest(Data data)
        {
            Data response = new Data();
            response = data;
            int result = int.Parse(data.DataItems[0].Value.ToString()) * int.Parse(data.DataItems[1].Value.ToString());
            response.DataItems.Add(new DataItem() { Name = "Result", Value = result.ToString() });
            return response;
        }
    }
}
