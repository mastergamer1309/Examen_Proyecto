using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasess
{
    public class CPEfectivo
    {
        int periodo;
        double entradasDeEfectivo, salidasDeEfectivo, flujoNetoDeEfectivo;

        public int Periodo { get => periodo; set => periodo = value; }
        public double EntradasDeEfectivo { get => entradasDeEfectivo; set => entradasDeEfectivo = value; }
        public double SalidasDeEfectivo { get => salidasDeEfectivo; set => salidasDeEfectivo = value; }
        public double FlujoNetoDeEfectivo { get => flujoNetoDeEfectivo; set => flujoNetoDeEfectivo = value; }
    }
}
