using Entidades;

namespace Ejer_67
{
    public partial class FrmRelojero : Form
    {
        private Temporizador temporizador;
        public FrmRelojero()
        {
            InitializeComponent();
            temporizador = new Temporizador(1000);
            temporizador.TiempoCumplido += AsignarHora;
        }

        private void FrmRelojero_Load(object sender, EventArgs e)
        {
            //ActualizarHoraConEstructurasIterativas();
            //ActualizarHoraConHilos();
            ActualizarHoraConClaseTemporizador();
        }

        private void btnIniciarReloj_Click(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }

        private void btnDetenerReloj_Click(object sender, EventArgs e)
        {
            temporizador.DetenerTemporizador();
        }

        private void AsignarHora()
        {
            if (lblHora.InvokeRequired)
            {
                Action actionHora = AsignarHora;
                lblHora.Invoke(actionHora);
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        #region Punto i (con estructuras iterativas)
        private void ActualizarHoraConEstructurasIterativas()
        {
            do
            {
                AsignarHora();
                Thread.Sleep(1000);
            } while (true);
        }
        #endregion

        #region Punto ii (con Timer)
        private void timer_Tick(object sender, EventArgs e)
        {
            //AsignarHora();
        }
        #endregion

        #region Punto iii (con hilos)
        private void ActualizarHoraConHilos()
        {
            Task task = Task.Run(() =>
            {
                do
                {
                    AsignarHora();
                    Thread.Sleep(1000);
                } while (true);
            });
        }
        #endregion

        #region EjercicioTemporizador
        public void ActualizarHoraConClaseTemporizador()
        {
            temporizador.IniciarTemporizador();
        }
        #endregion
    }
}