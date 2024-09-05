using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Clases
{
    public class PrestamoLibroFisico : Prestamo
    {
        public override void RealizarPrestamo()
        {
            try
            {
          
                if (LibroPrestado == null)
                {
                    throw new ArgumentNullException(nameof(LibroPrestado), "No se ha especificado un libro para el préstamo.");
                }

                if (Miembro == null)
                {
                    throw new ArgumentNullException(nameof(Miembro), "No se ha especificado un miembro para el préstamo.");
                }
                if (LibroPrestado is not LibroFisico)
                {
                    throw new InvalidOperationException("El libro solicitado no es de tipo libro físico.");
                }

                if (LibroPrestado.EstaPrestado)
                {
                    throw new InvalidOperationException("El libro ya está prestado.");
                }

                if (FechaDevolucion <= FechaPrestamo)
                {
                    throw new InvalidOperationException("La fecha de devolución debe ser posterior a la fecha de préstamo.");
                }


                base.RealizarPrestamo();


                LibroPrestado.EstaPrestado = true;
                Console.WriteLine("Este es un préstamo de un libro físico.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.ParamName} - {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error al realizar el préstamo: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error inesperado: {ex.Message}");
                throw;
            }

        }
    }
}