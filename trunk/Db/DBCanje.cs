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
    public class DBCanje
    {
        #region Atributos
        
        private SqlConnection conn;

        #endregion

        #region Constructores

        public DBCanje()
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

        #region Metodos
            private int calcularId(Transaccion t)
            {
                /*
                 * Este método determina qué Código de canje tendra el canje a crear.
                 */
                try
                {
                    string sql = "SELECT TOP 1 CAN_Codigo FROM Canje ORDER BY CAN_Codigo DESC;";

                    DataSet ds;
                    ParaDB.EjecutarConsulta(sql, t, out ds);

                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        int cod = RecuperarAtributo.Entero(ds.Tables[0].Rows[0], "CAN_Codigo");
                        cod++;
                        return cod;
                    }
                    else
                    {
                        return 1;
                    }
                }
                catch (ExcepcionGral e)
                {
                    throw e;
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
                    string sql = "SELECT SUM(PRE_CantPuntos) as PuntajeTotal FROM Premio p INNER JOIN Canje c ON p.PRE_Codigo = c.PRE_Codigo WHERE c.CLI_Dni = @Dni;";

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
            
            public void agregar(ArrayList arr, Transaccion t)
            {
                try
                {
                    int cod = this.calcularId(t);

                    string sql = @"INSERT INTO Canje (CAN_Codigo, CLI_Dni, PRE_Codigo, CAN_Fecha) ";
                    sql += "VALUES (@cCodigo, @Dni, @pCodigo, @Fecha) select SCOPE_IDENTITY() ";

                    Parametros col = new Parametros();

                    col.Add(Parametros.CargarParametro("@cCodigo", TipoDato.Entero, cod));
                    col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, arr[1]));
                    col.Add(Parametros.CargarParametro("@pCodigo", TipoDato.Entero, arr[2]));
                    col.Add(Parametros.CargarParametro("@Fecha", TipoDato.Fecha, arr[3]));

                    object id = ParaDB.EjecutarConsulta(sql, col, t, "Compra");
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
