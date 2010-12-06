using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Logic
{
    public class UPrivilegiado: Usuario
    {
        #region Constructores

            public UPrivilegiado(string usr, string pass)
                : base(usr, pass) { }

            public UPrivilegiado() { }

        #endregion

        #region Metodos

            public override ArrayList pasarAMR()
            {
                ArrayList arr = base.pasarAMR();
                arr.Add("");
                return arr;
            }

        #endregion
    }
}
