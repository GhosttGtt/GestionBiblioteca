namespace Biblioteca
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            btnGestionLibros = new Button();
            btnGestionMiembros = new Button();
            btnPrestamos = new Button();
            Cerrar = new Button();
            SuspendLayout();
            // 
            // btnGestionLibros
            // 
            btnGestionLibros.BackgroundImage = (Image)resources.GetObject("btnGestionLibros.BackgroundImage");
            btnGestionLibros.BackgroundImageLayout = ImageLayout.Stretch;
            btnGestionLibros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionLibros.Location = new Point(142, 147);
            btnGestionLibros.Name = "btnGestionLibros";
            btnGestionLibros.Size = new Size(150, 150);
            btnGestionLibros.TabIndex = 0;
            btnGestionLibros.Text = "Libros";
            btnGestionLibros.TextAlign = ContentAlignment.BottomCenter;
            btnGestionLibros.UseVisualStyleBackColor = true;
            btnGestionLibros.Click += btnGestionLibros_Click;
            // 
            // btnGestionMiembros
            // 
            btnGestionMiembros.BackgroundImage = (Image)resources.GetObject("btnGestionMiembros.BackgroundImage");
            btnGestionMiembros.BackgroundImageLayout = ImageLayout.Stretch;
            btnGestionMiembros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionMiembros.Location = new Point(338, 147);
            btnGestionMiembros.Name = "btnGestionMiembros";
            btnGestionMiembros.Size = new Size(150, 150);
            btnGestionMiembros.TabIndex = 1;
            btnGestionMiembros.Text = "Miembros";
            btnGestionMiembros.TextAlign = ContentAlignment.BottomCenter;
            btnGestionMiembros.UseVisualStyleBackColor = true;
            btnGestionMiembros.Click += btnGestionMiembros_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackgroundImage = (Image)resources.GetObject("btnPrestamos.BackgroundImage");
            btnPrestamos.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrestamos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.Location = new Point(533, 147);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(150, 150);
            btnPrestamos.TabIndex = 2;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextAlign = ContentAlignment.BottomCenter;
            btnPrestamos.UseVisualStyleBackColor = true;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = Color.Red;
            Cerrar.Cursor = Cursors.Hand;
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cerrar.ForeColor = Color.White;
            Cerrar.Location = new Point(750, 12);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(38, 35);
            Cerrar.TabIndex = 3;
            Cerrar.Text = "X";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.LightSlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Cerrar);
            Controls.Add(btnPrestamos);
            Controls.Add(btnGestionMiembros);
            Controls.Add(btnGestionLibros);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionLibros;
        private Button btnGestionMiembros;
        private Button btnPrestamos;
        private Button Cerrar;
    }
}
