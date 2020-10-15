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

namespace SistemaFacturacion.Reportes
{
    public partial class frmUsuarioProyectosVendidos : Form
    {
        // creo objeto datos
        Datos oBD = new Datos();
        public frmUsuarioProyectosVendidos()
        {
            InitializeComponent();
        }

        private void frmUsuarioProyectosVendidos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Rango invalido de fechas");
                dtpFechaDesde.Focus();
                return;
            }

            DataTable table = new DataTable();

            string sql = " select u.usuario, COUNT(p.id_proyecto) as cantidad from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                         " join Proyectos p on fd.id_proyecto = p.id_proyecto" +
                         " join Usuarios u on f.id_usuario_creador = u.id_usuario" +
                         " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                         " AND u.borrado = 0" + 
                         " AND p.descripcion <> '<<Ninguno>>'" +
                         " GROUP BY u.usuario, p.id_proyecto";

            table = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("dsUsuarioProyectosVendidos", table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();

            MessageBox.Show("Las fechas han sido filtradas correctamente");
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string sql = " select u.usuario, COUNT(p.id_proyecto) as cantidad from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                         " join Proyectos p on fd.id_proyecto = p.id_proyecto" +
                         " join Usuarios u on f.id_usuario_creador = u.id_usuario" +
                         " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                         " AND u.borrado = 0" +
                         " AND p.descripcion <> '<<Ninguno>>'" +
                         " GROUP BY u.usuario, p.id_proyecto";


            tabla = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("dsUsuarioProyectosVendidos", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
