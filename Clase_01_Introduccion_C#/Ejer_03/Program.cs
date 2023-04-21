namespace Ejer_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°3";

            int numero;
            bool esPrimo = true;

            Console.Write("Ingrese un número: ");
            int.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine($"Los números primos hasta {numero} son:");

            for (int i = 0; i <= numero; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    Console.Write(i + " ");
                }
            }
    }
}