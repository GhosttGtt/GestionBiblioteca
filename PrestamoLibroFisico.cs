﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class PrestamoLibroFisico : Prestamo
    {
        public override void RealizarPrestamo()
        {
            // Lógica específica para libros físicos
            base.RealizarPrestamo();
            Console.WriteLine("Este es un préstamo de un libro físico.");
        }
    }
}
