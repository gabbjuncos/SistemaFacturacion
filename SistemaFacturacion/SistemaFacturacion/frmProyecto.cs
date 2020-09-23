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


namespace SistemaFacturacion
{
    public partial class frmProyecto : Form
    {
        //flag para saber cuando se activa boton nuevo o no (boton modificar)
        bool nuevo = false;

        // creo objeto Proyecto
        Proyecto oProyecto = new Proyecto();

        Datos oBD = new Datos();

        public frmProyecto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProyecto_Load(object sender, EventArgs e)
        {
            //Carga el formulario deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
            this.habilitar(false);

            //cargamos la grilla campo por campo a partir de la consulta
            this.cargarGrilla(grdProyecto, oProyecto.recuperarProyectos());

            this.cargarCombo(cboIdProducto, "Productos",1);
            this.cargarCombo(cboIdResponsable, "Usuarios",2);
        }

        // metodo para cargar la grilla com su respectivos campos tomando como parametro la grilla y databla para hacerlos coincidir, 
        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            //limpiamos grilla 
            grilla.Rows.Clear();


            //recorremos el datable, contamos filas para limite superior del for
            for (int i = 0; i < tabla.Rows.Count; i++)
            {


                //cargamos la fila de la gilla, en el orden que ponemos cada instruccion es el orden de la columna de la grilla a la que se va a cargar el correspondiente valor de la columna que se indica con el nombre en el databla
                grilla.Rows.Add(tabla.Rows[i]["id_proyecto"],
                                tabla.Rows[i]["borrado"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["descripcion"],
                                tabla.Rows[i]["version"],
                                tabla.Rows[i]["alcance"],
                                tabla.Rows[i]["usuario"]);


            }

        }

        //metodo para habilitar o deshabilitar campos y botones
        private void habilitar(bool x)
        {
            txtIdProyecto.Enabled = false; //id proyecto desabilitado por que es autoincremental
            //txtIdProducto.Enabled = x;
            txtDescripcion.Enabled = x;
            txtVersion.Enabled = x;
            txtAlcance.Enabled = x;
            //txtIdResponsable.Enabled = x;
            //para los combobox
            cboIdProducto.Enabled = x;
            cboIdResponsable.Enabled = x;

            //habilitar botones o deshabilitar
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            grdProyecto.Enabled = !x;

        }

        //metodo para limpiar campos 
        private void limpiar()
        {
            txtIdProyecto.Clear();
            //txtIdProducto.Clear();
            //txtIdResponsable.Clear();
            txtAlcance.Clear();
            txtDescripcion.Clear();
            txtVersion.Clear();
            //para que apunte siempre al primero por defecto
            cboIdResponsable.SelectedIndex = 0;
            cboIdProducto.SelectedIndex = 0;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //activo flag nuevo
            this.nuevo = true;

            //Al hacer click en Nuevo habilitamos botones grabar y cancelar y tambien los campos       
            this.habilitar(true);
            //limpamos campos cajas texto
            this.limpiar();
            //hacemos focus en el campo CUIT
            this.txtVersion.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //tomamos los valores de las cajas de texto y se lo asignamos a un objeto cliente
            //oProyecto.Id_producto = int.Parse(txtIdProducto.Text);
            //oProyecto.Id_responsable = int.Parse(txtIdResponsable.Text);

            oProyecto.Descripcion = txtDescripcion.Text;
            oProyecto.Version = txtVersion.Text;
            oProyecto.Alcance = txtAlcance.Text;

            //seteamos los atributos de id , con los valores que tenga sus combobox
            oProyecto.Id_responsable = (int)cboIdResponsable.SelectedValue;
            oProyecto.Id_producto = (int)cboIdProducto.SelectedValue;



            //validamos los datos antes de grabar
            if (oProyecto.validarDatosProyecto())
            {
                //si la bandera dice que es nuevo hacemos agregamos los datos
                if (this.nuevo)
                {
                    //si el usuario que se quiere insertar no existe entonces lo grabamos
                    if (!oProyecto.existe())
                    {

                        oProyecto.grabarProyecto();

                    }

                    //si el usuario que se quiere insertar ya existe
                    else
                    {
                        MessageBox.Show("El Proyecto ya existente");
                    }
                }
                //si la bandera dice que NO es nuevo se trata de una modficacion , entonces actualizaciomos datos
                else
                {
                    oProyecto.Id_proyecto = int.Parse(txtIdProyecto.Text);
                    oProyecto.actualizarProyecto();
                }

                //actualizamos grilla
                cargarGrilla(grdProyecto, oProyecto.recuperarProyectos());
                MessageBox.Show("El PROYECTO se grabo correctamente");

            }


            //click en grabar deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
            this.habilitar(false);
            //desabilito la bandera nuevo
            this.nuevo = false;
        }



        

        
        

        //metodo para tomar algun registro dependiendo en que fila este posicionado en la grilla
        private void grdProyecto_SelectionChanged(object sender, EventArgs e)
        {
            //columna 0 correspondiente al id Proyecto
            this.actualizarCampos((int)grdProyecto.CurrentRow.Cells[0].Value);

        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = oProyecto.recuperarProyectoPorId(id);
            //colocamos cada dato de la columna en los campos correspondientes
            txtIdProyecto.Text = tabla.Rows[0]["id_proyecto"].ToString();

            //txtIdProducto.Text = tabla.Rows[0]["id_producto"].ToString();

            //txtIdResponsable.Text = tabla.Rows[0]["id_responsable"].ToString();

            txtVersion.Text = tabla.Rows[0]["version"].ToString();

            txtAlcance.Text = tabla.Rows[0]["alcance"].ToString();

            txtDescripcion.Text = tabla.Rows[0]["descripcion"].ToString();

            cboIdResponsable.SelectedValue = tabla.Rows[0]["id_responsable"];
            cboIdProducto.SelectedValue = tabla.Rows[0]["id_producto"];

        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Click en editar habilitamos botones grabar y cancelar y tambien los campos
            this.habilitar(true);
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        // click en cancelar deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
        {
            this.habilitar(false);
            //desabilito la bandera nuevo
            this.nuevo = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {   //mensaje para verificar borrado de Proyecto
            if (MessageBox.Show("Esta seguro de eliminar el proyecto : " + txtIdProyecto.Text,
                                "Eliminar PROYECTO",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                //tomamos los valores de las cajas de texto y se lo asignamos a un objeto Proyecto
                //oProyecto.Id_proyecto = int.Parse(txtIdProyecto.Text);
                //oProyecto.Id_responsable = int.Parse(txtIdResponsable.Text);

                //seteamos los atributos de id , con los valores que tenga sus combobox
                oProyecto.Id_responsable = (int)cboIdResponsable.SelectedValue;
                oProyecto.Id_producto = (int)cboIdProducto.SelectedValue;

                oProyecto.Version = txtVersion.Text;
                oProyecto.Alcance = txtAlcance.Text;
                oProyecto.Descripcion = txtDescripcion.Text;

                oProyecto.Id_proyecto = int.Parse(txtIdProyecto.Text);
                oProyecto.darBajaProyecto();

                //actualizamos grilla
                cargarGrilla(grdProyecto, oProyecto.recuperarProyectos());
                MessageBox.Show("El PROYECTO se borro correctamente");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCombo(ComboBox combo, string nombreTabla, int numeroColumnaDisplay)
        {

            DataTable tabla = new DataTable();

            tabla = oBD.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[numeroColumnaDisplay].ColumnName;    // para nombre
            combo.ValueMember = tabla.Columns[0].ColumnName;      //para ide
            combo.DropDownStyle = ComboBoxStyle.DropDownList;  //por si no lo hago por las propeidades para que no se pueda editar cuando escribo en el combo en ejecucion
            //combo.SelectedIndex = -1; // queda apuntando a la nada cuando se ejecuta 
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
