using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class FileManagerException : Exception
    {
        /// <summary>
        /// Constructor para el caso de excepcion con un parametro
        /// </summary>
        /// <param name="message">Recibe el mensaje</param>
        public FileManagerException(string message) : base(message)
        {
        }

        /// <summary>
        /// Sobrecarga del Constructor
        /// </summary>
        /// <param name="message">Menseja a recibir</param>
        /// <param name="innerException">Excepcion a recibir</param>
        public FileManagerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
