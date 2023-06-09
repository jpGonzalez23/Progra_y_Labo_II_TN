﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Competencia
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {
            this.CantCombustible = 0;
            this.VueltasRestantes = 0;
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
        public override string MostrarDatos()
        {
            return base.MostrarDatos() + "\n HP: " + this.CaballosDeFuerza;
        }
        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.Escuderia == a2.Escuderia) && (a1.CaballosDeFuerza == a2.CaballosDeFuerza);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
