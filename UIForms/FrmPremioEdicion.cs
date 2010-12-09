using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic;
using Library.Excepciones;
using Library.Funciones;

namespace UIForms
{
    public partial class FrmPremioEdicion : Form
    {
        #region Atributos

        private Premio premio;

        #endregion
        
        #region Constructores

        public FrmPremioEdicion()
        {
            InitializeComponent();
            premio = null;
        }

        #endregion

        #region Propiedades

        public Premio Premio
        {
            get { return premio; }
            set
            {
                premio = value;
                if (premio != null)
                    this.mostrar();
            }
        }

        #endregion

        #region Metodos

        private void mostrar()
        {
            codigoLB2.Text = premio.Codigo.ToString();
            descripcionTX.Text = premio.Descripcion;
            cantidadPuntosTX.Text = premio.CantPuntos.ToString();
            cantidadStockTX.Text = premio.CantStock.ToString();
            codigoLB2.Enabled = false;
        }

        private void cargar()
        {
            premio.Descripcion = descripcionTX.Text;
            premio.CantPuntos = Conversiones.AInt(cantidadPuntosTX.Text);
            premio.CantStock = Conversiones.AInt(cantidadStockTX.Text);
        }

        #endregion

        #region Eventos
        private void bGuardar_Click(object sender, EventArgs e)
        {
            ExcepcionGral exc = new ExcepcionGral();
            try
            {
                if (bajaCB.Checked)
                {
                    DialogResult rta = MessageBox.Show("Está seguro que desea eliminar el premio?", "Eliminación de Premio", MessageBoxButtons.YesNo);
                    if (rta.ToString() == "Yes")
                    {
                        ASupermercado.eliminarPremio(Conversiones.AInt(codigoLB2.Text));
                        MessageBox.Show("El premio se ha eliminado con éxito");
                    }
                }
                else
                {
                    errDescripcionLB.Visible = errCantidadPuntosLB.Visible = errCantidadStockLB.Visible =  false;
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

                    try
                    {
                        this.cargar();
                        ASupermercado.modificar(premio);
                        MessageBox.Show("El premio se ha modificado con éxito");
                    }
                    catch (ExcepcionGral ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (ExcepcionGral)
            {
                MessageBox.Show(exc.Message);
            }
            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            premio = null;
            this.Close();
        }

        #endregion
        
    }
}
