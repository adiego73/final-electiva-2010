using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Library.Excepciones;

namespace Db
{
    public class DBGeneral
    {
        //Tiene el string de conexion a usar por todas las DBClases

        #region Atributos

        private static string strconn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Supermercado.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        private SqlConnection conn;

        #endregion

        #region Constructores

        public DBGeneral()
        { }

        #endregion
        
        #region Propiedades

        public static string StrConn
        {
            get { return strconn; }
        }

        #endregion

        #region Metodos

        #endregion
    }
}
