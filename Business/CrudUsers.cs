using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Titanium.Date;
using System_Titanium.Presentation;

namespace System_Titanium.Business
{
    class CrudUsers
    {
        public static DataSet Usuarios() {
            var query = Conexion.transacBD("select id AS Clave, uUserName AS Usuario," +
                "uPassword AS Contraseña, uNumTel AS Teléfono, uNivSeg AS Nivel from tbUsers", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }


        //INsert
        public static int Insert_Usuarios( string user, string pass, string tel, string nivel)
        {
            var query = Conexion.transacBD("insert into tbUsers values('"+user+"', '"+pass+"', " +
                "'"+tel+"', '"+nivel+"');", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }


        //Delete
        public static int DeleteUsers(int id)
        {
            var query = Conexion.transacBD("delete from tbUsers where id = '"+id+"';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }


        //Update

        public static int UpdateUsers(int id, string user, string pssw, string tel, string nivSeg)
        {
            var query = Conexion.transacBD("UPDATE tbUsers SET uUserName = '"+user+"', uPassword = '"+pssw+"', " +
                "uNumTel = '"+tel+"', uNivSeg = '"+nivSeg+"' WHERE id = '"+id+"';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

    }

  
}
