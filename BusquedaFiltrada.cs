using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class BusquedaFiltrada
    {
        protected List<Libro> _libros;

        public BusquedaFiltrada(List<Libro> libros)
        {
            _libros = libros;
        }

        public abstract List<Libro> Filtrar(string criterio);
    }
}
