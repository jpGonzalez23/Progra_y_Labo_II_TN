using System.Text;

namespace Entidades
{
    public abstract class Comida
    {
        public enum EIngredientes
        {
            ADHERESO,
            QUESO = 10,
            CEBOLLA = 8,
            LECHUGA = 7,
            TOMATE=9,
            JAMON = 12,
            HUEVO = 13,
            PANCETA = 15
        };

        protected List<EIngredientes> ingredientes;
        private string nombre;

        protected Comida(string nombre) : this(nombre, new List<EIngredientes>()){ }
        protected Comida(string nombre, List<EIngredientes> ingredientes) 
        {
            this.ingredientes = ingredientes;
            this.nombre = nombre;
        }

        public virtual double Costo
        {
            get { return this.CalcularCosto(); }
        }

        public virtual string Descripcion
        {
            get
            {
                return this.MostrarDatos();
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                this.nombre = value;
            }
        }

        protected abstract string AgregarIngredientes(EIngredientes ingredientes);

        protected abstract double CalcularCosto();

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Ingresites: {this.Descripcion}");
            sb.AppendLine($"Costo: {this.Costo}");

            return sb.ToString();
        }

        public static bool operator ==(Comida c, EIngredientes i)
        {
            if (c.ingredientes.Contains(i))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Comida c, EIngredientes i) 
        { 
            return !(c == i);
        }

        public static string operator +(Comida c, EIngredientes i)
        {
            return c.AgregarIngredientes(i);
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Comida && ((Comida)obj).Nombre == this.nombre;
        }
    }
}