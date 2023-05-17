using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleCentralita
{
    public class Centralita
    {
        private List<Llamada> llamada;
        protected string razonSocial;

        public Centralita()
        {
            this.llamada = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
    }
}
