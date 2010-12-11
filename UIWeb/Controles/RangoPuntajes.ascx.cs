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
    public partial class RangoPuntajes : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.cargarRangoPuntajes();
        }

        private void cargarRangoPuntajes()
        {
            gvRangoPuntajes.DataSource = null;
            DataTable listaPuntos = new DataTable();

            //Genera la estructura de la tabla de Solicitud de Premios
            listaPuntos.Columns.Add("Rango de Puntajes");
            listaPuntos.Columns.Add("Cantidad de Clientes");

            List<Cliente> clientes = ASupermercado.listarTodosLosClientes();
            double puntos = 0;
            double cant_r1 = 0;
            double cant_r2 = 0;
            double cant_r3 = 0;

            foreach (Cliente c in clientes)
            {
                puntos = ASupermercado.calcularPuntajeTotal(c);
                //Rango desde 0 a 100
                if (puntos >= 0 && puntos <= 100)
                    cant_r1 = cant_r1 + 1;
                else
                {   //Rango desde 101 hasta 1000
                    if (puntos > 100 && puntos <= 1000)
                        cant_r2 = cant_r2 + 1;
                    else
                        //Rango desde 1000
                        cant_r3 = cant_r3 + 1;
                }
            }

            listaPuntos.Rows.Add(new Object[] { "" });
            listaPuntos.Rows[0].SetField("Rango de Puntajes", "0 a 100");
            listaPuntos.Rows[0].SetField("Cantidad de Clientes", cant_r1);

            listaPuntos.Rows.Add(new Object[] { "" });
            listaPuntos.Rows[1].SetField("Rango de Puntajes", "101 a 1000");
            listaPuntos.Rows[1].SetField("Cantidad de Clientes", cant_r2);

            listaPuntos.Rows.Add(new Object[] { "" });
            listaPuntos.Rows[2].SetField("Rango de Puntajes", "Más de 1000");
            listaPuntos.Rows[2].SetField("Cantidad de Clientes", cant_r3);
            
            //Asocia la tabla al gridview
            gvRangoPuntajes.DataSource = listaPuntos;
            gvRangoPuntajes.DataBind();
        }

    }
}