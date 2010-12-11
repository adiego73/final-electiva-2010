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
using System.Collections.Generic;
using System.IO;
using Logic;
using Library.Funciones;
using Library.Excepciones;


namespace UIWeb.Controles
{
    public partial class Canjear : System.Web.UI.UserControl
    {
        public Usuario usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            lExcepciones.Visible = false;
            usuario = (Usuario)Session["Usuario"];

            //if (!IsPostBack)
            this.completarCatalogo(ASupermercado.calcularPuntajeTotal(usuario.Cliente));
            Puntaje.Text = ASupermercado.calcularPuntajeTotal(usuario.Cliente).ToString();
        }

        public void Click_Canjear(object o, EventArgs e)
        {
            try
            {
                int idPremio = Conversiones.AInt(cCatalogo.SelectedRow.Cells[1].Text);
                ASupermercado.canjearPremio(idPremio, usuario.Cliente);
                //this.Submit_Click(null, null);// simulo el click
                this.completarCatalogo(ASupermercado.calcularPuntajeTotal(usuario.Cliente));
                Puntaje.Text = ASupermercado.calcularPuntajeTotal(usuario.Cliente).ToString();

                lExcepciones.Visible = true;
                lExcepciones.Text = "El premio se canjeo correctamente. Felicitaciones!!";
                lExcepciones.ForeColor = new System.Drawing.Color();
                lExcepciones.ForeColor = System.Drawing.ColorTranslator.FromHtml("#46FF96");
                lExcepciones.BackColor = new System.Drawing.Color();
                lExcepciones.BackColor = System.Drawing.ColorTranslator.FromHtml("#333333");
            }
            catch (ExcepcionGral ex)
            {
                lExcepciones.Visible = true;
                lExcepciones.Text = ex.Message;
                lExcepciones.ForeColor = new System.Drawing.Color();
                lExcepciones.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                lExcepciones.BackColor = new System.Drawing.Color();
                lExcepciones.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            }
        }

        private void completarCatalogo(int pts)
        {
            cCatalogo.DataSource = null;
            DataTable listaPremios = new DataTable();
            int i = 0;

            //Genera la estructura de la tabla de datos de cliente
            listaPremios.Columns.Add("Codigo");
            listaPremios.Columns.Add("Descripcion");
            listaPremios.Columns.Add("Puntos");
            listaPremios.Columns.Add("Stock");

            List<Premio> alPremios = ASupermercado.listarTodosLosPremios();

            foreach (Premio p in alPremios)
            {
                if (p.CantPuntos <= pts)
                {
                    listaPremios.Rows.Add(new Object[] { "" });
                    listaPremios.Rows[i].SetField("Codigo", p.Codigo);
                    listaPremios.Rows[i].SetField("Descripcion", p.Descripcion);
                    listaPremios.Rows[i].SetField("Puntos", p.CantPuntos);
                    listaPremios.Rows[i].SetField("Stock", p.CantStock);
                    i++;
                }
            }
            //Asocia la tabla al gridview
            CommandField cf = new CommandField();
            cf.ButtonType = ButtonType.Button;
            cf.ShowSelectButton = true;
            cf.SelectText = "Canjear";
            if (cCatalogo.Columns.Count == 0)
            {
                cCatalogo.Columns.Add(cf);
                cCatalogo.Columns[0].HeaderText = "Canjear";
            }
            cCatalogo.DataSource = listaPremios;
            cCatalogo.DataBind();
        }

        /*private void completarCatalogo()
        {
            cCatalogo.Columns.Clear();
            cCatalogo.DataSource = null;
            DataTable listaPremios = new DataTable();
            int i = 0;

            //Genera la estructura de la tabla de datos de cliente
            listaPremios.Columns.Add("Codigo");
            listaPremios.Columns.Add("Descripcion");
            listaPremios.Columns.Add("Puntos");
            listaPremios.Columns.Add("Stock");

            List<Premio> alPremios = ASupermercado.listarTodosLosPremios();

            foreach (Premio p in alPremios)
            {
                listaPremios.Rows.Add(new Object[] { "" });
                listaPremios.Rows[i].SetField("Codigo", p.Codigo);
                listaPremios.Rows[i].SetField("Descripcion", p.Descripcion);
                listaPremios.Rows[i].SetField("Puntos", p.CantPuntos);
                listaPremios.Rows[i].SetField("Stock", p.CantStock);

                i++;
            }
            //Asocia la tabla al gridview

            CommandField cf = new CommandField();
            cf.ButtonType = ButtonType.Button;
            cf.ShowSelectButton = true;
            cf.SelectText = "Canjear";
            if (cCatalogo.Columns.Count == 0)
            {
                cCatalogo.Columns.Add(cf);
                cCatalogo.Columns[0].HeaderText = "Canjear";
            }

            cCatalogo.DataSource = listaPremios;
            cCatalogo.DataBind();
        }*/
    }
}