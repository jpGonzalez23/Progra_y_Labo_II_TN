namespace Ejer_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°2";

            int numero;
            double resulCuadrado;
            double resulCubo;

            Console.WriteLine("Ingrese un numero mayor a cero");
            int.TryParse(Console.ReadLine(), out numero);

            while (numero < 1)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.WriteLine("Ingrese un numero mayor a cero");
            }

            resulCuadrado = Math.Pow(numero, 2);
            resulCubo = Math.Pow(numero, 3);

            Console.WriteLine($"El resultado del cuadrado del numero {numero}, es {resulCuadrado}");
            Console.WriteLine($"El resultado del cubo del numero {numero}, es {resulCubo}");

            Console.ReadKey();
        }
    }
}