using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entidades
{
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public int Id_rol{ get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email{ get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }

    }
}
