using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFacturacion.Formularios;
using SistemaFacturacion.Clases;
using SistemaFacturacion.Listados;
using SistemaFacturacion.Reportes;

namespace SistemaFacturacion
{
    public partial class frmPrincipal : Form
    {
        Usuario usuarioActual;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin fl;
            fl = new frmLogin();
            fl.ShowDialog();

            this.usuarioActual = fl.MiUsuario;

            if (this.usuarioActual.Id_usuario == 0)
                this.Close();
            else
                this.Text = this.Text + " - Usuario: " + this.usuarioActual.N_usuario;

            fl.Dispose();
        }
              
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frc = new frmClientes();
            frc.ShowDialog();
            frc.Dispose();            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto frpro = new frmProducto();
            frpro.ShowDialog();
            frpro.Dispose();
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyecto frproy = new frmProyecto();
            frproy.ShowDialog();
            frproy.Dispose();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            frmFacturas frfac = new frmFacturas();
            frfac.Text = frfac.Text + " - Usuario: " + this.usuarioActual.N_usuario;

            frfac.ShowDialog();
            frfac.Dispose();
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteProductos frp = new frmReporteProductos();
            frp.ShowDialog();
            frp.Dispose();
        }

        private void listadoDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteProyectos frrp = new frmReporteProyectos();
            frrp.ShowDialog();
            frrp.Dispose();
        }

        private void listadoDeFacturasPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteUsuariosResponsables frmRR = new frmReporteUsuariosResponsables();
            frmRR.ShowDialog();
            frmRR.Dispose();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteClientesRegistrados frmRCR = new frmReporteClientesRegistrados();
            frmRCR.ShowDialog();
            frmRCR.Dispose();
        }

        private void proyectosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProyectosVendidos frmPV = new frmProyectosVendidos();
            frmPV.ShowDialog();
            frmPV.Dispose();

        }

        private void cantidadDeProductosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductosVendidos frmP = new frmProductosVendidos();
            frmP.ShowDialog();
            frmP.Dispose();
        }

        private void cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioProyectosVendidos frmUP = new frmUsuarioProyectosVendidos();
            frmUP.ShowDialog();
            frmUP.Dispose();
        }
    }
}
