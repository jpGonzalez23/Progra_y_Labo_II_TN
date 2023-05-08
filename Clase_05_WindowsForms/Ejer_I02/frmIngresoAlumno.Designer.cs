namespace Ejer_I02
{
    partial class frmIngresoAlumno
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
            gpbDetallesDelAlumno = new GroupBox();
            lblEdadUsuario = new Label();
            lblDireccionUsuario = new Label();
            lblNombreUsuario = new Label();
            nupEdadUsuario = new NumericUpDown();
            txtDireccionUsuario = new TextBox();
            txtNombreUsuario = new TextBox();
            gpbGenero = new GroupBox();
            robGeneroNoBinario = new RadioButton();
            robGeneroFemenino = new RadioButton();
            robGeneroMasculino = new RadioButton();
            gpbCursos = new GroupBox();
            ckbCursoJS = new CheckBox();
            ckbCursoCMasMas = new CheckBox();
            ckbCursoCSharp = new CheckBox();
            lstPais = new ListBox();
            btnIngresar = new Button();
            lblPais = new Label();
            gpbDetallesDelAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupEdadUsuario).BeginInit();
            gpbGenero.SuspendLayout();
            gpbCursos.SuspendLayout();
            SuspendLayout();
            // 
            // gpbDetallesDelAlumno
            // 
            gpbDetallesDelAlumno.Controls.Add(lblEdadUsuario);
            gpbDetallesDelAlumno.Controls.Add(lblDireccionUsuario);
            gpbDetallesDelAlumno.Controls.Add(lblNombreUsuario);
            gpbDetallesDelAlumno.Controls.Add(nupEdadUsuario);
            gpbDetallesDelAlumno.Controls.Add(txtDireccionUsuario);
            gpbDetallesDelAlumno.Controls.Add(txtNombreUsuario);
            gpbDetallesDelAlumno.Location = new Point(12, 12);
            gpbDetallesDelAlumno.Name = "gpbDetallesDelAlumno";
            gpbDetallesDelAlumno.Size = new Size(198, 136);
            gpbDetallesDelAlumno.TabIndex = 0;
            gpbDetallesDelAlumno.TabStop = false;
            gpbDetallesDelAlumno.Text = "Detalles del usuario";
            // 
            // lblEdadUsuario
            // 
            lblEdadUsuario.AutoSize = true;
            lblEdadUsuario.Location = new Point(6, 108);
            lblEdadUsuario.Name = "lblEdadUsuario";
            lblEdadUsuario.Size = new Size(33, 15);
            lblEdadUsuario.TabIndex = 6;
            lblEdadUsuario.Text = "Edad";
            // 
            // lblDireccionUsuario
            // 
            lblDireccionUsuario.AutoSize = true;
            lblDireccionUsuario.Location = new Point(6, 68);
            lblDireccionUsuario.Name = "lblDireccionUsuario";
            lblDireccionUsuario.Size = new Size(57, 15);
            lblDireccionUsuario.TabIndex = 5;
            lblDireccionUsuario.Text = "Dirección";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(6, 26);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(51, 15);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "Nombre";
            // 
            // nupEdadUsuario
            // 
            nupEdadUsuario.Location = new Point(69, 100);
            nupEdadUsuario.Name = "nupEdadUsuario";
            nupEdadUsuario.Size = new Size(120, 23);
            nupEdadUsuario.TabIndex = 2;
            // 
            // txtDireccionUsuario
            // 
            txtDireccionUsuario.Location = new Point(69, 60);
            txtDireccionUsuario.Name = "txtDireccionUsuario";
            txtDireccionUsuario.Size = new Size(100, 23);
            txtDireccionUsuario.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(69, 18);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 2;
            // 
            // gpbGenero
            // 
            gpbGenero.Controls.Add(robGeneroNoBinario);
            gpbGenero.Controls.Add(robGeneroFemenino);
            gpbGenero.Controls.Add(robGeneroMasculino);
            gpbGenero.Location = new Point(254, 12);
            gpbGenero.Name = "gpbGenero";
            gpbGenero.Size = new Size(96, 100);
            gpbGenero.TabIndex = 1;
            gpbGenero.TabStop = false;
            gpbGenero.Text = "Género";
            // 
            // robGeneroNoBinario
            // 
            robGeneroNoBinario.AutoSize = true;
            robGeneroNoBinario.Location = new Point(6, 72);
            robGeneroNoBinario.Name = "robGeneroNoBinario";
            robGeneroNoBinario.Size = new Size(81, 19);
            robGeneroNoBinario.TabIndex = 4;
            robGeneroNoBinario.TabStop = true;
            robGeneroNoBinario.Text = "No Binario";
            robGeneroNoBinario.UseVisualStyleBackColor = true;
            // 
            // robGeneroFemenino
            // 
            robGeneroFemenino.AutoSize = true;
            robGeneroFemenino.Location = new Point(6, 47);
            robGeneroFemenino.Name = "robGeneroFemenino";
            robGeneroFemenino.Size = new Size(78, 19);
            robGeneroFemenino.TabIndex = 3;
            robGeneroFemenino.TabStop = true;
            robGeneroFemenino.Text = "Femenino";
            robGeneroFemenino.UseVisualStyleBackColor = true;
            // 
            // robGeneroMasculino
            // 
            robGeneroMasculino.AutoSize = true;
            robGeneroMasculino.Location = new Point(6, 22);
            robGeneroMasculino.Name = "robGeneroMasculino";
            robGeneroMasculino.Size = new Size(80, 19);
            robGeneroMasculino.TabIndex = 2;
            robGeneroMasculino.TabStop = true;
            robGeneroMasculino.Text = "Masculino";
            robGeneroMasculino.UseVisualStyleBackColor = true;
            // 
            // gpbCursos
            // 
            gpbCursos.Controls.Add(ckbCursoJS);
            gpbCursos.Controls.Add(ckbCursoCMasMas);
            gpbCursos.Controls.Add(ckbCursoCSharp);
            gpbCursos.Location = new Point(254, 118);
            gpbCursos.Name = "gpbCursos";
            gpbCursos.Size = new Size(96, 100);
            gpbCursos.TabIndex = 1;
            gpbCursos.TabStop = false;
            gpbCursos.Text = "Curso";
            // 
            // ckbCursoJS
            // 
            ckbCursoJS.AutoSize = true;
            ckbCursoJS.Location = new Point(6, 72);
            ckbCursoJS.Name = "ckbCursoJS";
            ckbCursoJS.Size = new Size(78, 19);
            ckbCursoJS.TabIndex = 2;
            ckbCursoJS.Text = "JavaScript";
            ckbCursoJS.UseVisualStyleBackColor = true;
            // 
            // ckbCursoCMasMas
            // 
            ckbCursoCMasMas.AutoSize = true;
            ckbCursoCMasMas.Location = new Point(6, 47);
            ckbCursoCMasMas.Name = "ckbCursoCMasMas";
            ckbCursoCMasMas.Size = new Size(50, 19);
            ckbCursoCMasMas.TabIndex = 1;
            ckbCursoCMasMas.Text = "C++";
            ckbCursoCMasMas.UseVisualStyleBackColor = true;
            // 
            // ckbCursoCSharp
            // 
            ckbCursoCSharp.AutoSize = true;
            ckbCursoCSharp.Location = new Point(6, 22);
            ckbCursoCSharp.Name = "ckbCursoCSharp";
            ckbCursoCSharp.Size = new Size(41, 19);
            ckbCursoCSharp.TabIndex = 0;
            ckbCursoCSharp.Text = "C#";
            ckbCursoCSharp.UseVisualStyleBackColor = true;
            // 
            // lstPais
            // 
            lstPais.FormattingEnabled = true;
            lstPais.ItemHeight = 15;
            lstPais.Location = new Point(12, 190);
            lstPais.Name = "lstPais";
            lstPais.Size = new Size(198, 139);
            lstPais.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(275, 306);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(12, 172);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 4;
            lblPais.Text = "Pais";
            // 
            // frmIngresoAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 344);
            Controls.Add(lblPais);
            Controls.Add(btnIngresar);
            Controls.Add(lstPais);
            Controls.Add(gpbGenero);
            Controls.Add(gpbCursos);
            Controls.Add(gpbDetallesDelAlumno);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmIngresoAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            gpbDetallesDelAlumno.ResumeLayout(false);
            gpbDetallesDelAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupEdadUsuario).EndInit();
            gpbGenero.ResumeLayout(false);
            gpbGenero.PerformLayout();
            gpbCursos.ResumeLayout(false);
            gpbCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbDetallesDelAlumno;
        private GroupBox gpbCursos;
        private GroupBox gpbGenero;

        private NumericUpDown nupEdadUsuario;

        private TextBox txtDireccionUsuario;
        private TextBox txtNombreUsuario;

        private RadioButton robGeneroNoBinario;
        private RadioButton robGeneroFemenino;
        private RadioButton robGeneroMasculino;

        private CheckBox ckbCursoJS;
        private CheckBox ckbCursoCMasMas;
        private CheckBox ckbCursoCSharp;

        private ListBox lstPais;

        private Button btnIngresar;

        private Label lblPais;
        private Label lblEdadUsuario;
        private Label lblDireccionUsuario;
        private Label lblNombreUsuario;
    }
}