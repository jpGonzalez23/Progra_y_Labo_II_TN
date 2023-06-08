namespace Ejer_61
{
    partial class FrmPersona
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
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnLeer = new Button();
            btnEliminar = new Button();
            lstPersona = new ListBox();
            lblNombre = new Label();
            lblApellido = new Label();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(181, 24);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(149, 23);
            txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 58);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(93, 58);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(174, 58);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 23);
            btnLeer.TabIndex = 4;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(255, 58);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstPersona
            // 
            lstPersona.FormattingEnabled = true;
            lstPersona.ItemHeight = 15;
            lstPersona.Location = new Point(12, 87);
            lstPersona.Name = "lstPersona";
            lstPersona.Size = new Size(318, 139);
            lstPersona.TabIndex = 6;
            lstPersona.DoubleClick += lstPersona_DoubleClick;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(66, 6);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(225, 6);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            // 
            // FrmPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 256);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lstPersona);
            Controls.Add(btnEliminar);
            Controls.Add(btnLeer);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data";
            Load += FrmPersona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnLeer;
        private Button btnEliminar;
        private ListBox lstPersona;
        private Label lblNombre;
        private Label lblApellido;
    }
}