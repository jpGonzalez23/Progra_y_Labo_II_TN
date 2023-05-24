using Entidades;
using System;

namespace Ejer_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°38";

            Sobrescrito sobrecarga = new Sobrescrito();

            Console.WriteLine(sobrecarga.ToString());
            string obj = "¡Este es mi metodo ToString sobrescrito";
            Console.WriteLine("---------------------------------");
            Console.Write("Comparación Sobrecarga con string: ");
            Console.WriteLine(sobrecarga.Equals(obj));

            Console.WriteLine("---------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());

            Console.ReadKey();
        }
    }
}