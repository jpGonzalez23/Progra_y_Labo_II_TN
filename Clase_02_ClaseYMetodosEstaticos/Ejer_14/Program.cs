using Entidades;

namespace Ejer_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            int opcion;
            double ladoCuadrado;
            double baseTriangulo;
            double alturaTringulo;
            double radioCirculo;

            Console.Write("Ingres una opción:\n1-Calculo de Area de un Cuadrado\n2-Calculo de Area de un Triangulo\n3-Calculo de Area de un Circulo\nSu opción es: ");
            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el lado del cuadrado: ");
                    double.TryParse(Console.ReadLine(), out ladoCuadrado);

                    Console.Write("El area del cuadrado es: " + CalculoDeArea.CalculoCuadrado(ladoCuadrado));
                   break;

                case 2:
                    Console.Write("Ingrese la altura del triangulo: ");
                    double.TryParse(Console.ReadLine(), out alturaTringulo);

                    Console.Write("Ingrese la base del triangulo: ");
                    double.TryParse(Console.ReadLine(), out baseTriangulo);

                    Console.Write("El area del Triangulo: " + CalculoDeArea.CalculoTriangulo(baseTriangulo, alturaTringulo));
                   break;

                case 3:
                    Console.Write("Ingrese el radio del circulo: ");
                    double.TryParse(Console.ReadLine(), out radioCirculo);

                    Console.Write("El area de un circulo es: " + CalculoDeArea.CalculoCirculo(radioCirculo));
                   break;
            }
        }
    }
}