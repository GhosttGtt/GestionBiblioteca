using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Clases
{
    internal class LibroElectronico : Libro
    {
        public int tamanoArchivo {  get; set; }
        public string formato { get; set; }

        public LibroElectronico(string titulo, string autor, int anio, Boolean EstaPrestado, int tamanoArchivo, string formato) : base (titulo, autor, anio, EstaPrestado)
        {
            this.tamanoArchivo = tamanoArchivo;
            this.formato = formato;
        }
    }
}
