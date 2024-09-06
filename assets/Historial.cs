using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.assets
{
    public class HistorialPrestamoDTO
    {
        public string TituloLibro { get; set; }
        public string NombreMiembro { get; set; }
        public string FechaPrestamo { get; set; }
        public string FechaDevolucion { get; set; }
        public string Estado { get; set; }
    }
}
