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
        // public event EventHandler canjearClick;
        public Usuario usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            //canjearClick += new EventHandler(Click_Canjear);

            usuario = (Usuario)Session["Usuario"];
            if (!IsPostBack)
                this.completarCatalogo(ASupermercado.calcularPuntajeTotal(usuario.Cliente));
        }

        public void Click_Canjear(object o, EventArgs e)
        {
            TextBox1.Text = "se apreto el botonete " + cCatalogo.SelectedRow.Cells[1].Text;
            int idPremio =  Conversiones.AInt(cCatalogo.SelectedRow.Cells[1].Text);
            ASupermercado.canjearPremio(idPremio, usuario.Cliente);
            
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
            listaPremios.Columns.Add("Canjear");

            List<Premio> alPremios = ASupermercado.listarTodosLosPremios();

            foreach (Premio p in alPremios)
            {
                if (p.CantPuntos <= pts)
                {
                    //Button b = new Button();
                    //b.Text = "Canjear";
                    //b.Click += new EventHandler(Click_Canjear);

                    listaPremios.Rows.Add(new Object[] { "" });
                    listaPremios.Rows[i].SetField("Codigo", p.Codigo);
                    listaPremios.Rows[i].SetField("Descripcion", p.Descripcion);
                    listaPremios.Rows[i].SetField("Puntos", p.CantPuntos);
                    listaPremios.Rows[i].SetField("Stock", p.CantStock);
                    listaPremios.Rows[i].SetField("Canjear", "catalogo");
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

        private void completarCatalogo()
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
            //listaPremios.Columns.Add("Canjear");

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
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            switch (cPuntajes.SelectedValue)
            {
                case "Todos":
                    this.completarCatalogo();
                    break;
                default:
                    this.completarCatalogo(int.Parse(cPuntajes.SelectedValue));
                    break;
            }
        }
    }
}