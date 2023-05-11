namespace PrimerParcial
{
    partial class frnABMInscripcionAlumno
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
            gbAltaAlumno = new GroupBox();
            lblNombreAlumno = new Label();
            lblApellidoAlumno = new Label();
            lblDNIAlumno = new Label();
            btnCrearAlumno = new Button();
            txtNombreAlumno = new TextBox();
            txtApellidoAlumno = new TextBox();
            txtDNIAlumno = new TextBox();
            lstAlumnosCreados = new ListBox();
            gbAsignarMateria = new GroupBox();
            btnAsignarMateria = new Button();
            cmbMaterias = new ComboBox();
            lstAlumnosInscriptosProgra = new ListBox();
            lstAlumnosInscriptosLabo = new ListBox();
            label1 = new Label();
            lblInscripcionProgra = new Label();
            lblInscriptosLabo = new Label();
            gbAltaAlumno.SuspendLayout();
            gbAsignarMateria.SuspendLayout();
            SuspendLayout();
            // 
            // gbAltaAlumno
            // 
            gbAltaAlumno.Controls.Add(lblNombreAlumno);
            gbAltaAlumno.Controls.Add(lblApellidoAlumno);
            gbAltaAlumno.Controls.Add(lblDNIAlumno);
            gbAltaAlumno.Controls.Add(btnCrearAlumno);
            gbAltaAlumno.Controls.Add(txtNombreAlumno);
            gbAltaAlumno.Controls.Add(txtApellidoAlumno);
            gbAltaAlumno.Controls.Add(txtDNIAlumno);
            gbAltaAlumno.Location = new Point(199, 12);
            gbAltaAlumno.Name = "gbAltaAlumno";
            gbAltaAlumno.Size = new Size(350, 180);
            gbAltaAlumno.TabIndex = 0;
            gbAltaAlumno.TabStop = false;
            gbAltaAlumno.Text = "Alta ALumno";
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Location = new Point(232, 47);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(56, 15);
            lblNombreAlumno.TabIndex = 6;
            lblNombreAlumno.Text = "NOMBRE";
            // 
            // lblApellidoAlumno
            // 
            lblApellidoAlumno.AutoSize = true;
            lblApellidoAlumno.Location = new Point(126, 47);
            lblApellidoAlumno.Name = "lblApellidoAlumno";
            lblApellidoAlumno.Size = new Size(60, 15);
            lblApellidoAlumno.TabIndex = 5;
            lblApellidoAlumno.Text = "APELLIDO";
            // 
            // lblDNIAlumno
            // 
            lblDNIAlumno.AutoSize = true;
            lblDNIAlumno.Location = new Point(20, 47);
            lblDNIAlumno.Name = "lblDNIAlumno";
            lblDNIAlumno.Size = new Size(30, 15);
            lblDNIAlumno.TabIndex = 1;
            lblDNIAlumno.Text = "DNI:";
            // 
            // btnCrearAlumno
            // 
            btnCrearAlumno.AutoSize = true;
            btnCrearAlumno.Location = new Point(99, 130);
            btnCrearAlumno.Name = "btnCrearAlumno";
            btnCrearAlumno.Size = new Size(154, 25);
            btnCrearAlumno.TabIndex = 4;
            btnCrearAlumno.Text = "Crear Alumno";
            btnCrearAlumno.UseVisualStyleBackColor = true;
            btnCrearAlumno.Click += btnCrearAlumno_Click;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(232, 65);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(100, 23);
            txtNombreAlumno.TabIndex = 3;
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.Location = new Point(126, 65);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(100, 23);
            txtApellidoAlumno.TabIndex = 2;
            // 
            // txtDNIAlumno
            // 
            txtDNIAlumno.Location = new Point(20, 65);
            txtDNIAlumno.Name = "txtDNIAlumno";
            txtDNIAlumno.Size = new Size(100, 23);
            txtDNIAlumno.TabIndex = 1;
            // 
            // lstAlumnosCreados
            // 
            lstAlumnosCreados.FormattingEnabled = true;
            lstAlumnosCreados.ItemHeight = 15;
            lstAlumnosCreados.Location = new Point(12, 269);
            lstAlumnosCreados.Name = "lstAlumnosCreados";
            lstAlumnosCreados.Size = new Size(145, 169);
            lstAlumnosCreados.TabIndex = 1;
            // 
            // gbAsignarMateria
            // 
            gbAsignarMateria.Controls.Add(btnAsignarMateria);
            gbAsignarMateria.Controls.Add(cmbMaterias);
            gbAsignarMateria.Location = new Point(185, 269);
            gbAsignarMateria.Name = "gbAsignarMateria";
            gbAsignarMateria.Size = new Size(220, 169);
            gbAsignarMateria.TabIndex = 2;
            gbAsignarMateria.TabStop = false;
            gbAsignarMateria.Text = "Asignar Materia";
            // 
            // btnAsignarMateria
            // 
            btnAsignarMateria.Location = new Point(49, 108);
            btnAsignarMateria.Name = "btnAsignarMateria";
            btnAsignarMateria.Size = new Size(127, 42);
            btnAsignarMateria.TabIndex = 9;
            btnAsignarMateria.Text = "Asignar al alumno seleccionado";
            btnAsignarMateria.UseVisualStyleBackColor = true;
            btnAsignarMateria.Click += btnAsignarMateria_Click;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(49, 39);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(125, 23);
            cmbMaterias.TabIndex = 8;
            // 
            // lstAlumnosInscriptosProgra
            // 
            lstAlumnosInscriptosProgra.FormattingEnabled = true;
            lstAlumnosInscriptosProgra.ItemHeight = 15;
            lstAlumnosInscriptosProgra.Location = new Point(431, 269);
            lstAlumnosInscriptosProgra.Name = "lstAlumnosInscriptosProgra";
            lstAlumnosInscriptosProgra.Size = new Size(151, 169);
            lstAlumnosInscriptosProgra.TabIndex = 3;
            // 
            // lstAlumnosInscriptosLabo
            // 
            lstAlumnosInscriptosLabo.FormattingEnabled = true;
            lstAlumnosInscriptosLabo.ItemHeight = 15;
            lstAlumnosInscriptosLabo.Location = new Point(637, 269);
            lstAlumnosInscriptosLabo.Name = "lstAlumnosInscriptosLabo";
            lstAlumnosInscriptosLabo.Size = new Size(151, 169);
            lstAlumnosInscriptosLabo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 251);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 5;
            label1.Text = "Alumnos Creados";
            // 
            // lblInscripcionProgra
            // 
            lblInscripcionProgra.AutoSize = true;
            lblInscripcionProgra.Location = new Point(431, 251);
            lblInscripcionProgra.Name = "lblInscripcionProgra";
            lblInscripcionProgra.Size = new Size(106, 15);
            lblInscripcionProgra.TabIndex = 6;
            lblInscripcionProgra.Text = "Inscripción Progra:";
            // 
            // lblInscriptosLabo
            // 
            lblInscriptosLabo.AutoSize = true;
            lblInscriptosLabo.Location = new Point(637, 251);
            lblInscriptosLabo.Name = "lblInscriptosLabo";
            lblInscriptosLabo.Size = new Size(90, 15);
            lblInscriptosLabo.TabIndex = 7;
            lblInscriptosLabo.Text = "Inscriptos Labo:";
            // 
            // frnABMInscripcionAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInscriptosLabo);
            Controls.Add(lblInscripcionProgra);
            Controls.Add(label1);
            Controls.Add(lstAlumnosInscriptosLabo);
            Controls.Add(lstAlumnosInscriptosProgra);
            Controls.Add(gbAsignarMateria);
            Controls.Add(lstAlumnosCreados);
            Controls.Add(gbAltaAlumno);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frnABMInscripcionAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripcion Alumno";
            Load += frnABMInscripcionAlumno_Load;
            gbAltaAlumno.ResumeLayout(false);
            gbAltaAlumno.PerformLayout();
            gbAsignarMateria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbAltaAlumno;
        private GroupBox gbAsignarMateria;

        private Label lblNombreAlumno;
        private Label lblApellidoAlumno;
        private Label lblDNIAlumno;
        private Label label1;
        private Label lblInscripcionProgra;
        private Label lblInscriptosLabo;

        private Button btnCrearAlumno;
        private Button btnAsignarMateria;

        private TextBox txtNombreAlumno;
        private TextBox txtApellidoAlumno;
        private TextBox txtDNIAlumno;

        private ListBox lstAlumnosCreados;
        private ListBox lstAlumnosInscriptosProgra;
        private ListBox lstAlumnosInscriptosLabo;

        private ComboBox cmbMaterias;

    }
}