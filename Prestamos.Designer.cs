namespace biblioteca
{
    partial class Prestamos
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            flowPanelPrestamosActuales = new FlowLayoutPanel();
            prestamobt = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Libro";
            // 
            // flowPanelPrestamosActuales
            // 
            flowPanelPrestamosActuales.Location = new Point(326, 62);
            flowPanelPrestamosActuales.Name = "flowPanelPrestamosActuales";
            flowPanelPrestamosActuales.Size = new Size(350, 356);
            flowPanelPrestamosActuales.TabIndex = 3;
            // 
            // prestamobt
            // 
            prestamobt.Location = new Point(77, 248);
            prestamobt.Name = "prestamobt";
            prestamobt.Size = new Size(139, 23);
            prestamobt.TabIndex = 0;
            prestamobt.Text = "Realizar Prestamo";
            prestamobt.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(160, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(21, 187);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(260, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 32);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Miembro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 111);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha de Prestamo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 169);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha de Entrega";
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(comboBox2);
            Controls.Add(prestamobt);
            Controls.Add(flowPanelPrestamosActuales);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Prestamos";
            Text = "Prestamos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private FlowLayoutPanel flowPanelPrestamosActuales;
        private Button prestamobt;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}