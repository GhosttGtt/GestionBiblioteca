using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Clases
{
    abstract public class Libro
    {
        public string titulo {  get; set; }
        public string autor { get; set; }
        public int anio { get; set; }

        public Boolean EstaPrestado { get; set; }

        public Libro(string titulo, string autor, int anio, Boolean EstaPrestado)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.EstaPrestado = EstaPrestado;
        }
    }
}
