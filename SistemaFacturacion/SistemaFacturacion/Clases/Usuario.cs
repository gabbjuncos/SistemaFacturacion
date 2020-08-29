using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SistemaFacturacion.Clases
{
    class Usuario
    {
        private int id_usuario;       //estos son atributos encapsulados
        private string n_usuario;
        private string password;
        private string email;
        private int id_perfil;

        //el get y set aca en .net no lo define como metodos de seteo, sino como una propiedad. al ser una 
        //propiedad implica el set y get y despues de acuerdo al uso como se implementa

        public int Id_usuario   //el atributo sera indicado con minuscula "id_usuario" y la propiedad 
                                // la indicada con mmayuscula 
                                //son propiedades para poder acceder a los atributos

        {
            get { return id_usuario;  } //me va a retornar el atributo
            set { id_usuario = value; }  
        }

        public string N_usuario
        {
            get { return n_usuario; }
            set { n_usuario = value; }
         }

        public string Password { get => password; set => password = value; }   //me paro sobre Password, btn secundario "acciones rapidas y refactorizaciones", "encapsular campo (y usar propiedad)
        public string Email { get => email; set => email = value; }
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }

        public int validarUsuario(string nombre, string clave)      //esta es la forma de hacer un metodo
        {
            string consultaSQL = "SELECT * FROM Users WHERE n_usuario='" + nombre + "' AND password='" + clave + "'";
            DataTable tabla = new DataTable();

            Datos oDato = new Datos();
            tabla = oDato.consultar(consultaSQL);

            if (tabla.Rows.Count > 0)
                return Convert.ToInt32(tabla.Rows[0][0]);
            else
                return 0;                
        }
    }
}
