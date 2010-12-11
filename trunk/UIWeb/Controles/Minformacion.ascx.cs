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
using System.Collections.Generic;
using Library.Excepciones;


namespace UIWeb.Controles
{
    public partial class Minformacion : System.Web.UI.UserControl
    {
        public Usuario usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            lException.Visible = false;
            usuario = (Usuario)Session["Usuario"];

            if (!IsPostBack)
            {
                tbApellidoNombre.Text = usuario.Cliente.Apellido + ", " + usuario.Cliente.Nombre;
                tbApellidoNombre.Enabled = false;
                tbUsuario.Text = usuario.User;
                tbProvincia.Text = usuario.Cliente.Provincia;
                tbTelefono.Text = usuario.Cliente.Telefono;
                tbMail.Text = usuario.Cliente.Mail;
                tbDni.Text = usuario.Cliente.Dni.ToString();
                tbDni.Enabled = false;
                tbPuntos.Text = ASupermercado.calcularPuntajeTotal(usuario.Cliente).ToString();
                tbPuntos.Enabled = false;
            }

        }

        //protected void btModificar_Click(object sender, EventArgs e)
        //{
        //    usuario.User = tbUsuario.Text;
        //    usuario.Contrasenia = tbPassword.Text;
        //    usuario.Cliente.Provincia = tbProvincia.Text;
        //    usuario.Cliente.Telefono = tbTelefono.Text;
        //    usuario.Cliente.Mail = tbMail.Text;

        //    try
        //    {
        //        ASupermercado.modificar(usuario);
        //        ASupermercado.modificar(usuario.Cliente);
                
        //        lException.Visible = true;
        //        lException.Text = "La informacion se modifico correctamente.";
        //        lException.ForeColor = new System.Drawing.Color();
        //        lException.ForeColor = System.Drawing.ColorTranslator.FromHtml("#46FF96");
        //        lException.BackColor = new System.Drawing.Color();
        //        lException.BackColor = System.Drawing.ColorTranslator.FromHtml("#333333");
        //    }
        //    catch (ExcepcionGral exc)
        //    {
        //        lException.Visible = true;
        //        lException.Text = exc.Message;
        //        lException.ForeColor = new System.Drawing.Color();
        //        lException.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
        //        lException.BackColor = new System.Drawing.Color();
        //        lException.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        //    }
        //}
    }
}