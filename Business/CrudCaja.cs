using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System_Titanium.Date;

namespace System_Titanium.Business
{
    class CrudCaja
    {
        public static DataSet VerCortes()
        {
            // where tbCortesCaja.id != 1
            var query = Conexion.transacBD("select tbCortesCaja.id AS ID, tbUsers.uUserName AS USUARIO,montoContado AS 'MONTO CONTADO', montoCalculado AS 'MONTO CALCULADO', diferencia AS 'DIFERENCIA', retirado AS 'RETIRADO', fechaCorte AS 'FECHA DE CORTE', montoEnCaja   from tbCortesCaja INNER JOIN tbUsers ON tbCortesCaja.idUser = tbUsers.id order by fechaCorte desc", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }

        public static DataSet VerConfCaja()
        {
            var query = Conexion.transacBD("select montoCaja from tbcontrolCaja", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }

        //para saber el total de ingresos a caja
        public static DataSet ingresosCaja()
        {
            var query = Conexion.transacBD("Select SUM(montoTotVenta) AS 'ventas'," +
                "(SELECT SUM(cantRetiro) FROM tbRetirosCaja WHERE fechaHoraMov BETWEEN(select MAX(fechaCorte) from tbCortesCaja) AND GETDATE()) AS 'Retiros'," +
                "(select SUM(montoMens) from tbPagosMensualidad WHERE tbPagosMensualidad.inicioMen BETWEEN(select MAX(fechaCorte) from tbCortesCaja) AND GETDATE()) AS 'Mensualidades'," +
                "(select SUM(cantPagar) from tbVisitas WHERE tbVisitas.fecha BETWEEN(select MAX(fechaCorte) from tbCortesCaja) AND GETDATE()) AS 'Visitas'" +
                "from tbTicket WHERE fechaTicket BETWEEN(select MAX(fechaCorte) from tbCortesCaja) AND GETDATE()", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }

        // Ver Ingresos de caja de fecha a tal fecha
        public static DataSet VerCortesXfecha(int idAct, int idAnterior)
        {
            var query = Conexion.transacBD("Select SUM(montoTotVenta) AS 'ventas'," +
                "(SELECT SUM(cantRetiro) FROM tbRetirosCaja WHERE fechaHoraMov BETWEEN(select fechaCorte from tbCortesCaja where id = '"+idAnterior+ "') AND(select fechaCorte from tbCortesCaja where id = '" + idAct + "')) AS 'Retiros'," +
                "(select SUM(montoMens) from tbPagosMensualidad WHERE tbPagosMensualidad.inicioMen BETWEEN(select fechaCorte from tbCortesCaja where id = '" + idAnterior + "') AND(select fechaCorte from tbCortesCaja where id = '" + idAct + "')) AS 'Mensualidades'," +
                "(select SUM(cantPagar) from tbVisitas WHERE tbVisitas.fecha BETWEEN(select fechaCorte from tbCortesCaja where id = '" + idAnterior + "') AND(select fechaCorte from tbCortesCaja where id = '" + idAct + "')) AS 'Visitas'" +
                "from tbTicket WHERE fechaTicket BETWEEN(select fechaCorte from tbCortesCaja where id = '" + idAnterior + "') AND(select fechaCorte from tbCortesCaja where id = '" + idAct + "')", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }
        //select SUM(montoTotVenta) AS 'Total en Ventas', (select SUM(montoMens) from tbPagosMensualidad) AS 'Total en Menusalidades', (select SUM(cantPagar) from tbVisitas) AS 'Total en Visitas' from tbTicket


        //UPDATE
        public static int UpdateMontoCaja(decimal monto)              
        {
            var query = Conexion.transacBD("UPDATE tbcontrolCaja SET montoCaja = '"+monto+"';", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }

        //INSERTAR CORTE DE CAJA
        public static int InsertarCorteCaja(int user, decimal montoContado, decimal montoCalculado, decimal diferencia, decimal retirado, DateTime fechaCorte)
        {
            var query = Conexion.transacBD("INSERT INTO tbCortesCaja VALUES ('"+user+"','"+montoContado+"','"+montoCalculado+"','"+diferencia+"', '"+retirado+"', '"+fechaCorte.ToString("yyyy'/'MM'/'dd HH:mm:ss") + "')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }


        //------------------------------------- MOVIMIENTOS DE CAJA -----------------------------

        public static int InsertarMovCaja(int user, decimal montoMov, DateTime fechaMov, string concepto)
        {
            var query = Conexion.transacBD("INSERT INTO tbRetirosCaja VALUES ('"+user+"','"+montoMov+"','"+fechaMov.ToString("yyyy'/'MM'/'dd HH:mm:ss") +"','"+concepto+"')", false);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;


            return Conexion.conf;

        }
        // -------------------- PARA SABER CUANTOS EGRESOS HUBO DE CAJA-------------
        public static DataSet VerEGRESOS(int idact, int idAnterior)
        {
            var query = Conexion.transacBD("select fechaHoraMov,concepto, uUserName,cantRetiro from tbRetirosCaja INNER JOIN tbUsers ON tbRetirosCaja.idUser = tbUsers.id where fechaHoraMov BETWEEN(select fechaCorte from tbCortesCaja where id = '"+idAnterior+"') AND(select fechaCorte from tbCortesCaja where id = '"+idact+"')", true);
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
