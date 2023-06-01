using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DatosFactura
{
    public class Factura : DatosFactura.Documento
    {
        public Factura(int numero)
            : base(numero)
        {
        }
    }
}
