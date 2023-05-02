namespace Entidades
{
    public class Cliente
    {
        private int numero;
        private string nombre;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero) 
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set 
            { 
                this.nombre = value; 
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public static bool operator ==(Cliente a, Cliente b)
        {
            return a.numero == b.numero;
        }

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }
    }
}