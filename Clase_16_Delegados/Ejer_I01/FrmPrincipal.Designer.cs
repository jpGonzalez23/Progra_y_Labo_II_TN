﻿namespace Ejer_I01
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            altaToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            testDelegadoToolStripMenuItem = new ToolStripMenuItem();
            alumnoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { altaToolStripMenuItem, mostrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testDelegadoToolStripMenuItem, alumnoToolStripMenuItem });
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(40, 20);
            altaToolStripMenuItem.Text = "Alta";
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(60, 20);
            mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // testDelegadoToolStripMenuItem
            // 
            testDelegadoToolStripMenuItem.Name = "testDelegadoToolStripMenuItem";
            testDelegadoToolStripMenuItem.Size = new Size(180, 22);
            testDelegadoToolStripMenuItem.Text = "Test Delegado";
            // 
            // alumnoToolStripMenuItem
            // 
            alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            alumnoToolStripMenuItem.Size = new Size(180, 22);
            alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem testDelegadoToolStripMenuItem;
        private ToolStripMenuItem alumnoToolStripMenuItem;
        private ToolStripMenuItem mostrarToolStripMenuItem;
    }
}