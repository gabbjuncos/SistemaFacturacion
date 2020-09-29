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
            frfac.ShowDialog();
            frfac.Dispose();

        }
    }
}
