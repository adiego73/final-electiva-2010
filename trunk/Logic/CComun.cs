using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Logic
{
    public class CComun:Cliente
    {
        #region Constructores

            public CComun(int d, string nom, string ape, string tel, string dire, string ciu, string p, string m)
                : base(d, nom, ape, tel, dire, ciu, p, m) { }

            public CComun() : base() { }

        #endregion

        #region Propiedades

            public override int CantPuntos { get { return 1; } }

            public override int CantPesos { get { return 5; } }

        #endregion

        #region Metodos

            public override ArrayList pasarAMR()
            {
                ArrayList arr = base.pasarAMR();
                arr.Add("Comun");
                return arr;
            }

            //public override int calcularPuntos(double total)
            //{
            //    int puntos = 0;
            //    puntos = (int)((total / this.CantPesos) * this.CantPuntos);
            //    return puntos;
            //}

        #endregion
    }
}
