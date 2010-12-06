using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Library.Excepciones;

namespace Library.Funciones
{
    public class RecuperarAtributo
    {
        public static string Cadena(DataRow fila, string nombreCampo)
        {
            if(Validaciones.EsVacio(fila[nombreCampo]))
                return "";
            else
                return Conversiones.AString(fila[nombreCampo]);
        }

        public static DateTime Fecha(DataRow fila, string nombreCampo)
        {
            if (Validaciones.EsVacio(fila[nombreCampo]))
                return Conversiones.VaciarFecha();
            else
                return Conversiones.AFecha(fila[nombreCampo]);
        }

        public static int Entero(DataRow fila, string nombreCampo)
        {
            if (Validaciones.EsVacio(fila[nombreCampo]))
                return 0;
            else
                return Conversiones.AInt(fila[nombreCampo]);
        }

        public static double Decimal(DataRow fila, string nombreCampo)
        {
            if(Validaciones.EsVacio(fila[nombreCampo]))
                return 0;
            else
                return Conversiones.ADouble(fila[nombreCampo]);
        }

        public static bool Booleano(DataRow fila, string nombreCampo)
        {
            if (Validaciones.EsVacio(fila[nombreCampo]))
                return false;
            else
                return Conversiones.ABool(fila[nombreCampo]);
        }
    }
}
