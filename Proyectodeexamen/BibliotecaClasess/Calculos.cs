using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasess
{
    public class Calculos
    {
        public decimal PrecioDeVentaPorUnidad { get; set; }
        public decimal CostoVariablePorUnidad { get; set; }
        public decimal CostosFijosTotales { get; set; }

        public Calculos(decimal precioVentaPorUnidad, decimal costoVariablePorUnidad, decimal costosFijosTotales)
        {
            PrecioDeVentaPorUnidad = precioVentaPorUnidad;
            CostoVariablePorUnidad = costoVariablePorUnidad;
            CostosFijosTotales = costosFijosTotales;
        }

        public decimal MargenContribucionPorUnidad()
        {
            return PrecioDeVentaPorUnidad - CostoVariablePorUnidad;
        }

        public decimal PuntoEquilibrioEnUnidades()
        {
            return CostosFijosTotales / MargenContribucionPorUnidad();
        }

        public decimal PuntoEquilibrioEnVentas()
        {
            return PuntoEquilibrioEnUnidades() * PrecioDeVentaPorUnidad;
        }


    }
}
