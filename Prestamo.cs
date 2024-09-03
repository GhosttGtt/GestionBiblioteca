using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Prestamo
    {
        public Libro LibroPrestado { get; set; }
        public Miembro Miembro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public virtual void RealizarPrestamo()
        {
            // Lógica genérica de préstamo
            Console.WriteLine($"{Miembro.Nombre} ha tomado prestado {LibroPrestado.Titulo}.");
        }
    }
}
