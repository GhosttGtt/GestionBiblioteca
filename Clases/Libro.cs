using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Clases
{
    abstract class Libro
    {
        public string titulo {  get; set; }
        public string autor { get; set; }
        public int anio { get; set; }

        public Libro(string titulo, string autor, int anio)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
        }
    }
}
