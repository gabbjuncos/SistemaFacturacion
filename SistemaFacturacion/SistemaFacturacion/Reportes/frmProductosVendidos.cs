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
using SistemaFacturacion.Listados;
using SistemaFacturacion.Clases;



namespace SistemaFacturacion.Reportes
{
    public partial class frmProductosVendidos : Form
    {

        // creo objeto datos
        Datos oBD = new Datos();
        public frmProductosVendidos()
        {
            InitializeComponent();
        }

        private void frmProductosVendidos_Load(object sender, EventArgs e)
        {
    
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string sql =  " select pr.nombre, COUNT(pr.id_producto) as cantidad from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                          " join Productos pr on fd.id_producto = pr.id_producto" +
                          " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                          " AND nombre <> '<<Ninguno>>'" +
                          " GROUP BY pr.nombre, pr.id_producto";


            tabla = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("DSProductosVendidos", tabla);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.LocalReport.Refresh();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Rango invalido de fechas");
                dtpFechaDesde.Focus();
                return;
            }

            DataTable table = new DataTable();

            string sql = " select pr.nombre, COUNT(pr.id_producto) as cantidad from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                          " join Productos pr on fd.id_producto = pr.id_producto" +
                          " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                          " AND nombre <> '<<Ninguno>>'" +
                          " GROUP BY pr.nombre, pr.id_producto";

            table = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("DSProductosVendidos", table);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.RefreshReport();

            MessageBox.Show("Las fechas han sido filtradas correctamente");
        }
    }
}
