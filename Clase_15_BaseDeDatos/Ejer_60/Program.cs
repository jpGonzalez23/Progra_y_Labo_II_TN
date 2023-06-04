using Entidades;
using System.Configuration;

namespace Ejer_60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleados> listEmplados = GestorBD.GetEmplado();
            GestorBD.InsertEmpleado(new Empleados("jorge", "Lopez", 1));

            foreach (Empleados emp in listEmplados)
            {
                Console.WriteLine(emp.Nombre);
            }

            Console.WriteLine(GestorBD.GetUnEmplado(1).Apellido);

            //Console.WriteLine(ConfigurationManager.AppSettings["saludo"]);
            //Console.WriteLine(ConfigurationManager.ConnectionStrings["myConection"]);
            
        }
    }
}