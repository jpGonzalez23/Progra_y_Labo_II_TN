using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleCentralita
{
    public class Llamada
    {
        public enum ETipoLlamada { Local, Provincíal, Todas };

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nro Origen: {this.NroOrigen}");
            sb.AppendLine($"Nro Destipo: {this.NroDestino}");
            sb.AppendLine($"Duración: {this.Duracion}");

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.duracion);
        }

    }
}
