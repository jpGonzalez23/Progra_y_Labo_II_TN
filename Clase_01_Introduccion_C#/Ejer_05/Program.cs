namespace Ejer_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°5";

            int numero;

            // Pedir al usuario el número máximo para calcular los centros numéricos
            Console.Write("Introduce un número entero positivo: ");
            int.TryParse(Console.ReadLine(), out numero);

            // Recorrer todos los números desde 6 hasta el número máximo
            for (int centro = 6; centro <= numero; centro++)
            {
                int sumaIzquierda = 0, sumaDerecha = 0;

                // Calcular la suma de los números a la izquierda del centro
                for (int i = 1; i < centro; i++)
                {
                    sumaIzquierda += i;
                }

                // Calcular la suma de los números a la derecha del centro
                for (int i = centro + 1; i <= numero; i++)
                {
                    sumaDerecha += i;

                    // Si la suma de la izquierda es igual a la de la derecha, se ha encontrado un centro numérico
                    if (sumaIzquierda == sumaDerecha)
                    {
                        Console.WriteLine("Centro numérico encontrado: " + centro);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}