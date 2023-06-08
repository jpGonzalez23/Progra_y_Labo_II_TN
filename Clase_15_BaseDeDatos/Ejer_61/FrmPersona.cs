using Entidades;

namespace Ejer_61
{
    public partial class FrmPersona : Form
    {
        private PersonaDAO personaDAO;
        private Persona persona;

        public FrmPersona()
        {
            InitializeComponent();
            this.personaDAO = new PersonaDAO();
            this.persona = null;
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            ActualizarListBox();
        }


        private void lstPersona_DoubleClick(object sender, EventArgs e)
        {
            if (lstPersona.SelectedItem != null)
            {
                persona = (Persona)lstPersona.SelectedItem;
                txtNombre.Text = persona.Nombre;
                txtApellido.Text = persona.Apellido;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (persona != null)
            {
                int id = persona.Id;
                personaDAO.Borrar(id);
                ActualizarListBox();
                LimpiarCampos();
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            ActualizarListBox();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (persona != null)
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                personaDAO.Modificar(persona);
                ActualizarListBox();
                LimpiarCampos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            Persona nuevaPersona = new Persona(nombre, apellido);
            personaDAO.Guardar(nuevaPersona);
            ActualizarListBox();
            LimpiarCampos();
        }

        private void ActualizarListBox()
        {
            lstPersona.DataSource = null;
            lstPersona.DataSource = personaDAO.Leer();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            persona = null;
        }
    }
}