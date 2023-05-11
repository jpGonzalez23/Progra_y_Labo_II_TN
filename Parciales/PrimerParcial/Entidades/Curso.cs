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
            this.materias = profesor.Materia;
            this.alumnos = new List<Persona>();
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
                return (Profesor)this.profesor;
            }
            set
            {
                this.profesor = value;
            }
        }

        public static void EvaluarAlumnos(Curso curso)
        {
            foreach (var item in curso.alumnos)
            {
                ((Profesor)curso.profesor).Evaluar((Alumno)item);
            }
        }

        public string InscribirAlumno(Alumno alumno)
        {
            if(this != alumno && alumno + this.materias)
            {
                this.alumnos.Add(alumno);

                return "Ya se inscribio a la materia";

            }

            return "No se inscribio a la materia";
        }


        public static string MostrarInformacionDelCurso(Curso curso)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Curso de {curso.materias}");
            sb.AppendLine($"Profesor: {curso.profesor.Informar}");
            sb.AppendLine("Alumnos:");

            foreach (var item in curso.alumnos)
            {
                sb.AppendLine(item.ToString());
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
