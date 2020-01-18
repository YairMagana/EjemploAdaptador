using Newtonsoft.Json;
using System.Collections.Generic;

namespace EjemploAdaptador
{
    class AdaptadorJSONADatos : IAdaptadorJSONADatos
    {
        private readonly IServicioAlternativoInfoSucursales origen;

        public AdaptadorJSONADatos(IServicioAlternativoInfoSucursales origen)
        {
            this.origen = origen;
        }

        public IServicioOriginalInfoSucursales AdaptarJSONADatos()
        {
            //decimal v;
            //if (decimal.TryParse(origen.ObtenerInfoSucursales, out v))
            //    return v;
            //return 0m;

            List<string[]> info = JsonConvert.DeserializeObject<List<string[]>>(origen.ObtenerInfoSucursales());
            IServicioOriginalInfoSucursales servicioOriginalInfoSucursales = new ServicioOriginalInfoSucursales();
            servicioOriginalInfoSucursales.InfoSucursales = info;
            return servicioOriginalInfoSucursales;
        }
    }
}
