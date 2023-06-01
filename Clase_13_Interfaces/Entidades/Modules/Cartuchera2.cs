using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modules
{
    public class Cartuchera2
    {
        private List<Lapiz> lapizList;
        private List<Boligrafo> boligrafoList;
        public Cartuchera2()
        {
            this.lapizList = new List<Lapiz>();
            this.boligrafoList = new List<Boligrafo>();
        }

        public List<Lapiz> LapizList { get { return this.lapizList; } }
        public List<Boligrafo> BoligrafoList { get { return this.boligrafoList; } }

        public bool ProbarElementos()
        {
            int cont = 0;
            foreach (Lapiz lapiz in this.LapizList)
            {
                if (((Interfaces.IAcciones)lapiz).UnidadDeEscritura > 0)
                {
                    ((IAcciones)lapiz).UnidadDeEscritura -= 1;
                }
            }
            foreach (Boligrafo boligrafo in this.boligrafoList)
            {
                if (boligrafo.UnidadDeEscritura < 1)
                {
                    boligrafo.Recargar(20);
                }
                else
                {
                    boligrafo.UnidadDeEscritura -= 1;
                    cont++;
                }
            }

            if (cont == this.boligrafoList.Count)
            {
                return true;
            }
            return false;
        }
    }
}
