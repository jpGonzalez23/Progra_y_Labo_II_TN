using Entidades;
using Entidades.ModuleVehiculoCompetencia;

namespace Ejer_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°36";

            Random azar = new Random();
            Competencia formulaUno = new Competencia(10, 5, Competencia.TipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];

            for (int i = 0; i < autos.Length; i++)
            {
                autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString());
                if ((formulaUno + autos[i]) == true)
                {
                    Console.WriteLine("Se Agrego el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                }
                else
                {
                    Console.WriteLine("No se agrego ya que la competencia esta completa: {0}", autos[i].MostrarDatos());
                }
            }

            Console.WriteLine();
            Console.WriteLine("<-------------------------------------------------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatos());

            Console.ReadKey();
        }
    }
}