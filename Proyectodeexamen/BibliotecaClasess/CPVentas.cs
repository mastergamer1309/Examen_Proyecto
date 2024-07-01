using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasess
{
    public class CPVentas
    {
        int periodo;
        string producto;
        double unidadesVendidas, precioUnitario, totalVentas;

        public int Periodo { get => periodo; set => periodo = value; }
        public string Producto { get => producto; set => producto = value; }
        public double UnidadesVendidas { get => unidadesVendidas; set => unidadesVendidas = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public double TotalVentas { get => totalVentas; set => totalVentas = value; }
        
    }
}
