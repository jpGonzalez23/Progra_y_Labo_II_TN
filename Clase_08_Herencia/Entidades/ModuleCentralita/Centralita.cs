using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleCentralita
{
    public class Centralita
    {
        private List<Llamada> llamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.llamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get { return this.llamadas; }
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.ELlamada.Local);
            }
        }

        public float GananciasPorProvincia
        {
            get
            {
                return this.CalcularGanancia(Llamada.ELlamada.Provincíal);
            }
        }

        public float GananciasTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.ELlamada.Todas);
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganacia por local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganacia por provincia: {this.GananciasPorProvincia}");
            sb.AppendLine($"Ganacia total: {this.GananciasTotal}");

            sb.AppendLine($"Destalles de las llamadas realizadas: ");
            foreach (Llamada item in llamadas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        private float CalcularGanancia(Llamada.ELlamada tipo)
        {
            
        }

        public void OrdenarLlamadas()
        {

        }
    }
}
