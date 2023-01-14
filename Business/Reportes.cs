using System;
using System.Data;
using System_Titanium.Date;

namespace System_Titanium.Business
{
    class Reportes
    {
        public static DataSet AreaMoreUse(DateTime fechaIni, DateTime fechaIniHasta)
        {

            var query = Conexion.transacBD("select nombreArea, COUNT(idSocio) as Conteo from tbPagosMensualidad INNER JOIN tbAreas on idareaGym = id where tbPagosMensualidad.inicioMen > '" + fechaIni.ToString("yyyy'/'MM'/'dd") + "' AND tbPagosMensualidad.inicioMen < '"+fechaIniHasta.ToString("yyyy'/'MM'/'dd") +"' group by nombreArea order by Conteo asc", true);
            //where tbPagosMensualidad.inicioMen > '"+fechaIni.ToString("yyyy'/'MM'/'dd") +"'
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;
        }

        public static DataSet ProductoMasVendido(DateTime fechaIni, DateTime hasta)
        {

            var query = Conexion.transacBD("SELECT TOP 5 nombreProd, COUNT(idProducto) AS CANTIDAD FROM tbVentas INNER JOIN tbTicket ON tbVentas.idFolioTicket = tbTicket.folioTicket Where fechaTicket > '" + fechaIni.ToString("yyyy'/'MM'/'dd") + "' AND fechaTicket < '"+hasta.ToString("yyyy'/'MM'/'dd") +"' group by nombreProd, idProducto order by CANTIDAD asc", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }

        public static DataSet EntradasVisitas(DateTime fecha, DateTime hasta)
        {

            var query = Conexion.transacBD("select nombreArea, sum(cantPagar) AS cantidad from tbVisitas INNER JOIN tbAreas ON idArea = id where fecha > '" + fecha.ToString("yyyy'/'MM'/'dd") + "' AND fecha < '"+hasta.ToString("yyyy'/'MM'/'dd") +"'group by nombreArea", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }

        public static DataSet Dashboard()
        {

            var query = Conexion.transacBD("select count(folioTicket) AS nTickets, (select COUNT(idSocio) from tbSocios) AS nSocios, (select COUNT(idPagoSocio) from tbPagosMensualidad where tbPagosMensualidad.finMen > GETDATE()) AS nMensuActivas from tbTicket", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }

        // Querys para Reporte General
        public static DataSet ReporGenVentas(DateTime fechaIni, DateTime fechaFin)
        {

            var query = Conexion.transacBD("select SUM(tbventas.precioCompra) as 'Compra', SUM(tbVentas.precioUnitario) as 'Venta' from tbTicket INNER JOIN tbVentas ON folioTicket = idFolioTicket where fechaTicket > '"+fechaIni.ToString("yyyy'/'MM'/'dd") +"' AND fechaTicket < '"+fechaFin.ToString("yyyy'/'MM'/'dd") +"'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }

        public static DataSet ReporUtilidadGym(DateTime fechaIni, DateTime fechaFin)
        {

            var query = Conexion.transacBD("select SUM(montoMens) as utilidadMensu, (select SUM(cantPagar) from tbVisitas where fecha > '"+fechaIni.ToString("yyyy'/'MM'/'dd") + "' and fecha < '"+fechaFin.ToString("yyyy'/'MM'/'dd") + "') as utilidadVisitas from tbPagosMensualidad where inicioMen > '"+fechaIni.ToString("yyyy'/'MM'/'dd") + "' and inicioMen < '"+fechaFin.ToString("yyyy'/'MM'/'dd") + "'", true);
            Conexion.conf = query.Item1;
            Conexion.ds = query.Item2;
            if (Conexion.conf == 0)
            {
                Conexion.ds = null;
            }
            return Conexion.ds;


        }

        public static DataSet ReporUtilidadEgresos(DateTime fechaIni, DateTime fechaFin)
        {

            var query = Conexion.transacBD("select SUM(cantRetiro) as Egresos from tbRetirosCaja where fechaHoraMov > '"+fechaIni.ToString("yyyy'/'MM'/'dd") + "' and fechaHoraMov < '"+fechaFin.ToString("yyyy'/'MM'/'dd") + "'", true);
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
