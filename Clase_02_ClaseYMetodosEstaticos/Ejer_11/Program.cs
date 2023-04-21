using Entidades;

namespace Ejer_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°11";

            int numero;
            int min = 0;
            int max = 0;
            int acumulador = 0;
            int bandera = 0;
            int i = 0;
            float promedio;

            for (i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el numero {i}: ");
                int.TryParse(Console.ReadLine(), out numero);

                if (Validacion.Validar(numero, -100, 100))
                {
                    acumulador += numero;

                    if (bandera == 0)
                    {
                        max = numero;
                        min = numero;
                        bandera = 1;
                    }
                    else if(bandera == 0 || numero > max)
                    {
                        max = numero;
                    }
                    else
                    {
                        min = numero;
                    }
                }
                else
                {
                    Console.Write("Error!!\nIngrese un valor entre -100 y 100\n");
                }
            }

            promedio = acumulador / i;

            Console.Write($"El numero maximo es: {max}\nEl minimo es: {min}\nY el promedio es: {promedio}");
            Console.ReadKey();


        }
    }
}