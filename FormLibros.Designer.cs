namespace Biblioteca
{
    partial class FormLibros
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
            btnAgregarLibro = new Button();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtAnioPublicacion = new TextBox();
            txtUbicacion = new TextBox();
            txtTamanoArchivo = new TextBox();
            txtFormato = new TextBox();
            dgvLibros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            cmbTipoLibro = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblUbicacion = new Label();
            lblTamanoArchivo = new Label();
            lblFormato = new Label();
            Volver = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            btnEditarLibro = new Button();
            btnEliminarlibro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.BackColor = Color.OliveDrab;
            btnAgregarLibro.FlatStyle = FlatStyle.Flat;
            btnAgregarLibro.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarLibro.ForeColor = SystemColors.ControlLightLight;
            btnAgregarLibro.Location = new Point(478, 376);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(297, 38);
            btnAgregarLibro.TabIndex = 0;
            btnAgregarLibro.Text = "Agregar";
            btnAgregarLibro.UseVisualStyleBackColor = false;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(584, 158);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(191, 23);
            txtTitulo.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(584, 202);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(191, 23);
            txtAutor.TabIndex = 2;
            // 
            // txtAnioPublicacion
            // 
            txtAnioPublicacion.Location = new Point(584, 246);
            txtAnioPublicacion.Name = "txtAnioPublicacion";
            txtAnioPublicacion.Size = new Size(191, 23);
            txtAnioPublicacion.TabIndex = 3;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(584, 290);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(191, 23);
            txtUbicacion.TabIndex = 4;
            // 
            // txtTamanoArchivo
            // 
            txtTamanoArchivo.Location = new Point(584, 290);
            txtTamanoArchivo.Name = "txtTamanoArchivo";
            txtTamanoArchivo.Size = new Size(191, 23);
            txtTamanoArchivo.TabIndex = 5;
            // 
            // txtFormato
            // 
            txtFormato.Location = new Point(584, 334);
            txtFormato.Name = "txtFormato";
            txtFormato.Size = new Size(191, 23);
            txtFormato.TabIndex = 6;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackgroundColor = Color.White;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvLibros.GridColor = SystemColors.ScrollBar;
            dgvLibros.Location = new Point(12, 84);
            dgvLibros.MultiSelect = false;
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(440, 319);
            dgvLibros.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "Titulo";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Autor";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Publicacion";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Estado";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.ButtonFace;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(12, 55);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(358, 23);
            txtBuscar.TabIndex = 10;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(376, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(76, 23);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // cmbTipoLibro
            // 
            cmbTipoLibro.FormattingEnabled = true;
            cmbTipoLibro.Location = new Point(478, 112);
            cmbTipoLibro.Name = "cmbTipoLibro";
            cmbTipoLibro.Size = new Size(297, 23);
            cmbTipoLibro.TabIndex = 12;
            cmbTipoLibro.Text = "Tipo de Libro";
            cmbTipoLibro.SelectedIndexChanged += cmbTipoLibro_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(478, 161);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre del libro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(478, 205);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre del autor:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(478, 249);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 15;
            label3.Text = "Año publicacion:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.BackColor = SystemColors.ActiveCaption;
            lblUbicacion.Location = new Point(478, 290);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(63, 15);
            lblUbicacion.TabIndex = 16;
            lblUbicacion.Text = "Ubicación:";
            // 
            // lblTamanoArchivo
            // 
            lblTamanoArchivo.AutoSize = true;
            lblTamanoArchivo.BackColor = SystemColors.ActiveCaption;
            lblTamanoArchivo.Location = new Point(478, 293);
            lblTamanoArchivo.Name = "lblTamanoArchivo";
            lblTamanoArchivo.Size = new Size(92, 15);
            lblTamanoArchivo.TabIndex = 17;
            lblTamanoArchivo.Text = "Tamaño archivo";
            // 
            // lblFormato
            // 
            lblFormato.AutoSize = true;
            lblFormato.BackColor = SystemColors.ActiveCaption;
            lblFormato.Location = new Point(478, 338);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(52, 15);
            lblFormato.TabIndex = 18;
            lblFormato.Text = "Formato";
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.FlatStyle = FlatStyle.Flat;
            Volver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = Color.White;
            Volver.Location = new Point(12, 12);
            Volver.Name = "Volver";
            Volver.Size = new Size(75, 27);
            Volver.TabIndex = 19;
            Volver.Text = "Regresar";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(461, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 377);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(529, 68);
            label4.Name = "label4";
            label4.Size = new Size(204, 21);
            label4.TabIndex = 21;
            label4.Text = "REGISTRAR NUEVO LIBRO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(332, 10);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 22;
            label5.Text = "----- LIBROS -----";
            label5.Click += label5_Click;
            // 
            // btnEditarLibro
            // 
            btnEditarLibro.Location = new Point(12, 409);
            btnEditarLibro.Name = "btnEditarLibro";
            btnEditarLibro.Size = new Size(224, 23);
            btnEditarLibro.TabIndex = 23;
            btnEditarLibro.Text = "Editar libro";
            btnEditarLibro.UseVisualStyleBackColor = true;
            btnEditarLibro.Click += btnEditarLibro_Click;
            // 
            // btnEliminarlibro
            // 
            btnEliminarlibro.BackColor = Color.Red;
            btnEliminarlibro.FlatStyle = FlatStyle.Flat;
            btnEliminarlibro.ForeColor = Color.White;
            btnEliminarlibro.Location = new Point(242, 409);
            btnEliminarlibro.Name = "btnEliminarlibro";
            btnEliminarlibro.Size = new Size(210, 23);
            btnEliminarlibro.TabIndex = 24;
            btnEliminarlibro.Text = "Eliminar libro";
            btnEliminarlibro.UseVisualStyleBackColor = false;
            btnEliminarlibro.Click += btnEliminarlibro_Click;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarlibro);
            Controls.Add(btnEditarLibro);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Volver);
            Controls.Add(lblFormato);
            Controls.Add(lblTamanoArchivo);
            Controls.Add(lblUbicacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipoLibro);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvLibros);
            Controls.Add(txtFormato);
            Controls.Add(txtTamanoArchivo);
            Controls.Add(txtUbicacion);
            Controls.Add(txtAnioPublicacion);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(btnAgregarLibro);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLibros";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormLibros";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarLibro;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtAnioPublicacion;
        private TextBox txtUbicacion;
        private TextBox txtTamanoArchivo;
        private TextBox txtFormato;
        private DataGridView dgvLibros;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private ComboBox cmbTipoLibro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblUbicacion;
        private Label lblTamanoArchivo;
        private Label lblFormato;
        private Button Volver;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Button btnEditarLibro;
        private Button btnEliminarlibro;
    }
}