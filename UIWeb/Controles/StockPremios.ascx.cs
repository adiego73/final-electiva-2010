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
    public partial class StockPremios : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            this.cargarStockPremios();
        }

        private void cargarStockPremios()
        {
            gvStockPremios.DataSource = null;
            DataTable listaPremios = new DataTable();
            int i = 0;

            //Genera la estructura de la tabla de Stock de Premios
            listaPremios.Columns.Add("Código de Premio");
            listaPremios.Columns.Add("Premio");
            listaPremios.Columns.Add("Stock");

            List<Premio> alPremios = ASupermercado.listarTodosLosPremios();

            foreach (Premio p in alPremios)
            {
                {
                    listaPremios.Rows.Add(new Object[] { "" });
                    listaPremios.Rows[i].SetField("Código de Premio", p.Codigo);
                    listaPremios.Rows[i].SetField("Premio", p.Descripcion);
                    listaPremios.Rows[i].SetField("Stock", p.CantStock);

                    i++;
                }
            }
            //Asocia la tabla al gridview
            gvStockPremios.DataSource = listaPremios;
            gvStockPremios.DataBind();
        }

    }
}