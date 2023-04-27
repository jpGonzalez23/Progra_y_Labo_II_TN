using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, EColores color, short cilindradas) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindradas;
        }
        /*
        public string MostrarMoto()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine(base.Mostrar());
            mensaje.AppendLine($"Cilindrada: {this.cilindrada}");

            return mensaje.ToString();
        }
        */
    }
}
