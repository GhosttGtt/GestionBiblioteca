using System;

namespace biblioteca.Clases
{
    public class PrestamoLibroElectronico : Prestamo
    {
        public override void RealizarPrestamo()
        {

            try
            {

                if (LibroPrestado == null)
                {
                    throw new InvalidOperationException("No se ha especificado un libro.");
                }

                if (Miembro == null)
                {
                    throw new InvalidOperationException("El libro ya está prestado.");
                }
                 if (LibroPrestado.EstaPrestado)
                {
                    throw new InvalidOperationException("Le comento que el libro no esta disponible");
                }

                if (FechaDevolucion <= FechaPrestamo)
                {
                    throw new InvalidOperationException("Recuerda que la fecha de devolución debe ser posterior a la fecha de préstamo.");
                }
                base.RealizarPrestamo();


                LibroPrestado.EstaPrestado = true;
                Console.WriteLine("Este es un préstamo de un libro electrónico.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error al realizar el préstamo: {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error inesperado: {ex.Message}");

            }
        }
    }
}