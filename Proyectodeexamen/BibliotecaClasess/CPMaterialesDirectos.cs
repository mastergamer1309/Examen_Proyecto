using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasess
{
    public class CPMaterialesDirectos
    {

        string materialPrincipal;

        int periodo, unidadesAProducir;
        
        double materialNecesario, costoUnitario;

        double totalCostoMaterialesDirectos;
        public int Periodo { get => periodo; set => periodo = value; }
        public string MaterialPrincipal { get => materialPrincipal; set => materialPrincipal = value; }
        public int UnidadesAProducir { get => unidadesAProducir; set => unidadesAProducir = value; }
        public double MaterialNecesario { get => materialNecesario; set => materialNecesario = value; }
        
        public double CostoUnitario { get => costoUnitario; set => costoUnitario = value; }
        public double TotalCostoMaterialesDirectos { get => totalCostoMaterialesDirectos; set => totalCostoMaterialesDirectos = value; }
    }
}
