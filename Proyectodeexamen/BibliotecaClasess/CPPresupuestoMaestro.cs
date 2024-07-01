using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasess
{
    public class CPPresupuestoMaestro
    {
        double ingresosTotalesDelAno, costosDeProduccionTotalesDelAno, gastosAdministrativosydeVentasDelAno,
            CostosIndirectosDeFabricacionDelAno, FlujoNetodeEfectivoDelAno;

        public double IngresosTotalesDelAno { get => ingresosTotalesDelAno; set => ingresosTotalesDelAno = value; }
        public double CostosDeProduccionTotalesDelAno { get => costosDeProduccionTotalesDelAno; set => costosDeProduccionTotalesDelAno = value; }
        public double GastosAdministrativosydeVentasDelAno { get => gastosAdministrativosydeVentasDelAno; set => gastosAdministrativosydeVentasDelAno = value; }
        public double CostosIndirectosDeFabricacionDelAno1 { get => CostosIndirectosDeFabricacionDelAno; set => CostosIndirectosDeFabricacionDelAno = value; }
        public double FlujoNetodeEfectivoDelAno1 { get => FlujoNetodeEfectivoDelAno; set => FlujoNetodeEfectivoDelAno = value; }
    }
}
