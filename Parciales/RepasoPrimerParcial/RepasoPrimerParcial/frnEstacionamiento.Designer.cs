namespace RepasoPrimerParcial
{
    partial class frnEstacionamiento
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
            btnAgregarVehiculo = new Button();
            cmbTipoVehiculo = new ComboBox();
            lblTipoVehiculo = new Label();
            lblPatente = new Label();
            txtPatente = new TextBox();
            lblTipo = new Label();
            cmbTipoMoto = new ComboBox();
            txtMarca = new TextBox();
            lstVehiculos = new ListBox();
            txtNombreEstacionamiento = new TextBox();
            SuspendLayout();
            // 
            // btnAgregarVehiculo
            // 
            btnAgregarVehiculo.Location = new Point(12, 350);
            btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            btnAgregarVehiculo.Size = new Size(157, 47);
            btnAgregarVehiculo.TabIndex = 0;
            btnAgregarVehiculo.Text = "Agragar Vehiculo";
            btnAgregarVehiculo.UseVisualStyleBackColor = true;
            btnAgregarVehiculo.Click += btnAgregarVehiculo_Click;
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(121, 58);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(121, 23);
            cmbTipoVehiculo.TabIndex = 1;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(17, 66);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(78, 15);
            lblTipoVehiculo.TabIndex = 2;
            lblTipoVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(17, 116);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 3;
            lblPatente.Text = "Patente";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(121, 108);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(121, 23);
            txtPatente.TabIndex = 4;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(17, 160);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(121, 160);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(121, 23);
            cmbTipoMoto.TabIndex = 6;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(248, 160);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(110, 23);
            txtMarca.TabIndex = 7;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(449, 108);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(339, 289);
            lstVehiculos.TabIndex = 9;
            lstVehiculos.MouseDoubleClick += lstVehiculos_MouseDoubleClick;
            // 
            // txtNombreEstacionamiento
            // 
            txtNombreEstacionamiento.Location = new Point(449, 12);
            txtNombreEstacionamiento.Multiline = true;
            txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            txtNombreEstacionamiento.Size = new Size(339, 73);
            txtNombreEstacionamiento.TabIndex = 10;
            // 
            // frnEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 411);
            Controls.Add(txtNombreEstacionamiento);
            Controls.Add(lstVehiculos);
            Controls.Add(txtMarca);
            Controls.Add(cmbTipoMoto);
            Controls.Add(lblTipo);
            Controls.Add(txtPatente);
            Controls.Add(lblPatente);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(btnAgregarVehiculo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frnEstacionamiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estacionamiento";
            Load += frnEstacionamiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarVehiculo;

        private ListBox lstVehiculos;

        private Label lblTipoVehiculo;
        private Label lblPatente;
        private Label lblTipo;

        private ComboBox cmbTipoMoto;
        private ComboBox cmbTipoVehiculo;

        private TextBox txtNombreEstacionamiento;
        private TextBox txtPatente;
        private TextBox txtMarca;
    }
}