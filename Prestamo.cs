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
            // Validaciones previas
            if (LibroPrestado == null)
                throw new ArgumentNullException("Por favor, seleccionar un libro para realizar el préstamo.");

            if (Miembro == null)
                throw new ArgumentNullException("Por favor, seleccionar un miembro para realizar el préstamo.");

            if (LibroPrestado.EstaPrestado)
                throw new InvalidOperationException("El libro seleccionado ya está prestado. No se puede realizar un nuevo préstamo.");

           
            LibroPrestado.EstaPrestado = true; 
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = FechaPrestamo.AddDays(15);


            Console.WriteLine($"{Miembro.Nombre} ha tomado prestado {LibroPrestado.Titulo}.");
        }
    }
}
