using BibliotecaClasess;
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

namespace Proyecto_Examen
{
    /// <summary>
    /// Interaction logic for FrmCVU.xaml
    /// </summary>
    public partial class FrmCVU : Window
    {
        public FrmCVU()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal precioVenta = decimal.Parse(TxtPrecioDeVentaPorUnidad.Text);
                decimal costoVariable = decimal.Parse(TxtCostoVariablePorUnidad.Text);
                decimal costosFijos = decimal.Parse(TxtCostosFijosTotales.Text);

                Calculos calculator = new Calculos(precioVenta, costoVariable, costosFijos);

                decimal margenContribucion = calculator.MargenContribucionPorUnidad();
                decimal puntoEquilibrioUnidades = calculator.PuntoEquilibrioEnUnidades();
                decimal puntoEquilibrioVentas = calculator.PuntoEquilibrioEnVentas();

                TxtMargenDeContribucionPorUnidad.Text = $"Margen de Contribución por Unidad: {margenContribucion:C}";
                TxtPuntoDeEquilibrioEnUnidades.Text = $"Punto de Equilibrio en Unidades: {puntoEquilibrioUnidades}";
                TxtPuntoDeEquilibrioEnVentas.Text = $"Punto de Equilibrio en Ventas: {puntoEquilibrioVentas:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos de entrada. Por favor, verifica los valores.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrmPantallaPrincipal frmPantallaPrincipal = new FrmPantallaPrincipal();

            frmPantallaPrincipal.Show();

            this.Close();
            
            
        }
    }
}
