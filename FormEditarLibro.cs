using Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormEditarLibro : Form
    {
        private Libro libroActual;

        public FormEditarLibro(Libro libro)
        {
            InitializeComponent();
            libroActual = libro;
            CargarDatosDelLibro();
        }
        private void CargarDatosDelLibro()
        {
            txtTitulo.Text = libroActual.Titulo;
            txtAutor.Text = libroActual.Autor;
            txtAnioPublicacion.Text = libroActual.AnioPublicacion.ToString();
            txtUbicacion.Visible = false;
            txtFormato.Visible = false;
            txtTamanioArchivo.Visible = false;
            Debug.WriteLine(libroActual is LibroElectronico);

            if (libroActual is LibroFisico esFisico)
            {
                txtUbicacion.Visible = true;
                txtUbicacion.Text = esFisico.Ubicacion;

            }
            else if (libroActual is LibroElectronico libroDigital)
            {
                txtTamanioArchivo.Visible = true;
                txtFormato.Visible = true;
                txtTamanioArchivo.Text = libroDigital.TamanoArchivo.ToString();
                txtFormato.Text = libroDigital.Formato;


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            libroActual.Titulo = txtTitulo.Text;
            libroActual.Autor = txtAutor.Text;
            libroActual.AnioPublicacion = int.Parse(txtAnioPublicacion.Text);

            if (libroActual is LibroFisico libroFisico)
            {
                libroFisico.Ubicacion = txtUbicacion.Text;
            }
            else if (libroActual is LibroElectronico libroElectronico)
            {
                libroElectronico.TamanoArchivo = int.Parse(txtTamanioArchivo.Text);
                libroElectronico.Formato = txtFormato.Text;
            }

            // Indicar que la edición fue exitosa
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
