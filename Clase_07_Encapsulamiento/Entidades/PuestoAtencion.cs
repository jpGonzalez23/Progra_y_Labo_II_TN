using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public static int NumeroActual
        {
            get
            {
                return ++PuestoAtencion.numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {

        }


    }
}
