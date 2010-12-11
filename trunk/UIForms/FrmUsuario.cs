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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        #region Eventos

            private void bGuardar_Click(object sender, EventArgs e)
            {
                ExcepcionGral exc = new ExcepcionGral();
                errContraseniaLB.Visible = errUsuarioLB.Visible = false;

                try
                {
                    if (Validaciones.EsVacio(usuarioTX.Text))
                    {
                        errUsuarioLB.Visible = true;
                        exc.AgregarError("El usuario no puede quedar en blanco");
                    }
                    else if (ASupermercado.existeUsuario(usuarioTX.Text))
                    {
                        errUsuarioLB.Visible = true;
                        exc.AgregarError("El nombre de usuario ya existe");
                    }
                    if (Validaciones.EsVacio(contraseniaTX.Text))
                    {
                        errContraseniaLB.Visible = true;
                        exc.AgregarError("La contraseña no puede quedar en blanco");
                    }
                    if (exc.TieneErrores)
                        throw exc;
                    Usuario usu = new UPrivilegiado(usuarioTX.Text, contraseniaTX.Text);

                    try
                    {
                        int i = ASupermercado.agregar(usu);

                        MessageBox.Show("El usuario se ha guardado con éxito, su CODIGO es: " + Conversiones.AString(i));
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
                this.Close();
            }

        #endregion


    }
}
