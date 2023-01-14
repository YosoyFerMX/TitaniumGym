using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System_Titanium.Date;

namespace System_Titanium.Business
{
    class CrudArea
    {
        public static DataSet AreasSelect() {

                var query = Conexion.transacBD("SELECT id as ID, nombreArea as AREA, precioArea as 'PRECIO SOCIO', precioAreaVisita as 'PRECIO VISITA', precioAreaQuince as 'PRECIO QUINCENAL' FROM tbAreas", true);
                Conexion.conf = query.Item1;
                Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }

        public static DataSet PrecioArea(int id)
        {

            var query = Conexion.transacBD("SELECT * FROM tbAreas WHERE id = '" + id + "';", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }


        public static int UpdateArea(int id, string area, decimal precioSocio, decimal precioVisita, decimal precioQuincenal)
        {
            var query = Conexion.transacBD("UPDATE tbAreas SET nombreArea = '"+area+"', precioArea = '"+precioSocio+"', precioAreaVisita = '"+precioVisita+"', precioAreaQuince = '"+precioQuincenal+"' WHERE id = '"+id+"'", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }



    }
}
