using System.Collections.Generic;

namespace EjemploAdaptador
{
    public interface IServicioOriginalInfoSucursales
    {
        List<string[]> InfoSucursales { get; set; }

        List<string[]> ObtenerInfoSucursales();
    }
}
