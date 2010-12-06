using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Logic
{
    public class Premio
    {
        #region Atributos

            private int codigo;
            private string descripcion;
            private int cantidadPuntos;
            private int cantidadStock;

        #endregion

        #region Constructores

            public Premio(int cod, string desc, int puntos, int stock)
            {
                this.Codigo = cod;
                this.Descripcion = desc;
                this.CantPuntos = puntos;
                this.CantStock = stock;
            }

            public Premio(string desc, int puntos, int stock)
            {
                this.Descripcion = desc;
                this.CantPuntos = puntos;
                this.CantStock = stock;
            }
            
            public Premio() { }

        #endregion

        #region Propiedades

            public int Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            public string Descripcion
            {
                get { return descripcion; }
                set { descripcion = value; }
            }

            public int CantPuntos
            {
                get { return cantidadPuntos; }
                set { cantidadPuntos = value; }
            }

            public int CantStock
            {
                get { return cantidadStock; }
                set { cantidadStock = value; }
            }

        #endregion

        #region Metodos

            public ArrayList pasarAMR()
            {
                ArrayList arr = new ArrayList();
                arr.Add(this.Descripcion);
                arr.Add(this.CantPuntos);
                arr.Add(this.CantStock);
                return arr;
            }

        #endregion

    }
}
