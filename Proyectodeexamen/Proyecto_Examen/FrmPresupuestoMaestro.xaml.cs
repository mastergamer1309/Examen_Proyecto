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
        string periodoDeTiempo;
        int periodoTotal;
        int periodoConvertido;


        
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
                CDatosGenerales datosGenerales = new CDatosGenerales();

                datosGenerales.NombreEmpresa = TxtNombreEmpresa.Text.ToUpper().Trim();

                datosGenerales.PeriodoDeTiempo = CmbPeriodoTiempo.SelectionBoxItem.ToString();


                datosGenerales.Periodoenanos = Convert.ToInt32(TxtPeriodoAños.Text);

                datosGenerales.calcularPeriodoDeTiempo(datosGenerales);

                asdasdasd.Text = datosGenerales.PeriodoDeTiempoConvertido.ToString();



            }






        }

        private void CmbPeriodoTiempo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NuevoPeriodoPVentas_Click(object sender, RoutedEventArgs e)
        {
            
            
            
            GbxPVentas.IsEnabled = true;
        }
    }
}
