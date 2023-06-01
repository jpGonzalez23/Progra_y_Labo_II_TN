using Entidades.DatosFactura;

namespace Ejer_48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°48";

            Random random = new Random();
            Factura[] factura = new Factura[10];
            Recibo[] recibo = new Recibo[10];
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            for (int i = 0; i < 10; i++)
            {
                factura[i] = new Factura(random.Next(0, 99999));
                recibo[i] = new Recibo(random.Next(0, 99999));
                contabilidad += factura[i];
                contabilidad += recibo[i];
            }

            Console.WriteLine(contabilidad.ToString());
            Console.ReadKey();
        }
    }
}