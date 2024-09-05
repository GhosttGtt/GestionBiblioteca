using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Clases
{
    internal class LibroFisico : Libro
    {
        public string ubicacionBiblioteca {  get; set; }

        public LibroFisico(string titulo, string autor, int anio, Boolean EstaPrestado, string ubicacionBiblioteca) : base(titulo, autor, anio, EstaPrestado)
        {
            this.ubicacionBiblioteca = ubicacionBiblioteca;
        }
    }
}
