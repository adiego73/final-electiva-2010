using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Funciones;
using Library.Excepciones;
using Library.ParaDB;
using System.Collections;
using Db;
using System.Data;

namespace Logic
{
    public class ASupermercado
    {
        #region consultas ABM a la DB
        
        //ABM de Clientes ----
        
            public static int agregar(Cliente cli)
            {
                Transaccion transaccion = null;
                ArrayList datosCliente = null;
                try
                {
                    transaccion = new Transaccion();
                    transaccion.Begin();
                    int id = 0;
                    DBCliente db = new DBCliente();
                    datosCliente = cli.pasarAMR();
                    id = db.agregar(datosCliente, transaccion);
                    db.Dispose();

                    DBUsuario dbusr = new DBUsuario();
                    Usuario usu = new UComun("", "", cli);
                    ArrayList datosUsuario = usu.pasarAMR();
                    id = dbusr.agregar(datosUsuario, transaccion);
                    dbusr.Dispose();

                    transaccion.Commit();
                    return id;
                }
                catch(ExcepcionGral exc)
                {
                    transaccion.Rollback();
                    throw exc;
                }
            }

            public static void modificar(Cliente cli)
            {
                Transaccion transaccion = null;
                ArrayList datosCliente = null;
                try
                {
                    transaccion = new Transaccion();
                    transaccion.Begin();
                    DBCliente db = new DBCliente();
                    datosCliente = cli.pasarAMR();
                    db.modificar(datosCliente, transaccion);
                    db.Dispose();
                    transaccion.Commit();
                }
                catch(ExcepcionGral exc)
                {
                    transaccion.Rollback();
                    throw exc;
                }
            }
        
        //---- Fin ABM de Clientes

        //ABM de Usuarios ----

            public static int agregar(Usuario usu)
            {
                Transaccion transaccion = null;
                try
                {
                    transaccion = new Transaccion();
                    transaccion.Begin();
                    DBUsuario dbusr = new DBUsuario();
                    ArrayList datosUsuario = usu.pasarAMR();
                    int id = dbusr.agregar(datosUsuario, transaccion);
                    dbusr.Dispose();
                    transaccion.Commit();
                    return id;
                }
                catch(ExcepcionGral exc)
                {
                    transaccion.Rollback();
                    throw exc;
                }
            }

            public static void eliminarUsuario(int dni)
            {
                try
                {
                    DBUsuario dbusr = new DBUsuario();
                    dbusr.eliminar(dni);
                    dbusr.Dispose();
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static int reactivar(Cliente cli)
            {
                Transaccion transaccion = null;
                try
                {
                    transaccion = new Transaccion();
                    transaccion.Begin();
                    int id = 0;
                    DBUsuario dbusr = new DBUsuario();
                    Usuario usu = new UComun("", "", cli);
                    ArrayList datosUsuario = usu.pasarAMR();
                    id = dbusr.agregar(datosUsuario, transaccion);
                    dbusr.Dispose();
                    transaccion.Commit();
                    return id;
                }
                catch(ExcepcionGral exc)
                {
                    transaccion.Rollback();
                    throw exc;
                }
            }

            public static void modificar(Usuario usu)
            {
                Transaccion transaccion = null;
                ArrayList datosUsuario = null;
                try
                {
                    transaccion = new Transaccion();
                    transaccion.Begin();
                    DBUsuario db = new DBUsuario();
                    datosUsuario = usu.pasarAMR();
                    db.modificar(datosUsuario, transaccion);
                    db.Dispose();
                    transaccion.Commit();
                }
                catch (ExcepcionGral exc)
                {
                    transaccion.Rollback();
                    throw exc;
                }
            }

        //---- Fin ABM de Usuarios

        //ABM de Premios ---- Jessi 28/11

            public static int agregar(Premio pre)
            {
                Transaccion transaccion = null;
                ArrayList datosPremio = null;
                try
                {
                    transaccion = new Transaccion();
                    transaccion.Begin();
                    int id = 0;
                    DBPremio db = new DBPremio();
                    datosPremio = pre.pasarAMR();
                    id = db.agregar(datosPremio, transaccion);
                    db.Dispose();
                    transaccion.Commit();
                    return id;
                }
                catch(ExcepcionGral exc)
                {
                    transaccion.Rollback();
                    throw exc;
                }
            }

            public static void modificar(Premio pre)
            {
                Transaccion transaccion = null;
                ArrayList datosPremio = null;
                try
                {
                    transaccion = new Transaccion();
                    transaccion.Begin();
                    DBPremio db = new DBPremio();
                    datosPremio = pre.pasarAMR();
                    db.modificar(datosPremio, transaccion);
                    db.Dispose();
                    transaccion.Commit();
                }
                catch(ExcepcionGral exc)
                {
                    transaccion.Rollback();
                    throw exc;
                }
            }

            public static void eliminarPremio(int cod)
            {
                try
                {
                    DBPremio db = new DBPremio();
                    db.eliminar(cod);
                    db.Dispose();
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

        //---- Fin ABM de Premios

        //ABM de Compras ---- Jessi 05/12

        public static int agregar(Compra com)
        {
            Transaccion transaccion = null;
            ArrayList datosCompra = null;
            try
            {
                transaccion = new Transaccion();
                transaccion.Begin();
                int id = 0;
                DBCompra db = new DBCompra();
                datosCompra = com.pasarAMR();
                id = db.agregar(datosCompra, transaccion);
                db.Dispose();
                transaccion.Commit();
                return id;
            }
            catch (ExcepcionGral exc)
            {
                transaccion.Rollback();
                throw exc;
            }
        }

        // Fin ABM de Compra

        //VACIAR TODAS LAS TABLAS
            public static void eliminar()
            {
                try
                {
                    DBPremio dbPre = new DBPremio();
                    dbPre.eliminar();
                    dbPre.Dispose();
                    DBUsuario dbusr = new DBUsuario();
                    dbusr.eliminar();
                    dbusr.Dispose();
                    DBCompra dbCom = new DBCompra();
                    dbCom.eliminar();
                    dbCom.Dispose();
                    DBCanje dbCan = new DBCanje();
                    dbCan.eliminar();
                    dbCan.Dispose();
                    DBCliente db = new DBCliente();
                    db.eliminar();
                    db.Dispose();
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

        //  Canje de Premios

            public static void canjearPremio(int idPremio, Cliente cliente)
            {
                ExcepcionGral ex = null;
                Premio p = ASupermercado.traerPremio(idPremio);
                if (ASupermercado.calcularPuntajeTotal(cliente) >= p.CantPuntos && p.CantStock > 0)
                {
                    // aca tengo que elimiar 1 del premio, crear el canje
                    Transaccion t = new Transaccion();
                    try
                    {
                        t.Begin();

                        Canje c = new Canje(10, cliente, p, DateTime.Now);

                        ArrayList al = c.pasarAMR();
                        p.CantStock -= 1; // resto uno al stock
                        ArrayList alPremio = p.pasarAMR();

                        DBCanje dbCanje = new DBCanje();
                        dbCanje.agregar(al, t); // agrega el canje a la base de datos
                        dbCanje.Dispose();
                        DBPremio dbPremio = new DBPremio();
                        dbPremio.modificar(alPremio, t);
                        dbPremio.Dispose();

                        t.Commit();
                    }
                    catch (ExcepcionGral exc)
                    {
                        t.Rollback();
                        throw exc;
                    }

                }
                else if (ASupermercado.calcularPuntajeTotal(cliente) < p.CantPuntos)
                {
                    
                    ex = new ExcepcionGral();
                    ex.AgregarError("La cantidad de puntos de la que dispone es menor a los puntos necesarios para canjear el premio");
                    throw ex;
                }
                else
                {
                    ex = new ExcepcionGral();
                    ex.AgregarError("No hay stock del premio");
                    throw ex;
                }
            }

        #endregion

        #region Consultas select hechas a la DB

        //Consultas de Clientes ----

            public static List<Cliente> listarTodosLosClientes()
            {
                try
                {
                    DBCliente db = new DBCliente();
                    DataSet ds = db.listarTodos();
                    List<Cliente> clientes = ASupermercado.crearListaClientes(ds);
                    return clientes;
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static bool existeClienteActivo(int dni)
            {
                try
                {
                    DBCliente db = new DBCliente();
                    bool existe = db.existeActivo(dni);
                    return existe;
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static bool existeCliente(int dni)
            {
                try
                {
                    DBCliente db = new DBCliente();
                    bool existe = db.existe(dni);
                    return existe;
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static Cliente traerCliente(int dni)
            {
                try
                {
                    DBCliente db = new DBCliente();
                    DataSet dsCli = db.traer(dni);
                    if (dsCli != null && dsCli.Tables[0].Rows.Count == 1)
                        return ASupermercado.cargarCliente(dsCli);
                    else
                        return null;
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

        //---- Fin Consultas de Clientes

        //Consultas de Usuarios

            public static List<Usuario> listarUsuariosPrivilegiados()
            {
                try
                {
                    DBUsuario db = new DBUsuario();
                    DataSet ds = db.listarPrivilegiados();
                    List<Usuario> usuarios = ASupermercado.crearListaUsuarios(ds);
                    return usuarios;
                }
                catch (ExcepcionGral exc)
                {
                    throw exc;
                }
            }

            public static int recuperarIdUsuario(int dni)
            {
                try
                {
                    DBUsuario db = new DBUsuario();
                    return db.recuperarIdUsuario(dni);
                }
                catch (ExcepcionGral exc)
                {
                    throw exc;
                }
            }

            public static Usuario traerUsuario(int dni, int id)
            {
                try
                {
                    DBUsuario db = new DBUsuario();
                    DataSet dsUsu = db.traer(dni, id);
                    if (dsUsu != null && dsUsu.Tables[0].Rows.Count == 1)
                        return ASupermercado.cargarUsuario(dsUsu);
                    else
                        return null;
                }
                catch (ExcepcionGral exc)
                {
                    throw exc;
                }
            }

            public static Usuario traerUsuario(string usuario, string contrasenia)
            {
                try
                {
                    DBUsuario db = new DBUsuario();
                    DataSet dsUsu = db.traer(usuario, contrasenia);
                    if (dsUsu != null && dsUsu.Tables[0].Rows.Count == 1)
                        return ASupermercado.cargarUsuario(dsUsu);
                    else
                        return null;
                }
                catch (ExcepcionGral exc)
                {
                    throw exc;
                }
            }

            public static bool existeUsuario(string usuario)
            {
                //bool existe;
                try
                {
                    DBUsuario db = new DBUsuario();
                    return db.existe(usuario);
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

        //---- Fin Consultas de Usuarios

       //Consultas de Premios ----

            public static List<Premio> listarTodosLosPremios()
            {
                try
                {
                    DBPremio db = new DBPremio();
                    DataSet ds = db.listarTodos();
                    List<Premio> premios = ASupermercado.crearListaPremios(ds);
                    return premios;
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static bool existePremio(int cod)
            {
                try
                {
                    DBPremio db = new DBPremio();
                    bool existe = db.existe(cod);
                    return existe;
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static Premio traerPremio(int cod)
            {
                try
                {
                    DBPremio db = new DBPremio();
                    DataSet dsPre = db.traer(cod);
                    if (dsPre != null && dsPre.Tables[0].Rows.Count == 1)
                        return ASupermercado.cargarPremio(dsPre);
                    else
                        return null;
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static int calcularIdPremio()
            {
                try
                {
                    DBPremio db = new DBPremio();
                    return db.calcularId();
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            //---- Fin Consultas de Premios

            //Consultas de Compras ---- Jessi 05/12

            public static List<Compra> listarTodasLasCompras()
            {
                try
                {
                    DBCompra db = new DBCompra();
                    DataSet ds = db.listarTodas();
                    List<Compra> compras = ASupermercado.crearListaCompras(ds);
                    return compras;
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static bool existeCompra(int cod)
            {
                try
                {
                    DBCompra db = new DBCompra();
                    bool existe = db.existe(cod);
                    return existe;
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static Compra traerCompra(int cod)
            {
                try
                {
                    DBCompra db = new DBCompra();
                    DataSet dsCom = db.traer(cod);
                    if (dsCom != null && dsCom.Tables[0].Rows.Count == 1)
                        return ASupermercado.cargarCompra(dsCom);
                    else
                        return null;
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static int calcularIdCompra()
            {
                try
                {
                    DBCompra db = new DBCompra();
                    return db.calcularId();
                }
                catch (ExcepcionGral exc)
                { throw exc; }
            }

            public static int calcularPuntajeTotal(Cliente cli)
            {
                DBCompra dbCom = new DBCompra();
                int puntosCompra = dbCom.sumarPuntaje(cli.Dni);
                DBCanje dbCan = new DBCanje();
                int puntosCanje = dbCan.sumarPuntaje(cli.Dni);
                int puntajeTotal = puntosCompra - puntosCanje;
                return puntajeTotal;
            }

            //---- Fin Consultas de Compras
            
        #endregion

        #region creacion de los List a partir de los dataset recuperados de la DB

            //---- Clientes
            private static List<Cliente> crearListaClientes(DataSet ds)
            {
                List<Cliente> clientes = new List<Cliente>();
                Cliente cli = null;
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    if (RecuperarAtributo.Cadena(r, "CLI_Tipo") == "Especial")
                        cli = new CEspecial();
                    else if (RecuperarAtributo.Cadena(r, "CLI_Tipo") == "Comun")
                        cli = new CComun();

                    cli.Dni = RecuperarAtributo.Entero(r, "CLI_Dni");
                    cli.Nombre = RecuperarAtributo.Cadena(r, "CLI_Nombre");
                    cli.Apellido = RecuperarAtributo.Cadena(r, "CLI_Apellido");
                    cli.Telefono = RecuperarAtributo.Cadena(r, "CLI_Telefono");
                    cli.Direccion = RecuperarAtributo.Cadena(r, "CLI_Direccion");
                    cli.Ciudad = RecuperarAtributo.Cadena(r, "CLI_Ciudad");
                    cli.Provincia = RecuperarAtributo.Cadena(r, "CLI_Provincia");
                    cli.Mail = RecuperarAtributo.Cadena(r, "CLI_Mail");
                    clientes.Add(cli);

                }
                return clientes;

            }

            //---- Usuarios
            private static List<Usuario> crearListaUsuarios(DataSet ds)
            {
                List<Usuario> usuarios = new List<Usuario>();
                Usuario usu = null;
                Cliente cli = null;
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    if(Validaciones.EsVacio(RecuperarAtributo.Entero(r, "CLI_Dni")))
                        usu = new UPrivilegiado();
                    else
                    {
                        usu = new UComun();
                        cli = ASupermercado.traerCliente(RecuperarAtributo.Entero(r,"CLI_Dni"));
                        usu.Cliente = cli;
                    }
                    usu.User = RecuperarAtributo.Cadena(r, "USU_Usuario");
                    usu.Contrasenia = RecuperarAtributo.Cadena(r, "USU_Contrasenia");
                    usuarios.Add(usu);
                }
                return usuarios;
            }

            //---- Premios
            private static List<Premio> crearListaPremios(DataSet ds)
            {
                List<Premio> premios = new List<Premio>();
                Premio pre;
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    pre = new Premio();
                    pre.Codigo = RecuperarAtributo.Entero(r, "PRE_Codigo");
                    pre.Descripcion = RecuperarAtributo.Cadena(r, "PRE_Descripcion");
                    pre.CantPuntos = RecuperarAtributo.Entero(r, "PRE_CantPuntos");
                    pre.CantStock = RecuperarAtributo.Entero(r, "PRE_CantStock");
                    pre = new Premio(pre.Codigo, pre.Descripcion, pre.CantPuntos, pre.CantStock);
                    premios.Add(pre);
                }

                return premios;
            }

            //---- Compras
            private static List<Compra> crearListaCompras(DataSet ds)
            {
                List<Compra> compras = new List<Compra>();
                Compra com;
                int dni;
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    com = new Compra();
                    com.Codigo = RecuperarAtributo.Entero(r, "COM_Codigo");
                    dni = RecuperarAtributo.Entero(r, "CLI_Dni");
                    com.Cliente = ASupermercado.traerCliente(dni);
                    com.Fecha = RecuperarAtributo.Fecha(r, "COM_Fecha");
                    com.Importe = RecuperarAtributo.Decimal(r, "COM_Importe");
                    com.Puntaje = RecuperarAtributo.Entero(r, "COM_Puntaje");
                    com = new Compra(com.Codigo, com.Cliente, com.Fecha, com.Importe, com.Puntaje);
                    compras.Add(com);
                }

                return compras;
            }
        #endregion

        #region creación de 1 objeto a partir de un dataset recuperado de la DB
        
            private static Cliente cargarCliente(DataSet ds)
            {
                Cliente cli = null;
                DataRow r = ds.Tables[0].Rows[0];
                if (RecuperarAtributo.Cadena(r, "CLI_Tipo") == "Especial")
                    cli = new CEspecial();
                else if (RecuperarAtributo.Cadena(r, "CLI_Tipo") == "Comun")
                    cli = new CComun();

                cli.Dni = RecuperarAtributo.Entero(r, "CLI_Dni");
                cli.Nombre = RecuperarAtributo.Cadena(r, "CLI_Nombre");
                cli.Apellido = RecuperarAtributo.Cadena(r, "CLI_Apellido");
                cli.Telefono = RecuperarAtributo.Cadena(r, "CLI_Telefono");
                cli.Direccion = RecuperarAtributo.Cadena(r, "CLI_Direccion");
                cli.Ciudad = RecuperarAtributo.Cadena(r, "CLI_Ciudad");
                cli.Provincia = RecuperarAtributo.Cadena(r, "CLI_Provincia");
                cli.Mail = RecuperarAtributo.Cadena(r, "CLI_Mail");
                return cli;
            }

            private static Premio cargarPremio(DataSet ds)
            {
                Premio pre = new Premio();
                DataRow r = ds.Tables[0].Rows[0];
                pre.Codigo = RecuperarAtributo.Entero(r, "PRE_Codigo");
                pre.Descripcion = RecuperarAtributo.Cadena(r, "PRE_Descripcion");
                pre.CantPuntos = RecuperarAtributo.Entero(r, "PRE_CantPuntos");
                pre.CantStock = RecuperarAtributo.Entero(r, "PRE_CantStock");
                return pre;
            }

            private static Usuario cargarUsuario(DataSet ds)
            {
                Usuario usu;
                DataRow r = ds.Tables[0].Rows[0];
                if (Validaciones.EsVacio(RecuperarAtributo.Entero(r, "CLI_Dni")))
                    usu = new UPrivilegiado();
                else
                    usu = new UComun();
                usu.User = RecuperarAtributo.Cadena(r, "USU_Usuario");
                usu.Contrasenia = RecuperarAtributo.Cadena(r, "USU_Contrasenia");
                try
                {
                    DBCliente db = new DBCliente();
                    DataSet dsCli = db.traer(RecuperarAtributo.Entero(r, "CLI_Dni"));
                    if (dsCli != null && dsCli.Tables[0].Rows.Count == 1)
                        usu.Cliente = ASupermercado.cargarCliente(dsCli);
                    else
                        usu.Cliente = null;
                }
                catch (ExcepcionGral exc)
                {
                    throw exc;
                }
                return usu;
            }

            private static Compra cargarCompra(DataSet ds)
            {
                Compra com = new Compra();
                DataRow r = ds.Tables[0].Rows[0];
                com.Codigo = RecuperarAtributo.Entero(r, "COM_Codigo");
                int dni = RecuperarAtributo.Entero(r, "CLI_Dni");
                com.Cliente = ASupermercado.traerCliente(dni);
                com.Fecha = RecuperarAtributo.Fecha(r, "COM_Fecha");
                com.Importe = RecuperarAtributo.Decimal(r, "COM_Importe");
                return com;
            }

        #endregion

        #region Metodos extra

            public static int calcularPuntajeCompra(Cliente cli, double importe)
            {
                int puntaje = cli.calcularPuntos(importe);
                return puntaje;
            }

        #endregion

    }
}
