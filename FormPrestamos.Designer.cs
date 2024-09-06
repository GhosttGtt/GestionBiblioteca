namespace Biblioteca
{
    partial class FormPrestamos
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
            btnRealizarPrestamo = new Button();
            cmbLibros = new ComboBox();
            cmbMiembros = new ComboBox();
            dgvHistorialPrestamos = new DataGridView();
            TituloLibro = new DataGridViewTextBoxColumn();
            NombreMiembro = new DataGridViewTextBoxColumn();
            FecahaPrestamo = new DataGridViewTextBoxColumn();
            FechaDevolucion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            dtpFechaPrestamo = new DateTimePicker();
            Volver = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialPrestamos).BeginInit();
            SuspendLayout();
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.Location = new Point(513, 234);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Size = new Size(251, 23);
            btnRealizarPrestamo.TabIndex = 0;
            btnRealizarPrestamo.Text = "Prestamo";
            btnRealizarPrestamo.UseVisualStyleBackColor = true;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // cmbLibros
            // 
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(513, 112);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(251, 23);
            cmbLibros.TabIndex = 1;
            // 
            // cmbMiembros
            // 
            cmbMiembros.FormattingEnabled = true;
            cmbMiembros.Location = new Point(513, 157);
            cmbMiembros.Name = "cmbMiembros";
            cmbMiembros.Size = new Size(251, 23);
            cmbMiembros.TabIndex = 2;
            // 
            // dgvHistorialPrestamos
            // 
            dgvHistorialPrestamos.AllowUserToAddRows = false;
            dgvHistorialPrestamos.AllowUserToDeleteRows = false;
            dgvHistorialPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialPrestamos.BackgroundColor = Color.White;
            dgvHistorialPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorialPrestamos.Columns.AddRange(new DataGridViewColumn[] { TituloLibro, NombreMiembro, FecahaPrestamo, FechaDevolucion, Estado });
            dgvHistorialPrestamos.Location = new Point(21, 61);
            dgvHistorialPrestamos.MultiSelect = false;
            dgvHistorialPrestamos.Name = "dgvHistorialPrestamos";
            dgvHistorialPrestamos.ReadOnly = true;
            dgvHistorialPrestamos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvHistorialPrestamos.Size = new Size(462, 339);
            dgvHistorialPrestamos.TabIndex = 3;
            dgvHistorialPrestamos.CellContentClick += dgvHistorialPrestamos_CellContentClick;
            // 
            // TituloLibro
            // 
            TituloLibro.HeaderText = "Titulo Libro";
            TituloLibro.Name = "TituloLibro";
            TituloLibro.ReadOnly = true;
            // 
            // NombreMiembro
            // 
            NombreMiembro.HeaderText = "Miembro";
            NombreMiembro.Name = "NombreMiembro";
            NombreMiembro.ReadOnly = true;
            // 
            // FecahaPrestamo
            // 
            FecahaPrestamo.HeaderText = "Fecha Prestamo";
            FecahaPrestamo.Name = "FecahaPrestamo";
            FecahaPrestamo.ReadOnly = true;
            // 
            // FechaDevolucion
            // 
            FechaDevolucion.HeaderText = "Fecha Devolucion";
            FechaDevolucion.Name = "FechaDevolucion";
            FechaDevolucion.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(513, 205);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(251, 23);
            dtpFechaPrestamo.TabIndex = 4;
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
            Volver.TabIndex = 27;
            Volver.Text = "Regresar";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(306, 14);
            label5.Name = "label5";
            label5.Size = new Size(213, 25);
            label5.TabIndex = 28;
            label5.Text = "----- PRESTAMOS -----";
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(Volver);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(dgvHistorialPrestamos);
            Controls.Add(cmbMiembros);
            Controls.Add(cmbLibros);
            Controls.Add(btnRealizarPrestamo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrestamos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormPrestamos";
            ((System.ComponentModel.ISupportInitialize)dgvHistorialPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRealizarPrestamo;
        private ComboBox cmbLibros;
        private ComboBox cmbMiembros;
        private DataGridView dgvHistorialPrestamos;
        private DataGridViewTextBoxColumn TituloLibro;
        private DataGridViewTextBoxColumn NombreMiembro;
        private DataGridViewTextBoxColumn FecahaPrestamo;
        private DataGridViewTextBoxColumn FechaDevolucion;
        private DataGridViewTextBoxColumn Estado;
        private DateTimePicker dtpFechaPrestamo;
        private Button Volver;
        private Label label5;
    }
}