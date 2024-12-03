using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities._1._6._4._Service_Base;
using Utilities.Data_Base;

namespace Application._1._2._1._Services
{
    public class Services
    {

        public Data RequestProcess(Data data)
        {
            ServiceBase services = new ServiceBase();
            Data result = new Data();
            try
            {
                services.AddItem("Velocidad", new Velocidad());
                services.AddItem("Aceleracion", new Aceleracion());

                result = services.RequestProcess(data.NombreMetodo, data);
                return result;
            }
            catch (Exception ex)
            {

                Data error = new Data();

                error.DataItems.Add(new DataItem() { Name = "Error", Value = ex.Message });
                return error;
            }


        }
    }
}
