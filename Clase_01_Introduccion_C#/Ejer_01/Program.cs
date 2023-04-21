namespace Ejer_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°1";

            int numero;
            int max = 0;
            int min = 0;
            int acumulador = 0;
            int bandera = 0;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el {i} numero: ");
                int.TryParse(Console.ReadLine(), out numero);

                acumulador += numero;

                if (bandera == 0)
                {
                    max = numero;
                    min = numero;
                    bandera = 1;
                }
                else if (bandera == 0 || numero > max)
                {
                    max = numero;
                }
                else
                {
                    min = numero;
                }
            }

            promedio = acumulador / 5;

            Console.WriteLine($"El numero maximo es: {max}");
            Console.WriteLine($"El numero minimo es: {min}");
            Console.WriteLine($"El numero promedio es: {promedio}");

            Console.ReadKey();
        }
    }
}