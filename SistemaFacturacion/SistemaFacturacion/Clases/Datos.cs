using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace SistemaFacturacion.Clases
{
    class Datos             //Esta clase "Datos" es la que me va a permitir la conectividad con la base de datos
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();
        private string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TPPAVI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; password=gabijun";

        //private OleDbConnection conexion = new OleDbConnection();
        //private OleDbCommand comando = new OleDbCommand();
        //private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\GJ\Desktop\Escritorio\UTN 2020\PAV1\ProyectoBugs\ProyectoBugs\Errores.mdb";

        private void conectar()         //esto seria la accion de conectar, nos conectamos, se abre la BD que  hace referencia
                                        // prepara el comando con esa conexion y ya le voy a pasar el txto que quiero que ejecute ese comando

        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }

        public DataTable consultar(string consultaSQL)  //es un set de datos, una consulta de lo que hice me lo devuelve en memoria
        {
            DataTable tabla = new DataTable();
            this.conectar();
            this.comando.CommandText = consultaSQL;
            tabla.Load(this.comando.ExecuteReader()); 
            //es el metodo que carga la tabla. "reader" es una ejecucion de lectura

            this.desconectar();
            return tabla;           //si queda algun resultado en esa tabla, me va a devolver en ese objeto datatable una fila que coincide con mi usuario/clave que estoy tratando de validar

        }
        //metodo para ejecutar la consulta sql recibida como parametro relacionada a un insert, delete, update
        public void actualizar(string consultaSQL)
        {
            //metodo para conectarme a la base de datos
            this.conectar();
            this.comando.CommandText = consultaSQL;
            //metodo executeNonQuery para actualizar, para upadte, insert o delete , no devuelve nada
            this.comando.ExecuteNonQuery();
            this.desconectar();

        }


    }
}
