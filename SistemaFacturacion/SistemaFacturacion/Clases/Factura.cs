﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemaFacturacion.Clases;
using SistemaFacturacion.Formularios;


namespace SistemaFacturacion.Clases
{
    class Factura
    {
        //creo objeto dato para conexiones con base de datos
        Datos oDato = new Datos();

        private List<FacturaDetalle> listFacturaDetalle;

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
        internal List<FacturaDetalle> ListFacturaDetalle { get => listFacturaDetalle; set => listFacturaDetalle = value; }

        //metodo para cargar numero de factura, se conecta con la BD y se fija cual es el ultimo y a ese 
        //le incrementa 1
        //Debemos generar un identiy
        //esto debemos sacar
                

        //Metodo para grabar la cabecera de la factura, junto con cada uno de sus detalles recorriendo la lista de detalles
        public void grabarFacturaConDataManager()
        {

            DataManager dm = new DataManager();

            try { 
            dm.Open();
            dm.BeginTransaction();

            string sql = string.Concat("INSERT INTO [dbo].[Facturas] ",
                                        "           ([numero_factura]   ",
                                        "           ,[id_cliente]         ",
                                        "           ,[fecha]       ",
                                        "           ,[id_usuario_creador]       ",
                                        "           ,[borrado])      ",
                                        "     VALUES                 ",
                                        "           (@numero_factura   ",
                                        "           ,@id_cliente          ",
                                        "           ,@fecha        ",
                                        "           ,@id_usuario_creador    ",
                                        "           ,@borrado)       ");


            var parametros = new Dictionary<string, object>();
            parametros.Add("numero_factura", "");
            parametros.Add("id_cliente", id_cliente);
            parametros.Add("fecha", fecha);
            parametros.Add("id_usuario_creador", id_usuario_creador);
            parametros.Add("borrado", false);
            dm.EjecutarSQLCONPARAMETROS(sql, parametros);

            var newId = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");

            string sql_update_nroFactura = "UPDATE facturas SET numero_factura = '" + newId.ToString() + "' WHERE id_factura = " + newId;
            dm.EjecutarSQL(sql_update_nroFactura);


            
            
           

            Id_factura = Convert.ToInt32(newId);


            foreach (var itemFactura in listFacturaDetalle)
            {
                string sqlDetalle = string.Concat(" INSERT INTO [dbo].[FacturasDetalle] ",
                                                    "           ([id_factura]           ",
                                                    "           ,[numero_orden]          ",
                                                    "           ,[id_proyecto]      ",
                                                    "           ,[id_producto]             ",
                                                    "           ,[precio]             ",
                                                    "           ,[borrado])             ",
                                                    "     VALUES                        ",
                                                    "           (@id_factura            ",
                                                    "           ,@numero_orden          ",
                                                    "           ,@id_proyecto       ",
                                                    "           ,@id_producto              ",
                                                    "           ,@precio              ",
                                                    "           ,@borrado)               ");

                var paramDetalle = new Dictionary<string, object>();
                paramDetalle.Add("id_factura", id_factura);
                paramDetalle.Add("numero_orden", itemFactura.Numero_orden);
                paramDetalle.Add("id_proyecto", itemFactura.Id_proyecto);
                paramDetalle.Add("id_producto", itemFactura.Id_producto);
                paramDetalle.Add("precio", itemFactura.Precio);
                paramDetalle.Add("borrado", false);

                dm.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);
            }



            dm.Commit();

        }

            catch (Exception ex)

            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

           

        }





    }
}
