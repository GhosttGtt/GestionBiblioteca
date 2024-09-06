using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class BusquedaFiltradaLibroElectronico : BusquedaFiltrada
    {
        public BusquedaFiltradaLibroElectronico(List<Libro> libros) : base(libros) { }

        public override List<Libro> Filtrar(string criterio)
        {
            List<Libro> resultados = new List<Libro>();

            foreach (Libro libro in _libros)
            {
                if (libro is LibroElectronico)
                {
                    LibroElectronico libroElectronico = (LibroElectronico)libro;

                    if (libroElectronico.Formato.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                        libroElectronico.Titulo.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                        libroElectronico.Autor.Contains(criterio, StringComparison.OrdinalIgnoreCase))
                    {
                        resultados.Add(libro);
                    }
                }
            }

            return resultados;
        }
    }
}
}
