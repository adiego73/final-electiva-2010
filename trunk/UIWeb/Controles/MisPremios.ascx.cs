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
    public partial class MisPremios : System.Web.UI.UserControl
    {
        Usuario usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if (!IsPostBack)
                this.completarMisPremios();
        }

        private void completarMisPremios()
        {
            GridView1.DataSource = null;
            DataTable listaPremios = new DataTable();
            int i = 0;

            //Genera la estructura de la tabla de datos de cliente
            listaPremios.Columns.Add("Fecha");
            listaPremios.Columns.Add("Premio");
            listaPremios.Columns.Add("Puntos");

            List<Canje> alCanjes = ASupermercado.listarTodosLosCanjes(usuario.Cliente.Dni); // todos los canjes que hizo el cliente
            
            foreach (Canje c in alCanjes)
            {
                listaPremios.Rows.Add(new Object[] { "" });
                listaPremios.Rows[i].SetField("Fecha", c.Fecha.ToString());
                listaPremios.Rows[i].SetField("Premio", c.Premio.Descripcion);
                listaPremios.Rows[i].SetField("Puntos", c.Premio.CantPuntos);

                i++;
            }
            //Asocia la tabla al gridview
            GridView1.DataSource = listaPremios;
            GridView1.DataBind();
        }
    }
}