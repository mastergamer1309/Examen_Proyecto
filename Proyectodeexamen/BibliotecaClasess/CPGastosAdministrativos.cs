using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasess
{
    public class CPGastosAdministrativos
    {
        int periodo;
        double gastosAdministrativos, gastosDeVentas, totalGastos;

        public int Periodo { get => periodo; set => periodo = value; }
        public double GastosAdministrativos { get => gastosAdministrativos; set => gastosAdministrativos = value; }
        public double GastosDeVentas { get => gastosDeVentas; set => gastosDeVentas = value; }
        public double TotalGastos { get => totalGastos; set => totalGastos = value; }
    }
}
