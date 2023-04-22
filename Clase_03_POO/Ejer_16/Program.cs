using Entidades;

namespace Ejer_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°16";

            Alumno alumnoUno = new Alumno("Gonzalez", "Juan Pablo", 100);
            alumnoUno.Estudiar(6, 3);
            alumnoUno.CalcularFinal();
            Console.Write(alumnoUno.Mostrar());

            Alumno alumnoDos = new Alumno("Alvarenga", "Jorge", 100);
            alumnoDos.Estudiar(6, 9);
            alumnoDos.CalcularFinal();
            Console.Write(alumnoDos.Mostrar());

            Alumno alumnoTres = new Alumno("Galvan", "Mauro", 100);
            alumnoTres.Estudiar(7, 7);
            alumnoTres.CalcularFinal();
            Console.Write(alumnoTres.Mostrar());

            Console.ReadKey();
        }
    }
}