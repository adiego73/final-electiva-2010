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

                if (!this.IsPostBack)
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
