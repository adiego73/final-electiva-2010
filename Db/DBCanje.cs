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
        //poner todos los métodos aca
        #endregion
    }
}
