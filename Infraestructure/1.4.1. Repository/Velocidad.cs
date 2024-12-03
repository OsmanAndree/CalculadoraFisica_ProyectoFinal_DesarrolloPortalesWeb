using System;
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

            try
            {
                double distancia = double.Parse(data.DataItems[0].Value.ToString());
                double tiempo = double.Parse(data.DataItems[1].Value.ToString());

                if (tiempo == 0)
                {
                    response.DataItems.Add(new DataItem() { Name = "Error", Value = "El tiempo no puede ser cero." });
                    return response;
                }

                double result = distancia / tiempo;

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
