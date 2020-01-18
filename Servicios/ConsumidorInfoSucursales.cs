using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploAdaptador
{
    class ConsumidorInfoSucursales
    {
        public void ConsumirInfoSucursales(IServicioOriginalInfoSucursales servicioOriginalInfoSucursales)
        {
            Console.WriteLine(string.Join("\n", servicioOriginalInfoSucursales.ObtenerInfoSucursales().Select(s => ("Ventas de " + s[0] + " = " + s[1]))));
        }
    }
}
