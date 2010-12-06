using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Excepciones;

namespace Library.Funciones
{
    public class Validaciones
    {
        #region comprobación de tipos

        #region es int

        public static bool EsInt(string s)
        {
            try
            {
                int.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EsInt(object o)
        {
            try
            {
                int.Parse(o.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region es fecha

        public static bool EsFecha(string s)
        {
            try
            {
                DateTime.Parse(s);
                return true;
            }
            catch
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("El valor no es una fecha válida");
                throw exc;
            }
        }

        public static bool EsFecha(object o)
        {
            try
            {
                DateTime.Parse(o.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region es double

        public static bool EsDouble(string s)
        {
            s.Replace(".", ",");
            try
            {
                double.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EsDouble(object o)
        {
            o.ToString().Replace(".", ",");
            try
            {
                double.Parse(o.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region es string

        public static bool EsString(object o)
        {
            try
            {
                o.ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EsString(DateTime f)
        {
            try
            {
                f.ToShortDateString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region es bool

        public static bool EsBool(object o)
        {
            try
            {
                bool.Parse(o.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EsBool(int n)
        {
            try
            {
                bool.Parse(n.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EsBool(string s)
        {
            try
            {
                bool.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        public static bool EsLong(string s)
        {
            try
            {
                long.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region son campos vacios

        public static bool EsVacio(DateTime fecha)
        {
            return (fecha.ToShortDateString().CompareTo(DateTime.MaxValue.ToShortDateString()) == 0);
        }

        public static bool EsVacio(long n)
        {
            return (n == long.MaxValue);
        }

        public static bool EsVacio(int n)
        {
            return (n == 0);
        }

        public static bool EsVacio(string s)
        {
            return (s == string.Empty || s == "");
        }

        public static bool EsVacio(object o)
        {
            return (o == null || o.ToString() == "");
        }

        #endregion

    }
}
