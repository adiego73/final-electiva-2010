using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Library.Excepciones;
using Library.Funciones;

namespace Library.ParaDB
{
    public class ParaDB
    {
        //CON TRANSACCION ASOCIADA -- se usan para los ABM
        public static object EjecutarConsulta(string strConsulta, Parametros parametros, Transaccion t, string tabla)
        {
            ExcepcionGral exc = new ExcepcionGral();
            IDbCommand cmd;
            string sqlSetID = "SET IDENTITY_INSERT " +tabla+ " ON;";

            object rta = null;
            try
            {
                cmd = new SqlCommand(sqlSetID, t.Conn);
                cmd.Transaction = t.Transaction;
                cmd.ExecuteScalar();
                cmd = ParaDB.CrearComando(strConsulta, parametros, t);
                cmd.Transaction = t.Transaction; 
                rta = cmd.ExecuteScalar();
                sqlSetID = "SET IDENTITY_INSERT " +tabla+ " OFF;";
                cmd = new SqlCommand(sqlSetID, t.Conn);
                cmd.Transaction = t.Transaction; 
                cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (InvalidOperationException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            return rta;
        }

        public static object EjecutarConsulta(string strConsulta, Parametros parametros, Transaccion t)
        {
            ExcepcionGral exc = new ExcepcionGral();
            IDbCommand cmd;

            object rta = null;
            try
            {
                cmd = ParaDB.CrearComando(strConsulta, parametros, t);
                cmd.Transaction = t.Transaction;
                rta = cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (InvalidOperationException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            return rta;
        }

        public static void EjecutarConsulta(string strConsulta, Parametros parametros, Transaccion t, out DataSet ds)
        {
            ExcepcionGral exc = new ExcepcionGral();
            ds = null;
            IDbCommand cmd;

            IDbDataAdapter ad = new SqlDataAdapter();
            try
            {
                cmd = ParaDB.CrearComando(strConsulta, parametros, t);
                cmd.Transaction = t.Transaction;
                cmd.ExecuteScalar();
                ad.SelectCommand = cmd;
                ds = new DataSet();
                ad.Fill(ds);
            }
            catch (SqlException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (InvalidOperationException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
        }

        public static void EjecutarConsulta(string strConsulta, Transaccion t, out DataSet ds)
        {
            ExcepcionGral exc = new ExcepcionGral();
            ds = null;
            IDbCommand cmd;

            IDbDataAdapter ad = new SqlDataAdapter();
            try
            {
                cmd = ParaDB.CrearComando(strConsulta, null, t);
                cmd.Transaction = t.Transaction; 
                ad.SelectCommand = cmd;
                cmd.ExecuteScalar();
                ds = new DataSet();
                ad.Fill(ds);
            }
            catch (SqlException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (InvalidOperationException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
        }

        public static void EjecutarConsulta(string strConsulta, Transaccion t)
        {
            ExcepcionGral exc = new ExcepcionGral();
            IDbCommand cmd;

            try
            {
                cmd = ParaDB.CrearComando(strConsulta, null, t);
                cmd.Transaction = t.Transaction;
                cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (InvalidOperationException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
        }

        private static IDbCommand CrearComando(string procedure, Parametros parametros, Transaccion t)
        {
            ExcepcionGral exc = new ExcepcionGral();
            IDbCommand command = null;
            try
            {
                command = new SqlCommand(procedure, t.Conn, (SqlTransaction)t.Transaction);
                command.Transaction = t.Transaction;
              
                if (parametros != null)
                {
                    foreach (IDbDataParameter parametro in parametros)
                        command.Parameters.Add(parametro);
                }
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL CREAR EL COMANDO: ParaDB.CrearComando() -- " + e.Message, TipoError.ERRTIPODATO);
                throw exc;
            }

            return command;
        }

        //SIN TRANSACCION ASOCIADA -- se usan para las consultas
        public static object EjecutarConsulta(string strConsulta, Parametros parametros, SqlConnection conn, string tabla)
        {
            ExcepcionGral exc = new ExcepcionGral();
            IDbCommand cmd;
            string sqlSetID = "SET IDENTITY_INSERT " + tabla + " ON;";

            object rta = null;
            try
            {
                cmd = new SqlCommand(sqlSetID, conn);
                cmd.ExecuteScalar();
                cmd = ParaDB.CrearComando(strConsulta, parametros, conn);
                rta = cmd.ExecuteScalar();
                sqlSetID = "SET IDENTITY_INSERT " + tabla + " OFF;";
                cmd = new SqlCommand(sqlSetID, conn);
                cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (InvalidOperationException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            return rta;
        }

        public static object EjecutarConsulta(string strConsulta, Parametros parametros, SqlConnection conn)
        {
            ExcepcionGral exc = new ExcepcionGral();
            IDbCommand cmd;

            object rta = null;
            try
            {
                cmd = ParaDB.CrearComando(strConsulta, parametros, conn);
                rta = cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (InvalidOperationException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            return rta;
        }

        public static void EjecutarConsulta(string strConsulta, Parametros parametros, SqlConnection conn, out DataSet ds)
        {
            ExcepcionGral exc = new ExcepcionGral();
            ds = null;
            IDbCommand cmd;

            IDbDataAdapter ad = new SqlDataAdapter();
            try
            {
                cmd = ParaDB.CrearComando(strConsulta, parametros, conn);
                cmd.ExecuteScalar();
                ad.SelectCommand = cmd;
                ds = new DataSet();
                ad.Fill(ds);
            }
            catch (SqlException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (InvalidOperationException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
        }

        public static void EjecutarConsulta(string strConsulta, SqlConnection conn, out DataSet ds)
        {
            ExcepcionGral exc = new ExcepcionGral();
            ds = null;
            IDbCommand cmd;

            IDbDataAdapter ad = new SqlDataAdapter();
            try
            {
                cmd = ParaDB.CrearComando(strConsulta, null, conn);
                cmd.ExecuteScalar();
                ad.SelectCommand = cmd;
                ds = new DataSet();
                ad.Fill(ds);
            }
            catch (SqlException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (InvalidOperationException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
        }

        public static void EjecutarConsulta(string strConsulta, SqlConnection conn)
        {
            ExcepcionGral exc = new ExcepcionGral();
            IDbCommand cmd;

            try
            {
                cmd = ParaDB.CrearComando(strConsulta, null, conn);
                cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (InvalidOperationException e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL EJECUTAR LA CONSULTA: ParaDB.EjecutarConsulta() -- " + e.Message, TipoError.ERRCONSULTA);
                throw exc;
            }
        }

        private static IDbCommand CrearComando(string procedure, Parametros parametros, SqlConnection conn)
        {
            ExcepcionGral exc = new ExcepcionGral();
            IDbCommand command = null;
            try
            {
                command = new SqlCommand(procedure, conn);

                if (parametros != null)
                {
                    foreach (IDbDataParameter parametro in parametros)
                        command.Parameters.Add(parametro);
                }
            }
            catch (Exception e)
            {
                exc.AgregarError("SE PRODUJO UN ERROR AL CREAR EL COMANDO: ParaDB.CrearComando() -- " + e.Message, TipoError.ERRTIPODATO);
                throw exc;
            }

            return command;
        }
    }
}
