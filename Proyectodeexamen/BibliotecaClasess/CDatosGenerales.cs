using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasess
{
    public class CDatosGenerales
    {
        string nombreEmpresa, periodoDeTiempo;
        int periodoenanos, periodoDeTiempoConvertido;
        
       

        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string PeriodoDeTiempo { get => periodoDeTiempo; set => periodoDeTiempo = value; }
        public int Periodoenanos { get => periodoenanos; set => periodoenanos = value; }
        public int PeriodoDeTiempoConvertido { get => periodoDeTiempoConvertido; set => periodoDeTiempoConvertido = value; }
       


        public void calcularPeriodoDeTiempo(CDatosGenerales datos)
        {



            if (datos.PeriodoDeTiempo.Equals("Mensual"))
            {
                datos.PeriodoDeTiempoConvertido = datos.Periodoenanos * 12;

            }
            else if (datos.PeriodoDeTiempo.Equals("Bimestral"))
            {

                datos.PeriodoDeTiempoConvertido = datos.Periodoenanos * 6;

            }
            else if (datos.PeriodoDeTiempo.Equals("Trimestral"))
            {
                datos.PeriodoDeTiempoConvertido = datos.Periodoenanos * 4;
            }
            else if (datos.PeriodoDeTiempo.Equals("Cuatrimestral"))
            {
                datos.PeriodoDeTiempoConvertido = datos.Periodoenanos * 3;
            }
            else if (datos.PeriodoDeTiempo.Equals("Semestral"))
            {
                datos.PeriodoDeTiempoConvertido = datos.Periodoenanos * 2;
            }
            else if (datos.PeriodoDeTiempo.Equals("Anual"))
            {

                datos.PeriodoDeTiempoConvertido = datos.Periodoenanos * 1;
            }




        }
    }


}
