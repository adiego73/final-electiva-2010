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

namespace UIWeb.Controles
{
    public partial class CatalogoUsuario : System.Web.UI.UserControl
    {
        private Usuario usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            int puntos = ASupermercado.calcularPuntos(usuario.Cliente);
            this.cargarCatalogoUsuario(puntos);
        }

        private void cargarCatalogoUsuario(int pts)
        {
            GridView1.DataSource = null;
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
            GridView1.DataSource = listaPremios;
            GridView1.DataBind();
        }
    }
}