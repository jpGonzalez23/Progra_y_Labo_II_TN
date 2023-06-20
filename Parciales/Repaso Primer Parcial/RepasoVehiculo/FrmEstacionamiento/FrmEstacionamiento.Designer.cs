namespace FrmEstacionamiento
{
    partial class FrmEstacionamiento
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
            lblTipoVehiculo = new Label();
            lblPatente = new Label();
            lblTipo = new Label();
            cmbTipoVehiculo = new ComboBox();
            cmbTipoMoto = new ComboBox();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            txtNombreEstacionamiento = new TextBox();
            lstVehiculos = new ListBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(12, 15);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(78, 15);
            lblTipoVehiculo.TabIndex = 0;
            lblTipoVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(12, 60);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 1;
            lblPatente.Text = "Patente";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(12, 106);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(96, 15);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(121, 23);
            cmbTipoVehiculo.TabIndex = 3;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(96, 103);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(121, 23);
            cmbTipoMoto.TabIndex = 4;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(96, 57);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(121, 23);
            txtPatente.TabIndex = 5;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(233, 103);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(121, 23);
            txtMarca.TabIndex = 6;
            // 
            // txtNombreEstacionamiento
            // 
            txtNombreEstacionamiento.Location = new Point(397, 15);
            txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            txtNombreEstacionamiento.Size = new Size(305, 23);
            txtNombreEstacionamiento.TabIndex = 7;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(397, 57);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(305, 139);
            lstVehiculos.TabIndex = 8;
            lstVehiculos.MouseClick += lstVehiculos_MouseClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 165);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 38);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 233);
            Controls.Add(btnAgregar);
            Controls.Add(lstVehiculos);
            Controls.Add(txtNombreEstacionamiento);
            Controls.Add(txtMarca);
            Controls.Add(txtPatente);
            Controls.Add(cmbTipoMoto);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(lblTipo);
            Controls.Add(lblPatente);
            Controls.Add(lblTipoVehiculo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEstacionamiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estacionamiento";
            Load += FrmEstacionamiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoVehiculo;
        private Label lblPatente;
        private Label lblTipo;
        private ComboBox cmbTipoVehiculo;
        private ComboBox cmbTipoMoto;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private TextBox txtNombreEstacionamiento;
        private ListBox lstVehiculos;
        private Button btnAgregar;
    }
}