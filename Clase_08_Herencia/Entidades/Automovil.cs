using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        public short cantMarchas;
        public int cantPasajeros;

        public Automovil(int cantPasajero, short cantMarchas, short cantRuedas, short cantPuertas, EColores color) : base(cantRuedas, cantPuertas, color)
        {
            this.cantPasajeros = cantPasajero;
            this.cantMarchas = cantMarchas;
        }
        
        /*
        public string MostrarAutomovil()
        {
            StringBuilder mensaje = new StringBuilder();

            //mensaje.AppendLine(base.Mostrar());
            mensaje.AppendLine($"cantidad de pasajeros: {this.cantPasajeros}");

            return mensaje.ToString();
        }
        */

    }
}