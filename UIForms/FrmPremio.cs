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
    public partial class FrmPremio : Form
    {
        #region Atributos

            private Premio premio;

        #endregion

        #region Constructores
        public FrmPremio()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        private void FrmPremio_Load(object sender, EventArgs e)
        {
            try
            {
                codigoLB1.Text = "Codigo del premio: ";
                codigoLB2.Text = Conversiones.AString(ASupermercado.calcularIdPremio());
            }
            catch (ExcepcionGral exc)
            { MessageBox.Show(exc.Message); }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            errDescripcionLB.Visible = errCantidadPuntosLB.Visible = errCantidadStockLB.Visible = false;

            ExcepcionGral exc = new ExcepcionGral();

            try
            {
                if (Validaciones.EsVacio(descripcionTX.Text))
                {
                    exc.AgregarError("La descripción no puede quedar en blanco");
                    errDescripcionLB.Visible = true;
                }

                if (Validaciones.EsVacio(cantidadPuntosTX.Text))
                {
                    exc.AgregarError("La cantidad de puntos no puede quedar en blanco");
                    errCantidadPuntosLB.Visible = true;
                }
                else if (!Validaciones.EsInt(cantidadPuntosTX.Text))
                {
                    exc.AgregarError("La cantidad de puntos debe ser un número entero.");
                    errCantidadPuntosLB.Visible = true;
                }

                if (Validaciones.EsVacio(cantidadStockTX.Text))
                {
                    exc.AgregarError("La cantidad de stock no puede quedar en blanco");
                    errCantidadStockLB.Visible = true;
                }
                else if (!Validaciones.EsInt(cantidadStockTX.Text))
                {
                    exc.AgregarError("La cantidad de stock debe ser un número entero.");
                    errCantidadStockLB.Visible = true;
                }

                if (exc.TieneErrores)
                    throw exc;

                premio = new Premio(Conversiones.AInt(codigoLB2.Text), descripcionTX.Text,Conversiones.AInt(cantidadPuntosTX.Text), Conversiones.AInt(cantidadStockTX.Text));
                try
                {
                    int i = ASupermercado.agregar(premio);

                    MessageBox.Show("El premio se ha guardado con éxito");
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
            premio = null;
            this.Close();
        }

        #endregion
    }
}
