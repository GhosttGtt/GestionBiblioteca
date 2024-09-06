using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class BusquedaFiltradaLibroFisico : BusquedaFiltrada
    {
        public BusquedaFiltradaLibroFisico(List<Libro> libros) : base(libros) { }

        public override List<Libro> Filtrar(string criterio)
        {
            List<Libro> resultados = new List<Libro>();

            foreach (Libro libro in _libros)
            {
                if (libro is LibroFisico)
                {
                    LibroFisico libroFisico = (LibroFisico)libro;

                    if (libroFisico.Ubicacion.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                        libroFisico.Titulo.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                        libroFisico.Autor.Contains(criterio, StringComparison.OrdinalIgnoreCase))
                    {
                        resultados.Add(libro);
                    }
                }
            }

            return resultados;
        }
    }
}
