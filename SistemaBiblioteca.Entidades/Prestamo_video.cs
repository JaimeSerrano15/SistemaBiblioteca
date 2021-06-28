using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entidades
{
    public class Prestamo_video
    {
        public int Id_prestamo_video { get; set; }
        public int Id_usuario { get; set; }
        public int Codigo_video { get; set; }
        public string Fecha_prestamo { get; set; }
        public string Fecha_devolucion { get; set; }
    }
}
