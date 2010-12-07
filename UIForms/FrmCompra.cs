using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic;
using Library.Funciones;
using Library.Excepciones;

namespace UIForms
{
    public partial class FrmCompra : Form
    {
        #region Atributos

            private Compra compra;
            private Cliente cliente;

        #endregion

        #region Constructores
            public FrmCompra()
            {
                InitializeComponent();
                compra = null;
            }

        #endregion

        #region Propiedades

        public Cliente Cliente
        {
            get { return cliente; }
            set
            {
                cliente = value;
                if (cliente != null)
                this.mostrar();
            }
        }

        #endregion

        #region Metodos

            private void mostrar()
            {
                clienteTX.Text = cliente.Nombre + " " + cliente.Apellido;
                clienteTX.Enabled = false;
            }

        #endregion

        #region Eventos

            private void FrmCompra_Load(object sender, EventArgs e)
            {
                try
                {
                    codigoLB1.Text = "Codigo del compra: ";
                    codigoLB2.Text = Conversiones.AString(ASupermercado.calcularIdCompra());
                }
                catch (ExcepcionGral exc)
                { MessageBox.Show(exc.Message); }
                clienteTX.Enabled = false;
            }

            private void bGuardar_Click(object sender, EventArgs e)
            {
                errFechaLB.Visible = errImporteLB.Visible = false;
                bool existe = false;
                ExcepcionGral exc = new ExcepcionGral();

                try
                {
                    if (Validaciones.EsVacio(dtFecha.Text))
                    {
                        exc.AgregarError("La Fecha no puede quedar en blanco");
                        errFechaLB.Visible = true;
                    }
                    else
                    {
                        if (!Validaciones.EsFecha(dtFecha.Text))
                        {
                            exc.AgregarError("La Fecha debe estar en formato fecha.");
                            errFechaLB.Visible = true;
                        }
                        else if (DateTime.Compare(DateTime.Now, DateTime.Parse(dtFecha.Text)) < 0)
                        {
                            exc.AgregarError("La Fecha ingresada debe ser menor o igual a la fecha actual.");
                            errFechaLB.Visible = true;
                        }
                    }

                    if (Validaciones.EsVacio(importeTX.Text))
                    {
                        exc.AgregarError("El Importe no puede quedar en blanco");
                        errImporteLB.Visible = true;
                    }
                    else if (!Validaciones.EsDouble(importeTX.Text))
                    {
                        exc.AgregarError("El Importe debe ser numérico.");
                        errImporteLB.Visible = true;
                    }

                    if (exc.TieneErrores)
                        throw exc;

                    compra = new Compra(Conversiones.AInt(codigoLB2.Text), cliente, Conversiones.AFecha(dtFecha.Text), Conversiones.ADouble(importeTX.Text));
                    try
                    {
                        int i = ASupermercado.agregar(compra);

                        MessageBox.Show("La compra se ha guardado con éxito ");
                        int puntos = ASupermercado.calcularPuntos(cliente);
                        MessageBox.Show("Puntaje alcanzado al día de la fecha: " + Conversiones.AString(puntos));

                        this.Close();
                    }
                    catch (ExcepcionGral ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (ExcepcionGral)
                {
                    MessageBox.Show(exc.Message);
                }
            }

            private void bCancelar_Click(object sender, EventArgs e)
            {
                compra = null;
                this.Close();
            }

        #endregion


        
    }
}
