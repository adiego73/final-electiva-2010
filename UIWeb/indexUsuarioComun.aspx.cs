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
        public Usuario usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                this.ocultarTodo();
            try
            {
                if (Request["dni"] != null && Request["id"] != null && Session["Usuario"] == null)
                {
                    Session["Usuario"] = ASupermercado.traerUsuario(int.Parse(Request["dni"]), int.Parse(Request["id"]));

                    if (Session["Usuario"] == null)
                        throw new Exception();
                }
                else if (Session["Usuario"] == null)
                {
                    Response.Redirect("index.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("index.aspx");
            }
            // else el usuario esta en la sesion
            usuario = (Usuario)Session["Usuario"];
            lNombre.Text = usuario.Cliente.Apellido + ", " + usuario.Cliente.Nombre;

        }

        protected void ArbolOpciones_SelectedNodeChanged(object sender, EventArgs e)
        {
            switch (ArbolOpciones.SelectedNode.Value)
            {
                case "Completo":
                    this.ocultarTodo();
                    CatalogoCompleto1.Visible = true;

                break;
                case "ConMisPuntos":
                    this.ocultarTodo();
                    CatalogoUsuario1.Visible = true;

                break;
                case "Canjear":
                    this.ocultarTodo();
                    Canjear1.Visible = true;
                    break;
                case "MisPremios":
                    this.ocultarTodo();
                    MisPremios1.Visible = true;
                    break;
                case "MiInformacion":
                    this.ocultarTodo();
                    Minformacion1.Visible = true;
                    break;
            }
        }

        private void ocultarTodo()
        {
            CatalogoCompleto1.Visible = false;
            CatalogoUsuario1.Visible = false;
            Canjear1.Visible = false;
            Minformacion1.Visible = false;
            MisPremios1.Visible = false;
        }

        protected void menu_MenuItemClick(object sender, MenuEventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("index.aspx");
        }
    }
}
