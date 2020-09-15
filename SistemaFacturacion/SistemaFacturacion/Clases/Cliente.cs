using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaFacturacion.Clases
{
    class Cliente
    {
        //creo objeto dato como un atributo mas de esta clase
        Datos oDato = new Datos();

        private int id_cliente;
        private int cuit;
        private string razon_social;
        private string borrado;
        private string calle;
        private int numero;
        private string fecha_alta;
        private int id_barrio;
        private int id_contacto;

        public int Id_contacto { get => id_contacto; set => id_contacto = value; }
        public int Id_barrio { get => id_barrio; set => id_barrio = value; }
        public string Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Borrado { get => borrado; set => borrado = value; }
        public string Razon_social { get => razon_social; set => razon_social = value; }
        public int Cuit { get => cuit; set => cuit = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }

        //metodo para crear data table cargada con los datos de clientes a partir de la consulta, teniendo solo encuenta los no borrados(N) 
        public DataTable recuperarClientes()
        {
            string consultaSQL = "SELECT cl.id_cliente, cl.borrado, cl.id_barrio, cl.cuit, cl.razon_social, cl.calle, cl.numero, cl.fecha_alta, cl.id_contacto" +
                " FROM Clientes cl";
                
            return oDato.consultar(consultaSQL);
        }

        //recuperamos un cliente determinado a partir de su id 
        public DataTable recuperarClientePorId(int id) {

            return oDato.consultar("SELECT * FROM Clientes WHERE id_cliente=" + id);
        }
    }

}
