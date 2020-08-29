using ProyectoBugs.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBugs.Clases;

namespace ProyectoBugs
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //if (txtUsuario.Text=="")

            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Usuario");
                this.txtUsuario.Focus();
                return;
            }

            //if (txtClave.Text == "")

            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                MessageBox.Show("Debe ingresar Clave");
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
                msj = "Login ok";
                MessageBox.Show(msj, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msj = "Usuario y/o clave incorrectos";
                MessageBox.Show(msj, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }
         
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
