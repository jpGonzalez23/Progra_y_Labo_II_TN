using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Calcular(double numeroUno, double numeroDos, string operacion)
        {
            double respuesta = 0;

            if (operacion == "+")
            {
                respuesta = numeroUno + numeroDos;
            }

            if (operacion == "-")
            {
                respuesta = numeroUno - numeroDos;
            }

            if (operacion == "*")
            {
                respuesta = numeroUno * numeroDos;
            }

            if (operacion == "/")
            {
                if (Validar(numeroDos))
                {
                    respuesta = numeroUno / numeroDos;
                }
                else
                {
                    Console.Write("No es divisible por 0");
                }
            }

            return respuesta;
        }

        private static bool Validar(double numeroDos)
        {
            if (numeroDos != 0)
            {
                return true;
            }
            return false;
        }
    }
}
