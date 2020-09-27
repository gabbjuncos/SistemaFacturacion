using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Clases
{
    class FacturaDetalle
    {
        //creo objeto dato para conexiones con base de datos

        Datos oDato = new Datos();

        private int id_detalle_factura;
        private int id_factura;
        private int numero_orden;
        private int id_proyecto;
        private int id_producto;
        private double precio;
        private bool borrado;

        public int Id_detalle_factura { get => id_detalle_factura; set => id_detalle_factura = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Numero_orden { get => numero_orden; set => numero_orden = value; }
        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public double Precio { get => precio; set => precio = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public void grabarFacturaDetalle()
        {

            string consultaSQL = "INSERT INTO FacturasDetalle (numero_orden, id_producto, id_proyecto, precio , borrado)" +
                " VALUES ( " +
                this.numero_orden + " , " +
                this.id_producto + "," +
                this.id_proyecto + " , " +
                this.precio + "," +
                0 + ")";

            BDHelper.getBDHelper().EjecutarSQLConTransaccion(consultaSQL);

        }
    }
}
