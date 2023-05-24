namespace Gonzalez.Juan.Pablo._2C.RPP
{
    partial class FrmView
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
            lblSeleccionHamburguesa = new Label();
            cmbGuarnicion = new ComboBox();
            lstHamburguesas = new ListBox();
            lblSeleccionGuarnicion = new Label();
            btnAgregarGuarnicion = new Button();
            gpbIngredientes = new GroupBox();
            btnAgregarIngredientes = new Button();
            rdbGuarnicion = new RadioButton();
            lblIngredientes = new Label();
            rdbHamburguesa = new RadioButton();
            cmbIngredientes = new ComboBox();
            rchTicket = new RichTextBox();
            txtDniCliente = new TextBox();
            gpbIngredientes.SuspendLayout();
            SuspendLayout();
            // 
            // lblSeleccionHamburguesa
            // 
            lblSeleccionHamburguesa.AutoSize = true;
            lblSeleccionHamburguesa.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionHamburguesa.Location = new Point(12, 53);
            lblSeleccionHamburguesa.Name = "lblSeleccionHamburguesa";
            lblSeleccionHamburguesa.Size = new Size(253, 25);
            lblSeleccionHamburguesa.TabIndex = 1;
            lblSeleccionHamburguesa.Text = "Seleccione su hamburguesa:";
            // 
            // cmbGuarnicion
            // 
            cmbGuarnicion.FormattingEnabled = true;
            cmbGuarnicion.Location = new Point(12, 191);
            cmbGuarnicion.Name = "cmbGuarnicion";
            cmbGuarnicion.Size = new Size(210, 23);
            cmbGuarnicion.TabIndex = 2;
            cmbGuarnicion.SelectedIndexChanged += cmbGuarnicion_SelectedIndexChanged;
            // 
            // lstHamburguesas
            // 
            lstHamburguesas.FormattingEnabled = true;
            lstHamburguesas.ItemHeight = 15;
            lstHamburguesas.Location = new Point(12, 81);
            lstHamburguesas.Name = "lstHamburguesas";
            lstHamburguesas.Size = new Size(268, 64);
            lstHamburguesas.TabIndex = 3;
            lstHamburguesas.MouseDoubleClick += lstHamburguesas_MouseDoubleClick;
            // 
            // lblSeleccionGuarnicion
            // 
            lblSeleccionGuarnicion.AutoSize = true;
            lblSeleccionGuarnicion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionGuarnicion.Location = new Point(12, 163);
            lblSeleccionGuarnicion.Name = "lblSeleccionGuarnicion";
            lblSeleccionGuarnicion.Size = new Size(212, 25);
            lblSeleccionGuarnicion.TabIndex = 4;
            lblSeleccionGuarnicion.Text = "Seleccion su guarnicion";
            // 
            // btnAgregarGuarnicion
            // 
            btnAgregarGuarnicion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarGuarnicion.Location = new Point(228, 191);
            btnAgregarGuarnicion.Name = "btnAgregarGuarnicion";
            btnAgregarGuarnicion.Size = new Size(52, 23);
            btnAgregarGuarnicion.TabIndex = 5;
            btnAgregarGuarnicion.Text = "+";
            btnAgregarGuarnicion.UseVisualStyleBackColor = true;
            btnAgregarGuarnicion.Click += btnAgregarGuarnicion_Click;
            // 
            // gpbIngredientes
            // 
            gpbIngredientes.Controls.Add(btnAgregarIngredientes);
            gpbIngredientes.Controls.Add(rdbGuarnicion);
            gpbIngredientes.Controls.Add(lblIngredientes);
            gpbIngredientes.Controls.Add(rdbHamburguesa);
            gpbIngredientes.Controls.Add(cmbIngredientes);
            gpbIngredientes.Location = new Point(297, 81);
            gpbIngredientes.Name = "gpbIngredientes";
            gpbIngredientes.Size = new Size(286, 133);
            gpbIngredientes.TabIndex = 6;
            gpbIngredientes.TabStop = false;
            gpbIngredientes.Text = "Ingredientes";
            // 
            // btnAgregarIngredientes
            // 
            btnAgregarIngredientes.Location = new Point(224, 97);
            btnAgregarIngredientes.Name = "btnAgregarIngredientes";
            btnAgregarIngredientes.Size = new Size(56, 23);
            btnAgregarIngredientes.TabIndex = 9;
            btnAgregarIngredientes.Text = "+";
            btnAgregarIngredientes.UseVisualStyleBackColor = true;
            btnAgregarIngredientes.Click += btnAgregarIngredientes_Click;
            // 
            // rdbGuarnicion
            // 
            rdbGuarnicion.AutoSize = true;
            rdbGuarnicion.Location = new Point(6, 47);
            rdbGuarnicion.Name = "rdbGuarnicion";
            rdbGuarnicion.Size = new Size(83, 19);
            rdbGuarnicion.TabIndex = 1;
            rdbGuarnicion.TabStop = true;
            rdbGuarnicion.Text = "Guarnición";
            rdbGuarnicion.UseVisualStyleBackColor = true;
            // 
            // lblIngredientes
            // 
            lblIngredientes.AutoSize = true;
            lblIngredientes.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngredientes.Location = new Point(6, 69);
            lblIngredientes.Name = "lblIngredientes";
            lblIngredientes.Size = new Size(119, 25);
            lblIngredientes.TabIndex = 8;
            lblIngredientes.Text = "Ingredientes";
            // 
            // rdbHamburguesa
            // 
            rdbHamburguesa.AutoSize = true;
            rdbHamburguesa.Location = new Point(6, 22);
            rdbHamburguesa.Name = "rdbHamburguesa";
            rdbHamburguesa.Size = new Size(100, 19);
            rdbHamburguesa.TabIndex = 0;
            rdbHamburguesa.TabStop = true;
            rdbHamburguesa.Text = "Hamburguesa";
            rdbHamburguesa.UseVisualStyleBackColor = true;
            // 
            // cmbIngredientes
            // 
            cmbIngredientes.FormattingEnabled = true;
            cmbIngredientes.Location = new Point(6, 97);
            cmbIngredientes.Name = "cmbIngredientes";
            cmbIngredientes.Size = new Size(212, 23);
            cmbIngredientes.TabIndex = 7;
            // 
            // rchTicket
            // 
            rchTicket.Location = new Point(12, 220);
            rchTicket.Name = "rchTicket";
            rchTicket.Size = new Size(571, 96);
            rchTicket.TabIndex = 7;
            rchTicket.Text = "";
            // 
            // txtDniCliente
            // 
            txtDniCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniCliente.Location = new Point(12, 12);
            txtDniCliente.MaxLength = 50;
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(175, 29);
            txtDniCliente.TabIndex = 0;
            txtDniCliente.TextChanged += txtDniCliente_TextChanged;
            txtDniCliente.Leave += txtDniCliente_Leave;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 346);
            Controls.Add(rchTicket);
            Controls.Add(gpbIngredientes);
            Controls.Add(btnAgregarGuarnicion);
            Controls.Add(lblSeleccionGuarnicion);
            Controls.Add(lstHamburguesas);
            Controls.Add(cmbGuarnicion);
            Controls.Add(lblSeleccionHamburguesa);
            Controls.Add(txtDniCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hamburgueseria";
            Load += FrmHamburgueseria_Load;
            gpbIngredientes.ResumeLayout(false);
            gpbIngredientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSeleccionHamburguesa;
        private ComboBox cmbGuarnicion;
        private ListBox lstHamburguesas;
        private Label lblSeleccionGuarnicion;
        private Button btnAgregarGuarnicion;
        private GroupBox gpbIngredientes;
        private Button btnAgregarIngredientes;
        private RadioButton rdbGuarnicion;
        private Label lblIngredientes;
        private RadioButton rdbHamburguesa;
        private ComboBox cmbIngredientes;
        private RichTextBox rchTicket;
        private TextBox txtDniCliente;
    }
}