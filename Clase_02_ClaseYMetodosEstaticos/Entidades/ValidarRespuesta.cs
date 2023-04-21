using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ValidarRespuesta
    {
        public static bool ValidarS_N(char caracter)
        {
            if (char.ToUpper(caracter) == 'S') 
            {
                return true;
            }
            return false;
        }
    }
}
