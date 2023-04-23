using Entidades;

namespace Ejer_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°22";

            NumeroBinario numBinario = "1010";
            NumeroDecimal numDecimal = 9;

            string auxBinario = (string)numBinario;
            double auxDecimal = (double)numDecimal;
            Console.WriteLine($"El numero binario es: {auxBinario}");
            Console.WriteLine($"El numero decimal es: {auxDecimal}");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Binario + decimal");
            Console.WriteLine(numBinario + numDecimal);
            Console.WriteLine("Binario - decimal");
            Console.WriteLine(numBinario - numDecimal);

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Decimal + Binario");
            Console.WriteLine(numDecimal + numBinario);
            Console.WriteLine("Decimal + Binario");
            Console.WriteLine(numDecimal - numBinario);

            Console.WriteLine("-----------------------------------");

            if (numBinario == numDecimal)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }
        }
    }
}