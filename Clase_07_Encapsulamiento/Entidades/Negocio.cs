using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                if(this.ClientesPendientes > 0)
                {
                    return this.clientes.Dequeue();
                }
                return null;
            }
            set
            {
                bool reult = this + value;
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente item in n.clientes) 
            {
                if(c == item)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
    }
}
