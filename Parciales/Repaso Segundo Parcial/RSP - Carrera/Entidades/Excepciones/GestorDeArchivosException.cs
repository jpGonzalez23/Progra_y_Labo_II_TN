using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class GestorDeArchivosException : Exception
    {
        /// <summary>
        /// Constructor para capturar las excepciones
        /// </summary>
        /// <param name="message">Recibe un mensaje</param>
        public GestorDeArchivosException(string? message) : base(message)
        {
        }

        /// <summary>
        /// Sobrecarga, Metodo para capturar las excepciones
        /// </summary>
        /// <param name="message">Recibe un mensaje</param>
        /// <param name="innerException">Recibe una excepcion</param>
        public GestorDeArchivosException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
