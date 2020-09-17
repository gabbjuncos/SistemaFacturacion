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

namespace SistemaFacturacion.Formularios
{
    public partial class frmClientes : Form
    {
        //flag para saber cuando se activa boton nuevo o no (boton modificar)
        bool nuevo = false;
        // creo objeto datos
        Datos oBD = new Datos();

        // creo objeto Cliente
        Cliente oCliente = new Cliente();
           

        public frmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            //Carga el formulario deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
            this.habilitar(false);

            //DataTable tabla = new DataTable();
            //oBD.consultarTabla("barrios");
            //cboBarrios.DataSource = tabla;
            //cboBarrios.displaymember = tabla.colums[1].columnName;
            //cboBarrios.ValueMember = tabla.colums[0].columnName;
            //cboBarrios.dropDownStyle = comboboxsyle.dropdowslist;
            //cboBarrios.selectedIndex = -1;

            //grdClientes.DataSource = oCliente.recuperarClientes();

            //cargamos la grilla campo por campo a partir de la consulta
            //this.cargarGrilla(grdClientes, oCliente.recuperarClientes());
            grdClientes.DataSource = oCliente.recuperarClientes();
        }
        // metodo para cargar la grilla com su respectivos campos tomando como parametro la grilla y databla para hacerlos coincidir, 
        private void cargarGrilla(DataGridView grilla, DataTable tabla) {
            //limpiamos grilla 
            grilla.Rows.Clear();
        

            //recorremos el datable, contamos filas para limite superior del for
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                

                //cargamos la fila de la gilla, en el orden que ponemos cada instruccion es el orden de la columna de la grilla a la que se va a cargar el correspondiente valor de la columna que se indica con el nombre en el databla
                grilla.Rows.Add(tabla.Rows[i]["id_cliente"],
                                tabla.Rows[i]["borrado"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["cuit"],
                                tabla.Rows[i]["razon_social"],
                                tabla.Rows[i]["calle"],
                                tabla.Rows[i]["numero"],
                                tabla.Rows[i]["fecha_alta"],
                                tabla.Rows[i]["apellido"]);
                    
               
            }

        }

        //metodo para habilitar o deshabilitar campos y botones
        private void habilitar(bool x)
        {
            txtIdCliente.Enabled = false; //id cliente desabilitado por que es autoincremental
            txtCuit.Enabled = x;
            txtRazonSocial.Enabled = x;
            txtCalle.Enabled = x;
            txtNumero.Enabled = x;
            txtIdContacto.Enabled = x;
            txtIdBarrio.Enabled = x;

            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            grdClientes.Enabled = !x;

        }

        //metodo para limpiar campos 
        private void limpiar()
        {
            txtIdCliente.Clear();
            txtRazonSocial.Clear();
            txtCuit.Clear();
            txtCalle.Clear();
            txtNumero.Clear();
            txtIdBarrio.Clear();
            txtIdContacto.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //activo flag nuevo
            this.nuevo = true;

            //Al hacer click en Nuevo habilitamos botones grabar y cancelar y tambien los campos       
            this.habilitar(true);
            //limpamos campos
            this.limpiar();
            //hacemos focus en el campo CUIT
            this.txtCuit.Focus();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //tomamos los valores de las cajas de texto y se lo asignamos a un objeto cliente
            oCliente.Cuit = txtCuit.Text;
            oCliente.Razon_social = txtRazonSocial.Text;
            oCliente.Calle = txtCalle.Text;
            oCliente.Numero = txtNumero.Text;
            oCliente.Id_barrio = int.Parse(txtIdBarrio.Text);
            oCliente.Id_contacto = int.Parse(txtIdContacto.Text);

            //validamos los datos antes de grabar
            if (oCliente.validarDatosClientes())
            {
                 //si la bandera dice que es nuevo hacemos agregamos los datos
                if (this.nuevo) {
                    //si el usuario que se quiere insertar no existe entonces lo grabamos
                    if (!oCliente.existe()) {

                        oCliente.grabarCliente();

                    }

                    //si el usuario que se quiere insertar ya existe
                    else
                    {
                        MessageBox.Show("El CLIENTE ya existente");
                    }
                }
                //si la bandera dice que NO es nuevo se trata de una modficacion , entonces actualizaciomos datos
                else
                {
                    oCliente.Id_cliente = int.Parse(txtIdCliente.Text);
                    oCliente.actualizarCliente();
                }

                //actualizamos grilla
                cargarGrilla(grdClientes, oCliente.recuperarClientes());
                MessageBox.Show("El CLIENTE se grabo correctamente");

            }

          
            //click en grabar deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
            this.habilitar(false);
            //desabilito la bandera nuevo
            this.nuevo = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
            // click en cancelar deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
        {
            this.habilitar(false);
            //desabilito la bandera nuevo
            this.nuevo = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Click en editar habilitamos botones grabar y cancelar y tambien los campos
            this.habilitar(true);
            //hacemos foco al CUIT
            this.txtCuit.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {   //mensaje para verificar borrado de cliente
            if(MessageBox.Show("Esta seguro de eliminar el cliente : " + txtCuit.Text,
                                "Eliminar cliente",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                oCliente.darBajaCliente();
                //actualizamos grilla
                cargarGrilla(grdClientes, oCliente.recuperarClientes());
                MessageBox.Show("El CLIENTE se borro correctamente");
            }
        }

        //metodo para tomar algun registro dependiendo en que fila este posicionado en la grilla
        private void grdClientes_SelectionChanged(object sender, EventArgs e)
        {
            //columna 0 correspondiente al id cliente
            this.actualizarCampos((int)grdClientes.CurrentRow.Cells[0].Value);

        }

        private void actualizarCampos(int id )
        {
            DataTable tabla = new DataTable();
            tabla = oCliente.recuperarClientePorId(id);
            //colocamos cada dato de la columna en los campos correspondientes
            txtIdCliente.Text = tabla.Rows[0]["id_cliente"].ToString();
            txtIdBarrio.Text = tabla.Rows[0]["id_barrio"].ToString();
            txtCuit.Text = tabla.Rows[0]["cuit"].ToString();
            txtRazonSocial.Text = tabla.Rows[0]["razon_social"].ToString();
            txtCalle.Text = tabla.Rows[0]["calle"].ToString();
            txtNumero.Text = tabla.Rows[0]["numero"].ToString();
            txtIdContacto.Text = tabla.Rows[0]["id_contacto"].ToString();
            

        }
    }
}
