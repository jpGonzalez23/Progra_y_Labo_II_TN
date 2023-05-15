namespace RepasoCentralita
{
    partial class Form1
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
            lblNombre = new Label();
            lblLegajo = new Label();
            lblTipo = new Label();
            lblHoraIngreso = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dtpIngreso = new DateTimePicker();
            cmbTipo = new ComboBox();
            cmbGrupo = new ComboBox();
            lblGrupo = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(131, 9);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 1;
            lblLegajo.Text = "Legajo";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(252, 9);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // lblHoraIngreso
            // 
            lblHoraIngreso.AutoSize = true;
            lblHoraIngreso.Location = new Point(392, 9);
            lblHoraIngreso.Name = "lblHoraIngreso";
            lblHoraIngreso.Size = new Size(38, 15);
            lblHoraIngreso.TabIndex = 3;
            lblHoraIngreso.Text = "label4";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Location = new Point(392, 27);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(200, 23);
            dtpIngreso.TabIndex = 7;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(252, 27);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 8;
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(12, 81);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(121, 23);
            cmbGrupo.TabIndex = 9;
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(12, 63);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 10;
            lblGrupo.Text = "Grupo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGrupo);
            Controls.Add(cmbGrupo);
            Controls.Add(cmbTipo);
            Controls.Add(dtpIngreso);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblHoraIngreso);
            Controls.Add(lblTipo);
            Controls.Add(lblLegajo);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblLegajo;
        private Label lblTipo;
        private Label lblHoraIngreso;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dtpIngreso;
        private ComboBox cmbTipo;
        private ComboBox cmbGrupo;
        private Label lblGrupo;
    }
}