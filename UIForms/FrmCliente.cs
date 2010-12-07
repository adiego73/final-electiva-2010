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
    public partial class FrmCliente : Form
    {
        #region Atributos

            private Cliente cliente;

        #endregion

        public FrmCliente()
        {
            InitializeComponent();
        }

        #region eventos

            private void FrmCliente_Load(object sender, EventArgs e)
            {
                nombreTX.Enabled = apellidoTX.Enabled = telefonoTX.Enabled = direccionTX.Enabled = ciudadTX.Enabled = provinciaTX.Enabled = mailTX.Enabled = false;
                errDniLB.Visible = errNombreLB.Visible = errApellidoLB.Visible = errTelefonoLB.Visible = errDireccionLB.Visible = errCiudadLB.Visible = errProvinciaLB.Visible = false;
                bGuardar.Enabled = false;
            }

            private void bVerificar_Click(object sender, EventArgs e)
            {
                errDniLB.Visible = nombreTX.Enabled = apellidoTX.Enabled = telefonoTX.Enabled = direccionTX.Enabled = ciudadTX.Enabled = provinciaTX.Enabled = mailTX.Enabled = false;
                bGuardar.Enabled = false;
                ExcepcionGral exc = new ExcepcionGral();
                try
                {
                    if (Validaciones.EsVacio(dniTX.Text))
                        exc.AgregarError("El número de documento no puede ser blanco");
                    else if (!Validaciones.EsLong(dniTX.Text))
                        exc.AgregarError("El número de documento debe ser numérico");
                    else if (dniTX.Text.Length < 7 || dniTX.Text.Length > 8)
                        exc.AgregarError("El número de documento no es válido. Debe tener 7 u 8 caracteres");

                    if (exc.TieneErrores)
                        throw exc;

                    bool existe = false;
                    try
                    {
                        existe = ASupermercado.existeClienteActivo(Conversiones.AInt(dniTX.Text));
                    }
                    catch (ExcepcionGral ex)
                    { throw ex; }
                    if (existe)
                    {
                        exc.AgregarError("Ya existe un cliente registrado con ese número de DNI");
                        throw exc;
                    }
                    else
                    {
                        try
                        {
                            existe = ASupermercado.existeCliente(Conversiones.AInt(dniTX.Text));
                        }
                        catch (ExcepcionGral ex)
                        { throw ex; }
                        if (existe)
                        {
                            DialogResult rta = MessageBox.Show("El cliente ya estuvo una vez registrado en el sistema de puntos. Desea Reactivarlo?", "Reactivación de Cliente", MessageBoxButtons.YesNo);
                            if (rta.ToString() == "Yes")
                            {
                                cliente = ASupermercado.traerCliente(Conversiones.AInt(dniTX.Text));
                                int i = ASupermercado.reactivar(cliente);
                                this.mostrar();
                                MessageBox.Show("El cliente se ha Reactivado con éxito. Su número de usuario es: " + Conversiones.AString(i));
                                bCancelar.Text = "Salir";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Número de DNI válido");
                            nombreTX.Enabled = apellidoTX.Enabled = telefonoTX.Enabled = direccionTX.Enabled = ciudadTX.Enabled = provinciaTX.Enabled = mailTX.Enabled = true;
                            bGuardar.Enabled = true;
                        }
                    }
                }
                catch (ExcepcionGral excep)
                {
                    MessageBox.Show(excep.Message);
                }

            }

            private void bGuardar_Click(object sender, EventArgs e)
            {
                string tipo = "Comun";
                if (especialRB.Checked)
                    tipo = "Especial";

                errDniLB.Visible = errNombreLB.Visible = errApellidoLB.Visible = errTelefonoLB.Visible = errDireccionLB.Visible = errCiudadLB.Visible = errProvinciaLB.Visible = false;
                
                ExcepcionGral exc = new ExcepcionGral();
                
                try
                {
                    //Validaciones del DNI
                    if (Validaciones.EsVacio(dniTX.Text))
                    {
                        exc.AgregarError("El número de documento no puede ser blanco");
                        errDniLB.Visible = true;
                    }
                    else if (!Validaciones.EsLong(dniTX.Text))
                    {
                        exc.AgregarError("El número de documento debe ser numérico");
                        errDniLB.Visible = true;
                    }
                    else if (dniTX.Text.Length < 7 || dniTX.Text.Length > 8)
                    {
                        exc.AgregarError("El número de documento no es válido. Debe tener 7 u 8 caracteres");
                        errDniLB.Visible = true;
                    }

                    bool existe = false;
                    try
                    {
                        existe = ASupermercado.existeClienteActivo(Conversiones.AInt(dniTX.Text));
                    }
                    catch (ExcepcionGral ex)
                    { throw ex; }
                    if (existe)
                    {
                        exc.AgregarError("Ya existe un cliente registrado con ese número de DNI");
                        throw exc;
                    }
                    else
                    {
                        try
                        {
                            existe = ASupermercado.existeCliente(Conversiones.AInt(dniTX.Text));
                            if (existe)
                            {
                                DialogResult rta = MessageBox.Show("El cliente ya estuvo una vez registrado en el sistema de puntos. Desea Reactivarlo?", "Reactivación de Cliente", MessageBoxButtons.YesNo);
                                if (rta.ToString() == "Yes")
                                {
                                    cliente = ASupermercado.traerCliente(Conversiones.AInt(dniTX.Text));
                                    int i = ASupermercado.reactivar(cliente);
                                    this.mostrar();
                                    MessageBox.Show("El cliente se ha Reactivado con éxito. Su número de usuario es: " + Conversiones.AString(i));
                                    bCancelar.Text = "Salir";
                                }
                            }
                        }
                        catch (ExcepcionGral ex)
                        { throw ex; }
                    }

                    if (Validaciones.EsVacio(nombreTX.Text))
                    {
                        exc.AgregarError("El nombre no puede quedar en blanco");
                        errNombreLB.Visible = true;
                    }

                    if (Validaciones.EsVacio(apellidoTX.Text))
                    {
                        exc.AgregarError("El apellido no puede quedar en blanco");
                        errApellidoLB.Visible = true;
                    }

                    if (Validaciones.EsVacio(telefonoTX.Text))
                    {
                        exc.AgregarError("El teléfono no puede quedar en blanco");
                        errTelefonoLB.Visible = true;
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

                    Cliente cli;
                    if (tipo == "Comun")
                        cli = new CComun(Conversiones.AInt(dniTX.Text), nombreTX.Text, apellidoTX.Text, telefonoTX.Text, direccionTX.Text, ciudadTX.Text, provinciaTX.Text, mailTX.Text);
                    else
                        cli = new CEspecial(Conversiones.AInt(dniTX.Text), nombreTX.Text, apellidoTX.Text, telefonoTX.Text, direccionTX.Text, ciudadTX.Text, provinciaTX.Text, mailTX.Text);

                    try
                    {
                        int i = ASupermercado.agregar(cli);

                        MessageBox.Show("El cliente se ha guardado con éxito, su CODIGO DE USUARIO es: " + Conversiones.AString(i));
                        this.Close();
                    }
                    catch (ExcepcionGral ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (ExcepcionGral excep)
                {
                    MessageBox.Show(excep.Message);
                }

            }

            private void bCancelar_Click(object sender, EventArgs e)
            {
                cliente = null;
                this.Close();
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
                dniTX.Enabled = nombreTX.Enabled = apellidoTX.Enabled = telefonoTX.Enabled = direccionTX.Enabled = ciudadTX.Enabled = provinciaTX.Enabled = mailTX.Enabled = false;
            }

        #endregion
    }
}
