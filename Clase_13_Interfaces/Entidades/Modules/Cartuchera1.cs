using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modules
{
    public class Cartuchera1
    {
        private List<Interfaces.IAcciones> acciones;

        public Cartuchera1()
        {
            this.acciones = new List<Interfaces.IAcciones>();
        }

        public bool ProbarElementos()
        {
            int qBoligrafos = 0;
            int conut = 0;

            foreach (Interfaces.IAcciones item in this.acciones)
            {
                if (item.UnidadDeEscritura is Modules.Boligrafo)
                {
                    item.Recargar(20);
                }
                else
                {
                    item.UnidadDeEscritura -= 1;
                }
                qBoligrafos++;
            }

            if (conut == qBoligrafos)
            {
                return true;
            }
            return false;
        }
    }
}
