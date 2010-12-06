using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Compra
    {
        #region Atributos

            private int codigo;
            private Cliente cliente;
            private DateTime fecha;
            private double importe;

        #endregion

        #region Constructores

            public Compra(int cod, Cliente cli, DateTime fec, double imp)
            {
                this.Codigo = cod;
                this.Cliente = cli;
                this.Fecha = fec;
                this.Importe = imp;
            }

            public Compra() { }

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

            public DateTime Fecha
            {
                get { return fecha; }
                set { fecha = value; }
            }

            public double Importe
            {
                get { return importe; }
                set { importe = value; }
            }

        #endregion

        #region Metodos
            public ArrayList pasarAMR()
            {
                ArrayList arr = new ArrayList();
                arr.Add(this.Codigo);
                arr.Add(this.Cliente.Dni);
                arr.Add(this.Fecha);
                arr.Add(this.Importe);
                return arr;
            }

        #endregion
    }
}
