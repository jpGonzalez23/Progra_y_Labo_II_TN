using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        public short cantRuedas;
        public short cantPuertas;
        public EColores color;

        public VehiculoTerrestre(short cantRuedas, short cantPuertas, EColores color)
        {
            this.cantRuedas = cantRuedas;
            this.cantPuertas = cantPuertas;
            this.color = color;
        }
        /*
        public short CantRuedas
        {
            get
            {
                return this.cantRuedas;
            }
            set
            {
                this.cantRuedas = value;
            }
        }

        public short CantPuerta
        {
            get
            {
                return this.cantPuertas;
            }
            set
            {
                this.CantPuerta = value;
            }
        }

        public EColores Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Cantidad de ruedas: {this.cantRuedas}");
            mensaje.AppendLine($"Cantidad de puertas: {this.cantPuertas}");
            mensaje.AppendLine($"Color: {this.color}");

            return mensaje.ToString();
        }
        */
    }
}
