using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface ILector
    {
        /// <summary>
        /// Definicion del metodo para obtener una nueva palabra
        /// </summary>
        /// <returns>Retorna una cadena de caracteres</returns>
        string ObtenerNuevaPalabra();
    }
}
