using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Clases
{
    public class Prestamo
    {
        public required Libro LibroPrestado { get; set; }
        public required Miembro Miembro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public virtual void RealizarPrestamo()
        {
            if (LibroPrestado == null)
                throw new ArgumentNullException("Por favor, seleccionar un libro para realizar el préstamo.");

            if (Miembro == null)
                throw new ArgumentNullException("Por favor, seleccionar un miembro para realizar el préstamo.");

            if (LibroPrestado.EstaPrestado)
                throw new InvalidOperationException("El libro seleccionado ya está prestado. Por favor selecciona otro.");


            LibroPrestado.EstaPrestado = true;
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = FechaPrestamo.AddDays(15);


        }
    }
}
