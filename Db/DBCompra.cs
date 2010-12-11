using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using Library.Excepciones;
using Library.ParaDB;
using Library.Funciones;
using System.Data;

namespace Db
{
    public class DBCompra : IDBConsultas 
    {
        #region Atributos
        
        private SqlConnection conn;

        #endregion

        #region Constructores

        public DBCompra()
        {
            this.Conn = new SqlConnection(DBGeneral.StrConn);
        }

        #endregion

        #region Propiedades

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        #endregion

        #region ABM

        public int agregar(ArrayList arr, Transaccion t)
        {
            try
            {
                string sql = @"insert into Compra (COM_Codigo, CLI_Dni, COM_Fecha, COM_Importe, COM_Puntaje) ";
                sql += "values (@Codigo, @Dni, @Fecha, @Importe, @Puntaje) select SCOPE_IDENTITY(); ";

                Parametros col = new Parametros();

                col.Add(Parametros.CargarParametro("@Codigo", TipoDato.Entero, arr[0]));
                col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, arr[1]));
                col.Add(Parametros.CargarParametro("@Fecha", TipoDato.Fecha, arr[2]));
                col.Add(Parametros.CargarParametro("@Importe", TipoDato.Decimal, arr[3]));
                col.Add(Parametros.CargarParametro("@Puntaje", TipoDato.Entero, arr[4]));

                object id = ParaDB.EjecutarConsulta(sql, col, t, "Compra");
                return Conversiones.AInt(id);
            }
            catch (ExcepcionGral exc)
            {
                this.Dispose();
                throw exc;
            }
        }

        public void eliminar()
        {
            Transaccion t = new Transaccion();
            try
            {
                t.Begin();
                string sql = "DELETE FROM Compra;";
                ParaDB.EjecutarConsulta(sql, t);
                t.Commit();
            }
            catch (ExcepcionGral exc)
            {
                t.Rollback();
                throw exc;
            }
        }

        #endregion

        #region Consultas

            public DataSet listarTodas()
            {
                SqlConnection conn = null;
                try
                {
                    try
                    {
                        conn = new SqlConnection(DBGeneral.StrConn);
                        conn.Open();
                    }
                    catch (SqlException e)
                    {
                        ExcepcionGral exc = new ExcepcionGral();
                        exc.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB -- " + e.Message, TipoError.ERRCONEXION);
                        throw exc;
                    }
                    string sql = "SELECT * FROM Compra;";

                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, conn, out ds);
                    conn.Close();
                    return ds;
                }
                catch (ExcepcionGral exc)
                {
                    conn.Close();
                    throw exc;
                }
            }

            public DataSet listarTodas(int dni)
            {
                SqlConnection conn = null;
                try
                {
                    try
                    {
                        conn = new SqlConnection(DBGeneral.StrConn);
                        conn.Open();
                    }
                    catch (SqlException e)
                    {
                        ExcepcionGral exc = new ExcepcionGral();
                        exc.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB -- " + e.Message, TipoError.ERRCONEXION);
                        throw exc;
                    }
                    string sql = "SELECT * FROM Compra p WHERE p.CLI_Dni = @Dni;";
                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, dni));
                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, col, conn, out ds);
                    conn.Close();
                    return ds;
                }
                catch (ExcepcionGral exc)
                {
                    conn.Close();
                    throw exc;
                }
            }


            public bool existe(int cod)
            {
                SqlConnection conn = null;
                try
                {
                    try
                    {
                        conn = new SqlConnection(DBGeneral.StrConn);
                        conn.Open();
                    }
                    catch (SqlException e)
                    {
                        ExcepcionGral exc = new ExcepcionGral();
                        exc.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB -- " + e.Message, TipoError.ERRCONEXION);
                        throw exc;
                    }
                    string sql = "SELECT * FROM Compra p WHERE p.COM_Codigo = @Codigo;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Codigo", TipoDato.Entero, cod));

                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, col, conn, out ds);
                    conn.Close();
                    if (ds != null && ds.Tables[0].Rows.Count == 0)
                        return false;
                    else
                        return true;
                }
                catch (ExcepcionGral exc)
                {
                    this.Dispose();
                    throw exc;
                }
            }

            public DataSet traer(int cod)
            {
                SqlConnection conn = null;
                try
                {
                    try
                    {
                        conn = new SqlConnection(DBGeneral.StrConn);
                        conn.Open();
                    }
                    catch (SqlException e)
                    {
                        ExcepcionGral exc = new ExcepcionGral();
                        exc.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB -- " + e.Message, TipoError.ERRCONEXION);
                        throw exc;
                    }
                    string sql = "SELECT * FROM Compra WHERE COM_Codigo = @Codigo;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Codigo", TipoDato.Entero, cod));

                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, col, conn, out ds);
                    conn.Close();
                    return ds;
                }
                catch (ExcepcionGral exc)
                {
                    this.Dispose();
                    throw exc;
                }
            }

            public int calcularId()
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(DBGeneral.StrConn);
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    ExcepcionGral exc = new ExcepcionGral();
                    exc.AgregarError(ex.Message);
                    throw exc;
                }

                try
                {
                    string sql = "SELECT TOP 1 COM_Codigo FROM Compra ORDER BY COM_Codigo DESC;";

                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, conn, out ds);

                    if (ds != null && ds.Tables[0].Rows.Count == 1)
                    {
                        int cod = RecuperarAtributo.Entero(ds.Tables[0].Rows[0], "COM_Codigo");
                        cod++;
                        return cod;
                    }
                    else
                        return 1;
                }
                catch (ExcepcionGral exc)
                {
                    throw exc;
                }
            }

            public int sumarPuntaje(int dni)
            {
                SqlConnection conn = null;
                try
                {
                    try
                    {
                        conn = new SqlConnection(DBGeneral.StrConn);
                        conn.Open();
                    }
                    catch (SqlException e)
                    {
                        ExcepcionGral exc = new ExcepcionGral();
                        exc.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB -- " + e.Message, TipoError.ERRCONEXION);
                        throw exc;
                    }
                    string sql = "SELECT SUM(COM_Puntaje) as PuntajeTotal FROM Compra WHERE CLI_Dni = @Dni;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, dni));
                    object rta = ParaDB.EjecutarConsulta(sql, col, conn);
                    int puntaje;
                    if (Validaciones.EsVacio(rta))
                        puntaje = 0;
                    else
                        puntaje = Conversiones.AInt(rta);
                    conn.Close();
                    return puntaje;
                }
                catch (ExcepcionGral exc)
                {
                    this.Dispose();
                    throw exc;
                }
            }

        #endregion

        #region Destructores

        public void Dispose() { }

        #endregion
    }
}
