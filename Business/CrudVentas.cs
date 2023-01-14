using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Titanium.Date;
using System.Data;

namespace System_Titanium.Business
{
    class CrudVentas
    {
        public static DataSet FolioTicket()
        {
            var query = Conexion.transacBD("select * from tbFolioTicket", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }
        public static int Insert_Ticket(int idUser, string fecha, decimal pagoCon, decimal cambioVen, decimal monto)
        {
            var query = Conexion.transacBD("insert into tbTicket values('"+idUser+"','"+fecha+"','"+pagoCon+"','"+cambioVen+"','"+monto+"')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        public static int Insert_Venta(int folioTicket, int idProd,string nombreProd, int cantidad, decimal precioUni, decimal importe, decimal precioCompra)
        {
            var query = Conexion.transacBD("insert into tbVentas values ('" + folioTicket + "','" + idProd + "','"+nombreProd+"','" + cantidad + "','" + precioUni + "','" + importe + "', '"+precioCompra+"')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;
        }

        // PARA TRAER LOS TICEKT DEL DÍA POR FECHA
        public static DataSet VentasDia(DateTime fecha)
        {
            var query = Conexion.transacBD("select folioTicket AS 'FOLIO', CAST(fechaTicket AS time) AS 'HORA', montoTotVenta as TOTAL, pagoConVenta AS 'PAGO CON', cambioVenta as 'CAMBIO', tbUsers.uUserName AS CAJERO from tbTicket INNER JOIN tbUsers ON idUsuario = id where CAST(fechaTicket as date) = '" + fecha.ToString("yyyy-MM-dd")+ "' order by 'HORA' desc", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        public static DataSet ListaVentasDia(int idFolio)
        {
            var query = Conexion.transacBD("select cantidad as CANTIDAD, nombreProd as 'DESCRIPCIÓN', importe as IMPORTE from tbVentas where idFolioTicket = '"+idFolio+"'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }
    }
}
