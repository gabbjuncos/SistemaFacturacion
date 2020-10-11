using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFacturacion.Listados;
using SistemaFacturacion.Clases;
using Microsoft.Reporting.WinForms;

namespace SistemaFacturacion.Listados
{
    public partial class frmReporteProyectos : Form
    {
        // creo objeto datos
        Datos oBD = new Datos();
        public frmReporteProyectos()
        {
            InitializeComponent();
        }

        private void frmReporteProyectos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (dtpFecheDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Rango invalido de fechas");
                dtpFecheDesde.Focus();
                return;
            }

            DataTable table = new DataTable();

            string sql = "select p.id_proyecto , p.descripcion, fd.precio, f.fecha from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                          "join Proyectos p on fd.id_proyecto = p.id_proyecto" +
                          " where CAST(f.fecha AS DATE) between CAST('" + dtpFecheDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                          " AND descripcion <> '<<Ninguno>>'"; ;

            table = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("ListadoProyectos", table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();

            MessageBox.Show("Las fechas han sido filtradas correctamente");

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string sql = "select p.id_proyecto , p.descripcion, fd.precio, f.fecha from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                          "join Proyectos p on fd.id_proyecto = p.id_proyecto" +
                          " where descripcion <> '<<Ninguno>>'";


            tabla = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("ListadoProyectos", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
