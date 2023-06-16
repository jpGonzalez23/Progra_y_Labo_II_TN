using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class DataBaseManagerException : Exception
    {
        /// <summary>
        /// Cosntructor para las excepciones
        /// </summary>
        /// <param name="message">Mensaje a recibir</param>
        public DataBaseManagerException(string message) : base(message)
        {
        }

        /// <summary>
        /// Sobrecarga del constructor 
        /// </summary>
        /// <param name="message">Mensaje a recibir</param>
        /// <param name="innerException">Excepcion a recibir</param>
        public DataBaseManagerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
