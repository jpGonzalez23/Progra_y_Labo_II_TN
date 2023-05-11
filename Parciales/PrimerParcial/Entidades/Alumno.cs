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

        public override string Informar
        {
            get
            {
                string datos = MostrarDatos();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Alumno -");
                sb.Append(datos);

                if (materiasAsignadas.Count > 0)
                {
                    sb.AppendLine("Materias inscriptas:");

                    foreach (EMateria materia in materiasAsignadas.Keys)
                    {
                        sb.AppendLine($"- {materia}");
                    }
                }
                else
                {
                    sb.AppendLine("No tiene materias inscriptas.");
                }

                return sb.ToString();
            }
        }


        public List<int> this[EMateria materia]
        {
            get
            {
                if (materiasAsignadas.ContainsKey(materia))
                {
                    return materiasAsignadas[materia];
                }
                else
                {
                    return null;
                }
            }
        }

        public bool RendirMateria(EMateria materia)
        {
            if (materiasAsignadas.ContainsKey(materia))
            {
                Random rnd = new Random();
                int nota = rnd.Next(1, 11);
                materiasAsignadas[materia].Add(nota);
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Legajo del alumno: {this.legajo}");
            sb.AppendLine("Materias inscriptas:");

            foreach (EMateria materia in materiasAsignadas.Keys)
            {
                sb.AppendLine($"- {materia}");
            }

            return sb.ToString();
        }

        public static implicit operator Alumno(string dni)
        {
            int dniInt;

            if (!int.TryParse(dni, out dniInt))
            {
                return null;
            }

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

        public override int GetHashCode()
        {
            return this.dni;
        }
    }
}
