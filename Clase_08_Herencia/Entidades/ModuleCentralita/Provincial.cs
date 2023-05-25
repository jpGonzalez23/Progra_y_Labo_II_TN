﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleCentralita
{
    public class Provincial : Llamada
    {
        public enum ETipoFranja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        };

        protected ETipoFranja franja;

        public Provincial(ETipoFranja franja, Llamada llamada)
            : this("", franja, 0, "")
        {
            this.franja = franja;
        }

        public Provincial(string origen, ETipoFranja franja, float duracion, string destino)
            : base(duracion, destino, origen)
        {

        }

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CalcularCosto()}");
            sb.AppendLine($"Franja: {this.franja}");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float costo = 0;
            
            if (franja is ETipoFranja.Franja_1)
            {
                costo = 0.99f * base.duracion;
            }
            else if (franja is ETipoFranja.Franja_2)
            {
                costo = 1.25f * base.duracion;
            }
            else
            {
                costo = 0.66f * base.duracion;
            }

            return costo;
        }
    }
}
