using Entidades;
using Entidades.ModuleEquipoDeFutbol;

namespace Ejer_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°35";

            Jugador j1 = new Jugador("Pepe", 43903434, 2, 5);
            Jugador j2 = new Jugador("Rodri", 43456251, 5, 5);

            Equipo equipo = new Equipo(5, "GG");

            if (equipo + j1)
            {
                Console.WriteLine("Se agrego el jugador");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            Console.WriteLine($"Jugador J1: {j1.MostrarDatos()}");
            Console.WriteLine($"Jugador J2: {j2.MostrarDatos()}");
            Console.WriteLine($"Equipo: {equipo}");
        }
    }
}