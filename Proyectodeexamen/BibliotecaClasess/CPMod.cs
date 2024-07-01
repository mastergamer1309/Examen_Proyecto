using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasess
{
    public class CPMod
    {
        int periodo;

        int unidadesAProducir;
        double horasDeMODPorUnidad, horasNecesarias, costoPorHoraManoDeObra, totalCosto;

        public int Periodo { get => periodo; set => periodo = value; }
        public int UnidadesAProducir { get => unidadesAProducir; set => unidadesAProducir = value; }
        public double HorasDeMODPorUnidad { get => horasDeMODPorUnidad; set => horasDeMODPorUnidad = value; }
        public double HorasNecesarias { get => horasNecesarias; set => horasNecesarias = value; }
        public double CostoPorHoraManoDeObra { get => costoPorHoraManoDeObra; set => costoPorHoraManoDeObra = value; }
        public double TotalCosto { get => totalCosto; set => totalCosto = value; }
    }
}
