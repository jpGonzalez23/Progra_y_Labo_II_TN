using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GuardarTexto<T,V> : IGuardar<T,V>
    {
        private string texto;

        public GuardarTexto(string texto)
        {
            this.texto = texto;
        }

        public bool Guardar()
        {
            return true;
        }

        public string Leer()
        {
            return this.texto;
        }
    }
}
