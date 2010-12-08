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
using Logic;
using Library.Excepciones;
using Library.Funciones;

namespace UIWeb.Controles
{
    public partial class LogIn : System.Web.UI.UserControl
    {
        public event EventHandler obtenerUsuario;
        public event EventHandler usuarioIngresado;

        #region Propiedades

        public Usuario usuario
        {
            get { return (Usuario)Session["Usuario"]; }
        }

        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                this.ocultarMensajes();
        }

        protected void bIngresar_Click(object sender, EventArgs e)
        {
            this.ocultarMensajes();
            if (this.validarDatos())
            {
                try
                {
                    Session["Usuario"] = ASupermercado.traerUsuario(usuarioTX.Text, ContraseniaTX.Text);
                    if ((Session["Usuario"]) != null)
                    {
                        avisoGralLB.Text = "Bienvenido!, " + ((Usuario)Session["Usuario"]).Cliente.Nombre + " " + ((Usuario)Session["Usuario"]).Cliente.Apellido;
                        avisoGralLB.Visible = true;
                        if (this.usuarioIngresado != null)
                        {
                            this.usuarioIngresado(null, null);
                        }
                    }
                    else
                    {
                        errorGralLB.Text = "Usuario Inválido. El usuario o la contraseña no son válidos!";
                        errorGralLB.Visible = true;
                    }
                }
                catch (ExcepcionGral exc)
                {
                    errorGralLB.Text = exc.Message;
                    errorGralLB.Visible = true;
                }
            }
        }
        protected void bObtener_Click(object sender, EventArgs e)
        {
            if (this.obtenerUsuario != null)
                obtenerUsuario(this, null);
        }

        #endregion

        #region Metodos
        private bool validarDatos()
        {
            ExcepcionGral exc = new ExcepcionGral();

            if (Validaciones.EsVacio(usuarioTX.Text))
                exc.AgregarError("Debe ingresar un usuario", errUsuarioLB.UniqueID, TipoError.ERRCARGAINVALIDA, errUsuarioPB.UniqueID);
            if (Validaciones.EsVacio(ContraseniaTX.Text))
                exc.AgregarError("Debe ingresar una contraseña", errContraseniaLB.UniqueID, TipoError.ERRCARGAINVALIDA, errContraseniaPB.UniqueID);
            try
            {
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
                    icono.ImageUrl = @"../imagenes/Iconos/" + err.Icono;
                    icono.Visible = true;
                }
            }
        }

        private void ocultarMensajes()
        {
            errContraseniaLB.Visible = false;
            errContraseniaLB.Text = "";
            errUsuarioLB.Visible = false;
            errUsuarioLB.Text = "";
            errContraseniaPB.Visible = false;
            errUsuarioPB.Visible = false;
            avisoGralLB.Text = "";
            avisoGralLB.Visible = false;
            errorGralLB.Text = "";
            errorGralLB.Visible = false;
        }

        #endregion

    }
}