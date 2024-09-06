using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.assets
{
    public static class Biblioteca
    {
        public static List<Libro> Libros { get; set; } = new List<Libro>();
        public static List<Miembro> Miembros { get; set; } = new List<Miembro>();
        public static List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();


        public static void CargarDatosEjemplo()
        {
            if (Libros.Count == 0)
            {

                {

                    Libros.Add(new LibroFisico() { Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", AnioPublicacion = 1967, Ubicacion = "Estante A1", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "El Señor de los Anillos", Autor = "J.R.R. Tolkien", AnioPublicacion = 1954, Ubicacion = "Estante A2", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "Don Quijote de la Mancha", Autor = "Miguel de Cervantes", AnioPublicacion = 1605, Ubicacion = "Estante A3", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "Orgullo y Prejuicio", Autor = "Jane Austen", AnioPublicacion = 1813, Ubicacion = "Estante B1", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "1984", Autor = "George Orwell", AnioPublicacion = 1949, Ubicacion = "Estante B2", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "Matar a un Ruiseñor", Autor = "Harper Lee", AnioPublicacion = 1960, Ubicacion = "Estante B3", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "Crimen y Castigo", Autor = "Fiódor Dostoyevski", AnioPublicacion = 1866, Ubicacion = "Estante C1", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "El Gran Gatsby", Autor = "F. Scott Fitzgerald", AnioPublicacion = 1925, Ubicacion = "Estante C2", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "La Odisea", Autor = "Homero", AnioPublicacion = -800, Ubicacion = "Estante C3", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "El Retrato de Dorian Gray", Autor = "Oscar Wilde", AnioPublicacion = 1890, Ubicacion = "Estante D1", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "Las Aventuras de Sherlock Holmes", Autor = "Arthur Conan Doyle", AnioPublicacion = 1892, Ubicacion = "Estante D2", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "La Sombra del Viento", Autor = "Carlos Ruiz Zafón", AnioPublicacion = 2001, Ubicacion = "Estante D3", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "El Hobbit", Autor = "J.R.R. Tolkien", AnioPublicacion = 1937, Ubicacion = "Estante E1", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "El Lobo Estepario", Autor = "Hermann Hesse", AnioPublicacion = 1927, Ubicacion = "Estante E2", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "La Isla del Tesoro", Autor = "Robert Louis Stevenson", AnioPublicacion = 1883, Ubicacion = "Estante E3", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "El Túnel", Autor = "Ernesto Sabato", AnioPublicacion = 1948, Ubicacion = "Estante F1", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "La Cabaña", Autor = "William P. Young", AnioPublicacion = 2007, Ubicacion = "Estante F2", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "Café Solo", Autor = "Javier Marías", AnioPublicacion = 2005, Ubicacion = "Estante F3", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "Un Día en la Vida de Iván Denísovich", Autor = "Aleksandr Solzhenitsyn", AnioPublicacion = 1962, Ubicacion = "Estante G1", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "La Tristeza del Samurai", Autor = "Víctor del Árbol", AnioPublicacion = 2011, Ubicacion = "Estante G2", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "El Viejo y el Mar", Autor = "Ernest Hemingway", AnioPublicacion = 1952, Ubicacion = "Estante G3", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "Una Vuelta al Mundo", Autor = "Jules Verne", AnioPublicacion = 1873, Ubicacion = "Estante H1", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "El Hombre que Calculaba", Autor = "Malba Tahan", AnioPublicacion = 1938, Ubicacion = "Estante H2", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "Un Mundo Feliz", Autor = "Aldous Huxley", AnioPublicacion = 1932, Ubicacion = "Estante H3", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "La Torre Oscura", Autor = "Stephen King", AnioPublicacion = 1982, Ubicacion = "Estante I1", EstaPrestado = true });
                    Libros.Add(new LibroFisico() { Titulo = "El Silmarillion", Autor = "J.R.R. Tolkien", AnioPublicacion = 1977, Ubicacion = "Estante I2", EstaPrestado = false });
                    Libros.Add(new LibroFisico() { Titulo = "La Cabaña", Autor = "William P. Young", AnioPublicacion = 2007, Ubicacion = "Estante I3", EstaPrestado = false });


                    Libros.Add(new LibroElectronico() { Titulo = "El Amor en los Tiempos del Cólera", Autor = "Gabriel García Márquez", AnioPublicacion = 1985, Formato = "EPUB", TamanoArchivo = 1200, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "Los Juegos del Hambre", Autor = "Suzanne Collins", AnioPublicacion = 2008, Formato = "PDF", TamanoArchivo = 2500, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "La Chica en el Tren", Autor = "Paula Hawkins", AnioPublicacion = 2015, Formato = "MOBI", TamanoArchivo = 3000, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "Divergente", Autor = "Veronica Roth", AnioPublicacion = 2011, Formato = "EPUB", TamanoArchivo = 1800, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "El Código Da Vinci", Autor = "Dan Brown", AnioPublicacion = 2003, Formato = "PDF", TamanoArchivo = 2200, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "El Alquimista", Autor = "Paulo Coelho", AnioPublicacion = 1988, Formato = "MOBI", TamanoArchivo = 1500, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", AnioPublicacion = 1967, Formato = "EPUB", TamanoArchivo = 1300, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "La Casa de los Espíritus", Autor = "Isabel Allende", AnioPublicacion = 1982, Formato = "PDF", TamanoArchivo = 2000, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "El Nombre de la Rosa", Autor = "Umberto Eco", AnioPublicacion = 1980, Formato = "MOBI", TamanoArchivo = 1700, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "La Sombra del Viento", Autor = "Carlos Ruiz Zafón", AnioPublicacion = 2001, Formato = "EPUB", TamanoArchivo = 1900, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "La Cabaña", Autor = "William P. Young", AnioPublicacion = 2007, Formato = "PDF", TamanoArchivo = 2100, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "El Lobo Estepario", Autor = "Hermann Hesse", AnioPublicacion = 1927, Formato = "MOBI", TamanoArchivo = 1600, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "Un Mundo Feliz", Autor = "Aldous Huxley", AnioPublicacion = 1932, Formato = "EPUB", TamanoArchivo = 1400, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "El Gran Gatsby", Autor = "F. Scott Fitzgerald", AnioPublicacion = 1925, Formato = "PDF", TamanoArchivo = 2200, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "Crimen y Castigo", Autor = "Fiódor Dostoyevski", AnioPublicacion = 1866, Formato = "MOBI", TamanoArchivo = 1800, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "El Perfume", Autor = "Patrick Süskind", AnioPublicacion = 1985, Formato = "EPUB", TamanoArchivo = 1300, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "El Diario de Ana Frank", Autor = "Ana Frank", AnioPublicacion = 1947, Formato = "PDF", TamanoArchivo = 2500, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "Los Tres Mosqueteros", Autor = "Alexandre Dumas", AnioPublicacion = 1844, Formato = "MOBI", TamanoArchivo = 1400, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "El Hombre Invisible", Autor = "H.G. Wells", AnioPublicacion = 1897, Formato = "EPUB", TamanoArchivo = 1500, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "La Princesa Prometida", Autor = "William Goldman", AnioPublicacion = 1973, Formato = "PDF", TamanoArchivo = 1800, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "Ve y Pon un Centinela", Autor = "Harper Lee", AnioPublicacion = 2015, Formato = "MOBI", TamanoArchivo = 1900, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "Mujer en la Ventana", Autor = "A.J. Finn", AnioPublicacion = 2018, Formato = "EPUB", TamanoArchivo = 2000, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "La Chica del Tren", Autor = "Paula Hawkins", AnioPublicacion = 2015, Formato = "PDF", TamanoArchivo = 2200, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "La Gente Normal", Autor = "Sally Rooney", AnioPublicacion = 2018, Formato = "MOBI", TamanoArchivo = 2100, EstaPrestado = false });
                    Libros.Add(new LibroElectronico() { Titulo = "La Bella y la Bestia", Autor = "Gabrielle-Suzanne Barbot de Villeneuve", AnioPublicacion = 1740, Formato = "EPUB", TamanoArchivo = 1600, EstaPrestado = true });
                    Libros.Add(new LibroElectronico() { Titulo = "El Hombre que Calculaba", Autor = "Malba Tahan", AnioPublicacion = 1938, Formato = "PDF", TamanoArchivo = 1700, EstaPrestado = false });
                }
            }

            if (Miembros.Count == 0)
            {

                Miembros.Add(new Miembro() { Nombre = "Juan Pérez", NumeroMiembro = 1001 });
                Miembros.Add(new Miembro() { Nombre = "Ana Gómez", NumeroMiembro = 1002 });
                Miembros.Add(new Miembro() { Nombre = "Luis Rodríguez", NumeroMiembro = 1003 });
                Miembros.Add(new Miembro() { Nombre = "María Fernández", NumeroMiembro = 1004 });
                Miembros.Add(new Miembro() { Nombre = "Carlos Martínez", NumeroMiembro = 1005 });
                Miembros.Add(new Miembro() { Nombre = "Laura Torres", NumeroMiembro = 1006 });
                Miembros.Add(new Miembro() { Nombre = "Miguel López", NumeroMiembro = 1007 });
                Miembros.Add(new Miembro() { Nombre = "Sofía García", NumeroMiembro = 1008 });
                Miembros.Add(new Miembro() { Nombre = "Andrés Sánchez", NumeroMiembro = 1009 });
                Miembros.Add(new Miembro() { Nombre = "Elena Morales", NumeroMiembro = 1010 });
                Miembros.Add(new Miembro() { Nombre = "Javier Ruiz", NumeroMiembro = 1011 });
                Miembros.Add(new Miembro() { Nombre = "Carmen Díaz", NumeroMiembro = 1012 });
                Miembros.Add(new Miembro() { Nombre = "Roberto Jiménez", NumeroMiembro = 1013 });
                Miembros.Add(new Miembro() { Nombre = "Isabel Martínez", NumeroMiembro = 1014 });
                Miembros.Add(new Miembro() { Nombre = "Francisco Silva", NumeroMiembro = 1015 });

                Prestamos.Add(new Prestamo(Libros[2], Miembros[0], DateTime.Now.AddDays(-10)) { FechaDevolucion = DateTime.Now.AddDays(-2) });
                Prestamos.Add(new Prestamo(Libros[3], Miembros[1], DateTime.Now.AddDays(-5)));
            }
        }
        public static List<HistorialPrestamoDTO> ObtenerHistorialPrestamos()
        {
            List<HistorialPrestamoDTO> historial = new List<HistorialPrestamoDTO>();

            foreach (var prestamo in Prestamos)
            {
                historial.Add(new HistorialPrestamoDTO
                {
                    TituloLibro = prestamo.Libro.Titulo,
                    NombreMiembro = prestamo.Miembro.Nombre,
                    FechaPrestamo = prestamo.FechaPrestamo.ToShortDateString(),
                    FechaDevolucion = prestamo.FechaDevolucion?.ToShortDateString() ?? "Pendiente",
                    Estado = prestamo.EstaDevuelto ? "Devuelto" : "No Devuelto"
                });
            }

            return historial;
        }
    }



}
