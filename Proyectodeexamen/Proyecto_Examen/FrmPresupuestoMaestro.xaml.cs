using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BibliotecaClasess;


namespace Proyecto_Examen
{
    /// <summary>
    /// Interaction logic for FrmPresupuestoMaestro.xaml
    /// </summary>
    public partial class FrmPresupuestoMaestro : Window
    {
        //referencias a clases

        CDatosGenerales datosGenerales = new CDatosGenerales();

        //variables globales


        string periodoDeTiempo;
        int periodoTotal;
        int periodoConvertido;
        bool verificarDatosIngresados;

        int contadorventas = 0;

        //Array

        CPVentas[] ventas = new CPVentas[0];



        //botones

        public FrmPresupuestoMaestro()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnIngresarDatosProyecto_Click(object sender, RoutedEventArgs e)
        {

            if (TxtNombreEmpresa.Text.Length < 1 || TxtPeriodoAños.Text.Length < 1 || CmbPeriodoTiempo.SelectedIndex < 0)
            {
                MessageBox.Show("Obligatorio el llenado de datos", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                

                datosGenerales.NombreEmpresa = TxtNombreEmpresa.Text.ToUpper().Trim();

                datosGenerales.PeriodoDeTiempo = CmbPeriodoTiempo.SelectionBoxItem.ToString();


                datosGenerales.Periodoenanos = Convert.ToInt32(TxtPeriodoAños.Text);

                datosGenerales.calcularPeriodoDeTiempo(datosGenerales);

                asdasdasd.Text = datosGenerales.PeriodoDeTiempoConvertido.ToString();

                verificarDatosIngresados = true;



            }






        }

        private void CmbPeriodoTiempo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NuevoPeriodoPVentas_Click(object sender, RoutedEventArgs e)
        {
            

            if(verificarDatosIngresados == true)
            {
                GbxPVentas.IsEnabled = true;
                NuevoPeriodoPVentas.IsEnabled = false;
                IngresarDatosPVentas.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese los datos del proyecto", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            
            
        }

        private void IngresarDatosPVentas_Click(object sender, RoutedEventArgs e)
        {
            if(TxtProducto.Text.Length < 1 || TxtUnidadesVendidas.Text.Length <1 || TxtPrecioUnitario.Text.Length < 1  )
            {
                MessageBox.Show("Ingrese los datos de las ventas", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }else if(contadorventas == datosGenerales.PeriodoDeTiempoConvertido)
            {
                MessageBox.Show("Se ha excedido el numero de periodos", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                

                CPVentas venta = new CPVentas();
                venta.Periodo = contadorventas + 1;
                venta.Producto = TxtProducto.Text;
                venta.UnidadesVendidas = Convert.ToDouble(TxtUnidadesVendidas.Text);
                venta.PrecioUnitario = Convert.ToDouble(TxtPrecioUnitario.Text);
                venta.TotalVentas = (venta.PrecioUnitario * venta.UnidadesVendidas);

                Array.Resize(ref ventas, ventas.Length + 1);
                ventas[ventas.Length - 1] = venta;
                DgPVentas.ItemsSource = ventas;
                DgPVentas.Items.Refresh();

                NuevoPeriodoPVentas.IsEnabled = true;
                IngresarDatosPVentas.IsEnabled = false;
                TxtProducto.Clear();
                TxtUnidadesVendidas.Clear();
                TxtPrecioUnitario.Clear();
                GbxPVentas.IsEnabled=false;

                contadorventas += 1;

            }
        }

        private void BtnNuevoPeriodoPProduccion_Click(object sender, RoutedEventArgs e)
        {
            if (verificarDatosIngresados == true)
            {
                GbxPVentas.IsEnabled = true;
                NuevoPeriodoPVentas.IsEnabled = false;
                IngresarDatosPVentas.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese los datos del proyecto", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
