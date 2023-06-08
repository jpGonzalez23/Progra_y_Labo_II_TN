namespace Ejer_I01_ListaSupermercado
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion(string titulo, string contenidoTexBox, string textBotonConfirmar)
        {
            InitializeComponent();
            Text = titulo;
            txtObjeto.Text = contenidoTexBox;
            btnConfirmar.Text = textBotonConfirmar;
        }

        public string Objeto
        {
            get => txtObjeto.Text;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void Confirmar()
        {
            if (string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                MessageBox.Show("El texto no puede estar vacio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Confirmar();
            }
            else if (e.KeyChar == (char)27)
            {
                Cancelar();
            }
        }
    }
}