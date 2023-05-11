using System.Runtime.InteropServices.ObjectiveC;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        protected int dni;

        /// <summary>
        /// Constructor de la clase persona
        /// </summary>
        /// <param name="dni"></param>
        protected Persona(int dni)
        {
            this.dni = dni;
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
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        /// <summary>
        /// Metodo para mostrar los datos de la persona
        /// </summary>
        /// <returns>Retorna un cadena de caracteres</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"DNI: {this.dni}");

            return sb.ToString();
        }

        public abstract string Informar { get; }

        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Persona otraPersona = (Persona)obj;
            return this.dni == otraPersona.dni;
        }

        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }
    }
}