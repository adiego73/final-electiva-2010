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

namespace UIWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        #region Eventos

            protected void Page_Load(object sender, EventArgs e)
            {
                Ingreso1.obtenerUsuario += new EventHandler(Ingreso1_obtenerUsuario);
                firstLogIn.volver += new EventHandler(firstLogIn_volver);
                Ingreso1.usuarioIngresado += new EventHandler(Ingreso1_usuarioIngreso);

                if (!this.IsPostBack) // esto es la primera vez que entra al sitio. Notese el !
                {
                    firstLogIn.Visible = false;
                    Ingreso1.Visible = false;
                    MenuAdministrador.Visible = false;
                    MenuUsuario.Visible = false;
                }
                else
                {
                   // this.Ingreso1_usuarioIngreso(null, null);
                }
            }

            public void firstLogIn_volver(object sender, EventArgs e)
            {
                firstLogIn.Visible = false;
            }

            public void Ingreso1_obtenerUsuario(object sender, EventArgs e)
            {
                firstLogIn.Visible = true;
                Ingreso1.Visible = false;
            }

            public void Ingreso1_usuarioIngreso(object s, EventArgs e)
            {
                if (Ingreso1.usuario != null) // No hay usuario definido, por lo tanto, no entro nadie.
                {
                    if (Ingreso1.usuario.Cliente == null)
                    {
                        MenuUsuario.Visible = false;
                        MenuAdministrador.Visible = true;
                    }
                    else
                    {
                        MenuAdministrador.Visible = false;
                        MenuUsuario.Visible = true;
                    }
                }
            }

            protected void menu_MenuItemClick(object sender, MenuEventArgs e)
            {
                if (menu.SelectedItem.Value == "logIn")
                {
                    Ingreso1.Visible = true;
                    firstLogIn.Visible = false;
                }
            }

            protected void menu_MenuUsuarioClick(object s, MenuEventArgs e)
            {
                switch (MenuUsuario.SelectedItem.Value)
                {
                    case "Completo":
                    //    Response.Redirect("http://google.com/search?q=diego+armando+maradona");
                        Label1.Text = "COMPLETO";
                    break;
                    case "ConMisPuntos":
                        Label1.Text = "CON MIS PUNTOS";
                    break;
                    case "Canjear":
                        Label1.Text = "CANJEAR";
                    break;
                    case "MiInformacion":
                        Label1.Text = "MI INFORMACION";
                    break;
                }
            }

        #endregion

    }
}
