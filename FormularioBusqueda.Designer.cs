namespace biblioteca
{
    partial class FormularioBusqueda
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
            components = new System.ComponentModel.Container();
            btnbuscar = new Button();
            textBoxCriterio = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            dgvlibros = new DataGridView();
            radioButtonLibrosFisicos = new RadioButton();
            radioButtonLibrosElectronicos = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvlibros).BeginInit();
            SuspendLayout();
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(197, 125);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(120, 38);
            btnbuscar.TabIndex = 12;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnBuscar_Click;
            // 
            // textBoxCriterio
            // 
            textBoxCriterio.Location = new Point(120, 92);
            textBoxCriterio.Name = "textBoxCriterio";
            textBoxCriterio.Size = new Size(280, 27);
            textBoxCriterio.TabIndex = 11;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgvlibros
            // 
            dgvlibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlibros.Location = new Point(120, 218);
            dgvlibros.Name = "dgvlibros";
            dgvlibros.RowHeadersWidth = 51;
            dgvlibros.Size = new Size(580, 188);
            dgvlibros.TabIndex = 21;
            // 
            // radioButtonLibrosFisicos
            // 
            radioButtonLibrosFisicos.AutoSize = true;
            radioButtonLibrosFisicos.Location = new Point(454, 92);
            radioButtonLibrosFisicos.Name = "radioButtonLibrosFisicos";
            radioButtonLibrosFisicos.Size = new Size(186, 24);
            radioButtonLibrosFisicos.TabIndex = 22;
            radioButtonLibrosFisicos.TabStop = true;
            radioButtonLibrosFisicos.Text = "Busqueda Libros Fisicos";
            radioButtonLibrosFisicos.UseVisualStyleBackColor = true;
            // 
            // radioButtonLibrosElectronicos
            // 
            radioButtonLibrosElectronicos.AutoSize = true;
            radioButtonLibrosElectronicos.Location = new Point(454, 120);
            radioButtonLibrosElectronicos.Name = "radioButtonLibrosElectronicos";
            radioButtonLibrosElectronicos.Size = new Size(246, 24);
            radioButtonLibrosElectronicos.TabIndex = 23;
            radioButtonLibrosElectronicos.TabStop = true;
            radioButtonLibrosElectronicos.Text = "Busqueda De Libros Electronicos";
            radioButtonLibrosElectronicos.UseVisualStyleBackColor = true;
            // 
            // FormularioBusqueda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonLibrosElectronicos);
            Controls.Add(radioButtonLibrosFisicos);
            Controls.Add(dgvlibros);
            Controls.Add(btnbuscar);
            Controls.Add(textBoxCriterio);
            Name = "FormularioBusqueda";
            Text = "FormularioGestionLibros";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvlibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnbuscar;
        private TextBox textBoxCriterio;
        private ErrorProvider errorProvider1;
        private DataGridView dgvlibros;
        private RadioButton radioButtonLibrosFisicos;
        private RadioButton radioButtonLibrosElectronicos;
    }
}