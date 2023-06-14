namespace Ejer_67
{
    partial class FrmRelojero
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
            lblHora = new Label();
            rhtbMostrar = new RichTextBox();
            btnIniciarReloj = new Button();
            btnDetenerReloj = new Button();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.Location = new Point(12, 9);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(187, 15);
            lblHora.TabIndex = 0;
            // 
            // rhtbMostrar
            // 
            rhtbMostrar.Location = new Point(12, 37);
            rhtbMostrar.Name = "rhtbMostrar";
            rhtbMostrar.Size = new Size(407, 96);
            rhtbMostrar.TabIndex = 1;
            rhtbMostrar.Text = "";
            // 
            // btnIniciarReloj
            // 
            btnIniciarReloj.Location = new Point(233, 9);
            btnIniciarReloj.Name = "btnIniciarReloj";
            btnIniciarReloj.Size = new Size(90, 23);
            btnIniciarReloj.TabIndex = 2;
            btnIniciarReloj.Text = "Iniciar Reloj";
            btnIniciarReloj.UseVisualStyleBackColor = true;
            btnIniciarReloj.Click += btnIniciarReloj_Click;
            // 
            // btnDetenerReloj
            // 
            btnDetenerReloj.Location = new Point(329, 9);
            btnDetenerReloj.Name = "btnDetenerReloj";
            btnDetenerReloj.Size = new Size(90, 23);
            btnDetenerReloj.TabIndex = 3;
            btnDetenerReloj.Text = "Detener Reloj";
            btnDetenerReloj.UseVisualStyleBackColor = true;
            btnDetenerReloj.Click += btnDetenerReloj_Click;
            // 
            // FrmRelojero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 147);
            Controls.Add(btnDetenerReloj);
            Controls.Add(btnIniciarReloj);
            Controls.Add(rhtbMostrar);
            Controls.Add(lblHora);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRelojero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reloj";
            Load += FrmRelojero_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblHora;
        private RichTextBox rhtbMostrar;
        private Button btnIniciarReloj;
        private Button btnDetenerReloj;
    }
}