using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities._1._6._3._Repository_Base;
using Utilities.Data_Base;

namespace Infraestructure.Repository
{
    public class Fuerza :RepositoryBase
    {
        public override Data ProcessRequest(Data data)
        {
            Data response = new Data();
            response = data;

            try
            {
                double masa = double.Parse(data.DataItems[0].Value.ToString());
                double aceleracion = double.Parse(data.DataItems[1].Value.ToString());

                

                double result = masa * aceleracion;

                response.DataItems.Add(new DataItem() { Name = "Resultado", Value = result.ToString("F2") });
            }
            catch (FormatException)
            {
                response.DataItems.Add(new DataItem() { Name = "Error", Value = "Los datos proporcionados deben ser numéricos." });
            }
            catch (Exception ex)
            {
                response.DataItems.Add(new DataItem() { Name = "Error", Value = $"Ocurrió un error: {ex.Message}" });
            }

            return response;
        }
    }
}
