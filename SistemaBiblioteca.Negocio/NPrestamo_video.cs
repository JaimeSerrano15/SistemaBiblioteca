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
    public class NPrestamo_video
    {

        public static DataTable Listar_Videos()
        {
            DPrestamo_Video Data = new DPrestamo_Video();
            return Data.Listar_Videos();
        }

        public static DataTable Listar_Profesores()
        {
            DPrestamo_Libro Data = new DPrestamo_Libro();
            return Data.Listar_Profesores();
        }
        public static DataTable Buscar_Video(string valor)
        {
            DPrestamo_Video Data = new DPrestamo_Video();
            return Data.Buscar_Video(valor);
        }

        public static DataTable Buscar_Profesor(string valor)
        {
            DPrestamo_Video Data = new DPrestamo_Video();
            return Data.Buscar_Profesor(valor);
        }

        public static DataTable Listar_Prestamos(string valor)
        {
            DPrestamo_Video Data = new DPrestamo_Video();
            return Data.Listar_Prestamos(valor);
        }

        public static string Insertar_Prestamo(int profesor, int libro,
            DateTime prestamo, DateTime devolucion)
        {
            DPrestamo_Video Data = new DPrestamo_Video();
            Prestamo_video nuevoP = new Prestamo_video();
            nuevoP.Id_usuario = profesor;
            nuevoP.Codigo_video = libro;
            nuevoP.Fecha_prestamo = prestamo;
            nuevoP.Fecha_devolucion = devolucion;

            return Data.Insertar_Prestamo(nuevoP);
        }
    }
}
