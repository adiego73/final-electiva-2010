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
                firstLogIn.usuarioIngresado += new EventHandler(Ingreso1_usuarioIngreso);
                introLB.Text = "Bienvenido al sistema de Puntajes de Gorilla Market!" + "\r\n" + "\r\n";
                introLB.Text += "Para comenzar a utilizar nuestro sistema debe ingresar con su usuario y contraseña." + "\r\n" + "\r\n";
                introLB.Text += "Si aún no dispone de un usuario, en la sección de login podrá generarlo.";
                introLB.Visible = true;
                if (!this.IsPostBack) // esto es la primera vez que entra al sitio. Notese el !
                {
                    firstLogIn.Visible = false;
                    Ingreso1.Visible = false;

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
                        // usuario administrador
                    }
                    else
                    {
                        // usuario comun.
                        int id = Logic.ASupermercado.recuperarIdUsuario(Ingreso1.usuario.User);
                        int dni = Ingreso1.usuario.Cliente.Dni;
                        Response.Redirect("indexUsuarioComun.aspx?id=" + id + "&dni=" + dni);
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
        #endregion

    }
}
