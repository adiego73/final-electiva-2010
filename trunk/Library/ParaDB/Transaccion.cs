using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Library.Excepciones;

namespace Library.ParaDB
{
    public class Transaccion : IDbTransaction
    {
        #region Atributos

            private IDbTransaction transaccion;
            private static string strconn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Supermercado.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            private SqlConnection conn;

        #endregion

        #region Constructores

            public Transaccion()
            {
                if (conn == null)
                    conn = new SqlConnection(Transaccion.StrConn);
            }

        #endregion

        #region Propiedades

            public static string StrConn
            {
                get { return strconn; }
            }

            public IDbTransaction Transaction
            {
                get { return transaccion; }
                set { transaccion = value; }
            }

            public IDbConnection Connection
            {
                get { return conn; } 
            }

            public SqlConnection Conn
            {
                get { return (SqlConnection)this.Connection; }
            }

            public IsolationLevel IsolationLevel 
            {
                get { return IsolationLevel.RepeatableRead; }
            }

        #endregion

        #region Metodos

            public void Commit()
            {
                if(this.Transaction != null)
                    this.Transaction.Commit();
                this.Transaction = null;
            }

            public void Rollback()
            {
                if(this.Transaction != null)
                    this.Transaction.Rollback();
            }

            public void Begin()
            {
                ExcepcionGral exc = new ExcepcionGral();
                if (this.Transaction != null)
                {
                    exc.AgregarError("Ya hay una transaccion abierta", TipoError.ERRCONEXION);
                    throw exc;
                }
                else
                {
                    try
                    {
                        this.Connection.Open();
                        this.Transaction = this.Connection.BeginTransaction();
                    }
                    catch (SqlException e)
                    {
                        exc.AgregarError(e.Message, TipoError.ERRCONEXION);
                        throw exc;
                    }
                    catch (ExcepcionGral e)
                    {
                        exc.AgregarError(e.Message, TipoError.ERRCONEXION);
                        throw exc;
                    }
                }
            }

        #endregion

        #region Destructores

        public void Dispose()
        {
            this.Connection.Close();
            this.Dispose();
        }

        #endregion
    }
}
