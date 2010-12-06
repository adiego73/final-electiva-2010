using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Logic
{
    public class UComun:Usuario
    {
        #region Atributos

            private Cliente cliente;

        #endregion

        #region Constructores

            public UComun(string usr, string pass, Cliente cli)
                : base(usr, pass)
            {
                this.Cliente = cli;
            }

            public UComun() { }

        #endregion

        #region Propiedades

            public override Cliente Cliente
            {
                get { return cliente; }
                set { cliente = value; }
            }

        #endregion

        #region Metodos

            public override ArrayList pasarAMR()
            {
                ArrayList arr = base.pasarAMR();
                arr.Add(this.Cliente.Dni);
                return arr;
            }

        #endregion
    }
}