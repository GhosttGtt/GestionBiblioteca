using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class PrestamoLibroFisico : Prestamo
    {
        public override void RealizarPrestamo()
        {
            try
            {
                if (LibroPrestado == null)
                    throw new ArgumentNullException(nameof(LibroPrestado), "El libro físico no puede ser prestado.");

                base.RealizarPrestamo();
                Console.WriteLine("Este es un préstamo de un libro físico.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al realizar el préstamo del libro físico: {ex.Message}");
                throw;
            }
        }
    }
}