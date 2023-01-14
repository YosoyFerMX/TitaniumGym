using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Titanium.Date;

namespace System_Titanium.Business
{
    class CrudVisitas
    {

        //INSERT
        public static int Insert_Visit(int idArea, int idUsuario, decimal cantPagar)
        {
            var query = Conexion.transacBD("insert into tbVisitas values('" + idArea + "', '" + idUsuario + "', " +
                "'" + DateTime.Now.ToString("MM/dd/yyyy") + "', '" + DateTime.Now.ToString("HH:mm:ss") + "', '" + cantPagar + "');", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }
    }
}
