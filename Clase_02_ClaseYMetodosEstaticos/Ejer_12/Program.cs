using Entidades;

namespace Ejer_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°12";

            int numero;
            int acumulador = 0;
            char caracter;

            do
            {
                Console.Write("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    acumulador += numero;
                }

                Console.Write("¿Desea seguir ingresando otro numero? (S/N)");
                char.TryParse(Console.ReadLine(), out caracter);

            } while (ValidarRespuesta.ValidarS_N(caracter));


            Console.WriteLine($"El resultado de la suma es: {acumulador}");
            Console.ReadKey();
        }
    }
}