using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class GestorBaseDeDatosException : Exception
    {
        /// <summary>
        /// Constructor para capturar las excepciones
        /// </summary>
        /// <param name="message">Recibe un mensaje</param>
        public GestorBaseDeDatosException(string? message) : base(message)
        {
        }

        /// <summary>
        /// Sobrecarga, Metodo para capturar las excepciones
        /// </summary>
        /// <param name="message">Recibe un mensaje</param>
        /// <param name="innerException">Recibe una excepcion</param>
        public GestorBaseDeDatosException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
