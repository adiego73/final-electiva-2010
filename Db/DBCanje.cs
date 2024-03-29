﻿using System;
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

        #region ABM

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

                object id = ParaDB.EjecutarConsulta(sql, col, t, "Canje");
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
                string sql = "DELETE FROM Canje;";
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

        /**
             * @summary Este método determina qué Código de canje tendra el canje a crear.
             * @returns int id de la transaccion que luego va a ser el id del canje
            */
        private int calcularId(Transaccion t)
        {
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
                string sql = "SELECT * FROM Canje;";

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

        public DataSet listarTodos(int dni)
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
                string sql = "SELECT * FROM Canje WHERE CLI_Dni = '" + dni + "';";

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

        //Se obtienen todos los canjes realizados para un determinado premio
        public double traerCanjesPorPremio(int cod)
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

                string sql = "SELECT COUNT(*) FROM Canje WHERE PRE_Codigo = @Cod;";

                Parametros col = new Parametros();
                col.Add(Parametros.CargarParametro("@Cod", TipoDato.Entero, cod));
                object rta = ParaDB.EjecutarConsulta(sql, col, conn);
                double canjes;
                if (Validaciones.EsVacio(rta))
                    canjes = 0;
                else
                    canjes = Conversiones.ADouble(rta);
                conn.Close();
                return canjes;
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
