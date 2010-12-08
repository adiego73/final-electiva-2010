﻿using System;
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

namespace UIWeb
{
    public partial class indexUsuarioComun : System.Web.UI.Page
    {
        Usuario usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ocultarTodo();

            if (Request["dni"] != null && Request["id"] != null && Session["Usuario"] == null)
            {
                Session["Usuario"] = ASupermercado.traerUsuario(int.Parse(Request["dni"]), int.Parse(Request["id"]));
            }
            else if (Session["Usuario"] == null)
            {
                Response.Redirect("index.aspx");
            }
            // else el usuario esta en la sesion
            usuario = (Usuario)Session["Usuario"];
            usuario.ToString();
        }

        protected void ArbolOpciones_SelectedNodeChanged(object sender, EventArgs e)
        {
            switch (ArbolOpciones.SelectedNode.Value)
            {
                case "Completo":
                    this.ocultarTodo();
                    break;
                case "ConMisPuntos":
                    this.ocultarTodo();
                    break;
                case "Canjear":
                    this.ocultarTodo();
                    break;
                case "MiInformacion":
                    this.ocultarTodo();
                    break;
            }
        }

        private void ocultarTodo()
        {
            CatalogoCompleto1.Visible = false;
            CatalogoUsuario1.Visible = false;
            Canjear1.Visible = false;
            Minformacion1.Visible = false;
        }
    }
}
