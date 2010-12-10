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
using Logic;
using Library;



namespace UIWeb.Controles
{
    public partial class Canjear : System.Web.UI.UserControl
    {
        public event EventHandler canjearClick;
        protected void Page_Load(object sender, EventArgs e)
        {
           // canjearClick = new EventHandler(Click_Canjear);

            if (!IsPostBack)
                this.completarCatalogo();
        }

        public void Click_Canjear(object o, EventArgs e)
        {
            TextBox1.Text = "se apreto el botonete";
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
                    Button b = new Button();
                    b.Text = "Canjear";
//                    canjearClick += b.Click();

                    listaPremios.Rows.Add(new Object[] { "" });
                    listaPremios.Rows[i].SetField("Codigo", p.Codigo);
                    listaPremios.Rows[i].SetField("Descripcion", p.Descripcion);
                    listaPremios.Rows[i].SetField("Puntos", p.CantPuntos);
                    listaPremios.Rows[i].SetField("Stock", p.CantStock);
                    listaPremios.Rows[i].SetField("Canjear", b);
                    i++;
                }
            }
            //Asocia la tabla al gridview
            cCatalogo.DataSource = listaPremios;
            cCatalogo.DataBind();
        }

        private void completarCatalogo()
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
                Button b = new Button();
                b.Text = "Canjear";
                listaPremios.Rows.Add(new Object[] { "" });
                listaPremios.Rows[i].SetField("Codigo", p.Codigo);
                listaPremios.Rows[i].SetField("Descripcion", p.Descripcion);
                listaPremios.Rows[i].SetField("Puntos", p.CantPuntos);
                listaPremios.Rows[i].SetField("Stock", p.CantStock);
                listaPremios.Rows[i].SetField("Canjear", "Canjear");
                i++;
            }
            //Asocia la tabla al gridview
            cCatalogo.DataSource = listaPremios;
            cCatalogo.DataBind();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "submit";
        }
    }
}