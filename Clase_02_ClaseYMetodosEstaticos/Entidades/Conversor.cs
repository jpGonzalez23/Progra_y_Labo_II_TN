using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string valorBinario = string.Empty;
            int resultDiv = numero;
            int restoDiv;

            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario;
                } while (resultDiv > 0);
            }

            return valorBinario;
        }

        public static int BinarioDecimal(string valorRecibido)
        {
            int resultado = 0;
            int cantidadCaracteres = valorRecibido.Length;
            foreach (char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }
    }
}
