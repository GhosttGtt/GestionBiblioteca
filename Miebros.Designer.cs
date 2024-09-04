namespace biblioteca
{
    partial class Miebros
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
            textBoxNombreMiembro = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            agregarbt = new Button();
            modificarbt = new Button();
            eliminarbt = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // textBoxNombreMiembro
            // 
            textBoxNombreMiembro.Location = new Point(12, 51);
            textBoxNombreMiembro.Name = "textBoxNombreMiembro";
            textBoxNombreMiembro.Size = new Size(262, 23);
            textBoxNombreMiembro.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre del Miembro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 3;
            label2.Text = "Numero de Miemrbo";
            // 
            // agregarbt
            // 
            agregarbt.Location = new Point(364, 33);
            agregarbt.Name = "agregarbt";
            agregarbt.Size = new Size(134, 23);
            agregarbt.TabIndex = 4;
            agregarbt.Text = "Agregar Miembro";
            agregarbt.UseVisualStyleBackColor = true;
            // 
            // modificarbt
            // 
            modificarbt.Location = new Point(364, 75);
            modificarbt.Name = "modificarbt";
            modificarbt.Size = new Size(134, 23);
            modificarbt.TabIndex = 5;
            modificarbt.Text = "Modifica Miembro";
            modificarbt.UseVisualStyleBackColor = true;
            modificarbt.Click += modificarbt_Click;
            // 
            // eliminarbt
            // 
            eliminarbt.Location = new Point(364, 117);
            eliminarbt.Name = "eliminarbt";
            eliminarbt.Size = new Size(134, 23);
            eliminarbt.TabIndex = 6;
            eliminarbt.Text = "Eliminar Miembro";
            eliminarbt.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(9, 182);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(489, 240);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // Miebros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(eliminarbt);
            Controls.Add(modificarbt);
            Controls.Add(agregarbt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBoxNombreMiembro);
            Name = "Miebros";
            Text = "Miebros";
            Load += Miebros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombreMiembro;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button agregarbt;
        private Button modificarbt;
        private Button eliminarbt;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}