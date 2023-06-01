using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DatosFactura
{
    public class Recibo : DatosFactura.Documento
    {
        public Recibo():this(0) { }
        public Recibo(int numero) : base(numero) { }
    }
}
