namespace Ejer_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°26";

            Random random = new Random();
            int[] numero = new int[20];
            int numRandom;

            for (int i = 0; i < 20; i++)
            {
                numRandom = random.Next(-100, 100);

                while (numRandom == 0)
                {
                    numRandom = random.Next(-100, 100);
                }
                numero[i] = numRandom;
            }

            Console.WriteLine("Array de numero: ");
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, numero[i]);
            }

            Console.WriteLine("positivos ordenados en forma decreciente.");
            Array.Sort(numero, Program.OrdenDescendente);
            for (int i = 0; i < numero.Length; i++)
            {

                if (numero[i] > 0)
                    Console.WriteLine("{0} : {1}", i, numero[i]);
            }
            Console.WriteLine("negativos ordenados en forma creciente.");
            Array.Sort(numero);
            for (int i = 0; i < numero.Length; i++)
            {

                if (numero[i] < 0)
                    Console.WriteLine("{0} : {1}", i, numero[i]);
            }


            Console.ReadKey();
        }

        public static int OrdenDescendente(int a, int b)
        {
            return b - a;
        }
    }
}