using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic;
using Library.Funciones;
using Library.Excepciones;

namespace UIForms
{
    public partial class FrmSupermercado : Form
    {
        public FrmSupermercado()
        {
            InitializeComponent();
        }
        
        #region Eventos

        //Opciones de menú relacionadas a los clientes ----
        
            private void nCliente_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de CLIENTES - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                FrmCliente frmNuevoCliente = new FrmCliente();
                frmNuevoCliente.ShowDialog();
                this.lClientesActivos_Click(null, null);
            }

            /*private void lCliente_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de todos los clientes ACTIVOS - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                try
                {
                    this.cargarGridView(ASupermercado.listarUsuarios());
                    DataGridViewLinkColumn lc = new DataGridViewLinkColumn();
                    lc.Name = "EditarCliente";
                    lc.HeaderText = "";
                    lc.Text = "Editar";
                    lc.UseColumnTextForLinkValue = true;
                    lc.ReadOnly = true;
                    lc.Width = 50;
                    listadoDG.Columns.Add(lc);
                }
                catch (ExcepcionGral exc)
                {
                    exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                    if(!Validaciones.EsVacio(exc.Message))
                        MessageBox.Show(exc.Message);
                }*/
            //}

            private void lClientesActivos_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de todos los clientes ACTIVOS - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                try
                {
                    this.cargarGridView(ASupermercado.listarUsuarios());
                    DataGridViewLinkColumn lc = new DataGridViewLinkColumn();
                    lc.Name = "EditarCliente";
                    lc.HeaderText = "";
                    lc.Text = "Editar";
                    lc.UseColumnTextForLinkValue = true;
                    lc.ReadOnly = true;
                    lc.Width = 50;
                    listadoDG.Columns.Add(lc);
                }
                catch (ExcepcionGral exc)
                {
                    exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                    if (!Validaciones.EsVacio(exc.Message))
                        MessageBox.Show(exc.Message);
                }
            }
            
        private void lClientesInactivos_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de todos los clientes INACTIVOS - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                try
                {
                    this.cargarGridView(ASupermercado.traerClientesInactivos());
                }
                catch (ExcepcionGral exc)
                {
                    exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                    if (!Validaciones.EsVacio(exc.Message))
                        MessageBox.Show(exc.Message);
                }
            }

        //---- Fin Opciones de Clientes

        //Opciones de menú relacionadas a los usuarios ----

            private void nUsuarioEspecial_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de USUARIOS - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                FrmUsuario frmNuevoUsuario = new FrmUsuario();

                frmNuevoUsuario.ShowDialog();                
                try
                {
                    this.cargarGridView(ASupermercado.listarUsuariosPrivilegiados());
                    DataGridViewLinkColumn lc = new DataGridViewLinkColumn();
                }
                catch (ExcepcionGral exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

            private void lUsuariosP_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de USUARIOS - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;

                try
                {
                    this.cargarGridView(ASupermercado.listarUsuariosPrivilegiados());
                }
                catch (ExcepcionGral exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        //---- Fin Opciones de Usuarios

       //Opciones de menú relacionadas a los premios ----

            private void nPremio_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de PREMIOS - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                FrmPremio frmNuevoPremio = new FrmPremio();
                frmNuevoPremio.ShowDialog();
                this.lPremiosActivos_Click(null, null);
            }

            private void lPremiosActivos_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de PREMIOS ACTIVOS - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                try
                {
                    this.cargarGridView(ASupermercado.listarTodosLosPremios());
                    DataGridViewLinkColumn lc = new DataGridViewLinkColumn();
                    lc.Name = "EditarPremio";
                    lc.HeaderText = "";
                    lc.Text = "Editar";
                    lc.UseColumnTextForLinkValue = true;
                    lc.ReadOnly = true;
                    lc.Width = 50;
                    listadoDG.Columns.Add(lc);
                }
                catch (ExcepcionGral exc)
                {
                    exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                    if (!Validaciones.EsVacio(exc.Message))
                        MessageBox.Show(exc.Message);
                }
            }

            private void lPremiosInactivos_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de PREMIOS INACTIVOS - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                try
                {
                    this.cargarGridView(ASupermercado.listarPremiosInactivos());
                }
                catch (ExcepcionGral exc)
                {
                    exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                    if (!Validaciones.EsVacio(exc.Message))
                        MessageBox.Show(exc.Message);
                }
            }

        //---- Fin Opciones de Premios

        //Opciones de menú relacionadas a los Compras ----

            private void nCompra_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Seleccion de cliente para la generación de COMPRAS - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                try
                {
                    this.cargarGridView(ASupermercado.listarTodosLosClientes());
                    DataGridViewLinkColumn lc = new DataGridViewLinkColumn();
                    lc.Name = "AgregarCompra";
                    lc.HeaderText = "";
                    lc.Text = "Agregar Compra";
                    lc.UseColumnTextForLinkValue = true;
                    lc.ReadOnly = true;
                    lc.Width = 100;
                    listadoDG.Columns.Add(lc);
                }
                catch (ExcepcionGral exc)
                {
                    exc.AgregarError("NO HAY CLIENTES PARA AGREGAR COMPRAS");
                    if (!Validaciones.EsVacio(exc.Message))
                        MessageBox.Show(exc.Message);
                }
            }

            //private void lCompra_Click(object sender, EventArgs e)
            //{
                
            //}

        //---- Fin Opciones de Compras

            private void cerrar_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        // Click en el DataGrid ----
        
            private void listadoDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

                if (listadoDG.SelectedCells[0].OwningColumn.Name == "EditarCliente")
                {
                    try
                    {
                        FrmClienteEdicion frmEditarCli = new FrmClienteEdicion();
                        frmEditarCli.Cliente = ASupermercado.traerCliente(Conversiones.AInt(listadoDG.SelectedCells[0].OwningRow.Cells["Dni"].Value));
                        frmEditarCli.ShowDialog();
                        this.lClientesActivos_Click(null, null);
                    }
                    catch (ExcepcionGral exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                else
                {
                    if (listadoDG.SelectedCells[0].OwningColumn.Name == "AgregarCompra")
                    {
                        try
                        {
                            FrmCompra frmNuevaCompra = new FrmCompra();
                            frmNuevaCompra.Cliente = ASupermercado.traerCliente(Conversiones.AInt(listadoDG.SelectedCells[0].OwningRow.Cells["Dni"].Value));
                            frmNuevaCompra.ShowDialog();
                            this.lCompraTodas_Click(null, null);
                        }
                        catch (ExcepcionGral exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                    }
                    else 
                    {
                        if (listadoDG.SelectedCells[0].OwningColumn.Name == "EditarPremio")
                        {
                            FrmPremioEdicion frmEditarPre = new FrmPremioEdicion();
                            frmEditarPre.Premio = ASupermercado.traerPremio(Conversiones.AInt(listadoDG.SelectedCells[0].OwningRow.Cells["Codigo"].Value));
                            frmEditarPre.ShowDialog();
                            this.lPremiosActivos_Click(null, null);
                        }
                        else if (listadoDG.SelectedCells[0].OwningColumn.Name == "VerCompras")
                        {
                            try
                            {
                                this.cargarGridView(ASupermercado.listarTodasLasComprasPorUsuario(Conversiones.AInt(listadoDG.SelectedCells[0].OwningRow.Cells["Dni"].Value)));
                            }
                            catch (ExcepcionGral exc)
                            {
                                exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                                if (!Validaciones.EsVacio(exc.Message))
                                    MessageBox.Show(exc.Message);
                            }
                        }
                        else if (listadoDG.SelectedCells[0].OwningColumn.Name == "VerCanjes")
                        {
                            try
                            {
                                this.cargarGridView(ASupermercado.listarTodosLosCanjes(Conversiones.AInt(listadoDG.SelectedCells[0].OwningRow.Cells["Dni"].Value)));
                            }
                            catch (ExcepcionGral exc)
                            {
                                exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                                if (!Validaciones.EsVacio(exc.Message))
                                    MessageBox.Show(exc.Message);
                            }
                        }
                    }
                }
            }
        
        //---- Fin de Clic en el DataGrid

            private void vaciar_Click(object sender, EventArgs e)
            {
                ASupermercado.eliminar();
            }

            private void lCompraTodas_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de todas las COMPRAS - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                try
                {
                    this.cargarGridView(ASupermercado.listarTodasLasCompras());
                }
                catch (ExcepcionGral exc)
                {
                    exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                    if (!Validaciones.EsVacio(exc.Message))
                        MessageBox.Show(exc.Message);
                }
            }

            private void lCompraCliente_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de todas las COMPRAS por CLIENTE - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                try
                {
                    this.cargarGridView(ASupermercado.listarUsuarios());
                    DataGridViewLinkColumn lc = new DataGridViewLinkColumn();
                    lc.Name = "VerCompras";
                    lc.HeaderText = "";
                    lc.Text = "Ver Compras";
                    lc.UseColumnTextForLinkValue = true;
                    lc.ReadOnly = true;
                    lc.Width = 100;
                    listadoDG.Columns.Add(lc);
                }
                catch (ExcepcionGral exc)
                {
                    exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                    if (!Validaciones.EsVacio(exc.Message))
                        MessageBox.Show(exc.Message);
                }
            }

            //---- Opciones de Canjes
            private void lCanjesTodos_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de todos los CANJES - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;

                try
                {
                    this.cargarGridView(ASupermercado.listarTodosLosCanjes());
                }
                catch (ExcepcionGral exc)
                {
                    exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                    if (!Validaciones.EsVacio(exc.Message))
                        MessageBox.Show(exc.Message);
                }
            }

            private void lCanjesCliente_Click(object sender, EventArgs e)
            {
                lTitulo.Text = " - Listado de todos los CANJES por CLIENTE - ";
                lTitulo.TextAlign = ContentAlignment.MiddleCenter;
                
                try
                {
                    this.cargarGridView(ASupermercado.listarUsuarios());
                    DataGridViewLinkColumn lc = new DataGridViewLinkColumn();
                    lc.Name = "VerCanjes";
                    lc.HeaderText = "";
                    lc.Text = "Ver Canjes";
                    lc.UseColumnTextForLinkValue = true;
                    lc.ReadOnly = true;
                    lc.Width = 100;
                    listadoDG.Columns.Add(lc);
                }
                catch (ExcepcionGral exc)
                {
                    exc.AgregarError("NO SE PUDO LISTAR LO PEDIDO");
                    if (!Validaciones.EsVacio(exc.Message))
                        MessageBox.Show(exc.Message);
                }
            }
            //---- Fin Opciones de Canjes

        #endregion

        #region Metodos

            public void cargarGridView(List<Cliente> listaClientes)
            {
                listadoDG.Columns.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("Dni");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Teléfono");
                dt.Columns.Add("Dirección");
                dt.Columns.Add("EMail");
                int i = 0;
                foreach (Cliente c in listaClientes)
                {
                    dt.Rows.Add(new Object[]{
                    "" });
                    dt.Rows[i].SetField("Dni", c.Dni);
                    dt.Rows[i].SetField("Nombre", c.Nombre);
                    dt.Rows[i].SetField("Apellido", c.Apellido);
                    dt.Rows[i].SetField("Teléfono", c.Telefono);
                    dt.Rows[i].SetField("Dirección", c.Direccion);
                    dt.Rows[i].SetField("EMail", c.Mail);
                    i++;
                }
                listadoDG.DataSource = dt;
                listadoDG.AllowUserToOrderColumns = true;
                //Bloquea las columnas para que no las puedan modificar
                foreach (DataGridViewColumn c in listadoDG.Columns)
                {
                    c.ReadOnly = true;
                }
            }

            public void cargarGridView(List<Usuario> listaUsuarios)
            {
                listadoDG.Columns.Clear();
                DataTable dt = new DataTable();
                
                dt.Columns.Add("Id de Usuario");
                dt.Columns.Add("Usuario");
                int i = 0;
                foreach (Usuario u in listaUsuarios)
                {
                    dt.Rows.Add(new Object[]{
                    "" });

                    dt.Rows[i].SetField("Usuario", u.User);
                    if (!Validaciones.EsVacio((object)u.Cliente))
                    {
                        dt.Rows[i].SetField("Id de Usuario", ASupermercado.recuperarIdUsuario(u.Cliente.Dni));
                        if (dt.Columns.Count == 2)
                        {
                            dt.Columns.Add("Dni");
                            dt.Columns.Add("Nombre y apellido");
                        }
                        if (dt.Columns.Count > 2)
                        {
                            dt.Rows[i].SetField("Dni", u.Cliente.Dni);
                            dt.Rows[i].SetField("Nombre y Apellido", u.Cliente.Nombre + " " + u.Cliente.Apellido);
                            
                        }
                    }else
                        dt.Rows[i].SetField("Id de Usuario", ASupermercado.recuperarIdUsuario(u.User));

                    i++;
                }
                listadoDG.DataSource = dt;
                listadoDG.AllowUserToOrderColumns = true;
                //Bloquea las columnas para que no las puedan modificar
                foreach (DataGridViewColumn c in listadoDG.Columns)
                {
                    c.ReadOnly = true;
                }
            }

            public void cargarGridView(List<Premio> listaPremios)
            {
                listadoDG.Columns.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Descripcion");
                dt.Columns.Add("Cantidad Puntos");
                dt.Columns.Add("Cantidad Stock");
                int i = 0;
                foreach (Premio p in listaPremios)
                {
                    dt.Rows.Add(new Object[]{
                    "" });
                    dt.Rows[i].SetField("Codigo", p.Codigo);
                    dt.Rows[i].SetField("Descripcion", p.Descripcion);
                    dt.Rows[i].SetField("Cantidad Puntos", p.CantPuntos);
                    dt.Rows[i].SetField("Cantidad Stock", p.CantStock);
                    i++;
                }
                listadoDG.DataSource = dt;
                listadoDG.AllowUserToOrderColumns = true;
                //Bloquea las columnas para que no las puedan modificar
                foreach (DataGridViewColumn c in listadoDG.Columns)
                {
                    c.ReadOnly = true;
                }
            }

            public void cargarGridView(List<Compra> listaCompras)
            {
                listadoDG.Columns.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("Código");
                dt.Columns.Add("Cliente");
                dt.Columns.Add("Fecha");
                dt.Columns.Add("Importe");
                int i = 0;
                foreach (Compra c in listaCompras)
                {
                    dt.Rows.Add(new Object[]{
                    "" });
                    dt.Rows[i].SetField("Código", c.Codigo);
                    dt.Rows[i].SetField("Cliente", c.Cliente.Nombre + " " + c.Cliente.Apellido);
                    dt.Rows[i].SetField("Fecha",  Conversiones.AString(c.Fecha));
                    dt.Rows[i].SetField("Importe", c.Importe);
                    i++;
                }
                listadoDG.DataSource = dt;
                listadoDG.AllowUserToOrderColumns = true;
                //Bloquea las columnas para que no las puedan modificar
                foreach (DataGridViewColumn c in listadoDG.Columns)
                {
                    c.ReadOnly = true;
                }
            }

            public void cargarGridView(List<Canje> listaCanjes)
            {
                listadoDG.Columns.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Cliente");
                dt.Columns.Add("Premio");
                dt.Columns.Add("Fecha");
                int i = 0;
                string nombreCliente;
                foreach (Canje c in listaCanjes)
                {
                    nombreCliente = c.Cliente.Apellido + ", " + c.Cliente.Nombre;
                    dt.Rows.Add(new Object[]{
                    "" });
                    dt.Rows[i].SetField("Codigo", c.Codigo);
                    dt.Rows[i].SetField("Cliente", nombreCliente);
                    dt.Rows[i].SetField("Premio", c.Premio.Descripcion);
                    dt.Rows[i].SetField("Fecha", c.Fecha);
                    i++;
                }
                listadoDG.DataSource = dt;
                listadoDG.AllowUserToOrderColumns = true;
                //Bloquea las columnas para que no las puedan modificar
                foreach (DataGridViewColumn c in listadoDG.Columns)
                {
                    c.ReadOnly = true;
                }
            }


        #endregion
    }
}
