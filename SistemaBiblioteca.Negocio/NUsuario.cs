using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBiblioteca.Datos;
using System.Data;
using SistemaBiblioteca.Entidades;

namespace SistemaBiblioteca.Negocio
{
    public class NUsuario
    {
        public static DataTable Login(string email, string clave)
        {
            DUsuario data = new DUsuario();
            return data.Login(email, clave);
        }
    }
}
