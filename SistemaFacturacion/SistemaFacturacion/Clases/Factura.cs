using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Clases
{
    class Factura
    {
        //creo objeto dato para conexiones con base de datos
        Datos oDato = new Datos();

        private int id_factura;
        private string numero_factura;
        private int id_cliente;
        private DateTime fecha;
        private int id_usuario_creador;
        private bool borrado;

        public int Id_factura { get => id_factura; set => id_factura = value; }
        public string Numero_factura { get => numero_factura; set => numero_factura = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id_usuario_creador { get => id_usuario_creador; set => id_usuario_creador = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        //metodo para cargar numero de factura, se conecta con la BD y se fija cual es el ultimo y a ese le incrementa 1
        public void cargarNroFactura()
        {
            DataTable table = new DataTable();
            //consulto solo la columna de numero factura 
            table = oDato.consultar(" SELECT MAX((CAST(replace(numero_factura, '-', '.') AS DECIMAL(18, 8)))) AS numero_factura" +
                                     " FROM facturas)");

            double numero_factura = Convert.ToDouble(table.Rows[0]["numero_factura"]);

            numero_factura = +0.0001;

            Numero_factura = numero_factura.ToString();

        }

        public void grabarFactura()
        {

            string consultaSQL = "INSERT INTO Facturas (numero_factura, id_cliente, fecha, id_usuario_creador, borrado)" +
                " VALUES ( '" +
                this.numero_factura + "', " +
                this.id_cliente + ",'" +
                this.fecha + "'," +
                this.id_usuario_creador + ", " +
                0 + ")";

            BDHelper.getBDHelper().EjecutarSQLConTransaccion(consultaSQL);


        }
    }
}
