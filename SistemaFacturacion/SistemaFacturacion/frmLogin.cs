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
using SistemaFacturacion.Formularios;

namespace SistemaFacturacion
{
    public partial class frmLogin : Form
    {
        Usuario miUsuario = new Usuario();

        internal Usuario MiUsuario { get => miUsuario; set => miUsuario = value; }

        public frmLogin()
        {
            InitializeComponent();
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //if (this.txtUsuario.Text=="")
            if (this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Usuario...");
                this.txtUsuario.Focus();
                return;
            }

            //if (this.txtClave.Text=="")
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                MessageBox.Show("Debe ingresar Clave...");
                this.txtClave.Focus();
                return;
            }

            //Validar usuario y clave

            MiUsuario.N_usuario = txtUsuario.Text;
            MiUsuario.Password = txtClave.Text;

            MiUsuario.Id_usuario = MiUsuario.validarUsuario(MiUsuario.N_usuario, MiUsuario.Password);

            string msj = "";
            if (MiUsuario.Id_usuario != 0)
            {
                msj = "Login OK";
                MessageBox.Show(msj, "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                msj = "Usuario y/o clave incorrectos";
                MessageBox.Show(msj, "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }
    }
}
