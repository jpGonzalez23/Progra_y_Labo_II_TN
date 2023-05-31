using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private string legajo;
        private Dictionary<EMateria, List<int>> materiasAsignadas;

        private Alumno(int dni) : base(dni) { }

        private Alumno(int dni, string legajo) : this(dni)
        {
            this.legajo = legajo;
        }

        public override string Informar
        {
            get
            {
                return $"Alumno - {this.MostrarDatos()}";
            }
        }

        public List<int> this[EMateria materia]
        {
            get
            {
                if(materia == EMateria.Programacion)
                {
                    return new List<int>();
                }
                else if (materia == EMateria.Laboratorio)
                {
                    return new List<int>();
                }
            }
        }

        //public bool RendirMateria(EMateria materia)
        //{
            
        //}

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Legajo del alumno: {this.legajo}");
            sb.AppendLine($"Nombre de las materias: {this.materiasAsignadas}");

            return sb.ToString();
        }

        //public static implicit operator Alumno(string dni)
        //{

        //}

        public static bool operator ==(Alumno alumno, EMateria materia)
        {

        }

        public static bool operator !=(Alumno alumno, EMateria materia)
        {
            return !(alumno == materia);
        }

        public static bool operator +(Alumno alumno, EMateria materia)
        {
            if(alumno == materia)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"Alumno - {this.legajo}";
        }

        public override int GetHashCode()
        {
            return this.dni;
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && base.dni > 0 && base.dni < 8;
        }
    }
}
