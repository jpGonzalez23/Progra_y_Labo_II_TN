namespace Ejer_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°9";

            int altura;

            Console.WriteLine("Ingrese la altura de la piramide: ");
            int.TryParse(Console.ReadLine(), out altura);

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
    }
}