using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro(int pagigas) 
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < paginas.Count)
                {
                    return paginas[i];
                }
                else
                {
                    return "";
                }
            }
            set
            {
                if (i >= 0 && i <= paginas.Count)
                {
                    paginas[i] = value;
                }
                else if (i == paginas.Count)
                {
                    paginas.Add(value);
                }
            }
        }
    }
}
