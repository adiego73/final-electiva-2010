using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Library.Excepciones
{
    public class ExcepcionGral : Exception
    {
        /*
         * AVN - 11/11/10
         * Contiene todo el manejo de excepciones generadas 
         * por la lógica de negocios del sistema
         */
        #region atributos

            List<EntidadError> errores = new List<EntidadError>();

        #endregion
        
        #region constructores

            public ExcepcionGral() : base() { }

        #endregion

        #region propiedades

            public bool TieneErrores
            {
                get { return errores.Count > 0; }
            }

            public List<EntidadError> Errores
            {
                /*
                 * Devuelve todos los errores
                 */
                get { return errores; }
            }

            public List<EntidadError> ErroresSinLugar
            {
                /*
                 * Devuelve los errores que NO tengan un label asociado donde mostrarse
                 */
                get
                {
                    List<EntidadError> lista = new List<EntidadError>();
                    foreach (EntidadError e in errores)
                    {
                        if (e.MsgLB == "")
                            lista.Add(e);
                    }
                    return lista;
                }
            }

            public List<EntidadError> ErroresConLugar
            {
                /*
                 * Devuelve los errores que TENGAN un label asociado en el que mostrarse
                 */
                get
                {
                    List<EntidadError> lista = new List<EntidadError>();
                    foreach (EntidadError e in errores)
                    {
                        if (e.MsgLB != "")
                            lista.Add(e);
                    }
                    return lista;
                }
            }

            public override string Message
            {
                get { return this.ToString(); }
            }

        #endregion

        #region metodos

            public override string ToString()
            {
                string newLine = System.Environment.NewLine;
                string stringErrores = "";
                bool hay = false;
                foreach (EntidadError err in errores)
                {
                   if (!hay)
                    {
                        stringErrores = err.Mensaje;
                        hay = true;
                    }
                    else

                        stringErrores += " / " + err.Mensaje;
                }
                return stringErrores;
            }
            
            public void AgregarError(string msg)
            {
                EntidadError err = new EntidadError();
                err.Mensaje = msg;
                errores.Add(err);
            }

            public void AgregarError(string msg, string obj)
            {
                /*
                * AVN - 12/11/10
                * Genera el error recibiendo aparte del 
                * mensaje el objeto donde debe mostrarse
                */
                EntidadError err = new EntidadError();
                err.Mensaje = msg;
                err.MsgLB = obj;
                errores.Add(err);
            }

            public void AgregarErrorDB(string msg, string tipo)
            {
                /*
                * AVN - 12/11/10
                * Genera el error recibiendo aparte del 
                * mensaje el tipo de error que se generó
                */
                EntidadError err = new EntidadError();
                err.Mensaje = msg;
                err.Icono = tipo;
                errores.Add(err);
            }

            public void AgregarError(string msg, string obj, string icono, string lugarIcono)
            {
                /*
                 * AVN - 12/11/10
                 * Genera el error recibiendo aparte del mensaje el objeto
                 * donde debe mostrarse y el ícono que lo representa
                 */
                EntidadError err = new EntidadError();
                err.Mensaje = msg;
                err.MsgLB = obj;
                err.Icono = icono;
                err.IconoPB = lugarIcono;
                errores.Add(err);
            }

            public void AgregarError(EntidadError err)
            {
                errores.Add(err);
            }

        #endregion
    }
}
