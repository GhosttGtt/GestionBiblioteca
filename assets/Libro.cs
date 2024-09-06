using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.assets
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }
        public bool EstaPrestado { get; set; }

        public virtual string Tipo => "General";
    }

    public class LibroFisico : Libro
    {
        public string Ubicacion { get; set; }

        public override string Tipo => "Físico";
    }

    public class LibroElectronico : Libro
    {
        public string Formato { get; set; }
        public int TamanoArchivo { get; set; } // Tamaño en kilobytes

        public override string Tipo => "Digital";
    }
}
