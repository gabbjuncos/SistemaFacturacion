using Microsoft.Reporting.WinForms;
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

namespace SistemaFacturacion.Listados
{
    public partial class frmReporteClientesRegistrados : Form
    {
        // creo objeto datos
        Datos oBD = new Datos();

        public frmReporteClientesRegistrados()
        {
            InitializeComponent();
        }

        private void frmReporteClientesRegistrados_Load(object sender, EventArgs e)
        {
            this.cargarCombo(cboBarrios, "Barrios", 1);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            // por defecto hacemos la consulta con la fecha que tiene el dimedatapicker por defecto , que es la fecha alctual 
            string sql = "select c.cuit, c.razon_social, c.calle, c.numero, b.nombre as nombre_barrio , con.telefono as contacto_telefono, con.email as contacto_email, c.fecha_alta as fecha_alta   from Clientes c join Barrios b  on c.id_barrio = b.id_barrio" +
                         " join Contactos con on c.id_contacto = con.id_contacto " +
                         " where CAST(c.fecha_alta AS DATE) between CAST('" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                         " AND c.borrado = 0";




            tabla = oBD.consultar(sql);
            ReportDataSource ds = new ReportDataSource("ListadoClientesRegistrados", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Rango invalido de fechas");
                dtpFechaDesde.Focus();
                return;
            }

            else
            {
                if (cboBarrios.SelectedIndex == -1)
                {
                    DataTable table = new DataTable();

                    string sql = "select c.cuit, c.razon_social, c.calle, c.numero, b.nombre as nombre_barrio , con.telefono as contacto_telefono, con.email as contacto_email, c.fecha_alta as fecha_alta   from Clientes c join Barrios b  on c.id_barrio = b.id_barrio" +
                                 " join Contactos con on c.id_contacto = con.id_contacto " +
                                 " where CAST(c.fecha_alta AS DATE) between CAST('" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                                 " AND c.borrado = 0";

                    table = oBD.consultar(sql);
                    ReportDataSource ds = new ReportDataSource("ListadoClientesRegistrados", table);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.RefreshReport();
                }


                else
                {
                    DataTable table = new DataTable();

                    string sql = "select c.cuit, c.razon_social, c.calle, c.numero, b.nombre as nombre_barrio , con.telefono as contacto_telefono, con.email as contacto_email, c.fecha_alta as fecha_alta   from Clientes c join Barrios b  on c.id_barrio = b.id_barrio" +
                                 " join Contactos con on c.id_contacto = con.id_contacto " +
                                 " where CAST(c.fecha_alta AS DATE) between CAST('" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AS date) AND CAST('" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "' AS date)" +
                                 " AND c.borrado = 0" +
                                 " AND b.nombre = '" + cboBarrios.Text + "'" ;

                    table = oBD.consultar(sql);
                    ReportDataSource ds = new ReportDataSource("ListadoClientesRegistrados", table);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.RefreshReport();


                }



                MessageBox.Show("Las fechas han sido filtradas correctamente");
            }


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


    }


}
