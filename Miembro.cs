using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Miembro
    {
        public string Nombre { get; set; }
        public int NumeroMiembro { get; set; }
        public List<Prestamo> HistorialPrestamos { get; set; } = new List<Prestamo>();
    }
}
