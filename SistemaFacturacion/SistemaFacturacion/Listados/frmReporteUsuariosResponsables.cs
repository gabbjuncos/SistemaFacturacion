using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SistemaFacturacion.Clases;

namespace SistemaFacturacion.Listados
{
    public partial class frmReporteUsuariosResponsables : Form
    {
        // creo objeto datos
        Datos oBD = new Datos();
        public frmReporteUsuariosResponsables()
        {
            InitializeComponent();
        }

        private void frmReporteUsuariosResponsables_Load(object sender, EventArgs e)
        {
            this.cargarCombo(cboUsuarioResponsable, "Usuarios", 2);
            this.rptUsuarioResponsable.RefreshReport();
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

        private void rptUsuarioResponsable_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            // por defecto hacemos la consulta con la fecha que tiene el dimedatapicker por defecto , que es la fecha alctual 
            string sql = "select f.numero_factura, c.razon_social as nombre_cliente, f.fecha, u.usuario from Facturas f join Clientes c  on f.id_cliente = c.id_cliente" +
                         " join Usuarios u on f.id_usuario_creador = u.id_usuario" +
                         " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaInicial.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                         " AND c.borrado = 0";




            tabla = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("ListadoUsuariosResponsables", tabla);

            rptUsuarioResponsable.LocalReport.DataSources.Clear();
            rptUsuarioResponsable.LocalReport.DataSources.Add(ds);
            rptUsuarioResponsable.LocalReport.Refresh();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicial.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Rango invalido de fechas");
                dtpFechaInicial.Focus();
                return;
            }

            else
            {
                if (cboUsuarioResponsable.SelectedIndex == -1)
                {
                    DataTable table = new DataTable();

                    string sql = "select f.numero_factura, c.razon_social as nombre_cliente, f.fecha, u.usuario from Facturas f join Clientes c  on f.id_cliente = c.id_cliente" +
                         " join Usuarios u on f.id_usuario_creador = u.id_usuario" +
                         " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaInicial.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                         " AND c.borrado = 0";


                    table = oBD.consultar(sql);
                    ReportDataSource ds = new ReportDataSource("ListadoUsuariosResponsables", table);

                    rptUsuarioResponsable.LocalReport.DataSources.Clear();
                    rptUsuarioResponsable.LocalReport.DataSources.Add(ds);
                    rptUsuarioResponsable.RefreshReport();
                }


                else
                {
                    DataTable table = new DataTable();

                    string sql = "select f.numero_factura, c.razon_social as nombre_cliente, f.fecha, u.usuario from Facturas f join Clientes c  on f.id_cliente = c.id_cliente" +
                         " join Usuarios u on f.id_usuario_creador = u.id_usuario" +
                         " where CAST(f.fecha AS DATE) between CAST('" + dtpFechaInicial.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)"+
                         " AND u.usuario = '" + cboUsuarioResponsable.Text + "'" +
                         " AND c.borrado = 0";

                    table = oBD.consultar(sql);
                    ReportDataSource ds = new ReportDataSource("ListadoUsuariosResponsables", table);

                    rptUsuarioResponsable.LocalReport.DataSources.Clear();
                    rptUsuarioResponsable.LocalReport.DataSources.Add(ds);
                    rptUsuarioResponsable.RefreshReport();


                }



                MessageBox.Show("Las fechas han sido filtradas correctamente");
            }
        }
    }

}
