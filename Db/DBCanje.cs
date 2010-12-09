using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using Library.Excepciones;
using Library.ParaDB;
using Library.Funciones;

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
        #endregion

        #region Destructores

            public void Dispose() { }

        #endregion
    }
}
