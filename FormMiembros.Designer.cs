namespace Biblioteca
{
    partial class FormMiembros
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
            btnAgregarMiembro = new Button();
            txtNombre = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            dgvMiembros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Volver = new Button();
            label1 = new Label();
            label2 = new Label();
            nMiembro = new Label();
            btnModificarMiembro = new Button();
            txtNombreEdit = new TextBox();
            label3 = new Label();
            btnEliminarMiembro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMiembros).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarMiembro
            // 
            btnAgregarMiembro.BackColor = Color.LimeGreen;
            btnAgregarMiembro.Cursor = Cursors.Hand;
            btnAgregarMiembro.FlatStyle = FlatStyle.Flat;
            btnAgregarMiembro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarMiembro.ForeColor = SystemColors.ControlLightLight;
            btnAgregarMiembro.Location = new Point(468, 269);
            btnAgregarMiembro.Name = "btnAgregarMiembro";
            btnAgregarMiembro.Size = new Size(286, 36);
            btnAgregarMiembro.TabIndex = 0;
            btnAgregarMiembro.Text = "Agregar";
            btnAgregarMiembro.UseVisualStyleBackColor = false;
            btnAgregarMiembro.Click += btnAgregarMiembro_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(527, 229);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribe un nombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(448, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 374);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(324, 9);
            label5.Name = "label5";
            label5.Size = new Size(197, 25);
            label5.TabIndex = 23;
            label5.Text = "----- USUARIOS -----";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(485, 136);
            label4.Name = "label4";
            label4.Size = new Size(235, 21);
            label4.TabIndex = 24;
            label4.Text = "REGISTRAR NUEVO MIEMBRO";
            // 
            // dgvMiembros
            // 
            dgvMiembros.AllowUserToAddRows = false;
            dgvMiembros.AllowUserToDeleteRows = false;
            dgvMiembros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMiembros.BackgroundColor = SystemColors.Control;
            dgvMiembros.BorderStyle = BorderStyle.None;
            dgvMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMiembros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvMiembros.Location = new Point(12, 51);
            dgvMiembros.MultiSelect = false;
            dgvMiembros.Name = "dgvMiembros";
            dgvMiembros.ReadOnly = true;
            dgvMiembros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvMiembros.Size = new Size(412, 320);
            dgvMiembros.TabIndex = 25;
            dgvMiembros.CellContentClick += dvgMiembros_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Miembro";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Número de miembro";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
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
            Volver.TabIndex = 26;
            Volver.Text = "Regresar";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(467, 232);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 27;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(468, 194);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 28;
            label2.Text = "Número de Miembro:";
            // 
            // nMiembro
            // 
            nMiembro.BackColor = SystemColors.ActiveCaption;
            nMiembro.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nMiembro.Location = new Point(613, 189);
            nMiembro.Name = "nMiembro";
            nMiembro.Size = new Size(141, 25);
            nMiembro.TabIndex = 29;
            nMiembro.Text = "0";
            nMiembro.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnModificarMiembro
            // 
            btnModificarMiembro.Location = new Point(265, 402);
            btnModificarMiembro.Name = "btnModificarMiembro";
            btnModificarMiembro.Size = new Size(88, 23);
            btnModificarMiembro.TabIndex = 30;
            btnModificarMiembro.Text = "Modificar";
            btnModificarMiembro.UseVisualStyleBackColor = true;
            btnModificarMiembro.Click += btnModificarMiembro_Click;
            // 
            // txtNombreEdit
            // 
            txtNombreEdit.Location = new Point(118, 402);
            txtNombreEdit.Name = "txtNombreEdit";
            txtNombreEdit.Size = new Size(141, 23);
            txtNombreEdit.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 406);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 32;
            label3.Text = "Nuevo nombre:";
            // 
            // btnEliminarMiembro
            // 
            btnEliminarMiembro.Location = new Point(359, 402);
            btnEliminarMiembro.Name = "btnEliminarMiembro";
            btnEliminarMiembro.Size = new Size(75, 23);
            btnEliminarMiembro.TabIndex = 33;
            btnEliminarMiembro.Text = "Eliminar";
            btnEliminarMiembro.UseVisualStyleBackColor = true;
            btnEliminarMiembro.Click += btnEliminarMiembro_Click_1;
            // 
            // FormMiembros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarMiembro);
            Controls.Add(label3);
            Controls.Add(txtNombreEdit);
            Controls.Add(btnModificarMiembro);
            Controls.Add(nMiembro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Volver);
            Controls.Add(dgvMiembros);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregarMiembro);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMiembros";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMiembros";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMiembros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarMiembro;
        private TextBox txtNombre;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private DataGridView dgvMiembros;
        private Button Volver;
        private Label label1;
        private Label label2;
        private Label nMiembro;
        private Button btnModificarMiembro;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox txtNombreEdit;
        private Label label3;
        private Button btnEliminarMiembro;
    }
}