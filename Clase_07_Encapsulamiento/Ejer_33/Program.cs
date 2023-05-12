using Entidades;

namespace Ejer_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°33";

            int size = 10;
            Libro myInd = new Libro(size);

            myInd[9] = "Some Value";
            myInd[3] = "Another Value";
            myInd[5] = "Any Value";
            myInd[10] = "New Page";   
        }
    }
}