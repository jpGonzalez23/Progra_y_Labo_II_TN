using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadorEstrellas;

        public EquipoFutbol(string nombre) : base (nombre) { }
        public EquipoFutbol(string nombre, bool jugadorEstrellas) : base (nombre)
        {
            this.jugadorEstrellas = false;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Futbool - ");
            
            sb.AppendLine(base.MostrarDatos()); 

            return sb.ToString();
        }

        public override int GetDificultad()
        {
            int dififultad = new Random().Next(7, 10);

            if (jugadorEstrellas)
            {
                dififultad *= 2;
            }

            return dififultad;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
