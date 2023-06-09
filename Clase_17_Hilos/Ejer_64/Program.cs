using Entidades;

namespace Ejer_64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 64";

            Caja caja1 = new Caja();
            Caja caja2 = new Caja();

            Negocio negocio = new Negocio(caja1, caja2);
            negocio.Clientes.Add("Cliente 1");
            negocio.Clientes.Add("Cliente 2");
            negocio.Clientes.Add("Cliente 3");
            negocio.Clientes.Add("Cliente 4");
            negocio.Clientes.Add("Cliente 5");

            Task asignarCajas = new Task(negocio.AsignarCaja);
            Task atenderCaja1 = new Task(caja1.AtenderClientes);
            Task atenderCaja2 = new Task(caja2.AtenderClientes);

            asignarCajas.Start();
            asignarCajas.Wait(); // Esperar a que se asignen los clientes antes de comenzar la atención

            atenderCaja1.Start();
            atenderCaja2.Start();

            Task.WaitAll(atenderCaja1, atenderCaja2); // Esperar a que ambas cajas terminen de atender

            Console.WriteLine("Todos los clientes han sido atendidos.");
        }
    }
}