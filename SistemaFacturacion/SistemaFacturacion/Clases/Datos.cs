using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaFacturacion.Clases
{
    class Datos             //Esta clase "Datos" es la que me va a permitir la conectividad con la base de datos
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();
        private string cadenaConexion = @"Data Source=DESKTOP-6MO7HMH;Initial Catalog=TPI_PAVI;Integrated Security=True";

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

    }
}
