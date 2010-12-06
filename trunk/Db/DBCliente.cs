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
    public class DBCliente : IDisposable, IDBConsultas
    {
        #region Atributos
            
            private SqlConnection conn;

        #endregion

        #region Constructores

            public DBCliente() { }

        #endregion

        #region Propiedades

        #endregion

        #region ABM

            public int agregar(ArrayList arr, Transaccion t)
            {
                try
                {
                     string sql = @"insert into Cliente (CLI_Dni, CLI_Nombre, CLI_Apellido, CLI_Telefono, CLI_Direccion, CLI_Ciudad, CLI_Provincia, CLI_Mail, CLI_Tipo) ";
                            sql += "values (@Dni, @Nombre, @Apellido, @Telefono, @Direccion, @Ciudad, ";
                            sql += "@Provincia, @Mail, @Tipo) select SCOPE_IDENTITY() ";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Dni",TipoDato.Entero, arr[0]));
                    col.Add(Parametros.CargarParametro("@Nombre",TipoDato.Cadena, arr[1]));
                    col.Add(Parametros.CargarParametro("@Apellido", TipoDato.Cadena, arr[2]));
                    col.Add(Parametros.CargarParametro("@Telefono", TipoDato.Cadena, arr[3]));
                    col.Add(Parametros.CargarParametro("@Direccion", TipoDato.Cadena, arr[4]));
                    col.Add(Parametros.CargarParametro("@Ciudad", TipoDato.Cadena, arr[5]));
                    col.Add(Parametros.CargarParametro("@Provincia", TipoDato.Cadena, arr[6]));
                    col.Add(Parametros.CargarParametro("@Mail", TipoDato.Cadena, arr[7]));
                    col.Add(Parametros.CargarParametro("@Tipo", TipoDato.Cadena, arr[8]));

                    object id = ParaDB.EjecutarConsulta(sql, col, t, "Cliente");
                    if(Validaciones.EsInt(id))
                       return Conversiones.AInt(id);
                    else
                        return 0;
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
                    string sql = "DELETE FROM Cliente;";
                    ParaDB.EjecutarConsulta(sql, t);
                    t.Commit();
                }
                catch(ExcepcionGral exc)
                {
                    t.Rollback();
                    throw exc;
                }
            }

            public void modificar(ArrayList arr, Transaccion t)
            {
                try
                {
                    string sql = @"UPDATE Cliente ";
                           sql += "SET CLI_Nombre = @Nombre, CLI_Apellido = @Apellido, CLI_Telefono = @Telefono, ";
                           sql += "CLI_Direccion = @Direccion, CLI_Ciudad = @Ciudad, CLI_Provincia = @Provincia, ";
                           sql += "CLI_Mail = @Mail, CLI_Tipo = @Tipo WHERE CLI_Dni = @Dni;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, arr[0]));
                    col.Add(Parametros.CargarParametro("@Nombre", TipoDato.Cadena, arr[1]));
                    col.Add(Parametros.CargarParametro("@Apellido", TipoDato.Cadena, arr[2]));
                    col.Add(Parametros.CargarParametro("@Telefono", TipoDato.Cadena, arr[3]));
                    col.Add(Parametros.CargarParametro("@Direccion", TipoDato.Cadena, arr[4]));
                    col.Add(Parametros.CargarParametro("@Ciudad", TipoDato.Cadena, arr[5]));
                    col.Add(Parametros.CargarParametro("@Provincia", TipoDato.Cadena, arr[6]));
                    col.Add(Parametros.CargarParametro("@Mail", TipoDato.Cadena, arr[7]));
                    col.Add(Parametros.CargarParametro("@Tipo", TipoDato.Cadena, arr[8]));

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
                        exc.AgregarError("SE PRODUJO UN ERROR AL INTENTAR CONECTAR CON LA DB: DBUsuario.listarPrivilegiados() -- " + e.Message, TipoError.ERRCONEXION);
                        throw exc;
                    }
                    string sql = "SELECT * FROM Cliente c inner join Usuario u on c.CLI_Dni = u.CLI_Dni;";

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

            public bool existeActivo(int dni)
            {
                /*
                 * Este método determina si el cliente existe como CLIENTE ACTIVO 
                 * un cliente es ACTIVO si existe su correspondiente USUARIO en la tabla Usuario.
                 * Las bajas solo se hacen sobre los usuarios por lo tanto la existencia de un cliente como
                 * ACTIVO o INACTIVO está determinada sobre la tabla Usuario.
                 */
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
                    string sql = "SELECT * FROM Cliente c INNER JOIN Usuario u ON c.CLI_Dni = u.CLI_Dni WHERE c.CLI_Dni = @Dni;";
                    
                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, dni));

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
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    this.Dispose();
                    throw exc;
                }
            }

            public bool existe(int dni)
            {
                /*
                 * Este metodo se utiliza al tratar de generar un nuevo cliente.
                 * Cuando se da de baja a un cliente, en realidad el cliente sigue existiendo 
                 * y lo que se da de baja es el usuario que le corresponde a ese cliente.
                 * Si se quiere generar un nuevo cliente se verifica su existencia como CLIENTE ACTIVO (con usuario)
                 * si no hay un usuario para el cliente se lo puede dar de alta.
                 * pero puede suceder que ese cliente SI exista en la tabla Cliente porque alguna vez estuvo como
                 * usuario ACTIVO.
                 * Este método determina si el cliente que se está tratando de dar de alta existe o no en la tabla
                 * Cliente para saber si hay que agregarlo como nuevo o modificarlo.
                 */
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
                    string sql = "SELECT * FROM Cliente c WHERE c.CLI_Dni = @Dni;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, dni));

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

            public DataSet traer(int dni)
            {
                /*
                 * Este método recupera un cliente en particular.
                 */
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(DBGeneral.StrConn);
                    conn.Open();
                    string sql = "SELECT * FROM Cliente WHERE CLI_Dni = @Dni;";

                    Parametros col = new Parametros();
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, dni));

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

        #endregion
     
        #region Destructores
            
            public void Dispose() { }
        
        #endregion
    }
}
