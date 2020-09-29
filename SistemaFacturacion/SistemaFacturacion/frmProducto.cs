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
    public partial class frmProducto : Form
    {

        //flag para saber cuando se activa boton nuevo o no (boton modificar)
        bool nuevo = false;

        //Creo objetos Datos
        Datos oBD = new Datos();

        //Creo objeto producto como atributo de la clase
        Producto oProducto = new Producto();

        public frmProducto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga el formulario deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
            this.habilitar(false);

            //cargamos la grilla campo por campo a partir de la consulta
            this.cargarGrilla(grdProductos, oProducto.recuperarProductos());
        }

        // metodo para cargar la grilla com su respectivos campos tomando como parametro la grilla y databla 
        //para hacerlos coincidir
        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            //limpiamos grilla 
            grilla.Rows.Clear();


            //recorremos el datable, contamos filas para limite superior del for
            for (int i = 0; i < tabla.Rows.Count; i++)
            {


                //cargamos la fila de la gilla, en el orden que ponemos cada instruccion es el orden de la columna 
                //de la grilla a la que se va a cargar el correspondiente valor de la columna que se indica con el 
                //nombre en el databla
                grilla.Rows.Add(tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["id_producto"],
                                tabla.Rows[i]["borrado"]);
            }
        }


        //metodo para habilitar o deshabilitar campos y botones
        private void habilitar(bool x)
        {
            txtid_producto.Enabled = false; //id cliente desabilitado por que es autoincremental
            txtNombre.Enabled = x;


            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            grdProductos.Enabled = !x;

        }

        //metodo para limpiar campos 
        private void limpiar()
        {
            txtNombre.Clear();
            txtid_producto.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

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
            this.txtNombre.Focus();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //tomamos los valores de las cajas de texto y se lo asignamos a un objeto producto
            oProducto.Nombre = txtNombre.Text;
           

            //validamos los datos antes de grabar
            if (oProducto.validarDatosProductos())
            {
                //si la bandera dice que es nuevo hacemos agregamos los datos
                if (this.nuevo)
                {
                    //si el usuario que se quiere insertar no existe entonces lo grabamos
                    if (!oProducto.existe())
                    {

                        oProducto.grabarProducto();

                    }

                    //si el usuario que se quiere insertar ya existe
                    else
                    {
                        MessageBox.Show("El Producto ya existe");
                    }
                }
                //si la bandera dice que NO es nuevo se trata de una modficacion , entonces actualizaciomos datos
                else
                {
                    oProducto.Id_producto = int.Parse(txtid_producto.Text);
                    oProducto.actualizarProducto();
                }

                //actualizamos grilla
                cargarGrilla(grdProductos, oProducto.recuperarProductos());
                MessageBox.Show("El producto fue grabado correctamente");

            }


            //click en grabar deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
            this.habilitar(false);
            //desabilito la bandera nuevo
            this.nuevo = false;
        }
                

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // click en cancelar deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
            this.habilitar(false);
            //desabilito la bandera nuevo
            this.nuevo = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Click en editar habilitamos botones grabar y cancelar y tambien los campos
            this.habilitar(true);
            //hacemos foco al NOMBRE
            this.txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //mensaje para verificar borrado de producto
            if (MessageBox.Show("Esta seguro de eliminar el producto : " + txtNombre.Text,
                                "Eliminar producto",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                //tomamos los valores de las cajas de texto y se lo asignamos a un objeto producto
                oProducto.Nombre = txtNombre.Text;


                oProducto.Id_producto = int.Parse(txtid_producto.Text);
                oProducto.darBajaProducto();

                //actualizamos grilla
                cargarGrilla(grdProductos, oProducto.recuperarProductos());
                MessageBox.Show("El PRODUCTO se borro correctamente");
            }
        }

        //metodo para tomar algun registro dependiendo en que fila este posicionado en la grilla
        private void grdProductos_SelectionChanged(object sender, EventArgs e)
        {
            //columna 0 correspondiente al id producto
            this.actualizarCampos((int)grdProductos.CurrentRow.Cells[1].Value);

        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = oProducto.recuperarProductoPorId(id);

            //colocamos cada dato de la columna en los campos correspondientes
            txtid_producto.Text = tabla.Rows[0]["id_producto"].ToString();

            txtNombre.Text = tabla.Rows[0]["nombre"].ToString();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
