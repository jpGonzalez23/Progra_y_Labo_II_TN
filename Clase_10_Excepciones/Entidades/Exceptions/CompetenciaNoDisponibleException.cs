using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) 
            : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        public override string ToString()
        {
            StringBuilder returnAux = new StringBuilder();
            Exception ex;
            returnAux.AppendFormat("Excepción en el método {0} de la clase {1}\n", this.NombreMetodo, this.NombreClase);
            returnAux.AppendLine("Error: " + this.Message);
            ex = this.InnerException;
            while (ex != null)
            {
                returnAux.Append("Inner: " + ex.Message + "\t");
                ex = ex.InnerException;
            }
            return returnAux.ToString();
        }
    }
}
