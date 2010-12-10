using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Canje
    {
        #region Atributos

            private int codigo;
            private Cliente cliente;
            private Premio premio;
            private DateTime fecha;

        #endregion

        #region Constructores

            public Canje(int cod, Cliente cli, Premio pre, DateTime fec)
        {
            this.Codigo = cod;
            this.Cliente = cli;
            this.Premio = pre;
            this.Fecha = fec;
        }

        #endregion

        #region Propiedades

            public int Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            public Cliente Cliente
            {
                get { return cliente; }
                set { cliente = value; }
            }

            public Premio Premio
            {
                get { return premio; }
                set { premio = value; }
            }

            public DateTime Fecha
            {
                get { return fecha; }
                set { fecha = value; }
            }

        #endregion

        #region Metodos
        //poner todos los métodos aqui
            public ArrayList pasarAMR()
            {
                ArrayList al = new ArrayList();
                al.Add(this.Codigo);
                al.Add(this.Cliente.Dni);
                al.Add(this.Premio.Codigo);
                al.Add(this.Fecha);

                return al;
            }
        #endregion

    }
}
