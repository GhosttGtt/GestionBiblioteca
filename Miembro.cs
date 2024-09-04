using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace biblioteca
{
    public class Miembro
    {
        private string nombre;
        private int numeroMiembro;
        private List<Prestamo> historialPrestamos;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío o solo contener espacios.");
                nombre = value;
            }
        }

        public int NumeroMiembro
        {
            get { return numeroMiembro; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(NumeroMiembro), "El número de miembro debe ser un valor positivo.");
                numeroMiembro = value;
            }
        }

        public List<Prestamo> HistorialPrestamos
        {
            get { return historialPrestamos; }
            private set { historialPrestamos = value; }  
        }

        public Miembro()
        {
            historialPrestamos = new List<Prestamo>();
        }

        public void AgregarPrestamo(Prestamo prestamo)
        {
            if (prestamo == null)
                throw new ArgumentNullException(nameof(prestamo), "El préstamo no puede ser nulo.");

            HistorialPrestamos.Add(prestamo);
        }
    }
}