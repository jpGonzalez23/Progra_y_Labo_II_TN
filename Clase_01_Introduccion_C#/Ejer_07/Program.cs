namespace Ejer_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°7";

            Console.WriteLine("Ingrese su fecha de nacimiento en formato DD/MM/AAAA: ");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            DateTime fechaActual = DateTime.Now;

            int diasVividos = 0;

            for (int i = fechaNacimiento.Year; i <= fechaActual.Year; i++)
            {
                int diasEnAnio = DateTime.IsLeapYear(i) ? 366 : 365;

                if (i == fechaNacimiento.Year)
                {
                    diasVividos += diasEnAnio - fechaNacimiento.DayOfYear;
                }
                else if (i == fechaActual.Year)
                {
                    diasVividos += fechaActual.DayOfYear;
                }
                else
                {
                    diasVividos += diasEnAnio;
                }
            }

            Console.WriteLine("Usted ha vivido " + diasVividos + " días hasta la fecha actual.");

            Console.ReadKey();
        }
    }
}