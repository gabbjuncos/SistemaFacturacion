using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SistemaFacturacion.Clases
{
    class Cliente
    {
        //creo objeto dato como un atributo mas de esta clase
        Datos oDato = new Datos();

        private int id_cliente;
        private string cuit;
        private string razon_social;
        private string borrado;
        private string calle;
        private string numero;
        private DateTime fecha_alta;
        private int id_barrio;
        private int id_contacto;

        public int Id_contacto { get => id_contacto; set => id_contacto = value; }
        public int Id_barrio { get => id_barrio; set => id_barrio = value; }
        public DateTime Fecha_alta { get => fecha_alta; set => fecha_alta = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Borrado { get => borrado; set => borrado = value; }
        public string Razon_social { get => razon_social; set => razon_social = value; }
        public string Cuit { get => cuit; set => cuit = value; }
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
        //metodo para validar datos antes de grabar
        public bool validarDatosClientes()
        {
            //validamos preguntando por todo lo que estaria mal cargado a los atributos del objero cliente
            if (this.cuit.ToString() == string.Empty) {
                MessageBox.Show("El campo CUIT esta vacio");
                return false;

            }
            if (this.razon_social == string.Empty)
            {
                MessageBox.Show("El campo RAZON SOCIAL esta vacio");
                return false;

            }
            if (this.calle == string.Empty)
            {
                MessageBox.Show("El campo CALLE esta vacio");
                return false;

            }

            if (this.numero.ToString() == string.Empty)
            {
                MessageBox.Show("El campo NUMERO esta vacio o no es un valor valido");
                return false;

            }
            if (this.id_barrio.ToString() == string.Empty | this.id_barrio < 0)
            {
                MessageBox.Show("El campo ID BARRIO esta vacio o no es un valor valido");
                return false;

            }

            if (this.id_contacto.ToString() == string.Empty | this.id_contacto < 0)
            {
                MessageBox.Show("El campo ID CONTACTO esta vacio o no es un valor valido");
                return false;

            }


            return true;
        }

        // metodo para verificar si existe el cliente con un determinado cuit y devuelve si o no
        public bool existe()
        {
            DataTable table = new DataTable();
            table = oDato.consultar("SELECT * FROM clientes WHERE cuit= '" + this.cuit+"'");
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
        public void grabarCliente()
        {
            string sqlInsert = "INSERT INTO Clientes (cuit, razon_social, borrado, calle, numero, id_barrio, id_contacto)" +
                " VALUES ( " +
                this.cuit + ",'" +
                this.razon_social + "', " +
                "'N'" + ", '" +
                this.calle + "', " +
                this.numero + ", " +
                this.id_barrio + ", " +
                this.Id_contacto + ")";

            //ejecutamos el metodo para realizar la consulta en la BD pasando la consulta insert
            oDato.actualizar(sqlInsert);


        }



        //metodo para realizar la consulta sql referia al update de los datos que se quieren grabar 
        public void actualizarCliente()
        {
            string sqlUpdate = "UPDATE Clientes SET cuit = " + this.cuit + "," +
                "razon_social = '" + this.razon_social + "' ," +
                " borrado = " + "'N'" + "," +
                " calle = '"  + this.calle + "', " +
                " numero = "  + this.numero + " , " +
                " id_barrio = " + this.id_barrio + " , " +
                " id_contacto = " + this.Id_contacto + 
                " WHERE id_cliente = " + this.id_cliente;


            //ejecutamos el metodo para realizar la consulta en la BD pasando la consulta insert
            oDato.actualizar(sqlUpdate);

        }

        //metodo para realizar la consulta sql referia al update de los datos modificando el cambo borrado a S
        public void darBajaCliente()
        {
            string sqlDarBaja = "UPDATE Clientes SET cuit = " + this.cuit + "," +
                "razon_social = '" + this.razon_social + "' ," +
                " borrado = " + "'S'" + "," +
                " calle = '" + this.calle + "', " +
                " numero = " + this.numero + " , " +
                " id_barrio = " + this.id_barrio + " , " +
                " id_contacto = " + this.Id_contacto +
                " WHERE id_cliente = " + this.id_cliente;


            //ejecutamos el metodo para realizar la consulta en la BD pasando la consulta UPDATE
            oDato.actualizar(sqlDarBaja);

        }


    }

}
