namespace Ejer_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°8";

            int numero;
            int valorHora;
            int horasTrabajadas;
            int antiguedad;
            int totalBruto;
            int descuento;
            int totalNeto;

            string nombre;

            Console.WriteLine("Ingrese la cantidad de empleados: ");
            int.TryParse(Console.ReadLine(), out numero);

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad (en años): ");
                int.TryParse(Console.ReadLine(), out antiguedad);

                Console.WriteLine("Ingrese las hora: ");
                int.TryParse(Console.ReadLine(), out valorHora);

                Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes: ");
                int.TryParse(Console.ReadLine(), out horasTrabajadas);

                totalBruto = valorHora * horasTrabajadas + antiguedad * 150;
                descuento = totalBruto * (int)0.13;
                totalNeto = totalBruto - descuento;

                Console.WriteLine($"Recibo del empleado: {nombre}");
                Console.WriteLine($"Antiguedad: {antiguedad}");
                Console.WriteLine($"Valor hora: {valorHora}");
                Console.WriteLine($"Total bruto: {totalBruto}");
                Console.WriteLine($"Total Descuento: {descuento}");
                Console.WriteLine($"Total Neto: {totalNeto}");
            }
    }
}