using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoBasket : Equipo
    {
        public enum ELiga { NBA, EuroLeague, ACB };

        private ELiga liga;

        public EquipoBasket (string nombre) : base (nombre) { }

        public EquipoBasket(string nombre, ELiga liga) : base (nombre) 
        {
            this.liga = ELiga.NBA;
        }

        public override int GetDificultad()
        {
            Random rnd = new Random();
            int dificultad;

            if (this.liga == ELiga.NBA)
            {
                dificultad = rnd.Next(8, 10);
            }
            else if(this.liga == ELiga.EuroLeague)
            {
                dificultad = rnd.Next(5, 10);
            }
            else
            {
                dificultad = rnd.Next(1, 7);
            }
            return dificultad;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Basket - ");
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
