namespace RepasoEquipo
{
    partial class FrmCompetencia
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
            cmbEquipoUno = new ComboBox();
            cmbEquipoDos = new ComboBox();
            btnDesafiar = new Button();
            rchtDatosTorneo = new RichTextBox();
            dgvResultados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // cmbEquipoUno
            // 
            cmbEquipoUno.FormattingEnabled = true;
            cmbEquipoUno.Location = new Point(12, 12);
            cmbEquipoUno.Name = "cmbEquipoUno";
            cmbEquipoUno.Size = new Size(200, 23);
            cmbEquipoUno.TabIndex = 0;
            cmbEquipoUno.SelectedIndexChanged += cmbEquipoUno_SelectedIndexChanged;
            // 
            // cmbEquipoDos
            // 
            cmbEquipoDos.FormattingEnabled = true;
            cmbEquipoDos.Location = new Point(218, 12);
            cmbEquipoDos.Name = "cmbEquipoDos";
            cmbEquipoDos.Size = new Size(200, 23);
            cmbEquipoDos.TabIndex = 1;
            // 
            // btnDesafiar
            // 
            btnDesafiar.Location = new Point(173, 41);
            btnDesafiar.Name = "btnDesafiar";
            btnDesafiar.Size = new Size(75, 23);
            btnDesafiar.TabIndex = 2;
            btnDesafiar.Text = "Desafiar";
            btnDesafiar.UseVisualStyleBackColor = true;
            btnDesafiar.Click += btnDesafiar_Click;
            // 
            // rchtDatosTorneo
            // 
            rchtDatosTorneo.Location = new Point(12, 226);
            rchtDatosTorneo.Name = "rchtDatosTorneo";
            rchtDatosTorneo.Size = new Size(406, 145);
            rchtDatosTorneo.TabIndex = 3;
            rchtDatosTorneo.Text = "";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(12, 70);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowTemplate.Height = 25;
            dgvResultados.Size = new Size(406, 150);
            dgvResultados.TabIndex = 4;
            // 
            // FrmCompetencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 383);
            Controls.Add(dgvResultados);
            Controls.Add(rchtDatosTorneo);
            Controls.Add(btnDesafiar);
            Controls.Add(cmbEquipoDos);
            Controls.Add(cmbEquipoUno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCompetencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Competencia";
            Load += FrmCompetencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbEquipoUno;
        private ComboBox cmbEquipoDos;
        private Button btnDesafiar;
        private RichTextBox rchtDatosTorneo;
        private DataGridView dgvResultados;
    }
}