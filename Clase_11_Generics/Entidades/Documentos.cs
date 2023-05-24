using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Documentos
    {
        private int numeroDocumentos;

        public int Numero
        {
            get { return this.numeroDocumentos; }
            protected set
            {
                if (value > 0)
                {
                    this.numeroDocumentos = value;
                }
            }
        }

        public Documentos(int numeroDocumentos)
        {
            this.numeroDocumentos = numeroDocumentos;
        }
    }
}
