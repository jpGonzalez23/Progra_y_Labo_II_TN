namespace Ejer_63
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
            rctbMostrar = new RichTextBox();
            lblHora = new Label();
            SuspendLayout();
            // 
            // rctbMostrar
            // 
            rctbMostrar.Location = new Point(12, 27);
            rctbMostrar.Name = "rctbMostrar";
            rctbMostrar.Size = new Size(387, 179);
            rctbMostrar.TabIndex = 0;
            rctbMostrar.Text = "";
            // 
            // lblHora
            // 
            lblHora.Location = new Point(12, 9);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(387, 15);
            lblHora.TabIndex = 1;
            // 
            // FrmRelojero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 217);
            Controls.Add(lblHora);
            Controls.Add(rctbMostrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmRelojero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reloj";
            Load += FrmRelojero_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rctbMostrar;
        private Label lblHora;
    }
}