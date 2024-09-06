using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormLibros : Form
    {
        public FormLibros()
        {
            InitializeComponent();
            CargarLibros();

            InicializarComponentes();
        }
        private void InicializarComponentes()
        {
            // Configurar los elementos del ComboBox
            cmbTipoLibro.Items.Clear();  // Asegurarse de limpiar elementos previos
            cmbTipoLibro.Items.Add("Físico");
            cmbTipoLibro.Items.Add("Digital");

            // Solo asigna el SelectedIndex si hay ítems en el ComboBox
            if (cmbTipoLibro.Items.Count > 0)
            {
                cmbTipoLibro.SelectedIndex = 0; // Selecciona "Físico" por defecto
            }

            MostrarCamposSegunTipo();
        }
        private void MostrarCamposSegunTipo()
        {
            // Mostrar u ocultar campos según el tipo de libro
            if (cmbTipoLibro.SelectedIndex == 0) // Físico
            {
                txtUbicacion.Visible = true;
                lblUbicacion.Visible = true;
                txtTamanoArchivo.Visible = false;
                lblTamanoArchivo.Visible = false;
                txtFormato.Visible = false;
                lblFormato.Visible = false;
            }
            else if (cmbTipoLibro.SelectedIndex == 1) // Digital
            {
                txtUbicacion.Visible = false;
                lblUbicacion.Visible = false;
                txtTamanoArchivo.Visible = true;
                lblTamanoArchivo.Visible = true;
                txtFormato.Visible = true;
                lblFormato.Visible = true;
            }
        }

        private void CargarDatos()
        {
            Clases.Biblioteca.CargarDatosEjemplo();
            dgvLibros.DataSource = Clases.Biblioteca.Libros;
        }

        private void ConfigurarColumnasDataGridView()
        {
            dgvLibros.Columns.Clear();
            dgvLibros.AutoGenerateColumns = false;

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Título", DataPropertyName = "Titulo" });
            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Autor", DataPropertyName = "Autor" });
            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Año de Publicación", DataPropertyName = "AnioPublicacion" });
            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "EstaPrestado" });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tipo",
                DataPropertyName = "Tipo" // Vinculado a la propiedad 'Tipo' de la clase Libro
            });


        }




        private void CargarLibros()
        {
            dgvLibros.DataSource = null; // Limpiar el DataGridView antes de recargarlo
            dgvLibros.DataSource = Clases.Biblioteca.Libros.OrderByDescending(l => l.AnioPublicacion).ToList(); // Mostrar los libros más recientes al inicio

            ConfigurarColumnasDataGridView();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }


        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del formulario
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                int anioPublicacion = int.Parse(txtAnioPublicacion.Text);
                bool esFisico = cmbTipoLibro.SelectedIndex == 0;

                // Validar la entrada
                if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) || string.IsNullOrWhiteSpace(txtAnioPublicacion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

                if (esFisico)
                {
                    // Crear un libro físico
                    var libroFisico = new Clases.LibroFisico
                    {
                        Titulo = titulo,
                        Autor = autor,
                        AnioPublicacion = anioPublicacion,
                        Ubicacion = txtUbicacion.Text
                    };

                    Clases.Biblioteca.Libros.Add(libroFisico);
                }
                else
                {
                    // Crear un libro digital
                    int tamanoArchivo = int.Parse(txtTamanoArchivo.Text);
                    var libroDigital = new Clases.LibroElectronico
                    {
                        Titulo = titulo,
                        Autor = autor,
                        AnioPublicacion = anioPublicacion,
                        TamanoArchivo = tamanoArchivo,
                        Formato = txtFormato.Text
                    };

                    Clases.Biblioteca.Libros.Add(libroDigital);
                }

                // Confirmar la adición
                MessageBox.Show("Libro agregado exitosamente.");
                CargarLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el libro: {ex.Message}");
            }
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnioPublicacion.Clear();
            txtUbicacion.Clear();
            txtTamanoArchivo.Clear();
            txtFormato.Clear();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower();
            dgvLibros.DataSource = Clases.Biblioteca.Libros.Where(libro => libro.Titulo.ToLower().Contains(busqueda) || libro.Autor.ToLower().Contains(busqueda))
                .ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarCamposSegunTipo();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower();
            dgvLibros.DataSource = Clases.Biblioteca.Libros.Where(libro => libro.Titulo.ToLower().Contains(busqueda) || libro.Autor.ToLower().Contains(busqueda))
                .ToList();
        }
    }
}
