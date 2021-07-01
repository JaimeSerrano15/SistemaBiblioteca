using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemaBiblioteca.Entidades;
using SistemaBiblioteca.Datos;

namespace SistemaBiblioteca.Negocio
{
    public class NPrestamo_libro
    {

        public static DataTable Listar_Libros()
        {
            DPrestamo_Libro Data = new DPrestamo_Libro();
            return Data.Listar_Libros();
        }

        public static DataTable Listar_Profesores()
        {
            DPrestamo_Libro Data = new DPrestamo_Libro();
            return Data.Listar_Profesores();
        }
        public static DataTable Buscar_Libro(string valor)
        {
            DPrestamo_Libro Data = new DPrestamo_Libro();
            return Data.Buscar_Libro(valor);
        }

        public static DataTable Buscar_Profesor(string valor)
        {
            DPrestamo_Libro Data = new DPrestamo_Libro();
            return Data.Buscar_Profesor(valor);
        }

        public static DataTable Listar_Prestamos(string valor)
        {
            DPrestamo_Libro Data = new DPrestamo_Libro();
            return Data.Listar_Prestamos(valor);
        }

        public static string Insertar_Prestamo(int profesor, int libro,
            DateTime prestamo, DateTime devolucion)
        {
            DPrestamo_Libro Data = new DPrestamo_Libro();
            Prestamo_libro nuevoP = new Prestamo_libro();
            nuevoP.Id_usuario = profesor;
            nuevoP.Codigo_libro = libro;
            nuevoP.Fecha_prestamo = prestamo;
            nuevoP.Fecha_devolucion = devolucion;

            return Data.Insertar_Prestamo(nuevoP);
        }
    }
}
