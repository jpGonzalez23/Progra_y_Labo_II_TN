using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleCentralita
{
    public class Local : Llamada
    {
        protected float costo;

        public float Costo
        {
            get { return this.CalcularCosto(); }
        }

        public Local(Llamada llamada, float costo) : this("", 5f, "", costo)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino,  float costo) 
            : base(duracion, destino, origen)
        {

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.Costo}");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }
    }
}
