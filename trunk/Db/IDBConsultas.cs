using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Library.Excepciones;
using System.Data;
using Library.ParaDB;

namespace Db
{
    public interface IDBConsultas
    {
        int agregar(ArrayList arr,  Transaccion t);
        void eliminar();
    }
}
