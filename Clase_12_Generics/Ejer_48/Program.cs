using Entidades; 

namespace Ejer_48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°48";

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            // Agregar egresos y ingresos
            contabilidad += new Recibo(1010);
            contabilidad += new Factura(1001);

            // Obtener la lista de egresos e ingresos
            List<Factura> egresos = contabilidad.Egresos;
            List<Recibo> ingresos = contabilidad.Ingresos;

            // Mostrar los elementos de las listas
            Console.WriteLine("Egresos:");

            foreach (Factura egreso in egresos)
            {
                Console.WriteLine($"Número de Factura: {egreso.Numero}");
            }

            Console.WriteLine("Ingresos:");
            foreach (Recibo ingreso in ingresos)
            {
                Console.WriteLine($"Número de Recibo: {ingreso.Numero}");
            }

            Console.ReadLine();
        }
    }
}