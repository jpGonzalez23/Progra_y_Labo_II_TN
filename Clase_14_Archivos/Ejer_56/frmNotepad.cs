using System.Text;

namespace Ejer_56
{
    public partial class frmNotepad : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private string ultimoArchivo;

        private string UltimoArchivo
        {
            get
            {
                return this.ultimoArchivo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.ultimoArchivo = value;
                }
            }
        }

        public frmNotepad()
        {
            InitializeComponent();
            this.openFileDialog = new OpenFileDialog();
            this.saveFileDialog = new SaveFileDialog();
            this.saveFileDialog.Filter = "Archivo de texto|*.txt";
        }

        private void FrmNotepad_Load(object sender, EventArgs e)
        {
            this.stripStatusLabelCaracteres.Text = "0 caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.ultimoArchivo = this.openFileDialog.FileName;
                    using StreamReader streamReader = new StreamReader(this.ultimoArchivo);
                    this.rtxtContenido.Text = streamReader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MostrarVentanaDeError(ex);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.UltimoArchivo = SeleccionarUbicacionGuardado();

            GuardarArchivo(this.UltimoArchivo);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.UltimoArchivo))
            {
                this.UltimoArchivo = SeleccionarUbicacionGuardado();
            }

            GuardarArchivo(this.UltimoArchivo);
        }

        private string SeleccionarUbicacionGuardado()
        {
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return this.saveFileDialog.FileName;
            }

            return string.Empty;
        }

        private void GuardarArchivo(string ruta)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ruta))
                {
                    using StreamWriter streamWriter = new StreamWriter(this.ultimoArchivo);
                    streamWriter.Write(this.rtxtContenido.Text);
                }
            }
            catch (Exception ex)
            {
                MostrarVentanaDeError(ex);
            }
        }

        private void MostrarVentanaDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Error: {ex.Message}");
            stringBuilder.AppendLine("Detalle:");
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rtxtContenido_TextChanged(object sender, EventArgs e)
        {
            this.stripStatusLabelCaracteres.Text = $"{this.rtxtContenido.Text.Length} caracteres";
        }
    }
}