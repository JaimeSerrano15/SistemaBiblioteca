using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entidades
{
    public class Prestamo_libro
    {
        public int Id_prestamo_libro { get; set; }
        public int Id_usuario { get; set; }
        public int Codigo_libro { get; set; }
        public DateTime Fecha_prestamo { get; set; }
        public DateTime Fecha_devolucion { get; set; }

    }
}
