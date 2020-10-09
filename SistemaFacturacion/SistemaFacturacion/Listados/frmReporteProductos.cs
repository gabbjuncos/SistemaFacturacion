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
            string sql = "select p.id_producto, p.nombre, fd.precio, f.fecha " +
                         "from Facturas f join FacturasDetalle fd on f.id_factura = fd.id_factura " +
                         "join Productos p on p.id_producto = fd.id_producto " +
                         "where f.fecha between " + dtpDesde.Value + " and " + dtpHasta.Value;



        }
    }
}
