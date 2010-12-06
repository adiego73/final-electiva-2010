using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Excepciones;

namespace Library.Funciones
{
    public class Conversiones
    {
        #region conversion de tipos

        #region a fecha

        public static DateTime AFecha(string f)
        {
            if (Validaciones.EsFecha(f))
                return DateTime.Parse(f);
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a fecha");
                throw exc;
            }
        }

        public static DateTime AFecha(object o)
        {
            if (Validaciones.EsFecha(o))
                return Conversiones.AFecha(o.ToString());
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a fecha");
                throw exc;
            }
        }

        #endregion

        #region a int

        public static int AInt(string s)
        {

            if (Validaciones.EsInt(s))
              return  int.Parse(s);
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a número entero");
                throw exc;
            }
        }

        public static int AInt(object o)
        {
            if (Validaciones.EsInt(o))
                return Conversiones.AInt(Conversiones.AString(o));
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a número entero");
                throw exc;
            }
        }

        public static int AInt(double d)
        {
            d = Conversiones.ADouble(Conversiones.AString(d));
            string nro = Conversiones.AString(d);
            string[] n = nro.Split(',');
            return Conversiones.AInt(n[0]);
        }

        #endregion

        #region a double

        public static double ADouble(string s)
        {
            if (Validaciones.EsDouble(s))
                return double.Parse(s);
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a decimal");
                throw exc;
            }
        }

        public static double ADouble(object o)
        {
            if (Validaciones.EsDouble(o))
                return Conversiones.ADouble(Conversiones.AString(o));
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a decimal");
                throw exc;
            }
        }

        #endregion

        #region a string

        public static string AString(object o)
        {
            if (Validaciones.EsString(o))
                return o.ToString();
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a candena de texto");
                throw exc;
            }
        }

        public static string AString(DateTime f)
        {
            if (Validaciones.EsString(f))
                return f.ToShortDateString();
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a candena de texto");
                throw exc;
            }
        }

        public static string AString(double d)
        {
            return d.ToString();
        }

        #endregion
        
        #region a bool

        public static bool ABool(int n)
        {
            if (Validaciones.EsBool(n))
                return bool.Parse(n.ToString());
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a bool");
                throw exc;
            }
        }

        public static bool ABool(string s)
        {
            if (Validaciones.EsBool(s))
                return bool.Parse(s);
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a bool");
                throw exc;
            }
        }

        public static bool ABool(object o)
        {
            if (Validaciones.EsBool(o))
                return bool.Parse(Conversiones.AString(o));
            else
            {
                ExcepcionGral exc = new ExcepcionGral();
                exc.AgregarError("No se pudo convertir el valor a bool");
                throw exc;
            }
        }

        #endregion

        #endregion

        #region vaciar campos

        public static String VaciarTexto()
        {
            return "";
        }

        public static int VaciarEntero()
        {
            return 0;
        }

        public static DateTime VaciarFecha()
        {
            return DateTime.MaxValue;
        }

        public static double VaciarDecimal()
        {
            return 0;
        }

        #endregion
    }
}