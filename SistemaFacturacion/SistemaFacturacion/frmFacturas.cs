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
    public partial class frmFacturas : Form
    {
        // creo objeto Factura
        Factura oFactura = new Factura();
        Datos oBD = new Datos();


        List<FacturaDetalle> listaItems = new List<FacturaDetalle>();

        int nro_orden = 0;


        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            string nombreUsuario = this.Text.Remove(0,19);

            //Carga el formulario deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
            this.habilitar(false);

            this.cargarCombo(cboCliente, "Clientes", 2);
            this.cargarComboProyectos_Productos(cboProducto, "Productos","nombre", 1);
            this.cargarComboProyectos_Productos(cboProyecto, "Proyectos","descripcion", 2);
            this.cargarComboUsuario(cboUsuario, nombreUsuario, 2);


        }

        //metodo para habilitar o deshabilitar campos y botones
        private void habilitar(bool x)
        {
            txtPrecio.Enabled = x;
            txtPrecioTotal.Enabled = false;
            txtNuevoCliente.Enabled = x;

            dtpFecha.Enabled = x;

            cboCliente.Enabled = x;
            cboUsuario.Enabled = false;
            cboProducto.Enabled = x;
            cboProyecto.Enabled = x;
            chcProyecto.Enabled = x;
            chcProducto.Enabled = x;



            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnAgregar.Enabled = x;
            btnQuitar.Enabled = x;
            btnNuevo.Enabled = !x;

            btnSalir.Enabled = !x;
            //grdFacturaDetalle.Enabled = !x;

        }

        //metodo para limpiar campos 
        private void limpiar()
        {
                        
            
            txtPrecio.Clear();
            txtPrecioTotal.Clear();
            listaItems.Clear();
            
            //para que apunten siempre al primero los combos por defecto
            cboCliente.SelectedIndex = -1;
            cboProducto.SelectedIndex = 0;
            cboProyecto.SelectedIndex = 0;
            cboUsuario.SelectedIndex = 0;

            grdFacturaDetalle.Rows.Clear();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Al hacer click en Nuevo habilitamos botones, agregar,quitar, cancelar y tambien los campos       
            this.habilitar(true);

            //limpamos campos cajas texto
            this.limpiar();

            //Bloqueamos los combobox
            this.cboProducto.Enabled = false;
            this.cboProyecto.Enabled = false;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //para capturar el identity de factura
            DataTable table = new DataTable();
            //click en grabar deshabilitando los campos y habilitando solo botones nuevo, borrar y salir
            this.habilitar(false);
            cboCliente.Enabled = true;

            //ejecutamos metodo validar para verificar que se haya cargado la cabecera de la factura y sus detalles
            if (validarFactura())
            {

                //set de los atributos al obj Factura

                oFactura.Fecha = dtpFecha.Value;
                oFactura.Id_usuario_creador = (int)cboUsuario.SelectedValue;
                oFactura.Id_cliente = (int)cboCliente.SelectedValue;


                //verificamos que haya detalles cargados
                if (grdFacturaDetalle.Rows.Count > 0)
                {
                    cargarListaConDetalles();

                    //intentamos realizar la transaccion
                    try
                    {
                        //Ejecuta el metodo pra realizar la transaccion 
                        oFactura.grabarFacturaConDataManager();
                        MessageBox.Show("Se ha realizado la FACTURACION con EXITO");
                        limpiar();                 
                    }

                    //En caso de que no se pueda realizar la transaccion mostramos mensaje
                    catch {

                        MessageBox.Show("Ha ocurrido un ERROR al realizar la FACTURACION");
                        limpiar();                        
                    }                                   
                }

                else
                {
                    MessageBox.Show("Debe tener al menos un DETALLE DE FACTURA.");

                }
            }
            else
            {
                this.habilitar(true);
            }

        }

        private bool validarFactura()
        {   //validamos que la fecha no este vacia y quede marcado con color lo que falta cargar
            if (dtpFecha.Value == null) 
            {
                MessageBox.Show("Debe ingresar una FECHA");
                dtpFecha.CalendarTitleBackColor = Color.Red;
                dtpFecha.Focus();

                return false;
            }
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Cliente");
                cboCliente.Focus();
                return false;
            }
            return true;
        }


            private void btnCancelar_Click(object sender, EventArgs e)
        // click en cancelar deshabilitando los campos y habilitando solo botones nuevo, y salir
        {
            this.habilitar(false);
            
            
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
            combo.SelectedIndex = -1; // queda apuntando a la nada cuando se ejecuta 
        }
        
        private void cargarComboUsuario(ComboBox combo, string nombreUsuario, int numeroColumnaDisplay)
        {

            DataTable tabla = new DataTable();
            string sql_consulta = "Select * from Usuarios where usuario = '" + nombreUsuario + "'";

            tabla = oBD.consultar(sql_consulta);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[numeroColumnaDisplay].ColumnName;    // para nombre
            combo.ValueMember = tabla.Columns[0].ColumnName;      //para ide
            combo.DropDownStyle = ComboBoxStyle.DropDownList;  //por si no lo hago por las propeidades para que no se pueda editar cuando escribo en el combo en ejecucion
            combo.SelectedIndex = 0; // queda apuntando a la nada cuando se ejecuta 
        }

        private void cargarComboProyectos_Productos(ComboBox combo, string nombreTabla, string nombreColumna, int numeroColumnaDisplay)
        {


            DataTable tabla = new DataTable();
            string sql_consulta = "Select * from " + nombreTabla + " order by " + nombreColumna;

            tabla = oBD.consultar(sql_consulta);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[numeroColumnaDisplay].ColumnName;    // para nombre
            combo.ValueMember = tabla.Columns[0].ColumnName;      //para ide
            combo.DropDownStyle = ComboBoxStyle.DropDownList;  //por si no lo hago por las propeidades para que no se pueda editar cuando escribo en el combo en ejecucion
            combo.SelectedIndex = 0; // queda apuntando a la nada cuando se ejecuta 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (chcProducto.Checked == false && chcProyecto.Checked == false)
            {
                MessageBox.Show("Debe Seleccionar un producto o un proyecto");
                cboProyecto.SelectedIndex = 0;
                cboProducto.SelectedIndex = 0;
                txtPrecio.Clear();
            }
            else
            {
                if (chcProyecto.Checked == true && cboProyecto.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe Seleccionar un proyecto");
                    cboProyecto.Focus();
                    cboProyecto.SelectedIndex = 0;
                    cboProducto.SelectedIndex = 0;
                    txtPrecio.Clear();
                    return;
                }
                
                if(chcProducto.Checked == true && cboProducto.SelectedIndex == 0)
                {
                        MessageBox.Show("Debe Seleccionar un producto");
                        cboProducto.Focus();
                        cboProyecto.SelectedIndex = 0;
                        cboProducto.SelectedIndex = 0;
                        txtPrecio.Clear();
                        return;
                }

                if (txtPrecio.Text == "")
                {
                    MessageBox.Show("Debe ingresar un Precio");
                    return;
                }
                nro_orden += 1;

                //agregamos a grilla el detalle colocado
                grdFacturaDetalle.Rows.Add(nro_orden.ToString(), cboProducto.SelectedValue, cboProducto.Text, cboProyecto.SelectedValue, cboProyecto.Text, txtPrecio.Text);

                //calculamos precio total de la grilla y lo ponemos en la caja de texto precio total
                txtPrecioTotal.Text = calcularTotal().ToString();

                //Bloquea el usuario y el cliente luego de agregar
                cboUsuario.Enabled = false;

                //Limpia los combo box luego de agregar 
                cboProyecto.SelectedIndex = 0;
                cboProducto.SelectedIndex = 0;
                txtPrecio.Clear();
            }            
            
        }

        //metodo para calcular el precio total de los detalles
        private double calcularTotal() {
            double total = 0;

            for (int i = 0; i < grdFacturaDetalle.Rows.Count ; i++)
            {
                total += Convert.ToDouble(grdFacturaDetalle.Rows[i].Cells[5].Value);
            }

            return total;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int cantidad_Filas = grdFacturaDetalle.Rows.Count;
            if (cantidad_Filas == 0)
            {
                MessageBox.Show("No se puede quitar una fila. Grilla vacía");
            }
            else
            {
                //primero quitamos la fila que el usuario elige
                grdFacturaDetalle.Rows.Remove(grdFacturaDetalle.CurrentRow);

                cantidad_Filas = grdFacturaDetalle.Rows.Count;

                for (int i = 0; i < cantidad_Filas; i++)
                {
                    grdFacturaDetalle.Rows[i].Cells[0].Value = i + 1;
                }
                nro_orden = cantidad_Filas;
                //calculamos precio total de la grilla y lo ponemos en la caja de texto precio total
                txtPrecioTotal.Text = calcularTotal().ToString();
            }

            
        }

        public void cargarListaConDetalles()
        {
            //FacturaDetalle oFacturaDetalle = new FacturaDetalle();
            for (int i = 0; i < grdFacturaDetalle.Rows.Count; i++)
            {
                FacturaDetalle oFacturaDetalle = new FacturaDetalle();
                

                oFacturaDetalle.Numero_orden = int.Parse(grdFacturaDetalle.Rows[i].Cells["nroDeOrden"].Value.ToString());
                oFacturaDetalle.Id_producto = int.Parse(grdFacturaDetalle.Rows[i].Cells["id_producto"].Value.ToString());
                oFacturaDetalle.Id_proyecto = int.Parse(grdFacturaDetalle.Rows[i].Cells["id_proyecto"].Value.ToString());
                oFacturaDetalle.Precio = Convert.ToDouble(grdFacturaDetalle.Rows[i].Cells["precio"].Value.ToString());
                oFacturaDetalle.Borrado = false;


                listaItems.Add(oFacturaDetalle);
            }

            //le pasa la lista con los objetos detalles al atributo lista de la factura
            oFactura.ListFacturaDetalle = listaItems;
        }

        private void txtNuevoCliente_Click(object sender, EventArgs e)
        {
            frmClientes frc = new frmClientes();
            frc.ShowDialog();
            frc.Dispose();
            //Se refresca nuevamente el combo box clientes
            this.cargarCombo(cboCliente, "Clientes", 2);

        }

        private void chcProyecto_CheckedChanged(object sender, EventArgs e)
        {

            if (chcProyecto.Checked == true)
            {
                cboProducto.Enabled = false;
                cboProyecto.Enabled = true;
                chcProducto.Checked = false;
            }
            else 
            {
                cboProyecto.Enabled = false;
                cboProyecto.SelectedIndex = 0;
            }
            
        }

        private void chcProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (chcProducto.Checked == true)
            {
                cboProducto.Enabled = true;
                cboProyecto.Enabled = false;
                chcProyecto.Checked = false;
            }
            else
            {
                cboProducto.Enabled = false;
                cboProducto.SelectedIndex = 0;
            }
        }
    }
}
