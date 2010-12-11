using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logic;
using System.Data;

namespace UIWeb.Controles
{
    public partial class SolicitudPremios : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.cargarSolicitudPremios();
        }

        private void cargarSolicitudPremios()
        {
            gvSolicitudPremios.DataSource = null;
            DataTable listaPremios = new DataTable();
            int i = 0;

            //Genera la estructura de la tabla de Solicitud de Premios
            listaPremios.Columns.Add("Código de Premio");
            listaPremios.Columns.Add("Premio");
            listaPremios.Columns.Add("Cantidad de Clientes");

            List<Premio> alPremios = ASupermercado.listarTodosLosPremios();
            double canjes;

            foreach (Premio p in alPremios)
            {
                canjes = ASupermercado.traerCanjesPorPremio(p.Codigo);

                {
                    listaPremios.Rows.Add(new Object[] { "" });
                    listaPremios.Rows[i].SetField("Código de Premio", p.Codigo);
                    listaPremios.Rows[i].SetField("Premio", p.Descripcion);
                    listaPremios.Rows[i].SetField("Cantidad de Clientes", canjes);

                    i++;
                }
            }
            //Asocia la tabla al gridview
            gvSolicitudPremios.DataSource = listaPremios;
            gvSolicitudPremios.DataBind();
        }
    }
}