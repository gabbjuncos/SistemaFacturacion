using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SistemaFacturacion.Clases
{
    class Producto
    {
        //creo objeto dato como un atributo mas de esta clase
        Datos oDato = new Datos();

        private string nombre;
        private int id_producto;
        private bool borrado;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public bool validarDatosProductos()
        {
            //validamos preguntando por todo lo que estaria mal cargado a los atributos del objeto Producto
            if (this.nombre == string.Empty)
            {
                MessageBox.Show("El campo Nombre no contiene datos");
                return false;
            }
            return true;
        }

        // metodo para verificar si existe el cliente con un determinado cuit y devuelve si o no
        public bool existe()
        {
            DataTable table = new DataTable();
            table = oDato.consultar("SELECT * FROM productos WHERE id_producto= '" + this.id_producto + "'");
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //metodo para realizar la consulta sql referia al insert de los datos que se quieren grabar 
        public void grabarProducto()
        {
            string sqlInsert = "INSERT INTO Productos (nombre, borrado)" +
                " VALUES ( '" +
                this.nombre + "'," +
                0 + ")";

            //ejecutamos el metodo para realizar la consulta en la BD pasando la consulta insert
            oDato.actualizar(sqlInsert);

        }

        //metodo para realizar la consulta sql referia al update de los datos que se quieren grabar 
        public void actualizarProducto()
        {
            string sqlUpdate = "UPDATE Productos SET " +
                " nombre = '" + this.nombre + "' ," +
                " borrado = " + 0 +
                " WHERE id_producto = " + this.id_producto;

            //ejecutamos el metodo para realizar la consulta en la BD pasando la consulta insert
            oDato.actualizar(sqlUpdate);

        }

        //metodo para crear data table cargada con los datos de productos a partir de la consulta, teniendo solo encuenta los no borrados(N) 
        public DataTable recuperarProductos()
        {
            string consultaSQL = "SELECT pr.nombre, pr.id_producto, pr.borrado" +
                " FROM Productos pr" +
                " WHERE pr.borrado = 0";

            return oDato.consultar(consultaSQL);
        }
    }
}
