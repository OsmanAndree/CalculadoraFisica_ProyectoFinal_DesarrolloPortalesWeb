using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities.Data_Base;
using Application._1._2._1._Services;

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
        public Data Velocidad(double Distancia, double Tiempo)
        {
            Data data = new Data();
            data.DataItems.Add(new DataItem { Name = "Distancia", Value = Distancia.ToString() });
            data.DataItems.Add(new DataItem { Name = "Tiempo", Value = Tiempo.ToString() });
            data.NombreMetodo = "Velocidad";
            Services srv = new Services();
            Data result = srv.RequestProcess(data);
            return result;
        }

        [WebMethod]
        public Data Aceleracion(double VelocidadFinal, double VelocidadInicial, double Tiempo)
        {
            Data data = new Data();
            data.DataItems.Add(new DataItem { Name = "VelocidadFinal", Value = VelocidadFinal.ToString() });
            data.DataItems.Add(new DataItem { Name = "VelocidadInicial", Value = VelocidadInicial.ToString() });
            data.DataItems.Add(new DataItem { Name = "Tiempo", Value = Tiempo.ToString() });
            data.NombreMetodo = "Aceleracion";
            Services srv = new Services();
            Data result = srv.RequestProcess(data);
            return result;
        }

        [WebMethod]
        public Data Fuerza(double Masa, double Aceleracion)
        {
            Data data = new Data();
            data.DataItems.Add(new DataItem { Name = "Masa", Value = Masa.ToString() });
            data.DataItems.Add(new DataItem { Name = "Aceleracion", Value = Aceleracion.ToString() });
            data.NombreMetodo = "Fuerza";
            Services srv = new Services();
            Data result = srv.RequestProcess(data);
            return result;
        }

    }
}
