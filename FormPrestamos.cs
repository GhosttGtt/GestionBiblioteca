using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.assets;

namespace Biblioteca
{
    public partial class FormPrestamos : Form
    {
        public FormPrestamos()
        {
            InitializeComponent();
            ConfigurarDataGridViewHistorial();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cargar libros y miembros en los ComboBox
            cmbLibros.DataSource = Biblioteca.Libros;
            cmbLibros.DisplayMember = "Titulo"; // Mostrar el título en el ComboBox
            cmbLibros.ValueMember = "Titulo"; // Usar el título como valor seleccionado (esto debe ser ajustado para seleccionar el objeto)

            cmbMiembros.DataSource = Biblioteca.Miembros;
            cmbMiembros.DisplayMember = "Nombre"; // Mostrar el nombre en el ComboBox
            cmbMiembros.ValueMember = "NumeroMiembro"; // Usar el número de miembro como valor seleccionado (esto debe ser ajustado para seleccionar el objeto)

            CargarHistorialPrestamos();
        }

        private void CargarHistorialPrestamos()
        {

            var prestamos = Biblioteca.ObtenerHistorialPrestamos();
            dgvHistorialPrestamos.DataSource = prestamos;
        }



        private void CargarLibros()
        {
            foreach (var libro in Biblioteca.Libros)
            {
                cmbLibros.Items.Add(libro.Titulo);
            }
        }
        private void CargarMiembros()
        {
            foreach (var miembro in Biblioteca.Miembros)
            {
                cmbMiembros.Items.Add(miembro.Nombre);
            }
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {

            try
            {

                var libroSeleccionado = (Libro)cmbLibros.SelectedItem;
                var miembroSeleccionado = (Miembro)cmbMiembros.SelectedItem;

                if (libroSeleccionado == null || miembroSeleccionado == null)
                {
                    MessageBox.Show("Por favor, seleccione un libro y un miembro.");
                    return;
                }
                if (libroSeleccionado.EstaPrestado)
                {
                    MessageBox.Show("El libro ya está prestado.");
                    return;
                }
                var nuevoPrestamo = new Prestamo(libroSeleccionado, miembroSeleccionado, dtpFechaPrestamo.Value);
                Biblioteca.Prestamos.Add(nuevoPrestamo);

                libroSeleccionado.EstaPrestado = true;
                miembroSeleccionado.HistorialPrestamos.Add(nuevoPrestamo);

                CargarHistorialPrestamos();
                MessageBox.Show("Préstamo agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar préstamo: {ex.Message}");
            }
        }
        private void ConfigurarDataGridViewHistorial()
        {
            dgvHistorialPrestamos.Columns.Clear();
            dgvHistorialPrestamos.AutoGenerateColumns = false;

            // Crear columnas
            DataGridViewTextBoxColumn columnaTitulo = new DataGridViewTextBoxColumn();
            columnaTitulo.HeaderText = "Título del Libro";
            columnaTitulo.DataPropertyName = "TituloLibro";
            dgvHistorialPrestamos.Columns.Add(columnaTitulo);

            DataGridViewTextBoxColumn columnaMiembro = new DataGridViewTextBoxColumn();
            columnaMiembro.HeaderText = "Miembro";
            columnaMiembro.DataPropertyName = "NombreMiembro";
            dgvHistorialPrestamos.Columns.Add(columnaMiembro);

            DataGridViewTextBoxColumn columnaFechaPrestamo = new DataGridViewTextBoxColumn();
            columnaFechaPrestamo.HeaderText = "Fecha de Préstamo";
            columnaFechaPrestamo.DataPropertyName = "FechaPrestamo";
            dgvHistorialPrestamos.Columns.Add(columnaFechaPrestamo);

            DataGridViewTextBoxColumn columnaFechaDevolucion = new DataGridViewTextBoxColumn();
            columnaFechaDevolucion.HeaderText = "Fecha de Devolución";
            columnaFechaDevolucion.DataPropertyName = "FechaDevolucion";
            dgvHistorialPrestamos.Columns.Add(columnaFechaDevolucion);

            DataGridViewTextBoxColumn columnaEstado = new DataGridViewTextBoxColumn();
            columnaEstado.HeaderText = "Estado";
            columnaEstado.DataPropertyName = "Estado";
            dgvHistorialPrestamos.Columns.Add(columnaEstado);
        }

        private void dgvHistorialPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
