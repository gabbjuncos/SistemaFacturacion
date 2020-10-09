using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SistemaFacturacion.Clases;
using SistemaFacturacion.Listados;

namespace SistemaFacturacion.Listados
{
    public partial class frmReporteProductos : Form
    {
        // creo objeto datos
        Datos oBD = new Datos();
        public frmReporteProductos()
        {
            InitializeComponent();
        }

        private void frmReporteProductos_Load(object sender, EventArgs e)
        {
            
            this.rptReporteProductos.RefreshReport();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            string sql = "select p.id_producto , p.nombre, fd.precio, f.fecha from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                          "join Productos p on fd.id_producto = p.id_producto" +
                          " where CAST(f.fecha AS DATE) between CAST('" + dtpDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpHasta.Value.ToString("yyyy-MM-dd") + "' AS date)";

            table = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("DatosListadoProductos", table);

            rptReporteProductos.LocalReport.DataSources.Clear();
            rptReporteProductos.LocalReport.DataSources.Add(ds);
            rptReporteProductos.RefreshReport();



        }

        private void rptReporteProductos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();


            string sql = "select p.id_producto , p.nombre, fd.precio, f.fecha from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                          "join Productos p on fd.id_producto = p.id_producto";

            tabla = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("DatosListadoProductos", tabla);

            rptReporteProductos.LocalReport.DataSources.Clear();
            rptReporteProductos.LocalReport.DataSources.Add(ds);
            rptReporteProductos.LocalReport.Refresh();


        }
    }
}
