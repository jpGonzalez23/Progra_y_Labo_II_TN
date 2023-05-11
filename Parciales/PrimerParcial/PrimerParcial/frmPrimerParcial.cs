using Entidades;

namespace PrimerParcial
{
    public partial class frnABMInscripcionAlumno : Form
    {
        private Persona alumno;
        private Persona profeProgra;
        private Persona profeLabo;
        private Curso cursoProgramacion;
        private Curso cursoLaboratorio;

        public frnABMInscripcionAlumno()
        {
            InitializeComponent();
            profeLabo = new Profesor(99000123, "profesorLabo@email.com", EMateria.Laboratorio);
            profeProgra = new Profesor(99000123, "profeProga@email.com", EMateria.Programacion);
            
            cursoProgramacion = new Curso((Profesor)profeProgra);
            cursoLaboratorio = new Curso((Profesor)profeLabo);
        }

        private void frnABMInscripcionAlumno_Load(object sender, EventArgs e)
        {
            this.cmbMaterias.DataSource = Enum.GetValues(typeof(EMateria));
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            alumno = (Alumno)this.txtDNIAlumno.Text;
            alumno.Nombre = this.txtNombreAlumno.Text;
            alumno.Apellido = this.txtApellidoAlumno.Text;
            this.lstAlumnosCreados.Items.Add(alumno);
        }

        private void ActualizarInscripstos()
        {
            this.lstAlumnosInscriptosLabo.DataSource = null;
            this.lstAlumnosInscriptosProgra.DataSource = null;

            this.lstAlumnosInscriptosLabo.DataSource = this.cursoLaboratorio.Alumnos;
            this.lstAlumnosInscriptosProgra.DataSource = this.cursoProgramacion.Alumnos;
        }

        private void btnAsignarMateria_Click(object sender, EventArgs e)
        {
            EMateria materia = (EMateria)this.cmbMaterias.SelectedItem;
            string mensaje = string.Empty;
            if (materia == EMateria.Programacion)
            {
                mensaje = cursoProgramacion.InscribirAlumno((Alumno)alumno);
            }
            else
            {
                mensaje = cursoLaboratorio.InscribirAlumno((Alumno)alumno);
            }
        }
    }
}