using Entidades;

namespace Ejer_23
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionPeso.Text = Peso.GetCotizacion().ToString();
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            if (txtCotizacionEuro.Enabled)
            {
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPeso.Enabled = false;

                btnCandado.Image = ilImagenCandado.Images[1];
            }
            else
            {
                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPeso.Enabled = true;

                btnCandado.Image = ilImagenCandado.Images[0];

            }
        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {
            double aux;
            if(double.TryParse(txtCotizacionDolar.Text, out aux))
            {
                Dolar.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionDolar.Focus();
            }
        }

        private void txtEuro_Leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionEuro.Text, out aux))
            {
                Euro.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionEuro.Focus();
            }
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionPeso.Text, out aux))
            {
                Peso.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionPeso.Focus();
            }
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            double aux;

            if (double.TryParse(txtDolar.Text, out aux))
            {
                Dolar cambio = new Dolar(aux);

                txtDolarAEuro.Text = ((Dolar)cambio).GetCantidad().ToString();
                txtDolarADolar.Text = cambio.GetCantidad().ToString();
                txtDolarAPeso.Text = ((Dolar)cambio).GetCantidad().ToString();
            }
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            double aux; 

            if(double.TryParse(txtEuro.Text, out aux))
            {
                Euro cambio = new Euro(aux);

                txtEuroADolar.Text = ((Euro)cambio).GetCantidad().ToString();
                txtEuroAEuro.Text = cambio.GetCantidad().ToString();
                txtEuroAPeso.Text = ((Euro)cambio).GetCantidad().ToString();
            }
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            double aux;

            if (double.TryParse(txtPeso.Text, out aux))
            {
                Peso cambio = new Peso(aux);

                txtPesoADolar.Text = ((Peso)cambio).GetCantidad().ToString();
                txtPesoAEuro.Text = ((Peso)cambio).GetCantidad().ToString();
                txtPesoAPeso.Text = cambio.GetCantidad().ToString();
            }
        }

        private void btnReseteo_Click(object sender, EventArgs e)
        {
            txtEuroADolar.Clear();
            txtEuroAEuro.Clear();
            txtEuroAPeso.Clear();
            txtEuro.Clear();

            txtDolar.Clear();
            txtDolarADolar.Clear();
            txtDolarAEuro.Clear();
            txtDolarAPeso.Clear();

            txtPeso.Clear();
            txtPesoADolar.Clear();
            txtPesoAEuro.Clear();
            txtPesoAPeso.Clear();
        }
    }
}