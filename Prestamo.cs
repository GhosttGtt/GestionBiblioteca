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


            if (LibroPrestado == null)
                throw new ArgumentNullException("No ha seleccionado un libro para realizar el prestamo.");
            if (Miembro == null)
                throw new ArgumentNullException("Seleccionar un miembro");
            if (LibroPrestado.Estaprestado == null)
                throw new InvalidOperationException("Le informamos que el libro seleccionado ya está prestado");

            LibroPrestado.Estaprestado = true;
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = FechaPrestamo.AddDays(15);


            // Lógica genérica de préstamo
            Console.WriteLine($"{Miembro.Nombre} ha tomado prestado {LibroPrestado.Titulo}.");
        }
    }
}
