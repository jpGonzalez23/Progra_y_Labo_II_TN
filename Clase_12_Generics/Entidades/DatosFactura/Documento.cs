﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DatosFactura
{
    public class Documento
    {
        private int numero;
        public Documento(int numero)
        {
            this.numero = numero;
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }
    }
}
