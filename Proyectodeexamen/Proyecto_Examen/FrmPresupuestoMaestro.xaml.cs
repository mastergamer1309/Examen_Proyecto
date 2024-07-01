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

        

        //Array

        CPVentas[] ventas = new CPVentas[0];
        CPProduccion[] producciones = new CPProduccion[0];
        CPMaterialesDirectos[] materiales = new CPMaterialesDirectos[0];
        CPMod[] mods = new CPMod[0];
        CPCif[] cifs = new CPCif[0];
        CPGastosAdministrativos[] gastos = new CPGastosAdministrativos[0];
        CPEfectivo[] efectivos = new CPEfectivo[0];

        //contadores

        int contadorventas = 0;
        int contadorproduccion = 0;
        int contadorMaterialesDirectos = 0;
        int contadorMOD = 0;
        int contadorCIF = 0;
        int contadorGastos = 0;
        int contadorEfectivo = 0;

        //Variables para presupuesto maestro 

        Double IngresosTotalesDelAno = 0;
        Double CostosDeProduccionTotalesDelAno = 0;
        Double GastosAdministrativosYDeVentasDelAno = 0;
        Double CostosIndirectosDeFabricacionDelAno = 0;
        Double TotalDeCostos = 0;
        Double UtilidadNeta = 0;


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

            

            if (TxtProducto.Text.Length < 1 || TxtUnidadesVendidas.Text.Length <1 || TxtPrecioUnitario.Text.Length < 1  )
            {
                MessageBox.Show("Ingrese los datos de las ventas", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }else if(contadorventas == datosGenerales.PeriodoDeTiempoConvertido)
            {
                MessageBox.Show("Se ha excedido el numero de periodos", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                

                CPVentas venta = new CPVentas();
                venta.Periodo = contadorventas += 1;
                venta.Producto = TxtProducto.Text;
                venta.UnidadesVendidas = Convert.ToDouble(TxtUnidadesVendidas.Text);
                venta.PrecioUnitario = Convert.ToDouble(TxtPrecioUnitario.Text);
                venta.TotalVentas = (venta.PrecioUnitario * venta.UnidadesVendidas);

                IngresosTotalesDelAno += venta.TotalVentas;

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

                

            }
        }

        private void BtnNuevoPeriodoPProduccion_Click(object sender, RoutedEventArgs e)
        {
            if (verificarDatosIngresados == true)
            {
                GbxPProduccion.IsEnabled = true;
                BtnNuevoPeriodoPProduccion.IsEnabled = false;
                BtnIngresarDatosPProduccion.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese los datos del proyecto", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnNuevoPeriodoPMaterialesDirectos_Click(object sender, RoutedEventArgs e)
        {
            if (verificarDatosIngresados == true)
            {
                GbxPMaterialesDirectos.IsEnabled = true;
                BtnNuevoPeriodoPMaterialesDirectos.IsEnabled = false;
                BtnIngresarDatosPMaterialesDirectos.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese los datos del proyecto", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnNuevoPeriodoPMOD_Click(object sender, RoutedEventArgs e)
        {
            if (verificarDatosIngresados == true)
            {
                GbxPMOD.IsEnabled = true;
                BtnNuevoPeriodoPMOD.IsEnabled = false;
                BtnIngresarDatosPMOD.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese los datos del proyecto", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnNuevoPeriodoPCIF_Click(object sender, RoutedEventArgs e)
        {
            if (verificarDatosIngresados == true)
            {
                GbxPCIF.IsEnabled = true;
                BtnNuevoPeriodoPCIF.IsEnabled = false;
                BtnIngresarDatosPCIF.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese los datos del proyecto", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnNuevoPeriodoPGastos_Click(object sender, RoutedEventArgs e)
        {
            if (verificarDatosIngresados == true)
            {
                GbxPGastos.IsEnabled = true;
                BtnNuevoPeriodoPGastos.IsEnabled = false;
                BtnIngresarDatosPGastos.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese los datos del proyecto", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnNuevoPeriodoPEfectivo_Click(object sender, RoutedEventArgs e)
        {
            if (verificarDatosIngresados == true)
            {
                GbxPEfectivo.IsEnabled = true;
                BtnNuevoPeriodoPEfectivo.IsEnabled = false;
                BtnIngresarDatosPEfectivo.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese los datos del proyecto", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnIngresarDatosPProduccion_Click(object sender, RoutedEventArgs e)
        {
            

            if (TxtUnidadesVendidas1.Text.Length < 1 || TxtInventarioInicial.Text.Length < 1 || TxtInventarioFinalDeseado.Text.Length < 1)
            {
                MessageBox.Show("Ingrese los datos de las ventas", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (contadorproduccion == datosGenerales.PeriodoDeTiempoConvertido)
            {
                MessageBox.Show("Se ha excedido el numero de periodos", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {


                CPProduccion produccion = new CPProduccion();

                produccion.Periodo = contadorproduccion +=1;
                produccion.UnidadesVendidas = Convert.ToInt32(TxtUnidadesVendidas1.Text);
                produccion.InventarioInicial = Convert.ToInt32(TxtInventarioInicial.Text);
                produccion.InventarioFinalDeseado = Convert.ToInt32(TxtInventarioFinalDeseado.Text);
                produccion.UnidadesAProducir = (produccion.UnidadesVendidas + produccion.InventarioFinalDeseado - produccion.InventarioInicial);

                Array.Resize(ref producciones, producciones.Length + 1);
                producciones[producciones.Length - 1] = produccion;
                DgPProduccion.ItemsSource = producciones;
                DgPProduccion.Items.Refresh();

                BtnNuevoPeriodoPProduccion.IsEnabled = true;
                BtnIngresarDatosPProduccion.IsEnabled = false;
                TxtUnidadesVendidas1.Clear();
                TxtInventarioInicial.Clear();
                TxtInventarioFinalDeseado.Clear();
                GbxPProduccion.IsEnabled = false;

                

            }
        }

        private void BtnIngresarDatosPMaterialesDirectos_Click(object sender, RoutedEventArgs e)
        {
            if (TxtUnidadesAProducir.Text.Length < 1 || TxtMaterialPrincipal.Text.Length < 1 || TxtCantidadMaterialPorUnidad.Text.Length < 1 || TxtCostoUnitarioPMaterialesDirectos.Text.Length < 1)
            {
                MessageBox.Show("Ingrese los datos de los materiales", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (contadorMaterialesDirectos == datosGenerales.PeriodoDeTiempoConvertido)
            {
                MessageBox.Show("Se ha excedido el numero de periodos", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {


                CPMaterialesDirectos material = new CPMaterialesDirectos();

                material.Periodo = contadorMaterialesDirectos += 1;
                material.UnidadesAProducir = Convert.ToInt32(TxtUnidadesAProducir.Text);
                material.MaterialPrincipal = TxtMaterialPrincipal.Text;
                material.MaterialNecesario = (Convert.ToDouble(TxtCantidadMaterialPorUnidad.Text)*(Convert.ToInt32(TxtUnidadesAProducir.Text)));
                material.CostoUnitario = Convert.ToDouble(TxtCostoUnitarioPMaterialesDirectos.Text);
                material.TotalCostoMaterialesDirectos = (material.MaterialNecesario * material.CostoUnitario);

                CostosDeProduccionTotalesDelAno += material.TotalCostoMaterialesDirectos;
                


                Array.Resize(ref materiales, materiales.Length + 1);
                materiales[materiales.Length - 1] = material;
                DgPMaterialesDirectos.ItemsSource = materiales;
                DgPMaterialesDirectos.Items.Refresh();

                BtnNuevoPeriodoPMaterialesDirectos.IsEnabled = true;
                BtnIngresarDatosPMaterialesDirectos.IsEnabled = false;
                TxtUnidadesAProducir.Clear();
                TxtMaterialPrincipal.Clear();
                TxtCantidadMaterialPorUnidad.Clear();
                TxtCostoUnitarioPMaterialesDirectos.Clear();
                GbxPMaterialesDirectos.IsEnabled = false;



            }
        }

        private void BtnIngresarDatosPMOD_Click(object sender, RoutedEventArgs e)
        {
            if (TxtUnidadesAProducir1.Text.Length < 1 || TxtHorasModPorUnidad.Text.Length < 1 || TxtCostoPorHoraManoDeObra.Text.Length < 1)
            {
                MessageBox.Show("Ingrese los datos de los materiales", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (contadorMOD == datosGenerales.PeriodoDeTiempoConvertido)
            {
                MessageBox.Show("Se ha excedido el numero de periodos", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {


                CPMod mod = new CPMod();

                mod.Periodo = contadorMOD += 1;
                mod.UnidadesAProducir = Convert.ToInt32(TxtUnidadesAProducir1.Text);
                mod.HorasDeMODPorUnidad = Convert.ToDouble(TxtHorasModPorUnidad.Text);
                mod.HorasNecesarias = ((mod.UnidadesAProducir) * (mod.HorasDeMODPorUnidad));
                mod.CostoPorHoraManoDeObra = Convert.ToDouble(TxtCostoPorHoraManoDeObra.Text);
                mod.TotalCosto = ((mod.HorasNecesarias) *(mod.CostoPorHoraManoDeObra));

                CostosDeProduccionTotalesDelAno += mod.TotalCosto;



                Array.Resize(ref mods, mods.Length + 1);
                mods[mods.Length - 1] = mod;
                DgPMOD.ItemsSource = mods;
                DgPMOD.Items.Refresh();

                BtnNuevoPeriodoPMOD.IsEnabled = true;
                BtnIngresarDatosPMOD.IsEnabled = false;
                TxtUnidadesAProducir1.Clear();
                TxtHorasModPorUnidad.Clear();
                TxtCostoPorHoraManoDeObra.Clear();
             
                GbxPMOD.IsEnabled = false;



            }
        }

        private void BtnIngresarDatosPCIF_Click(object sender, RoutedEventArgs e)
        {
            if (TxtCIF.Text.Length < 1)
            {
                MessageBox.Show("Ingrese los datos de los materiales", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (contadorCIF == datosGenerales.PeriodoDeTiempoConvertido)
            {
                MessageBox.Show("Se ha excedido el numero de periodos", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {


                CPCif cif = new CPCif();

                cif.Periodo = contadorCIF += 1;
                cif.Cif = Convert.ToDouble(TxtCIF.Text);

                CostosDeProduccionTotalesDelAno += cif.Cif;
                CostosIndirectosDeFabricacionDelAno += cif.Cif;



                Array.Resize(ref cifs, cifs.Length + 1);
                cifs[cifs.Length - 1] = cif;
                DgPCIF.ItemsSource = cifs;
                DgPCIF.Items.Refresh();

                BtnNuevoPeriodoPCIF.IsEnabled = true;
                BtnIngresarDatosPCIF.IsEnabled = false;
                TxtCIF.Clear();
                


                GbxPCIF.IsEnabled = false;



            }
        }

        private void BtnIngresarDatosPGastos_Click(object sender, RoutedEventArgs e)
        {
            if (TxtGastosAdministrativos.Text.Length < 1 || TxtGastosDeVentas.Text.Length < 1)
            {
                MessageBox.Show("Ingrese los datos de los materiales", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (contadorGastos == datosGenerales.PeriodoDeTiempoConvertido)
            {
                MessageBox.Show("Se ha excedido el numero de periodos", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {


               CPGastosAdministrativos gasto = new CPGastosAdministrativos();

                gasto.Periodo = contadorGastos += 1;
                gasto.GastosAdministrativos = Convert.ToDouble(TxtGastosAdministrativos.Text);
                gasto.GastosDeVentas = Convert.ToDouble(TxtGastosDeVentas.Text);
                gasto.TotalGastos = ((gasto.GastosAdministrativos) + (gasto.GastosDeVentas));

                GastosAdministrativosYDeVentasDelAno += gasto.TotalGastos;




                Array.Resize(ref gastos, gastos.Length + 1);
                gastos[gastos.Length - 1] = gasto;
                DgPGastos.ItemsSource = gastos;
                DgPGastos.Items.Refresh();

                BtnNuevoPeriodoPGastos.IsEnabled = true;
                BtnIngresarDatosPGastos.IsEnabled = false;
                TxtGastosAdministrativos.Clear();
                TxtGastosDeVentas.Clear();
                

                GbxPGastos.IsEnabled = false;



            }
        }

        private void BtnIngresarDatosPEfectivo_Click(object sender, RoutedEventArgs e)
        {
            if (TxtEntradasDeEfectivo.Text.Length < 1 || TxtSalidasDeEfectivo.Text.Length < 1)
            {
                MessageBox.Show("Ingrese los datos de los materiales", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (contadorEfectivo == datosGenerales.PeriodoDeTiempoConvertido)
            {
                MessageBox.Show("Se ha excedido el numero de periodos", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {


                CPEfectivo efectivo = new CPEfectivo();

                efectivo.Periodo = contadorEfectivo += 1;

                efectivo.EntradasDeEfectivo = Convert.ToDouble(TxtEntradasDeEfectivo.Text);
                efectivo.SalidasDeEfectivo = Convert.ToDouble(TxtSalidasDeEfectivo.Text);
                efectivo.FlujoNetoDeEfectivo = ((efectivo.EntradasDeEfectivo)- (efectivo.SalidasDeEfectivo));




                Array.Resize(ref efectivos, efectivos.Length + 1);
                efectivos[efectivos.Length - 1] = efectivo;
                DgPEfectivo.ItemsSource = efectivos;
                DgPEfectivo.Items.Refresh();

                BtnNuevoPeriodoPEfectivo.IsEnabled = true;
                BtnIngresarDatosPEfectivo.IsEnabled = false;
                TxtEntradasDeEfectivo.Clear();
                TxtSalidasDeEfectivo.Clear();


                GbxPEfectivo.IsEnabled = false;



            }
        }

        private void BtnCalcularPresupuestoMaestro_Click(object sender, RoutedEventArgs e)
        {

            TotalDeCostos = (CostosDeProduccionTotalesDelAno + GastosAdministrativosYDeVentasDelAno);

            UtilidadNeta = (IngresosTotalesDelAno - TotalDeCostos);

            if (IngresosTotalesDelAno == 0 || CostosDeProduccionTotalesDelAno == 0 || GastosAdministrativosYDeVentasDelAno == 0
                || CostosIndirectosDeFabricacionDelAno == 0 || TotalDeCostos == 0 || UtilidadNeta == 0)
            {
                MessageBox.Show("Faltan datos para el calculo del Presupuesto Maestro", "Informacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                

                TxtPresupuestoMaestro.Text = impresion();
            }
           

            

        }

        public string impresion()
        {
            string retorno = "";

            

            retorno += "Utilidad Neta(Ingresos Totales - Costos Totales): $" + IngresosTotalesDelAno + " - $" + TotalDeCostos + " : $" +
                UtilidadNeta;

            return retorno;
        }
    }
}
