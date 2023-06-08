namespace Ejer_I01_ListaSupermercado
{
    partial class FrmListaSuper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstObjeto = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lstObjeto
            // 
            lstObjeto.FormattingEnabled = true;
            lstObjeto.ItemHeight = 15;
            lstObjeto.Location = new Point(12, 12);
            lstObjeto.Name = "lstObjeto";
            lstObjeto.Size = new Size(170, 259);
            lstObjeto.TabIndex = 0;
            lstObjeto.KeyPress += lstObjeto_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(190, 11);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(48, 41);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(190, 58);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(48, 41);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(190, 105);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(48, 40);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "M";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmListaSuper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 291);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lstObjeto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmListaSuper";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaSuper";
            Load += FrmListaSuper_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstObjeto;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}