using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Titanium.Date;
using System.Data;

namespace System_Titanium.Business
{
    class CrudSocios
    {
        //INSERT
        public static int Insert_Socio(int idUser, string nombreSocio, string tel, string correo,  string path)
        {
            var query = Conexion.transacBD("insert into tbSocios VALUES ('"+idUser+"','"+nombreSocio+"','"+tel+"','"+correo+"',0,'"+path+"')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        //SELECT
        public static DataSet SociosSelect()
        {
            var query = Conexion.transacBD("select idSocio as 'ID', nombreSocio AS 'SOCIO',telefono AS 'TELÉFONO', correo AS 'CORREO', mesesPagados AS 'RENOVACIONES', photo from tbSocios", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //UPDATE
        public static int UpdateSocio(int idSocio,int idUser, string nombreSocio, string tel, string correo, string path)
        {
            var query = Conexion.transacBD("UPDATE tbSocios SET idUser = '"+idUser+"',nombreSocio = '"+nombreSocio+"', telefono = '"+tel+"',correo = '"+correo+"', photo = '"+path+"' WHERE idSocio = '" + idSocio + "';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }
                    // DELETE MENUSALIDAD
        public static int DeleteMensualidad(int idMensualidad)
        {
            var query = Conexion.transacBD("DELETE FROM tbPagosMensualidad where idPagoSocio = '"+idMensualidad+"'", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }


        //  DELETE
        public static int DeleteSocio(int idSocio)
        {
            var query = Conexion.transacBD("DELETE FROM tbSocios WHERE idSocio = '"+ idSocio + "';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        //-------------------------------MENSUALIDADES ----------------------
        //INSERT
        public static int Insert_Mensuaalidad(int idSocio, int idAreGym, string inicioMensualidadn, string finMensualidad, decimal montoMen)
        {
            var query = Conexion.transacBD("INSERT INTO tbPagosMensualidad VALUES ('"+idSocio+"','"+idAreGym+"','"+inicioMensualidadn+"','"+finMensualidad+"','"+montoMen+"')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        public static int UpdateMensualidad(int idMensualidad, int idAreagym, string inicioMensualidadn, string finMensualidad, decimal montoMen)
        {
            var query = Conexion.transacBD("UPDATE tbPagosMensualidad SET idareaGym= '"+idAreagym+"',inicioMen= '"+inicioMensualidadn+"', finMen='"+finMensualidad+"', montoMens = '"+montoMen+"' where idPagoSocio = '"+idMensualidad+"'", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        //SELECT Todos los Socios con mensualidad
        public static DataSet SociosMensSelect()
        {
            var query = Conexion.transacBD("select idPagoSocio AS  'ID MENSUALIDAD', nombreSocio as 'SOCIO', tbAreas.nombreArea AS 'AREA', inicioMen AS 'INICIO PERIODO', finMen AS 'FIN PERIODO', montoMens AS MONTO, photo from tbPagosMensualidad INNER JOIN tbAreas ON tbAreas.id = tbPagosMensualidad.idareaGym INNER JOIN tbSocios ON tbSocios.idSocio = tbPagosMensualidad.idSocio", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //SELECT Todos los Socios con mensualidad vencidos
        public static DataSet SociosMensVencidos()
        {
            var query = Conexion.transacBD("select idPagoSocio AS  'ID MENSUALIDAD', nombreSocio as 'SOCIO', tbAreas.nombreArea AS 'AREA', inicioMen AS 'INICIO PERIODO', finMen AS 'FIN PERIODO', montoMens AS MONTO, photo from tbPagosMensualidad INNER JOIN tbAreas ON tbAreas.id = tbPagosMensualidad.idareaGym INNER JOIN tbSocios ON tbSocios.idSocio = tbPagosMensualidad.idSocio where finMen < GETDATE()", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;

        }

        //SELECT Todos los Socios con mensualidad Activos
        public static DataSet SociosMensActivos()
        {
            var query = Conexion.transacBD("select idPagoSocio AS  'ID MENSUALIDAD', nombreSocio as 'SOCIO', tbAreas.nombreArea AS 'AREA', inicioMen AS 'INICIO PERIODO', finMen AS 'FIN PERIODO', montoMens AS MONTO, photo from tbPagosMensualidad INNER JOIN tbAreas ON tbAreas.id = tbPagosMensualidad.idareaGym INNER JOIN tbSocios ON tbSocios.idSocio = tbPagosMensualidad.idSocio where finMen > GETDATE()", true);
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
