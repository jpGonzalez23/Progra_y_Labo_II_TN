namespace Ejer_63
{
    public partial class FrmRelojero : Form
    {
        private System.Threading.Timer timer;

        public FrmRelojero()
        {
            InitializeComponent();
            
        }

        private void FrmRelojero_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(ActualizarHora);
            thread.IsBackground = true;
            thread.Start();
        }

        public void ActualizarHora()
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                lblHora.Invoke((MethodInvoker)(() => lblHora.Text = now.ToString("dd/MM/yyyy HH:mm:ss")));
                Thread.Sleep(1000);
            }
        }
    }
}