namespace Ejer_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°2";
            int count = 0;
            int number = 1;

            while (count < 4)
            {
                int sum = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == number)
                {
                    Console.WriteLine(number);
                    count++;
                }

                number++;
            }
    }
}