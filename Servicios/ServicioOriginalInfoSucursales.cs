using System.Collections.Generic;

namespace EjemploAdaptador
{
    class ServicioOriginalInfoSucursales : IServicioOriginalInfoSucursales
    {
        public List<string[]> InfoSucursales { get; set; }

        public ServicioOriginalInfoSucursales()
        {
            InfoSucursales = new List<string[]> { new string[] { "Sucursal1", "5500" }, new string[] { "Sucursal2", "10700" }, new string[] { "Sucursal3", "7800" } };
        }

        public List<string[]> ObtenerInfoSucursales()
        {
            return InfoSucursales;
        }
    }
}
