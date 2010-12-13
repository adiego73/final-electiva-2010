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
    public partial class FrmClienteEdicion : Form
    {
        #region Atributos
        
            private Cliente cliente;
        
        #endregion

        #region Constructores

            public FrmClienteEdicion()
        {
            InitializeComponent();
            cliente = null;
        }

        #endregion

        #region Propiedades

            public Cliente Cliente
        {
            get { return cliente; }
            set 
            { 
                cliente = value;
                if(cliente != null)
                    this.mostrar();
            }
        }

        #endregion

        #region Metodos

            private void mostrar()
            {
                if (cliente.CantPuntos == 1)
                {
                    comunRB.Checked = true;
                    especialRB.Checked = false;
                }
                else
                {
                    comunRB.Checked = false;
                    especialRB.Checked = true;
                }

                nombreTX.Text = cliente.Nombre;
                dniTX.Text = Conversiones.AString(cliente.Dni);
                apellidoTX.Text = cliente.Apellido;
                telefonoTX.Text = cliente.Telefono;
                direccionTX.Text = cliente.Direccion;
                ciudadTX.Text = cliente.Ciudad;
                provinciaTX.Text = cliente.Provincia;
                mailTX.Text = cliente.Mail;
                dniTX.Enabled = false;
            }

            private void cargar()
            {
                cliente.Nombre = nombreTX.Text;
                cliente.Apellido = apellidoTX.Text;
                cliente.Telefono = telefonoTX.Text;
                cliente.Direccion = direccionTX.Text;
                cliente.Ciudad = ciudadTX.Text;
                cliente.Provincia = provinciaTX.Text;
                cliente.Mail = mailTX.Text;
                if (comunRB.Checked & cliente.CantPuntos == 3)
                    cliente = cliente.cambiarTipo(cliente);
                if (especialRB.Checked & cliente.CantPuntos == 1)
                    cliente = cliente.cambiarTipo(cliente);
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
                        DialogResult rta = MessageBox.Show("Está seguro que desea eliminar el cliente?", "Eliminación de Cliente", MessageBoxButtons.YesNo);
                        if (rta.ToString() == "Yes")
                        {
                            ASupermercado.eliminarUsuario(Conversiones.AInt(dniTX.Text));
                            MessageBox.Show("El cliente se ha eliminado con éxito");
                        }

                    }
                    else
                    {
                        errNombreLB.Visible = errApellidoLB.Visible = errTelefonoLB.Visible = errDireccionLB.Visible = errCiudadLB.Visible = errProvinciaLB.Visible = false;

                        if (Validaciones.EsVacio(nombreTX.Text))
                        {
                            exc.AgregarError("El nombre no puede quedar en blanco");
                            errNombreLB.Visible = true;
                        }
                        else
                        {
                            if (Validaciones.EsLong(nombreTX.Text))
                            {
                                exc.AgregarError("El nombre no puede contener valores numéricos");
                                errNombreLB.Visible = true;
                            }
                        }

                        if (Validaciones.EsVacio(apellidoTX.Text))
                        {
                            exc.AgregarError("El apellido no puede quedar en blanco");
                            errApellidoLB.Visible = true;
                        }
                        else
                        {
                            if (Validaciones.EsLong(apellidoTX.Text))
                            {
                                exc.AgregarError("El apellido no puede contener valores numéricos");
                                errApellidoLB.Visible = true;
                            }
                        }

                        if (Validaciones.EsVacio(telefonoTX.Text))
                        {
                            exc.AgregarError("El teléfono no puede quedar en blanco");
                            errTelefonoLB.Visible = true;
                        }
                        else
                        {
                            if (!Validaciones.EsLong(telefonoTX.Text))
                            {
                                exc.AgregarError("El número de teléfono debe ser numérico");
                                errTelefonoLB.Visible = true;
                            }
                        }

                        if (Validaciones.EsVacio(direccionTX.Text))
                        {
                            exc.AgregarError("La dirección no puede quedar en blanco");
                            errDireccionLB.Visible = true;
                        }

                        if (Validaciones.EsVacio(ciudadTX.Text))
                        {
                            exc.AgregarError("La ciudad no puede quedar en blanco");
                            errCiudadLB.Visible = true;
                        }

                        if (Validaciones.EsVacio(provinciaTX.Text))
                        {
                            exc.AgregarError("La provincia no puede quedar en blanco");
                            errProvinciaLB.Visible = true;
                        }

                        if (exc.TieneErrores)
                            throw exc;

                        try
                        {
                            this.cargar();
                            ASupermercado.modificar(cliente);
                            MessageBox.Show("El cliente se ha modificado con éxito");
                            this.Close();
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
//                this.Close();
            }

            private void bCancelar_Click(object sender, EventArgs e)
            {
                this.Cliente = null;
                this.Close();
            }

        #endregion
    }
}
