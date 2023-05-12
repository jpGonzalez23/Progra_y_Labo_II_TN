using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        public int pesoCarga;
        public short cantMarchas;

        public Camion(int pesoCarga, short cantMarchas, short cantRuedas, short cantPuertas, EColores color) : base(cantRuedas, cantPuertas, color)
        {
            this.pesoCarga = pesoCarga;
            this.cantMarchas = cantMarchas;
        }
        /*
        public string MostrarCamion()
        {
            StringBuilder mensaje = new StringBuilder();

            //mensaje.AppendLine(base.Mostrar());
            mensaje.AppendLine($"Peso de carga: {this.pesoCarga}");

            return mensaje.ToString();
        }*/
    }
}
