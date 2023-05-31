using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializar<T,V>:IGuardar<T,V>
    {
        private object obj;

        public Serializar(object obj)
        {
            this.obj = obj;
        }

        public bool Guardad()
        {
            return true;
        }

        public string Leer()
        {
            return Convert.ChangeType(this.obj, typeof(string), CultureInfo.InvariantCulture).ToString();
        }
    }
}
