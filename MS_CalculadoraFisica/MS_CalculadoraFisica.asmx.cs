using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MS_CalculadoraFisica
{
    /// <summary>
    /// Descripción breve de MS_CalculadoraFisica
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class MS_CalculadoraFisica : System.Web.Services.WebService
    {

        [WebMethod]
        public Data Velocidad(int numberA, int numberB)
        {
            Data data = new Data();
            data.DataItems.Add(new DataItem { Name = "numberA", Value = numberA.ToString() });
            data.DataItems.Add(new DataItem { Name = "numberB", Value = numberB.ToString() });
            data.NombreMetodo = "Velocidad";
            Services srv = new Services();
            Data result = srv.RequestProcess(data);
            return result;
        }
    }
}
