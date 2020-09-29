using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SistemaFacturacion.Clases
{
    class Proyecto
    {
        //creo objeto dato como un atributo mas de esta clase
        Datos oDato = new Datos();

        private int id_proyecto;
        private int id_producto;
        private int id_responsable;
        private string descripcion;
        private string version;
        private string alcance;
        private bool borrado;

        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Id_responsable { get => id_responsable; set => id_responsable = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Version { get => version; set => version = value; }
        public string Alcance { get => alcance; set => alcance = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public bool validarDatosProyecto()
        {
            //validamos preguntando por todo lo que estaria mal cargado a los atributos del objeto Proyecto
            if (this.descripcion.ToString() == string.Empty)
            {
                MessageBox.Show("El campo DESCRIPCION esta vacio");
                return false;

            }
            if (this.version == string.Empty)
            {
                MessageBox.Show("El campo VERSION esta vacio");
                return false;

            }
            if (this.alcance == string.Empty)
            {
                MessageBox.Show("El campo ALCANCE esta vacio");
                return false;

            }


            if (this.id_producto.ToString() == string.Empty | this.id_producto < 0)
            {
                MessageBox.Show("El campo ID PRODUCTO esta vacio o no es un valor valido");
                return false;

            }

            if (this.id_responsable.ToString() == string.Empty | this.id_responsable < 0)
            {
                MessageBox.Show("El campo ID RESPONSABLE esta vacio o no es un valor valido");
                return false;

            }


            return true;
        }

        // metodo para verificar si existe el proyecto con un determinado ID y devuelve si o no
        public bool existe()

        {
            DataTable table = new DataTable();
            table = oDato.consultar("SELECT * FROM Proyectos WHERE id_proyecto= '" + this.id_proyecto + "'");
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
        public void grabarProyecto()
        {
            string sqlInsert = "INSERT INTO Proyectos (id_producto, descripcion, version, alcance, id_responsable, borrado)" +
                " VALUES ( " +
                this.id_producto + ", '" +
                this.descripcion + "','" +
                this.version + "','" +
                this.alcance + "', " +
                this.id_responsable + ", " +
                0 + ")";

            //ejecutamos el metodo para realizar la consulta en la BD pasando la consulta insert
            oDato.actualizar(sqlInsert);


        }
        //metodo para realizar la consulta sql referia al update de los datos que se quieren grabar 
        public void actualizarProyecto()
        {
            string sqlUpdate = "UPDATE Proyectos SET " +
                " id_producto = " + this.id_producto + " ," +
                " descripcion = '" + this.descripcion + "', " +
                " version = '" + this.version + "', " +
                " alcance = '" + this.alcance + "', " +
                " id_responsable = " + this.id_responsable + ", " +
                " borrado = " + 0 +
                " WHERE id_proyecto = " + this.id_proyecto;


            //ejecutamos el metodo para realizar la consulta en la BD pasando la consulta insert
            oDato.actualizar(sqlUpdate);

        }

        //metodo para crear data table cargada con los datos de Producto a partir de la consulta, teniendo solo encuenta los no borrados(N) 
        public DataTable recuperarProyectos()
        {
            string consultaSQL = "SELECT pr.id_proyecto, pr.borrado, p.nombre, pr.descripcion, pr.version, pr.alcance, u.usuario" +
                " FROM Proyectos pr, Productos p, Usuarios u" +
                " WHERE pr.borrado = 0" +
                " AND pr.id_responsable = u.id_usuario" +
                " AND pr.id_producto = p.id_producto";

            return oDato.consultar(consultaSQL);
        }

        //metodo para realizar la consulta sql referia al update de los datos modificando el cambo borrado a S
        public void darBajaProyecto()
        {
            string sqlDarBaja = "UPDATE Proyectos SET " +
                " borrado = " + 1 +
                " WHERE id_proyecto = " + this.id_proyecto;


            //ejecutamos el metodo para realizar la consulta en la BD pasando la consulta UPDATE
            oDato.actualizar(sqlDarBaja);

        }

        //recuperamos un Proyecto determinado a partir de su id 
        public DataTable recuperarProyectoPorId(int id)
        {

            return oDato.consultar("SELECT * FROM Proyectos WHERE id_proyecto=" + id);
        }
    }
}
