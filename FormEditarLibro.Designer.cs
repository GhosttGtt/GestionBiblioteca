namespace Biblioteca
{
    partial class FormEditarLibro
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtAnioPublicacion = new TextBox();
            txtUbicacion = new TextBox();
            txtTamanioArchivo = new TextBox();
            txtFormato = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Olive;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(201, 193);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(163, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(26, 193);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(26, 28);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(338, 23);
            txtTitulo.TabIndex = 2;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(26, 70);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(338, 23);
            txtAutor.TabIndex = 3;
            // 
            // txtAnioPublicacion
            // 
            txtAnioPublicacion.Location = new Point(26, 109);
            txtAnioPublicacion.Name = "txtAnioPublicacion";
            txtAnioPublicacion.Size = new Size(169, 23);
            txtAnioPublicacion.TabIndex = 4;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(201, 109);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(163, 23);
            txtUbicacion.TabIndex = 5;
            // 
            // txtTamanioArchivo
            // 
            txtTamanioArchivo.Location = new Point(26, 151);
            txtTamanioArchivo.Name = "txtTamanioArchivo";
            txtTamanioArchivo.Size = new Size(169, 23);
            txtTamanioArchivo.TabIndex = 6;
            // 
            // txtFormato
            // 
            txtFormato.Location = new Point(201, 151);
            txtFormato.Name = "txtFormato";
            txtFormato.Size = new Size(163, 23);
            txtFormato.TabIndex = 7;
            // 
            // FormEditarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(389, 238);
            Controls.Add(txtFormato);
            Controls.Add(txtTamanioArchivo);
            Controls.Add(txtUbicacion);
            Controls.Add(txtAnioPublicacion);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarLibro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormEditarLibro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtAnioPublicacion;
        private TextBox txtUbicacion;
        private TextBox txtTamanioArchivo;
        private TextBox txtFormato;
    }
}