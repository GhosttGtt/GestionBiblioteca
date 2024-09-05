using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class FormularioBusqueda : Form
    {
        private List<Libro> _libros;
        public FormularioBusqueda(List<Libro> libros)
        {
            InitializeComponent();
            _libros = libros;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = textBoxCriterio.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Ingrese un criterio de búsqueda");
                return;
            }
            BusquedaFiltrada busquedaFiltrada;

            if (radioButtonLibrosFisicos.Checked)
            {
                busquedaFiltrada = new BusquedaFiltradaLibroFisico(_libros);
            }
            else
            {
                busquedaFiltrada = new BusquedaFiltradaLibroElectronico(_libros);
            }

            List<Libro> resultados = busquedaFiltrada.Filtrar(criterio);

            dgvlibros.DataSource = resultados;
        }
    }
    }
}
