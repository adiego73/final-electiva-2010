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
    public class DBCompra
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
                string sql = @"insert into Compra (COM_Codigo, CLI_Dni, COM_Fecha, COM_Importe) ";
                sql += "values (@Codigo, @Dni, @Fecha, @Importe) select SCOPE_IDENTITY(); ";

                Parametros col = new Parametros();

                col.Add(Parametros.CargarParametro("@Codigo", TipoDato.Entero, arr[0]));
                col.Add(Parametros.CargarParametro("@Dni", TipoDato.Entero, arr[1]));
                col.Add(Parametros.CargarParametro("@Fecha", TipoDato.Fecha, arr[2]));
                col.Add(Parametros.CargarParametro("@Importe", TipoDato.Decimal, arr[3]));

                object id = ParaDB.EjecutarConsulta(sql, col, t, "Compra");
                return Conversiones.AInt(id);
            }
            catch (ExcepcionGral exc)
            {
                this.Dispose();
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

        #endregion

        #region Destructores

        public void Dispose() { }

        #endregion
    }
}
