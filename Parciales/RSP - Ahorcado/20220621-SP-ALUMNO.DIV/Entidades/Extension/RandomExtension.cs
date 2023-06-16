using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Extension
{
    //10.	Extenderá la clase Random la cual retornará un valor de Id aleatorio
    //desde 1 hasta el valor recibido por parámetro.
    public static class RandomExtension
    {
        /// <summary>
        /// Metodo para retornar un ID aleatorio
        /// </summary>
        /// <param name="value">Recibe un valor instanciado, valor inicial</param>
        /// <param name="hasta">Hasta donde se detiene, valor final </param>
        /// <returns></returns>
        public static int GetRandomId(this Random value, int hasta)
        {
            return value.Next(1, hasta);
        }
    }
}
