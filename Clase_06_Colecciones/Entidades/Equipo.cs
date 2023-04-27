namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadorList;
        private string nombre;

        private Equipo()
        {
            this.jugadorList = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if(e.jugadorList.Count < e.cantidadDeJugadores)
            {
                foreach(Jugador item in e.jugadorList)
                {
                    if(item == j)
                    {
                        return false;
                    }
                }
                e.jugadorList.Add(j);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}