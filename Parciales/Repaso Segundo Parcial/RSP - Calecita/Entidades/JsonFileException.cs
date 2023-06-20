using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class JsonFileException : Exception
    {
        public JsonFileException(string message) : base(message)
        {
        }

        public JsonFileException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
