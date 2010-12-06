using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Library.Excepciones;
using System.Collections;
using System.Data;

namespace Library.ParaDB
{
    public class Parametros : CollectionBase
    {
        public Parametros()
        {
        }
        
        public Parametros(params IDbDataParameter [] parametros)
		{
			foreach(IDbDataParameter param in parametros)
			{
                List.Add(param);
			}
		}

        public void Add(IDbDataParameter param)
        //public IDbDataParameter Add(IDbDataParameter param)
        {
            List.Add(param);
            //return param;
        }

        public static SqlParameter CargarParametro(string nombre, TipoDato dbType, object valor)
        {
            SqlParameter param;
            SqlDbType tipo = SqlDbType.VarChar;

            switch (dbType)
            {
                case TipoDato.Bool:
                    tipo = SqlDbType.Bit;
                    break;
                case TipoDato.Binario:
                    tipo = SqlDbType.Binary;
                    break;
                case TipoDato.Cadena:
                    tipo = SqlDbType.VarChar;
                    break;
                case TipoDato.Entero:
                    tipo = SqlDbType.Int;
                    break;
                case TipoDato.Fecha:
                    tipo = SqlDbType.DateTime;
                    break;
                case TipoDato.Decimal:
                    tipo = SqlDbType.Float;
                    break;
                case TipoDato.Id:
                    tipo = SqlDbType.UniqueIdentifier;
                    break;
            }
            param = new SqlParameter(nombre, tipo);
            param.Value = valor;
            return param;
        }
    }
}
