using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Sobrescribir
    {
        protected string miAtributo;

        public Sobrescribir()
        {
            this.miAtributo = "Probar abastracto";
        }

        public abstract string MiPropiedad { get; }
        public abstract string MiMetodo();
    }
}
