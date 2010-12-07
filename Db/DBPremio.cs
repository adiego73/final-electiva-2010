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
    public class DBPremio
    {
        #region Atributos
        
        private SqlConnection conn;

        #endregion

        #region Constructores

        public DBPremio()
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
                    string sql = @"insert into Premio (PRE_Codigo, PRE_Descripcion, PRE_CantPuntos, PRE_CantStock) ";
                           sql += "values (@Codigo, @Descripcion, @CantidadPuntos, @CantidadStock) select SCOPE_IDENTITY(); ";

                    Parametros col = new Parametros();

                    col.Add(Parametros.CargarParametro("@Codigo", TipoDato.Entero, arr[0]));
                    col.Add(Parametros.CargarParametro("@Descripcion", TipoDato.Cadena, arr[1]));
                    col.Add(Parametros.CargarParametro("@CantidadPuntos", TipoDato.Entero, arr[2]));
                    col.Add(Parametros.CargarParametro("@CantidadStock", TipoDato.Entero, arr[3]));

                    object id = ParaDB.EjecutarConsulta(sql, col, t, "Premio");
                    return Conversiones.AInt(id);
                }
                catch(ExcepcionGral exc)
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
                    string sql = "DELETE FROM Premio;";
                    ParaDB.EjecutarConsulta(sql, t);
                    t.Commit();
                }
                catch (ExcepcionGral exc)
                {
                    t.Rollback();
                    throw exc;
                }
            }

            public void modificar(ArrayList arr, Transaccion t)
            {
                try
                {
                    string sql = @"UPDATE Premio ";
                    sql += "SET PRE_Codigo = @Codigo, PRE_Descripcion = @Descripcion, PRE_CantidadPuntos = @CantidadPuntos, ";
                    sql += "PRE_CantidadStock = @CantidadStock WHERE PRE_Codigo = @Codigo;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Codigo", TipoDato.Entero, arr[0]));
                    col.Add(Parametros.CargarParametro("@Descripcion", TipoDato.Cadena, arr[1]));
                    col.Add(Parametros.CargarParametro("@CantidadPuntos", TipoDato.Entero, arr[2]));
                    col.Add(Parametros.CargarParametro("@CantidadStock", TipoDato.Entero, arr[3]));

                    ParaDB.EjecutarConsulta(sql, col, t);
                }
                catch(ExcepcionGral exc)
                {
                    this.Dispose();
                    throw exc;
                }
            }

        #endregion

        #region Consultas

            public DataSet listarTodos()
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
                    string sql = "SELECT * FROM Premio;";

                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, conn, out ds);
                    conn.Close();
                    return ds;
                }
                catch(ExcepcionGral exc)
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
                    string sql = "SELECT * FROM Premio p WHERE p.PRE_Codigo = @Codigo;";

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
                    string sql = "SELECT * FROM Premio WHERE PRE_Codigo = @Codigo;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, cod));

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
                    string sql = "SELECT TOP 1 PRE_Codigo FROM Premio ORDER BY PRE_Codigo DESC;";

                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, conn, out ds);

                    if (ds != null && ds.Tables[0].Rows.Count == 1)
                    {
                        int cod = RecuperarAtributo.Entero(ds.Tables[0].Rows[0], "PRE_Codigo");
                        cod= cod++;
                        return cod;
                    }
                    else
                        return 0;
                }
                catch(ExcepcionGral exc)
                {
                    throw exc;
                }
            }

        #endregion

        #region Destructores

        public void Dispose() { }

        #endregion

    }
}
