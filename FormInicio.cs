namespace Biblioteca
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            Biblioteca.CargarDatosEjemplo();
        }

        private void btnGestionLibros_Click(object sender, EventArgs e)
        {


            this.Hide();

            // Crear y mostrar el formulario secundario
            using (var formSecundario = new FormLibros())
            {
                // Mostrar el formulario secundario
                formSecundario.ShowDialog();

                // Al cerrar el formulario secundario, volvemos a mostrar el formulario principal
                this.Show();
            }



        }

        private void btnGestionMiembros_Click(object sender, EventArgs e)
        {

            this.Hide();

            // Crear y mostrar el formulario secundario
            using (var formSecundario = new FormMiembros())
            {
                // Mostrar el formulario secundario
                formSecundario.ShowDialog();

                // Al cerrar el formulario secundario, volvemos a mostrar el formulario principal
                this.Show();
            }

        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var formSecundario = new FormPrestamos())
            {
                // Mostrar el formulario secundario
                formSecundario.ShowDialog();

                // Al cerrar el formulario secundario, volvemos a mostrar el formulario principal
                this.Show();
            }


        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
