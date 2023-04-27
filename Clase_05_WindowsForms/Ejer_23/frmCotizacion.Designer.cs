namespace Ejer_23
{
    partial class frmConversor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversor));
            txtCotizacionDolar = new TextBox();
            txtCotizacionEuro = new TextBox();
            txtCotizacionPeso = new TextBox();
            txtDolarAPeso = new TextBox();
            txtDolarAEuro = new TextBox();
            txtDolarADolar = new TextBox();
            txtEuroAPeso = new TextBox();
            txtEuroAEuro = new TextBox();
            txtEuroADolar = new TextBox();
            txtPesoAPeso = new TextBox();
            txtPesoAEuro = new TextBox();
            txtPesoADolar = new TextBox();
            btnDolar = new Button();
            btnEuro = new Button();
            btnPeso = new Button();
            txtPeso = new TextBox();
            txtEuro = new TextBox();
            txtDolar = new TextBox();
            btnCandado = new Button();
            ilImagenCandado = new ImageList(components);
            lblDolar = new Label();
            lblEuro = new Label();
            lblPeso = new Label();
            lblDolarA = new Label();
            lblEuroA = new Label();
            lblPesoA = new Label();
            lblCotizacion = new Label();
            btnReseteo = new Button();
            SuspendLayout();
            // 
            // txtCotizacionDolar
            // 
            txtCotizacionDolar.Location = new Point(283, 12);
            txtCotizacionDolar.Name = "txtCotizacionDolar";
            txtCotizacionDolar.Size = new Size(100, 23);
            txtCotizacionDolar.TabIndex = 0;
            // 
            // txtCotizacionEuro
            // 
            txtCotizacionEuro.Location = new Point(389, 12);
            txtCotizacionEuro.Name = "txtCotizacionEuro";
            txtCotizacionEuro.Size = new Size(100, 23);
            txtCotizacionEuro.TabIndex = 1;
            // 
            // txtCotizacionPeso
            // 
            txtCotizacionPeso.Location = new Point(495, 12);
            txtCotizacionPeso.Name = "txtCotizacionPeso";
            txtCotizacionPeso.Size = new Size(100, 23);
            txtCotizacionPeso.TabIndex = 2;
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Enabled = false;
            txtDolarAPeso.Location = new Point(495, 72);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.Size = new Size(100, 23);
            txtDolarAPeso.TabIndex = 5;
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Enabled = false;
            txtDolarAEuro.Location = new Point(389, 72);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.Size = new Size(100, 23);
            txtDolarAEuro.TabIndex = 4;
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Enabled = false;
            txtDolarADolar.Location = new Point(283, 72);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.Size = new Size(100, 23);
            txtDolarADolar.TabIndex = 3;
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Enabled = false;
            txtEuroAPeso.Location = new Point(495, 101);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.Size = new Size(100, 23);
            txtEuroAPeso.TabIndex = 8;
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Enabled = false;
            txtEuroAEuro.Location = new Point(389, 101);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.Size = new Size(100, 23);
            txtEuroAEuro.TabIndex = 7;
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Enabled = false;
            txtEuroADolar.Location = new Point(283, 101);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.Size = new Size(100, 23);
            txtEuroADolar.TabIndex = 6;
            // 
            // txtPesoAPeso
            // 
            txtPesoAPeso.Enabled = false;
            txtPesoAPeso.Location = new Point(495, 130);
            txtPesoAPeso.Name = "txtPesoAPeso";
            txtPesoAPeso.Size = new Size(100, 23);
            txtPesoAPeso.TabIndex = 11;
            // 
            // txtPesoAEuro
            // 
            txtPesoAEuro.Enabled = false;
            txtPesoAEuro.Location = new Point(389, 130);
            txtPesoAEuro.Name = "txtPesoAEuro";
            txtPesoAEuro.Size = new Size(100, 23);
            txtPesoAEuro.TabIndex = 10;
            // 
            // txtPesoADolar
            // 
            txtPesoADolar.Enabled = false;
            txtPesoADolar.Location = new Point(283, 130);
            txtPesoADolar.Name = "txtPesoADolar";
            txtPesoADolar.Size = new Size(100, 23);
            txtPesoADolar.TabIndex = 9;
            // 
            // btnDolar
            // 
            btnDolar.Location = new Point(202, 72);
            btnDolar.Name = "btnDolar";
            btnDolar.Size = new Size(75, 23);
            btnDolar.TabIndex = 12;
            btnDolar.Text = "-->";
            btnDolar.UseVisualStyleBackColor = true;
            btnDolar.Click += btnDolar_Click;
            // 
            // btnEuro
            // 
            btnEuro.Location = new Point(202, 100);
            btnEuro.Name = "btnEuro";
            btnEuro.Size = new Size(75, 23);
            btnEuro.TabIndex = 13;
            btnEuro.Text = "-->";
            btnEuro.UseVisualStyleBackColor = true;
            btnEuro.Click += btnEuro_Click;
            // 
            // btnPeso
            // 
            btnPeso.Location = new Point(202, 130);
            btnPeso.Name = "btnPeso";
            btnPeso.Size = new Size(75, 23);
            btnPeso.TabIndex = 14;
            btnPeso.Text = "-->";
            btnPeso.UseVisualStyleBackColor = true;
            btnPeso.Click += btnPeso_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(96, 130);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 17;
            txtPeso.Leave += txtPeso_Leave;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(96, 101);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 16;
            txtEuro.Leave += txtEuro_Leave;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(96, 72);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 15;
            txtDolar.Leave += txtDolar_Leave;
            // 
            // btnCandado
            // 
            btnCandado.ImageIndex = 0;
            btnCandado.ImageList = ilImagenCandado;
            btnCandado.Location = new Point(202, 12);
            btnCandado.Name = "btnCandado";
            btnCandado.Size = new Size(75, 57);
            btnCandado.TabIndex = 18;
            btnCandado.UseVisualStyleBackColor = true;
            btnCandado.Click += btnCandado_Click;
            // 
            // ilImagenCandado
            // 
            ilImagenCandado.ColorDepth = ColorDepth.Depth8Bit;
            ilImagenCandado.ImageStream = (ImageListStreamer)resources.GetObject("ilImagenCandado.ImageStream");
            ilImagenCandado.TransparentColor = Color.Transparent;
            ilImagenCandado.Images.SetKeyName(0, "internet_locked_padlock_password_secure_security_unlock_icon_127083.png");
            ilImagenCandado.Images.SetKeyName(1, "internet_lock_locked_padlock_password_secure_security_icon_127078.png");
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Location = new Point(37, 76);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(35, 15);
            lblDolar.TabIndex = 19;
            lblDolar.Text = "Dólar";
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Location = new Point(37, 104);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(31, 15);
            lblEuro.TabIndex = 20;
            lblEuro.Text = "Euro";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(36, 134);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 21;
            lblPeso.Text = "Peso";
            // 
            // lblDolarA
            // 
            lblDolarA.AutoSize = true;
            lblDolarA.Location = new Point(314, 54);
            lblDolarA.Name = "lblDolarA";
            lblDolarA.Size = new Size(35, 15);
            lblDolarA.TabIndex = 22;
            lblDolarA.Text = "Dólar";
            // 
            // lblEuroA
            // 
            lblEuroA.AutoSize = true;
            lblEuroA.Location = new Point(419, 54);
            lblEuroA.Name = "lblEuroA";
            lblEuroA.Size = new Size(31, 15);
            lblEuroA.TabIndex = 23;
            lblEuroA.Text = "Euro";
            // 
            // lblPesoA
            // 
            lblPesoA.AutoSize = true;
            lblPesoA.Location = new Point(526, 54);
            lblPesoA.Name = "lblPesoA";
            lblPesoA.Size = new Size(32, 15);
            lblPesoA.TabIndex = 24;
            lblPesoA.Text = "Peso";
            // 
            // lblCotizacion
            // 
            lblCotizacion.AutoSize = true;
            lblCotizacion.Location = new Point(96, 12);
            lblCotizacion.Name = "lblCotizacion";
            lblCotizacion.Size = new Size(63, 15);
            lblCotizacion.TabIndex = 25;
            lblCotizacion.Text = "Cotización";
            // 
            // btnReseteo
            // 
            btnReseteo.Location = new Point(96, 43);
            btnReseteo.Name = "btnReseteo";
            btnReseteo.Size = new Size(75, 23);
            btnReseteo.TabIndex = 26;
            btnReseteo.Text = "Reseteo";
            btnReseteo.UseVisualStyleBackColor = true;
            btnReseteo.Click += btnReseteo_Click;
            // 
            // frmConversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 178);
            Controls.Add(btnReseteo);
            Controls.Add(lblCotizacion);
            Controls.Add(lblPesoA);
            Controls.Add(lblEuroA);
            Controls.Add(lblDolarA);
            Controls.Add(lblPeso);
            Controls.Add(lblEuro);
            Controls.Add(lblDolar);
            Controls.Add(btnCandado);
            Controls.Add(txtPeso);
            Controls.Add(txtEuro);
            Controls.Add(txtDolar);
            Controls.Add(btnPeso);
            Controls.Add(btnEuro);
            Controls.Add(btnDolar);
            Controls.Add(txtPesoAPeso);
            Controls.Add(txtPesoAEuro);
            Controls.Add(txtPesoADolar);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtEuroAEuro);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtDolarAEuro);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtCotizacionPeso);
            Controls.Add(txtCotizacionEuro);
            Controls.Add(txtCotizacionDolar);
            Name = "frmConversor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCotizacionDolar;
        private TextBox txtCotizacionEuro;
        private TextBox txtCotizacionPeso;
        private TextBox txtDolarAPeso;
        private TextBox txtDolarAEuro;
        private TextBox txtDolarADolar;
        private TextBox txtEuroAPeso;
        private TextBox txtEuroAEuro;
        private TextBox txtEuroADolar;
        private TextBox txtPesoAPeso;
        private TextBox txtPesoAEuro;
        private TextBox txtPesoADolar;
        private Button btnDolar;
        private Button btnEuro;
        private Button btnPeso;
        private TextBox txtPeso;
        private TextBox txtEuro;
        private TextBox txtDolar;
        private Button btnCandado;
        private ImageList ilImagenCandado;
        private Label lblDolar;
        private Label lblEuro;
        private Label lblPeso;
        private Label lblDolarA;
        private Label lblEuroA;
        private Label lblPesoA;
        private Label lblCotizacion;
        private Button btnReseteo;
    }
}