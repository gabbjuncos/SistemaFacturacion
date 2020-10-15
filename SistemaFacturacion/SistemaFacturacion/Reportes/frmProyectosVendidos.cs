using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFacturacion.Clases;

namespace SistemaFacturacion.Reportes
{
    public partial class frmProyectosVendidos : Form
    {
        // creo objeto datos
        Datos oBD = new Datos();

        public frmProyectosVendidos()
        {
            InitializeComponent();
        }

        private void frmProyectosVendidos_Load(object sender, EventArgs e)
        {

            this.rpvEstadisticaProyectosVendidos.RefreshReport();
        }

        private void rpvEstadisticaProyectosVendidos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string sql = "select p.descripcion, COUNT(p.id_proyecto) as cantidad from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                          "join Proyectos p on fd.id_proyecto = p.id_proyecto" +
                          " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaInicio.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                          " AND descripcion <> '<<Ninguno>>'" +
                          " GROUP BY p.descripcion, p.id_proyecto";


            tabla = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("DataSet1", tabla);

            rpvEstadisticaProyectosVendidos.LocalReport.DataSources.Clear();
            rpvEstadisticaProyectosVendidos.LocalReport.DataSources.Add(ds);
            rpvEstadisticaProyectosVendidos.LocalReport.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Rango invalido de fechas");
                dtpFechaInicio.Focus();
                return;
            }

            DataTable table = new DataTable();

            string sql = "select p.descripcion, COUNT(p.id_proyecto) as cantidad from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                          "join Proyectos p on fd.id_proyecto = p.id_proyecto" +
                          " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaInicio.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                          " AND descripcion <> '<<Ninguno>>'" +
                          " GROUP BY p.descripcion, p.id_proyecto";

            table = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("DataSet1", table);

            rpvEstadisticaProyectosVendidos.LocalReport.DataSources.Clear();
            rpvEstadisticaProyectosVendidos.LocalReport.DataSources.Add(ds);
            rpvEstadisticaProyectosVendidos.RefreshReport();

            MessageBox.Show("Las fechas han sido filtradas correctamente");
        }
    }
}
