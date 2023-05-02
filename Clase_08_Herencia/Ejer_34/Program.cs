using Entidades;

namespace Ejer_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°34";
            Camion camioncito = new Camion(500, 8, 4, 2, EColores.Azul);
            Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga: {4}", camioncito.cantRuedas, camioncito.cantPuertas, camioncito.color, camioncito.cantMarchas, camioncito.pesoCarga);
            Console.WriteLine("--------------");
            Automovil autito = new Automovil(3, 6, 4, 4, EColores.Gris);
            Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.cantRuedas, autito.cantPuertas, autito.color, autito.cantMarchas, autito.cantPasajeros);
            Console.WriteLine("-----------");
            Moto motito = new Moto(2, 0, EColores.Rojo, 4);
            Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.cantRuedas, motito.cantPuertas, motito.color, motito.cilindrada);
        }
    }
}