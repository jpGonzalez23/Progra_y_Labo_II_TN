using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string returnAux = string.Empty;

            while(numero != 0)
            {
                if(numero % 2 == 0)
                {
                    returnAux = "0" + returnAux;
                }
                else
                {
                    returnAux = "1" + returnAux;
                }

                numero /= 2;
                numero = Math.Floor(numero);
            }

            return returnAux;
        }

        public static double BinarioDecimal(string numero)
        {
            double returnAux = default(double);
            double.TryParse(numero, out returnAux);

            int residuo = 0;
            int exponente = 0;

            double acumulador = default(double);

            do
            {
                residuo = (int)returnAux % 10;
                returnAux = returnAux / 10;
                acumulador += (double)(residuo * Math.Pow(2, exponente));
                exponente++;

            } while (returnAux != 0);

            return acumulador;
        }
    }
}
