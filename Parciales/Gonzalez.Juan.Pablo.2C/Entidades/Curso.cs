using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnoList;
        private EMateria materias;
        private Persona profesor;

        public Curso(Profesor profesor) 
        {
            this.profesor = profesor;
        }

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnoList;
            }
        }

        public Profesor Profesor
        {
            get
            {
                return ;
            }
            set
            {
                this.profesor = value;
            }
        }

        public static void EvaluarAlumnos(Curso curso)
        {

        }

        public string InscribirAlumno(Alumno alumno)
        {
            StringBuilder sb = new StringBuilder();

            if ()
            {

            }


            return sb.ToString();
        }


        public static string MostrarInformacionDelCurso(Curso curso)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Profesor: ");

            return sb.ToString();
        }

        public static bool operator ==(Curso curso, Alumno alumno)
        {
            return ;
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
