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
    public class DBUsuario : IDisposable, IDBConsultas
    {
        #region Constructores

        public DBUsuario() { }

        #endregion

        #region ABM

            public int agregar(ArrayList arr, Transaccion t)
            {
                try
                {
                    int cod = this.calcularId(t);
                    string sql = @"insert into Usuario (USU_Codigo,USU_Usuario, USU_Contrasenia, CLI_Dni) ";
                    sql += "values (@Codigo, @Usuario, @Contrasenia, @Dni) select SCOPE_IDENTITY() ";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Codigo", TipoDato.Entero, cod));
                    if (!Validaciones.EsVacio(arr[0]))
                        col.Add(Parametros.CargarParametro("@Usuario", TipoDato.Cadena, arr[0]));
                    else
                        col.Add(Parametros.CargarParametro("@Usuario", TipoDato.Cadena, DBNull.Value));

                    if (!Validaciones.EsVacio(arr[1]))
                        col.Add(Parametros.CargarParametro("@Contrasenia", TipoDato.Cadena, arr[1]));
                    else
                        col.Add(Parametros.CargarParametro("@Contrasenia", TipoDato.Cadena, DBNull.Value));

                    if (!Validaciones.EsVacio(arr[2]))
                        col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, arr[2]));
                    else
                        col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, DBNull.Value));

                    object id = ParaDB.EjecutarConsulta(sql, col, t, "Usuario");

                    if (Validaciones.EsInt(id))
                        return Conversiones.AInt(id);
                    else
                        return 0;
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
                    string sql = "DELETE FROM Usuario;";
                    ParaDB.EjecutarConsulta(sql, t);
                    t.Commit();
                }
                catch (ExcepcionGral exc)
                {
                    t.Rollback();
                    throw exc;
                }
            }

            public void eliminar(int dni)
            {
                Transaccion t = new Transaccion();
                try
                {
                    t.Begin();
                    string sql = "DELETE FROM Usuario WHERE CLI_Dni = @Dni;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, dni));

                    ParaDB.EjecutarConsulta(sql, col, t);
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
                    string sql = @"UPDATE Usuario ";
                    sql += "SET USU_Usuario = @Usuario, USU_Contrasenia = @Contrasenia ";
                    sql += "WHERE CLI_Dni = @Dni;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Usuario", TipoDato.Cadena, arr[0]));
                    col.Add(Parametros.CargarParametro("@Contrasenia", TipoDato.Cadena, arr[1]));
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, arr[2]));

                    ParaDB.EjecutarConsulta(sql, col, t);
                }
                catch (ExcepcionGral exc)
                {
                    this.Dispose();
                    throw exc;
                }
            }

        #endregion

        #region Consultas

            private int calcularId(Transaccion t)
            {
                /*
                 * Este método determina qué Código de Usuario tendrá el usuario a crear.
                 */
                try
                {
                    string sql = "SELECT TOP 1 USU_Codigo FROM Usuario ORDER BY USU_Codigo DESC;";

                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, t, out ds);

                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        int cod = RecuperarAtributo.Entero(ds.Tables[0].Rows[0], "USU_Codigo");
                        cod++;
                        return cod;
                    }
                    else
                    {
                        return 1;
                    }
                }
                catch(ExcepcionGral e)
                {
                    throw e;
                }

            }

            public DataSet listarPrivilegiados()
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
                        exc.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB: DBUsuario.listarPrivilegiados() -- " + e.Message, TipoError.ERRCONEXION);
                        throw exc;
                    }
                    string sql = "SELECT * FROM Usuario WHERE CLI_Dni IS NULL;";

                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, conn, out ds);
                    conn.Close();
                    return ds; 
                }
                catch (ExcepcionGral e)
                {
                    if(conn.State == ConnectionState.Open)
                        conn.Close();
                    throw e;
                }
            }

            public DataSet listar()
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
                        exc.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB: DBUsuario.listarPrivilegiados() -- " + e.Message, TipoError.ERRCONEXION);
                        throw exc;
                    }
                    string sql = "SELECT * FROM Usuario WHERE CLI_Dni IS NOT NULL;";

                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, conn, out ds);
                    conn.Close();
                    return ds;
                }
                catch (ExcepcionGral e)
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    throw e;
                }
            }

            public int recuperarIdUsuario(string usuario)
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(DBGeneral.StrConn);
                    conn.Open();
                }
                catch (SqlException e)
                {
                    ExcepcionGral ex = new ExcepcionGral();
                    ex.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB: DBUsuario.listarPrivilegiados() -- " + e.Message, TipoError.ERRCONEXION);
                    throw ex;
                }
                try
                {
                    string sql = "SELECT USU_Codigo FROM Usuario where USU_Usuario = @Usuario;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Usuario", TipoDato.Cadena, usuario));

                    object id = ParaDB.EjecutarConsulta(sql, col, conn);
                    if (Validaciones.EsInt(id))
                        return Conversiones.AInt(id);
                    else
                        return 0;
                }
                catch(ExcepcionGral exc)
                {
                    throw exc;
                }

            }

            public int recuperarIdUsuario(int dni)
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(DBGeneral.StrConn);
                    conn.Open();
                }
                catch (SqlException e)
                {
                    ExcepcionGral ex = new ExcepcionGral();
                    ex.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB: DBUsuario.listarPrivilegiados() -- " + e.Message, TipoError.ERRCONEXION);
                    throw ex;
                }
                try
                {
                    string sql = "SELECT USU_Codigo FROM Usuario where CLI_Dni = @dni;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@dni", TipoDato.Entero, dni));

                    object id = ParaDB.EjecutarConsulta(sql, col, conn);
                    if (Validaciones.EsInt(id))
                        return Conversiones.AInt(id);
                    else
                        return 0;
                }
                catch (ExcepcionGral exc)
                {
                    throw exc;
                }

            }

            public DataSet traer(int dni, int id)
            {
                /*
                 * Este método recupera un cliente en particular.
                 */
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(DBGeneral.StrConn);
                    conn.Open();
                    string sql = "SELECT * FROM Usuario WHERE CLI_Dni = @Dni AND USU_Codigo = @Id;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, dni));
                    col.Add(Parametros.CargarParametro("@Id", TipoDato.Entero, id)); 
                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, col, conn, out ds);
                    conn.Close();
                    return ds;
                }
                catch (SqlException e)
                {
                    ExcepcionGral exc = new ExcepcionGral();
                    exc.AgregarError("ERROR AL EJECUTAR LA CONSULTA: " + e.Message, TipoError.ERRCONSULTA);
                    this.Dispose();
                    throw exc;
                }
                catch (ExcepcionGral exc)
                {
                    this.Dispose();
                    throw exc;
                }
            }

            public DataSet traer(string usuario, string contrasenia)
            {
                /*
                 * Este método recupera un cliente en particular.
                 */
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(DBGeneral.StrConn);
                    conn.Open();
                    string sql = "SELECT * FROM Usuario WHERE USU_Usuario = @Usuario AND USU_Contrasenia = @Contrasenia;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Usuario", TipoDato.Cadena, usuario));
                    col.Add(Parametros.CargarParametro("@Contrasenia", TipoDato.Cadena, contrasenia));
                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, col, conn, out ds);
                    conn.Close();
                    return ds;
                }
                catch (SqlException e)
                {
                    ExcepcionGral exc = new ExcepcionGral();
                    exc.AgregarError("ERROR AL EJECUTAR LA CONSULTA: " + e.Message, TipoError.ERRCONSULTA);
                    this.Dispose();
                    throw exc;
                }
                catch (ExcepcionGral exc)
                {
                    this.Dispose();
                    throw exc;
                }
            }

            public bool existe(string usuario)
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(DBGeneral.StrConn);
                    conn.Open();
                }
                catch (SqlException e)
                {
                    ExcepcionGral ex = new ExcepcionGral();
                    ex.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB: DBUsuario.listarPrivilegiados() -- " + e.Message, TipoError.ERRCONEXION);
                    throw ex;
                }

                try
                {
                    string sql = "SELECT USU_Codigo FROM Usuario where USU_Usuario = @Usuario;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Usuario", TipoDato.Cadena, usuario));

                    object id = ParaDB.EjecutarConsulta(sql, col, conn);
                    if (Validaciones.EsInt(id) && Conversiones.AInt(id) > 0)
                        return true;
                    else
                        return false;
                }
                catch (ExcepcionGral exc)
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
