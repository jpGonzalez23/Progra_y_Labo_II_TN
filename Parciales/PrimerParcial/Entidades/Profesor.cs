using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private string email;
        private EMateria materiaAsignada;

        public Profesor(int dni) : base(dni) { } 
        public Profesor(int dni, string email) : this(dni)
        {
            this.email = email;
        }
        public Profesor(int dni, string email, EMateria materiaAsignadas) : this(dni, email)
        {
            this.materiaAsignada = materiaAsignadas;
        }

        public override string Informar
        {
            get
            {
                return $"Profesor - {this.MostrarDatos()}";
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Email - {this.email}");
            sb.AppendLine($"Materia asignada: {this.materiaAsignada}");

            return sb.ToString();
        }

        public bool Evaluar(Alumno alumno)
        {
            return alumno[this.materiaAsignada].Count > 0;
        }

        public override string ToString()
        {
            return $"Profesor - {this.materiaAsignada}";
        }
    }
}
