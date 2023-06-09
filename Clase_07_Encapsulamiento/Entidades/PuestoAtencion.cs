﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum EPuesto
        {
            Caja1,
            Caja2,
        }

        private static int numeroActual;
        private EPuesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }

        public bool Atender(Cliente cliente)
        {
            if(cliente is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
