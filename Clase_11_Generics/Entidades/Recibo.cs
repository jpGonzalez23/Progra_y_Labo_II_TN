using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recibo : Documentos
    {
        public Recibo() : this(0) { }
        public Recibo(int numeroDocumento) : base(numeroDocumento) { }
    }
}
