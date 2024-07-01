using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasess
{
    public class CPProduccion
    {
        int unidadesVendidas, inventarioInicial, inventarioFinalDeseado;

        public int UnidadesVendidas { get => unidadesVendidas; set => unidadesVendidas = value; }
        public int InventarioInicial { get => inventarioInicial; set => inventarioInicial = value; }
        public int InventarioFinalDeseado { get => inventarioFinalDeseado; set => inventarioFinalDeseado = value; }
    }
}
