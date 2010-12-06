using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Excepciones
{
    public class EntidadError
    {
        #region atributos

            private string mensaje; //Mensaje de error
            private string msgLB; //objeto donde se mostrará el error
            private string icono; //El icono que tiene que mostrar
            private string iconoPB;

        #endregion

        #region constructores

            public EntidadError()
            {
                msgLB = "";
                mensaje = "";
                icono = "";
                IconoPB = "";
            }

        #endregion

        #region propiedades

            public string Mensaje
            {
                get { return mensaje; }
                set { mensaje = value; }
            }

            public string MsgLB
            {
                get { return msgLB; }
                set { msgLB = value; }
            }

            public string Icono
            {
                get { return icono; }
                set { icono = value; }
            }

            public string IconoPB
            {
                get { return iconoPB; }
                set { iconoPB = value; }
        }

        #endregion
    }
}
