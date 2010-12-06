using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Library.Excepciones;
using Library.Funciones;

namespace Logic
{
    public abstract class Cliente
    {
        #region Atributos

            private int dni;
            private string nombre;
            private string apellido;
            private string telefono;
            private string direccion;
            private string ciudad;
            private string provincia;
            private string mail;

        #endregion

        #region Constructores
   
            public Cliente(int d, string nom, string ape, string tel, string dire, string ciu, string p, string m)
        {
            this.Dni = d;
            this.Nombre = nom;
            this.Apellido = ape;
            this.Telefono = tel;
            this.Direccion = dire;
            this.Ciudad = ciu;
            this.Provincia = p;
            this.Mail = m;
        }

            public Cliente()
        {
        }

        #endregion
        
        #region Propiedades

            public virtual int CantPuntos { get { return 0; } }

            public virtual int CantPesos { get { return 0; } }

            public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

            public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

            public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

            public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

            public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

            public string Ciudad
            {
                get { return ciudad; }
                set { ciudad = value; }
            }

            public string Provincia
            {
                get { return provincia; }
                set { provincia = value; }
            }

            public string Mail
            {
                get { return mail; }
                set { mail = value; }
            }

        #endregion

        #region Metodos

            public virtual ArrayList pasarAMR()
            {
                ArrayList arr = new ArrayList();
                arr.Add(this.Dni);
                arr.Add(this.Nombre);
                arr.Add(this.Apellido);
                arr.Add(this.Telefono);
                arr.Add(this.Direccion);
                arr.Add(this.Ciudad);
                arr.Add(this.Provincia);
                arr.Add(this.Mail);
                return arr;
            }

            public Cliente cambiarTipo(Cliente cli)
            {
                Cliente c;
                if (cli.CantPuntos == 1)
                    c = new CEspecial();
                else
                    c = new CComun();
                c.Dni = cli.Dni;
                c.Nombre = cli.Nombre;
                c.Apellido = cli.Apellido;
                c.Telefono = cli.Telefono;
                c.Direccion = cli.Direccion;
                c.Ciudad = cli.Ciudad;
                c.Provincia = cli.Provincia;
                c.Mail = cli.Mail;
                return c;
            }

            public int calcularPuntos(double total)
            {
                int puntos = Conversiones.AInt((total / this.CantPesos) * this.CantPuntos);
                return puntos;
            }

        #endregion
    }
}
