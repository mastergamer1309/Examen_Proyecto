using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasess
{
    public class CPProduccion
    {

        int  periodo,  unidadesVendidas, inventarioFinalDeseado, inventarioInicial, unidadesAProducir ;

        public int Periodo { get => periodo; set => periodo = value; }
        
        public int UnidadesVendidas { get => unidadesVendidas; set => unidadesVendidas = value; }
        public int InventarioFinalDeseado { get => inventarioFinalDeseado; set => inventarioFinalDeseado = value; }
        public int InventarioInicial { get => inventarioInicial; set => inventarioInicial = value; }
        public int UnidadesAProducir { get => unidadesAProducir; set => unidadesAProducir = value; }
        
    }
}
