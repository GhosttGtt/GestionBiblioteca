namespace biblioteca
{
    partial class Libros
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
            textBoxTituloLibro = new TextBox();
            textBoxAñoLibro = new TextBox();
            textBoxAutorLibro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            agregarbt = new Button();
            modificarbt = new Button();
            eliminarbt = new Button();
            comboBoxTipoLibro = new ComboBox();
            flowPanelListaLibros = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // textBoxTituloLibro
            // 
            textBoxTituloLibro.Location = new Point(12, 65);
            textBoxTituloLibro.Name = "textBoxTituloLibro";
            textBoxTituloLibro.Size = new Size(294, 23);
            textBoxTituloLibro.TabIndex = 0;
            // 
            // textBoxAñoLibro
            // 
            textBoxAñoLibro.Location = new Point(12, 184);
            textBoxAñoLibro.Name = "textBoxAñoLibro";
            textBoxAñoLibro.Size = new Size(294, 23);
            textBoxAñoLibro.TabIndex = 1;
            // 
            // textBoxAutorLibro
            // 
            textBoxAutorLibro.Location = new Point(12, 125);
            textBoxAutorLibro.Name = "textBoxAutorLibro";
            textBoxAutorLibro.Size = new Size(294, 23);
            textBoxAutorLibro.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 3;
            label1.Text = "Titulo del Libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 5;
            label3.Text = "Año de publicacion";
            // 
            // agregarbt
            // 
            agregarbt.Location = new Point(328, 107);
            agregarbt.Name = "agregarbt";
            agregarbt.Size = new Size(132, 23);
            agregarbt.TabIndex = 6;
            agregarbt.Text = "Agregar";
            agregarbt.UseVisualStyleBackColor = true;
            // 
            // modificarbt
            // 
            modificarbt.Location = new Point(328, 145);
            modificarbt.Name = "modificarbt";
            modificarbt.Size = new Size(132, 23);
            modificarbt.TabIndex = 7;
            modificarbt.Text = "Modificar";
            modificarbt.UseVisualStyleBackColor = true;
            // 
            // eliminarbt
            // 
            eliminarbt.Location = new Point(328, 181);
            eliminarbt.Name = "eliminarbt";
            eliminarbt.Size = new Size(132, 23);
            eliminarbt.TabIndex = 8;
            eliminarbt.Text = "Eliminar";
            eliminarbt.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipoLibro
            // 
            comboBoxTipoLibro.FormattingEnabled = true;
            comboBoxTipoLibro.Items.AddRange(new object[] { "Libro Electronico", "Libro Fisico " });
            comboBoxTipoLibro.Location = new Point(328, 65);
            comboBoxTipoLibro.Name = "comboBoxTipoLibro";
            comboBoxTipoLibro.Size = new Size(132, 23);
            comboBoxTipoLibro.TabIndex = 9;
            // 
            // flowPanelListaLibros
            // 
            flowPanelListaLibros.Location = new Point(12, 232);
            flowPanelListaLibros.Name = "flowPanelListaLibros";
            flowPanelListaLibros.Size = new Size(448, 206);
            flowPanelListaLibros.TabIndex = 11;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 450);
            Controls.Add(flowPanelListaLibros);
            Controls.Add(comboBoxTipoLibro);
            Controls.Add(eliminarbt);
            Controls.Add(modificarbt);
            Controls.Add(agregarbt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAutorLibro);
            Controls.Add(textBoxAñoLibro);
            Controls.Add(textBoxTituloLibro);
            Name = "Libros";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTituloLibro;
        private TextBox textBoxAñoLibro;
        private TextBox textBoxAutorLibro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button agregarbt;
        private Button modificarbt;
        private Button eliminarbt;
        private ComboBox comboBoxTipoLibro;
        private FlowLayoutPanel flowPanelListaLibros;
    }
}
