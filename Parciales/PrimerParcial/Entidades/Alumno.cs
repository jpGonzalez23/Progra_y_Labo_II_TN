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

        private Alumno(int dni) : base(dni)
        {
            this.materiasAsignadas = new Dictionary<EMateria, List<int>>();
        }

        private Alumno(int dni, string legajo) : this(dni)
        {
            this.legajo = legajo;
        }

        public List<int> this[EMateria materia]
        {
            get
            {
                if (this == materia)
                {
                    return this.materiasAsignadas[materia];
                }
                return null;
            }
        }
        public override string Informar
        {
            get
            {
                return $"Alumno - {this.MostrarDatos()}";
            }
        }

        public bool RendirMateria(EMateria materia)
        {
            if (this == materia)
            {
                Random random = new Random();
                this[materia].Add(random.Next(1, 10));
                return true;
            }
            return false;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Legajo del alumno: {this.legajo}");
            sb.AppendLine("Materias inscriptas:");

            foreach (EMateria materia in this.materiasAsignadas.Keys)
            {
                sb.AppendLine(materia.ToString());
            }

            return sb.ToString();
        }

        public static implicit operator Alumno(string dni)
        {
            int dniInt;
            int.TryParse(dni, out dniInt);
            Alumno alumno = new Alumno(dniInt);
            alumno.legajo = $"L-{alumno.GetHashCode()}";
            return alumno;
        }

        public static bool operator ==(Alumno alumno, EMateria materia)
        {
            return alumno.materiasAsignadas.ContainsKey(materia);
        }

        public static bool operator !=(Alumno alumno, EMateria materia)
        {
            return !(alumno == materia);
        }

        public static bool operator +(Alumno alumno, EMateria materia)
        {
            if (alumno == materia)
            {
                return false;
            }
            else
            {
                alumno.materiasAsignadas.Add(materia, new List<int>());
                return true;
            }
        }

        public override string ToString()
        {
            return $"Alumno - {this.legajo}";
        }


    }
}
