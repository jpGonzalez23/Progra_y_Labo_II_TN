using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadorEstrella;

        public EquipoFutbol(string nombre) : base(nombre) { }
        public EquipoFutbol(string nombre, bool jugadorEstrella) : this(nombre)
        {
            this.jugadorEstrella = false;
        }

        public override int GetDificultad()
        {
            if (this.jugadorEstrella) 
            {
                Random rd = new Random();
                int numRd = rd.Next(7,10);

            }
        }
    }
}
