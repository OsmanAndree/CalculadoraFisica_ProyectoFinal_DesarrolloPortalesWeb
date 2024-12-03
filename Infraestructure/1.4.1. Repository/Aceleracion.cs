using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities._1._6._3._Repository_Base;
using Utilities.Data_Base;

namespace Infraestructure.Repository
{
    public class Aceleracion : RepositoryBase
    {
        public override Data ProcessRequest(Data data)
        {
            Data response = new Data();
            response = data;

            try
            {
                double velocidadFinal = double.Parse(data.DataItems[0].Value.ToString());
                double velocidadInicial = double.Parse(data.DataItems[1].Value.ToString());
                double tiempo = double.Parse(data.DataItems[2].Value.ToString());
                if (tiempo == 0)
                {
                    response.DataItems.Add(new DataItem() { Name = "Error", Value = "El tiempo no puede ser cero." });
                    return response;
                }
                double result = (velocidadFinal - velocidadInicial) / tiempo;

          
                response.DataItems.Add(new DataItem() { Name = "Aceleracion", Value = result.ToString("F2") });
            }
            catch (FormatException)
            {
                response.DataItems.Add(new DataItem() { Name = "Error", Value = "Los datos deben ser numéricos." });
            }
            catch (Exception ex)
            {
                response.DataItems.Add(new DataItem() { Name = "Error", Value = $"Ocurrió un error: {ex.Message}" });
            }

            return response;
        }
    }
}
