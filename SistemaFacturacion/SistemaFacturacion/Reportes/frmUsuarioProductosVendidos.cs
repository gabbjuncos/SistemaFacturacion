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
    public partial class frmUsuarioProductosVendidos : Form
    {
        // creo objeto datos
        Datos oBD = new Datos();
        public frmUsuarioProductosVendidos()
        {
            InitializeComponent();
        }

        private void frmUsuarioProductosVendidos_Load(object sender, EventArgs e)
        {

            this.rptUsuarioProductosVendidos.RefreshReport();
            
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

            string sql = " select u.usuario, COUNT(p.id_producto) as cantidad from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                         " join Productos p on fd.id_producto = p.id_producto" +
                         " join Usuarios u on f.id_usuario_creador = u.id_usuario" +
                         " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                         " AND u.borrado = 0" +
                         " AND p.nombre <> '<<Ninguno>>'" +
                         " GROUP BY u.usuario, p.id_producto";

            table = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("DSUsuarioProductosVendidos", table);

            rptUsuarioProductosVendidos.LocalReport.DataSources.Clear();
            rptUsuarioProductosVendidos.LocalReport.DataSources.Add(ds);
            rptUsuarioProductosVendidos.RefreshReport();

            MessageBox.Show("Las fechas han sido filtradas correctamente");
        }

        private void rptUsuarioProductosVendidos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string sql = " select u.usuario, COUNT(p.id_producto) as cantidad from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                         " join Productos p on fd.id_producto = p.id_producto" +
                         " join Usuarios u on f.id_usuario_creador = u.id_usuario" +
                         " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                         " AND u.borrado = 0" +
                         " AND p.nombre <> '<<Ninguno>>'" +
                         " GROUP BY u.usuario, p.id_producto";


            tabla = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("DSUsuarioProductosVendidos", tabla);

            rptUsuarioProductosVendidos.LocalReport.DataSources.Clear();
            rptUsuarioProductosVendidos.LocalReport.DataSources.Add(ds);
            rptUsuarioProductosVendidos.LocalReport.Refresh();
        }
    }
}
