namespace Ejer_56
{
    partial class frmNotepad
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
            menuStrip = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            stripStatusLabelCaracteres = new StatusStrip();
            rtxtContenido = new RichTextBox();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            stripStatusLabelCaracteres.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(684, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            abrirToolStripMenuItem.Size = new Size(269, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarToolStripMenuItem.Size = new Size(269, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            guardarComoToolStripMenuItem.Size = new Size(269, 22);
            guardarComoToolStripMenuItem.Text = "Guardar como...";
            // 
            // stripStatusLabelCaracteres
            // 
            stripStatusLabelCaracteres.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2 });
            stripStatusLabelCaracteres.Location = new Point(0, 384);
            stripStatusLabelCaracteres.Name = "stripStatusLabelCaracteres";
            stripStatusLabelCaracteres.Size = new Size(684, 22);
            stripStatusLabelCaracteres.TabIndex = 1;
            stripStatusLabelCaracteres.Text = "statusStrip1";
            // 
            // rtxtContenido
            // 
            rtxtContenido.Dock = DockStyle.Fill;
            rtxtContenido.Location = new Point(0, 24);
            rtxtContenido.Name = "rtxtContenido";
            rtxtContenido.Size = new Size(684, 360);
            rtxtContenido.TabIndex = 2;
            rtxtContenido.Text = "";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // frmNotepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 406);
            Controls.Add(rtxtContenido);
            Controls.Add(stripStatusLabelCaracteres);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNotepad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            stripStatusLabelCaracteres.ResumeLayout(false);
            stripStatusLabelCaracteres.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private StatusStrip stripStatusLabelCaracteres;
        private RichTextBox rtxtContenido;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}