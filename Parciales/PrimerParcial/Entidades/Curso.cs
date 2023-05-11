using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Persona> alumnos;
        private EMateria materias;
        private Persona profesor;

        public Curso(Profesor profesor) 
        {
            this.profesor = profesor;
        }

        public List<Persona> Alumnos
        {
            get
            {
                return this.alumnos;
            }
        }

        public Persona Profesor
        {
            get
            {
                return this.profesor;
            }
            set
            {
                this.profesor = value;
            }
        }

        public static void EvaluarAlumnos(Curso curso)
        {
            foreach (Alumno alumno in curso.alumnos)
            {
                if (alumno.Materias.Contains(curso.materias))
                {
                    curso.profesor.Evaluar(alumno);
                }
            }
        }

        public string InscribirAlumno(Alumno alumno)
        {
            StringBuilder sb = new StringBuilder();

            if (this == alumno)
            {
                sb.AppendLine($"Ya inscripto o no se pudo inscribir el alumno a la materias {this.materias}");
            }
            else if (alumno + this.materias)
            {
                this.alumnos.Add(alumno);
                sb.AppendLine($"Se inscribio al alumno a la materias {this.materias}\n{alumno}");
            }
            else
            {
                sb.AppendLine($"No se pudo inscribir el alumno a la materias {this.materias}");
            }

            return sb.ToString();
        }


        public static string MostrarInformacionDelCurso(Curso curso)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Curso de {curso.materias}");
            sb.AppendLine($"Profesor: {curso.profesor}");
            sb.AppendLine("Alumnos:");

            foreach (Alumno alumno in curso.alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }

            return sb.ToString();
        }

        public static bool operator ==(Curso curso, Alumno alumno)
        {
            return curso.alumnos.Contains(alumno);
        }

        public static bool operator !=(Curso curso, Alumno alumno)
        {
            return !(curso == alumno);
        }

        public override string ToString()
        {
            return $"Curso de {this.materias}";
        }
    }
}
