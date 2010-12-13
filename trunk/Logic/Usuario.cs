using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Logic
{
    public abstract class Usuario
    {
        #region Atributos

            protected string usuario;
            protected string contrasenia;

        #endregion

        #region Constructores

            public Usuario(string usr, string pass)
            {
                this.User = usr;
                this.Contrasenia = pass;
            }

            public Usuario() { }

        #endregion

        #region Propiedades

            public string User
            {
                get { return usuario; }
                set { usuario = value; }
            }

            public string Contrasenia
            {
                get { return contrasenia; }
                set { contrasenia = value; }
            }

            public virtual Cliente Cliente
            {
                get { return null; }
                set { }
            }

        #endregion

        #region Metodos

            public virtual ArrayList pasarAMR()
            {
                ArrayList arr = new ArrayList();
                arr.Add(this.User);
                arr.Add(this.Contrasenia);
                return arr;
            }

        #endregion
    }
}
