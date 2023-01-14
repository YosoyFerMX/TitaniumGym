using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System_Titanium.Date;
using System_Titanium.Presentation;

namespace System_Titanium.Business
{
    class CrudProductos
    {
        public static DataSet Productos()
        {
            var query = Conexion.transacBD("select id AS Clave, nombreProd AS Producto," +
                "precioCompra AS 'Precio Compra', precioVenta AS 'Precio Venta', procentajeGanancia AS 'Procentaje Ganancia'," +
                "stockProd AS Existencia from tbProductos", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }


        //INSERT
        public static int Insert_Productos(int id, string nombreProd, decimal precioCompra, decimal precioVenta, decimal porcentajeVenta, int stockProd)
        {
            var query = Conexion.transacBD("insert into tbProductos values('" + nombreProd + "', '" + precioCompra + "', " +
                "'" + precioVenta + "', '" + porcentajeVenta + "', '" + stockProd + "');", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        //UPDATE
        public static int UpdateProd(int id, string nombreProd, decimal precioCompra, decimal precioVenta, decimal porcentajeVenta, int stockProd)
        {
            var query = Conexion.transacBD("UPDATE tbProductos SET nombreProd = '" + nombreProd + "', precioCompra = '" + precioCompra + "', " +
                "precioVenta = '" + precioVenta + "', procentajeGanancia = '" + porcentajeVenta + "' , stockProd = '" + stockProd + "' WHERE id = '" + id + "';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }


        //Delete
        public static int DeleteProd(int id)
        {
            var query = Conexion.transacBD("delete from tbProductos where id = '" + id + "';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }
    }
}
