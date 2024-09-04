using System;

namespace biblioteca
{
    public class PrestamoLibroElectronico : Prestamo
    {
        public override void RealizarPrestamo()
        {
            try
            {
             
                if (Libro == null)
                {
                    throw new InvalidOperationException("No se ha especificado un libro para el préstamo.");
                }

                if (Libro.EstaPrestado)
                {
                    throw new InvalidOperationException("El libro ya está prestado.");
                }

                
                base.RealizarPrestamo();

               
                Libro.EstaPrestado = true;
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