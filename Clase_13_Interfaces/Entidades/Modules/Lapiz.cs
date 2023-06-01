using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modules
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get => ConsoleColor.Gray;
            set => throw new NotImplementedException();
        }

        float IAcciones.UnidadesDeEscritura
        {
            get => this.tamanioMina;
            set => this.tamanioMina = value;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            this.tamanioMina -= (float)texto.Length * 0.1F;
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Es Lapiz");
            sb.AppendLine($"Su color es: {((IAcciones)this).Color}");
            sb.AppendLine($"y su nivel es {((IAcciones)this).UnidadesDeEscritura}");

            return sb.ToString();
        }
    }
}
