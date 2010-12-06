using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Library.Funciones;

namespace Logic
{
    public class CEspecial:Cliente
    {

        #region Constructores

            public CEspecial(int d, string nom, string ape, string tel, string dire, string ciu, string p, string m)
                : base(d, nom, ape, tel, dire, ciu, p, m){ }

            public CEspecial() : base() { }

        #endregion

        #region Propiedades

            public override int CantPuntos { get { return 3; } }

            public override int CantPesos { get { return 5; } }

        #endregion

        #region Metodos

            public override ArrayList pasarAMR()
            {
                ArrayList arr = base.pasarAMR();
                arr.Add("Especial");
                return arr;
            }

            //public override int calcularPuntos(double total)
            //{
            //    int puntos = Conversiones.AInt((total / this.CantPesos) * this.CantPuntos));
            //    return puntos;
            //}

        #endregion
    }
}
