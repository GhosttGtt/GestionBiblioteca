using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Clases;

namespace Biblioteca
{
    public partial class FormMiembros : Form
    {
        public FormMiembros()
        {
            InitializeComponent();
            CargarMiembros();
        }
        public static int ObtenerUltimoNumeroMiembro()
        {
            if (Clases.Biblioteca.Miembros.Count == 0)
            {
                return 1;
            }
            else
            {
                return Clases.Biblioteca.Miembros.Max(m => m.NumeroMiembro) + 1;
            }
        }
        private void btnAgregarMiembro_Click(object sender, EventArgs e)
        {
            int nuevoNumeroMiembro = ObtenerUltimoNumeroMiembro();

            Clases.Miembro nuevoMiembro = new Clases.Miembro()
            {
                Nombre = txtNombre.Text,
                NumeroMiembro = nuevoNumeroMiembro,
            };
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre.");
            }
            else {
                Clases.Biblioteca.Miembros.Add(nuevoMiembro);
                dgvMiembros.DataSource = null;
                dgvMiembros.DataSource = Clases.Biblioteca.Miembros;
                MessageBox.Show("Miembro agregado.");
                LimpiarFormulario();
            }
            
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            nMiembro.Text = "0";
        }

        private void dvgMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (dgvMiembros.SelectedRows.Count > 0)
                {
                    Clases.Miembro miembroSeleccionado = (Clases.Miembro)dgvMiembros.SelectedRows[0].DataBoundItem;
                    Clases.Biblioteca.Miembros.Remove(miembroSeleccionado);

                    ActualizarMiembros();
                }

            }

        }
        private void dvgMiembros_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void FormMiembros_Load(object sender, EventArgs e)
        {
            dgvMiembros.DataSource = null;
            dgvMiembros.DataSource = Clases.Biblioteca.Miembros;
            dgvMiembros.Columns["NumeroMiembro"].HeaderText = "Número de Miembro";
            dgvMiembros.Columns["Nombre"].HeaderText = "Nombre Completo";




        }
        private void CargarMiembros()
        {
            int nuevoNumeroMiembro = ObtenerUltimoNumeroMiembro();
            nMiembro.Text = nuevoNumeroMiembro.ToString();
            dgvMiembros.DataSource = null;
            dgvMiembros.DataSource = Clases.Biblioteca.Miembros.ToList();
            ConfigurarColumnasDataGridView();
        }
        private void ConfigurarColumnasDataGridView()
        {
            dgvMiembros.Columns.Clear();
            dgvMiembros.AutoGenerateColumns = false;

            dgvMiembros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre Completo", DataPropertyName = "Nombre" });
            dgvMiembros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Número Miembro", DataPropertyName = "NumeroMiembro" });

            
        }
        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarMiembro_Click(object sender, EventArgs e)
        {
            if (dgvMiembros.SelectedRows.Count > 0)
            {
                Miembro miembroSeleccionado = (Miembro)dgvMiembros.SelectedRows[0].DataBoundItem;
                miembroSeleccionado.Nombre = txtNombreEdit.Text;
                txtNombreEdit.Clear();
                ActualizarMiembros();
                MessageBox.Show("Nombre actualizado.");

            }
            else {
                MessageBox.Show("Selecciona un nombre para actualizar.");
            }
        }

        private void btnEliminarMiembro_Click(object sender, EventArgs e)
        {
            if (dgvMiembros.SelectedRows.Count > 0)
            {
                Clases.Miembro miembroSeleccionado = (Miembro)dgvMiembros.SelectedRows[0].DataBoundItem;
                Clases.Biblioteca.Miembros.Remove(miembroSeleccionado);

                ActualizarMiembros();
            }
            else {
                MessageBox.Show("Selecciona el nombre que quieres eliminar.");
            }
        }
        private void ActualizarMiembros()
        {
            dgvMiembros.DataSource = null;
            dgvMiembros.DataSource = Clases.Biblioteca.Miembros;
        }

        private void btnEliminarMiembro_Click_1(object sender, EventArgs e)
        {
            if (dgvMiembros.SelectedRows.Count > 0)
            {
                DialogResult result;
                result = MessageBox.Show("¿Deseas eliminar permanentemente este registro?","", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Clases.Miembro miembroSeleccionado = (Miembro)dgvMiembros.SelectedRows[0].DataBoundItem;
                    Clases.Biblioteca.Miembros.Remove(miembroSeleccionado);

                    ActualizarMiembros();
               
                }
                
            }
            else
            {
                MessageBox.Show("Selecciona un nombre para actualizar.");
            }
        }
    }

}
