using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Library.Excepciones;
using Library.Funciones;
using Logic;

namespace UIWeb.Controles
{
    public partial class edfirstLogIn : System.Web.UI.UserControl
    {
        public event EventHandler volver;
        #region Propiedades

            public Usuario usuario
            {
                get { return (Usuario)Session["Usuario"]; }
            }

        #endregion

        #region Eventos

            protected void Page_Load(object sender, EventArgs e)
            {
                if(!this.IsPostBack)
                    pnlCargaUsuario.Visible = false;
            }

            protected void bSiguiente_Click(object sender, EventArgs e)
            {
                //Verifica el ingreso correcto de los datos 
                //Habilita el ingreso de un usuario y contraseña

                this.ocultarMensajes();
                if (this.validarDatos())
                {
                    try
                    {
                        Session["Usuario"] = ASupermercado.traerUsuario(Conversiones.AInt(dniTX.Text), Conversiones.AInt(idUsuarioTX.Text));
                        if ((Usuario)Session["Usuario"] == null)
                        {
                            errorGralLB.Text = "Usuario Inválido";
                            errorGralLB.Visible = true;
                            pnlCargaUsuario.Visible = false;
                        }
                        else
                        {
                            avisoGralLB.Text = "Bienvenido!, " + ((Usuario)Session["Usuario"]).Cliente.Nombre + " " + ((Usuario)Session["Usuario"]).Cliente.Apellido;
                            avisoGralLB.Text += " eliga el usuario y contraseña con los que ingresará a partir de ahora.";
                            avisoGralLB.Visible = true;
                            pnlCargaUsuario.Visible = true;
                        }
                    }
                    catch (ExcepcionGral exc)
                    {
                        errorGralLB.Text = exc.Message;
                        errorGralLB.Visible = true;
                        Session["Usuario"] = null;
                    }
                }
            }

            protected void bRegistrar_Click(object sender, EventArgs e)
            {
                this.ocultarMensajes2();
                if (this.validarDatos2())
                {
                    try
                    {
                        ((Usuario)Session["Usuario"]).User = usuarioTX.Text;
                        ((Usuario)Session["Usuario"]).Contrasenia = contraseniaTX.Text;
                        ASupermercado.modificar((Usuario)Session["Usuario"]);
                        avisoGralLB2.Text = "Su usuario ha sido actualizado!. La próxima vez que ingrese ";
                        avisoGralLB2.Text += "podrá hacerlo usando su nuevo usuario y contraseña.";
                        avisoGralLB2.Visible = true;
                    }
                    catch (ExcepcionGral exc)
                    { errorGralLB2.Text = exc.Message; }
                }
            }

            protected void bVolver_Click(object sender, EventArgs e)
            {
                if (this.volver != null)
                    volver(null, null);
            }

        #endregion

        #region Metodos

            private void ocultarMensajes()
                {
                    errorGralLB.Text = "";
                    errorGralLB.Visible = false;
                    errDniLB.Visible = false;
                    errDniPB.Visible = false;
                    errDniLB.Text = "";
                    errIdUsuarioLB.Visible = false;
                    errIdUsuarioPB.Visible = false;
                    errIdUsuarioLB.Text = "";
                    avisoGralLB.Text = "";
                    avisoGralLB.Visible = false;
                    errContraseniaLB.Visible = false;
                    errContraseniaLB.Text = "";
                    errUsuarioLB.Visible = false;
                    errUsuarioLB.Text = "";
                    errVerificaLB.Visible = false;
                    errVerificaLB.Text = "";
                    errVerificaPB.Visible = false;
                    errContraseniaPB.Visible = false;
                    errUsuarioPB.Visible = false;
                    avisoGralLB2.Text = "";
                    avisoGralLB2.Visible = false;
                    errorGralLB2.Text = "";
                    errorGralLB2.Visible = false;
                }

            private void ocultarMensajes2()
            {
                errContraseniaLB.Visible = false;
                errContraseniaLB.Text = "";
                errUsuarioLB.Visible = false;
                errUsuarioLB.Text = "";
                errVerificaLB.Visible = false;
                errVerificaLB.Text = "";
                errVerificaPB.Visible = false;
                errContraseniaPB.Visible = false;
                errUsuarioPB.Visible = false;
                avisoGralLB2.Text = "";
                avisoGralLB2.Visible = false;
                avisoGralLB2.Text = "";
                avisoGralLB2.Visible = false;
                errorGralLB2.Text = "";
                errorGralLB2.Visible = false;
            }

            private bool validarDatos()
            {
                ExcepcionGral exc = new ExcepcionGral();
                try
                {
                   if (Validaciones.EsVacio(dniTX.Text))
                        exc.AgregarError("Debe ingresar un dni", errDniLB.UniqueID, TipoError.ERRCARGAINVALIDA, errDniPB.UniqueID);
                    else if (!Validaciones.EsInt(dniTX.Text))
                        exc.AgregarError("El dni debe ser numérico", errDniLB.UniqueID, TipoError.ERRCARGAINVALIDA, errDniPB.UniqueID);
                    else if (dniTX.Text.Length < 7 || dniTX.Text.Length > 8)
                        exc.AgregarError("El dni debe tener entre 7 y 8 dígitos", errDniLB.UniqueID, TipoError.ERRCARGAINVALIDA, errDniPB.UniqueID);

                    if (Validaciones.EsVacio(idUsuarioTX.Text))
                        exc.AgregarError("Debe ingresar su ID de usuario", errIdUsuarioLB.UniqueID, TipoError.ERRCARGAINVALIDA, errIdUsuarioPB.UniqueID);
                    else if (!Validaciones.EsInt(idUsuarioTX.Text))
                        exc.AgregarError("El ID de usuario debe ser numérico", errIdUsuarioLB.UniqueID, TipoError.ERRCARGAINVALIDA, errIdUsuarioPB.UniqueID);

                    if (exc.TieneErrores)
                        throw exc;

                    return true;
                }
                catch (ExcepcionGral)
                {
                    this.mostrarErrores(exc);
                    return false;
                }
            }

            private bool validarDatos2()
            {
                ExcepcionGral exc = new ExcepcionGral();
                try
                {
                    if (Validaciones.EsVacio(usuarioTX.Text))
                        exc.AgregarError("Debe ingresar un usuario", errUsuarioLB.UniqueID, TipoError.ERRCARGAINVALIDA, errUsuarioPB.UniqueID);
                    else
                    {
                        try
                        {
                            if (ASupermercado.existeUsuario(usuarioTX.Text))
                                exc.AgregarError("Usuario existente!. Ingrese otro.", errUsuarioLB.UniqueID, TipoError.ERRCARGAINVALIDA, errUsuarioPB.UniqueID);
                        }
                        catch (ExcepcionGral ex)
                        { exc.AgregarError(ex.Message); }
                    }
                    if (Validaciones.EsVacio(contraseniaTX.Text))
                        exc.AgregarError("Debe ingresar una contraseña", errContraseniaLB.UniqueID, TipoError.ERRCARGAINVALIDA, errContraseniaPB.UniqueID);
                    if (Validaciones.EsVacio(verificarTX.Text))
                        exc.AgregarError("Debe ingresar la verificación de la contraseña", errVerificaLB.UniqueID, TipoError.ERRCARGAINVALIDA, errVerificaPB.UniqueID);
                    if (exc.TieneErrores)
                        throw exc;
                    if (contraseniaTX.Text != verificarTX.Text)
                        exc.AgregarError("La verificación no se corresponde con la contraseña", errorGralLB2.UniqueID);

                    if (exc.TieneErrores)
                        throw exc;

                    return true;
                }
                catch (ExcepcionGral)
                {
                    this.mostrarErrores(exc);
                    return false;
                }
            }

            private void mostrarErrores(ExcepcionGral exc)
            {
                foreach (EntidadError err in exc.ErroresConLugar)
                {
                    Label msgError = ((Label)Page.FindControl(err.MsgLB));
                    msgError.Text = err.Mensaje;
                    msgError.Visible = true;
                    if (err.Icono != "")
                    {
                        Image icono = ((Image)Page.FindControl(err.IconoPB));
                        icono.ImageUrl = @"../Iconos/" + err.Icono;
                        icono.Visible = true;
                    }
                }
            }

        #endregion

            
    }
}