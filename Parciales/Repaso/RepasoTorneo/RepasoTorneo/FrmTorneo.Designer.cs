namespace RepasoTorneo
{
    partial class FrmTorneo
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
            rchtDatosTorneo = new RichTextBox();
            dgvResultados = new DataGridView();
            btnDesafiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // cmbEquipoUno
            // 
            cmbEquipoUno.FormattingEnabled = true;
            cmbEquipoUno.Location = new Point(12, 12);
            cmbEquipoUno.Name = "cmbEquipoUno";
            cmbEquipoUno.Size = new Size(160, 23);
            cmbEquipoUno.TabIndex = 0;
            // 
            // cmbEquipoDos
            // 
            cmbEquipoDos.FormattingEnabled = true;
            cmbEquipoDos.Location = new Point(178, 12);
            cmbEquipoDos.Name = "cmbEquipoDos";
            cmbEquipoDos.Size = new Size(160, 23);
            cmbEquipoDos.TabIndex = 1;
            // 
            // rchtDatosTorneo
            // 
            rchtDatosTorneo.Location = new Point(12, 241);
            rchtDatosTorneo.Name = "rchtDatosTorneo";
            rchtDatosTorneo.Size = new Size(326, 96);
            rchtDatosTorneo.TabIndex = 2;
            rchtDatosTorneo.Text = "";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(12, 70);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowTemplate.Height = 25;
            dgvResultados.Size = new Size(326, 165);
            dgvResultados.TabIndex = 3;
            // 
            // btnDesafiar
            // 
            btnDesafiar.Location = new Point(114, 41);
            btnDesafiar.Name = "btnDesafiar";
            btnDesafiar.Size = new Size(120, 23);
            btnDesafiar.TabIndex = 4;
            btnDesafiar.Text = "Jugar Partido";
            btnDesafiar.UseVisualStyleBackColor = true;
            // 
            // FrmTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 355);
            Controls.Add(btnDesafiar);
            Controls.Add(dgvResultados);
            Controls.Add(rchtDatosTorneo);
            Controls.Add(cmbEquipoDos);
            Controls.Add(cmbEquipoUno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTorneo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Competencia";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbEquipoUno;
        private ComboBox cmbEquipoDos;
        private RichTextBox rchtDatosTorneo;
        private DataGridView dgvResultados;
        private Button btnDesafiar;
    }
}