using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdaptador
{

    class Program
    {
        static void Main(string[] args)
        {

            //IGeneradorEnteroComoString origen = new GeneradorEnteroComoString();
            //IConvertidorDecimal destino = new ConvertidorDecimal(origen);

            //Console.WriteLine($"Total: \"{origen.GenerarEnteroComoString()}\" convertido a {destino.ConvertirADecimal().ToString("0.00")}");
            //Console.ReadKey();
            ConsumidorInfoSucursales consumidorInfoSucursales = new ConsumidorInfoSucursales();


            Console.WriteLine("* Obteniendo Datos del servidor Original:");
            IServicioOriginalInfoSucursales servicioOriginalInfoSucursales = new ServicioOriginalInfoSucursales();
            consumidorInfoSucursales.ConsumirInfoSucursales(servicioOriginalInfoSucursales);

            Console.WriteLine("\n* Obteniendo Datos del servidor Alternativo:");
            IServicioAlternativoInfoSucursales servicioAlternativoInfoSucursales = new ServicioAlternativoInfoSucursales();
            Console.WriteLine("Datos Crudos Recibidos:");
            Console.WriteLine(servicioAlternativoInfoSucursales.ObtenerInfoSucursales().ToString());
            Console.WriteLine("Datos Adaptados:");
            IAdaptadorJSONADatos adaptadorJSONADatos = new AdaptadorJSONADatos(servicioAlternativoInfoSucursales);
            consumidorInfoSucursales.ConsumirInfoSucursales(adaptadorJSONADatos.AdaptarJSONADatos());

            Console.ReadKey();
        }
    }
}
