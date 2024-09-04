namespace biblioteca
{
    public class PrestamoLibroElectronico : Prestamo
    {
        public override void RealizarPrestamo()
        {
            try
            {
          
                if (LibroPrestado == null)
                    throw new ArgumentNullException(nameof(LibroPrestado), "El libro físico no puede ser prestado.");

                base.RealizarPrestamo();
                Console.WriteLine("Este es un préstamo de un libro electrónico.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al realizar el préstamo del libro electrónico: {ex.Message}");
               
            }
        }
    }
}