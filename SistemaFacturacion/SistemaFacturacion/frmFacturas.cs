﻿using System;
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
    public partial class frmFacturas : Form
    {
        // creo objeto Factura
        Factura oFactura = new Factura();
        Datos oBD = new Datos();

        List<FacturaDetalle> listaItems = new List<FacturaDetalle>();




        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            //Carga el formulario deshabilitando los campos y habilitando solo botones nuevo, editar, borrar y salir
            this.habilitar(false);

            this.cargarCombo(cboCliente, "Clientes", 2);
            this.cargarCombo(cboProducto, "Productos", 1);
            this.cargarCombo(cboProyecto, "Proyectos", 2);
            this.cargarCombo(cboUsuario, "Usuarios", 2);
        }

        //metodo para habilitar o deshabilitar campos y botones
        private void habilitar(bool x)
        {
            txtNroFactura.Enabled = x;
            txtPrecio.Enabled = x;
            dtpFecha.Enabled = x;

            cboCliente.Enabled = x;
            cboUsuario.Enabled = x;
            cboProducto.Enabled = x;
            cboProyecto.Enabled = x;


            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnAgregar.Enabled = x;
            btnQuitar.Enabled = x;
            btnNuevo.Enabled = !x;

            btnSalir.Enabled = !x;
            grdFacturaDetalle.Enabled = !x;

        }

        //metodo para limpiar campos 
        private void limpiar()
        {
            
            
            txtNroFactura.Clear();
            txtPrecio.Clear();
            
            //para que apunten siempre al primero los combos por defecto
            cboCliente.SelectedIndex = 0;
            cboProducto.SelectedIndex = 0;
            cboProyecto.SelectedIndex = 0;
            cboUsuario.SelectedIndex = 0;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Al hacer click en Nuevo habilitamos botones, agregar,quitar, cancelar y tambien los campos       
            this.habilitar(true);
            //limpamos campos cajas texto
            this.limpiar();
            //hacemos focus en el campo CUIT
            this.txtNroFactura.Focus();

            oFactura.cargarNroFactura();
            txtNroFactura.Text = oFactura.Numero_factura.ToString();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //para capturar el identity de factura
            DataTable table = new DataTable();
            //click en grabar deshabilitando los campos y habilitando solo botones nuevo, borrar y salir
            this.habilitar(false);

            //ejecutamos metodo validar para verificar que se haya cargado la cabecera de la factura y sus detalles
            if (validarFactura())
            {

                //set de los atributos al obj Factura

                oFactura.Fecha = dtpFecha.Value;
                oFactura.Numero_factura = txtNroFactura.Text;
                oFactura.Id_usuario_creador = (int)cboUsuario.SelectedValue;
                oFactura.Id_cliente = (int)cboCliente.SelectedValue;


                //verificamos que haya detalles cargados
                if (grdFacturaDetalle.Rows.Count > 0)
                {
                    cargarListaConDetalles();

                    try
                    {
                        //txtIdFactura.Text = listaItems.Count.ToString();

                        //txtNroFactura.Text = oFactura.ListFacturaDetalle.Count.ToString();

                        //nos conectamos con trasaccion
                        //BDHelper.getBDHelper().conectarConTransaccion();

                        //grabo cabezera
                        //oFactura.grabarFactura();

                        oFactura.grabarFacturaConDataManager();
                        txtIdFactura.Text = oFactura.Id_factura.ToString();

                        MessageBox.Show("Se ha realizado la TRANSACCION con EXITO");

                    }

                    catch{

                        MessageBox.Show("Ha ocurrido un ERROR al realizar la TRANSACCION");


                    }


               
                }


                else
                {
                    MessageBox.Show("Debe tener al menos un DETALLE DE FACTURA.");

                }
            }

        }

        private bool validarFactura()
        {   //validamos que la fecha no este vacia y quede marcado con color lo que falta cargar
            if (dtpFecha.Value == null) {
                MessageBox.Show("Debe ingresar una FECHA");
                dtpFecha.CalendarTitleBackColor = Color.Red;
                dtpFecha.Focus();

                return false;
            }
            //verificamos que la caja de texto nro factura no este vacia y quede marcado con color para cargar
            if (txtNroFactura.Text == string.Empty) {
                txtNroFactura.BackColor = Color.Red;
                txtNroFactura.Focus();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agregamos a grilla el detalle colocado
            grdFacturaDetalle.Rows.Add(txtIdFactura.Text,txtNroOrden.Text,cboProducto.SelectedValue, cboProyecto.SelectedValue, txtPrecio.Text);

            //calculamos precio total de la grilla y lo ponemos en la caja de texto precio total
            txtPrecioTotal.Text = calcularTotal().ToString();
        }


        //metodo para calcular el precio total de los detalles

        private double calcularTotal() {
            double total = 0;

            for (int i = 0; i < grdFacturaDetalle.Rows.Count ; i++)
            {
                total += Convert.ToDouble(grdFacturaDetalle.Rows[i].Cells[4].Value);
            }

            return total;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            grdFacturaDetalle.Rows.Remove(grdFacturaDetalle.CurrentRow);
        }

        public void cargarListaConDetalles()
        {
            //FacturaDetalle oFacturaDetalle = new FacturaDetalle();
            for (int i = 0; i < grdFacturaDetalle.Rows.Count; i++)
            {
                FacturaDetalle oFacturaDetalle = new FacturaDetalle();
                //oFactura.ListFacturaDetalle.Add(new FacturaDetalle()
                //{

                oFacturaDetalle.Numero_orden = int.Parse(grdFacturaDetalle.Rows[i].Cells["nroDeOrden"].Value.ToString());
                oFacturaDetalle.Id_producto = int.Parse(grdFacturaDetalle.Rows[i].Cells["producto"].Value.ToString());
                oFacturaDetalle.Id_proyecto = int.Parse(grdFacturaDetalle.Rows[i].Cells["proyecto"].Value.ToString());
                oFacturaDetalle.Precio = Convert.ToDouble(grdFacturaDetalle.Rows[i].Cells["precio"].Value.ToString());
                oFacturaDetalle.Borrado = false;

                //});

                listaItems.Add(oFacturaDetalle);



            }

            //le pasa la lista con los objetos detalles al atributo lista de la factura
            oFactura.ListFacturaDetalle = listaItems;



        }
    }
}
