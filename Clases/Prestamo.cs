using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Prestamo
    {
        public Libro Libro { get; set; }
        public Miembro Miembro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public bool EstaDevuelto => FechaDevolucion.HasValue;

        public Prestamo(Libro libro, Miembro miembro, DateTime fechaPrestamo)
        {
            Libro = libro;
            Miembro = miembro;
            FechaPrestamo = fechaPrestamo;
        }
    }
}
