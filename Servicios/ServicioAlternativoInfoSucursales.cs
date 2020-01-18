using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploAdaptador
{
    class ServicioAlternativoInfoSucursales : IServicioAlternativoInfoSucursales
    {
        public string ObtenerInfoSucursales()
        {
            return (JsonConvert.SerializeObject(new List<string[]> { new string[] { "Sucursal1", "5500" }, new string[] { "Sucursal2", "10700" }, new string[] { "Sucursal3", "7800" } }));
        }
    }
}
