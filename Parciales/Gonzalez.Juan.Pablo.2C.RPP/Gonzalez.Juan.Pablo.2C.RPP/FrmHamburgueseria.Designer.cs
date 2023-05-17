namespace Gonzalez.Juan.Pablo._2C.RPP
{
    partial class FrmHamburgueseria
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
            rdbIngredienteDos = new RadioButton();
            lblIngredientes = new Label();
            rdbIngredienteUno = new RadioButton();
            cmbIngredientes = new ComboBox();
            rctbSalida = new RichTextBox();
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
            // 
            // lstHamburguesas
            // 
            lstHamburguesas.FormattingEnabled = true;
            lstHamburguesas.ItemHeight = 15;
            lstHamburguesas.Location = new Point(12, 81);
            lstHamburguesas.Name = "lstHamburguesas";
            lstHamburguesas.Size = new Size(268, 64);
            lstHamburguesas.TabIndex = 3;
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
            // 
            // gpbIngredientes
            // 
            gpbIngredientes.Controls.Add(btnAgregarIngredientes);
            gpbIngredientes.Controls.Add(rdbIngredienteDos);
            gpbIngredientes.Controls.Add(lblIngredientes);
            gpbIngredientes.Controls.Add(rdbIngredienteUno);
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
            // 
            // rdbIngredienteDos
            // 
            rdbIngredienteDos.AutoSize = true;
            rdbIngredienteDos.Location = new Point(6, 47);
            rdbIngredienteDos.Name = "rdbIngredienteDos";
            rdbIngredienteDos.Size = new Size(83, 19);
            rdbIngredienteDos.TabIndex = 1;
            rdbIngredienteDos.TabStop = true;
            rdbIngredienteDos.Text = "Guarnición";
            rdbIngredienteDos.UseVisualStyleBackColor = true;
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
            // rdbIngredienteUno
            // 
            rdbIngredienteUno.AutoSize = true;
            rdbIngredienteUno.Location = new Point(6, 22);
            rdbIngredienteUno.Name = "rdbIngredienteUno";
            rdbIngredienteUno.Size = new Size(100, 19);
            rdbIngredienteUno.TabIndex = 0;
            rdbIngredienteUno.TabStop = true;
            rdbIngredienteUno.Text = "Hamburguesa";
            rdbIngredienteUno.UseVisualStyleBackColor = true;
            // 
            // cmbIngredientes
            // 
            cmbIngredientes.FormattingEnabled = true;
            cmbIngredientes.Location = new Point(6, 97);
            cmbIngredientes.Name = "cmbIngredientes";
            cmbIngredientes.Size = new Size(212, 23);
            cmbIngredientes.TabIndex = 7;
            // 
            // rctbSalida
            // 
            rctbSalida.Location = new Point(12, 220);
            rctbSalida.Name = "rctbSalida";
            rctbSalida.Size = new Size(571, 96);
            rctbSalida.TabIndex = 7;
            rctbSalida.Text = "";
            // 
            // txtDniCliente
            // 
            txtDniCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniCliente.Location = new Point(12, 12);
            txtDniCliente.MaxLength = 50;
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(175, 29);
            txtDniCliente.TabIndex = 0;
            // 
            // FrmHamburgueseria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 346);
            Controls.Add(rctbSalida);
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
            Name = "FrmHamburgueseria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hamburgueseria";
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
        private RadioButton rdbIngredienteDos;
        private Label lblIngredientes;
        private RadioButton rdbIngredienteUno;
        private ComboBox cmbIngredientes;
        private RichTextBox rctbSalida;
        private TextBox txtDniCliente;
    }
}