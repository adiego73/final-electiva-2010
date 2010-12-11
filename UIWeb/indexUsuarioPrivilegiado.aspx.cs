using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logic;

namespace UIWeb
{
    public partial class indexUsuarioPrivilegiado : System.Web.UI.Page
    {
        public Usuario usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                this.ocultarTodo();

            if (Session["Usuario"] == null)
                Response.Redirect("index.aspx");
            else
            {
                usuario = (Usuario)Session["Usuario"];
                lNombre.Text = "Bienvenido: " + usuario.User;
            }
        }

        protected void ArbolOpciones_SelectedNodeChanged(object sender, EventArgs e)
        {
            switch (ArbolOpciones.SelectedNode.Value)
            {
                case "Solicitud":
                    this.ocultarTodo();
                    SolicitudPremios1.Visible = true;
                    break;
                case "Stock":
                    this.ocultarTodo();
                    StockPremios1.Visible = true;
                    break;
                case "Rango":
                    this.ocultarTodo();
                    break;
            }
        }

        private void ocultarTodo()
        {
            SolicitudPremios1.Visible = false;
            StockPremios1.Visible = false;
        }

        protected void menu_MenuItemClick(object sender, MenuEventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("index.aspx");
        }

    }
}
