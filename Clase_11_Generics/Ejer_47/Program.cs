using Entidades;

namespace Ejer_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejecicio N°47";

            // Crear equipos de fútbol
            EquipoFutbol equipo1 = new EquipoFutbol("Equipo 1", new DateTime(2022, 1, 1));
            EquipoFutbol equipo2 = new EquipoFutbol("Equipo 2", new DateTime(2022, 2, 1));
            EquipoFutbol equipo3 = new EquipoFutbol("Equipo 3", new DateTime(2022, 3, 1));

            // Crear torneo de fútbol
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo de Fútbol");

            // Agregar equipos al torneo
            torneoFutbol += equipo1;
            torneoFutbol += equipo2;
            torneoFutbol += equipo3;

            // Mostrar información del torneo
            Console.Write(torneoFutbol.Mostrar());

            // Jugar partido
            Console.Write(torneoFutbol.JugarPartido());

            Console.WriteLine();

            // Crear equipos de básquet
            EquipoBasquet equipo4 = new EquipoBasquet("Equipo 4", new DateTime(2022, 4, 1));
            EquipoBasquet equipo5 = new EquipoBasquet("Equipo 5", new DateTime(2022, 5, 1));

            // Crear torneo de básquet
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo de Básquet");

            // Agregar equipos al torneo
            torneoBasquet += equipo4;
            torneoBasquet += equipo5;

            // Mostrar información del torneo
            Console.Write(torneoBasquet.Mostrar());

            // Jugar partido
            Console.Write(torneoBasquet.JugarPartido());

            Console.ReadLine();
        }
    }
}