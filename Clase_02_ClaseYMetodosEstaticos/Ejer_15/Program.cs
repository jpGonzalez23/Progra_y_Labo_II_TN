using Entidades;

namespace Ejer_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°15";

            double numeroUno;
            double numeroDos;
            string opcion;

            Console.Write("Ingrese el numero uno: ");
            double.TryParse(Console.ReadLine(), out numeroUno);

            Console.Write("Ingrese el numero dos: ");
            double.TryParse(Console.ReadLine(), out numeroDos);

            Console.Write("Seleccion una operacion (+, -, *, /): ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "+":
                    Console.WriteLine("La suma es: " + Calculadora.Calcular(numeroUno, numeroDos, "+"));
                    break;

                case "-":
                    Console.WriteLine("La resta es: " + Calculadora.Calcular(numeroUno, numeroDos, "-"));
                    break;

                case "*":
                    Console.WriteLine("La multiplicación es: ", Calculadora.Calcular(numeroUno, numeroDos, "*"));
                    break;

                case "/":
                    Console.WriteLine("La división es: ", Calculadora.Calcular(numeroUno, numeroDos, "/"));
                    break;
            }
    }
}