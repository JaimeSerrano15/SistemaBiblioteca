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
    public class NVideo
    {
        public static DataTable Listar()
        {
            DVideo Data = new DVideo();
            return Data.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DVideo Data = new DVideo();
            return Data.Buscar(Valor);
        }

        public static string Insertar(string titulo, string director, string productora,
            int id_tipo, int anio, int duracion, string pais, string idioma, string subtitulo,
            string clasificacion, string genero, string sinopsis, string ubicacion){
            DVideo Data = new DVideo();
            string Exists = Data.Existe(titulo);
            if (Exists.Equals("1"))
            {
                return "El video ya existe";
            }
            else
            {
                Video Obj = new Video();
                Obj.Titulo = titulo;
                Obj.Director = director;
                Obj.Productora = productora;
                Obj.Id_tipo = id_tipo;
                Obj.Anio = anio;
                Obj.Duracion = duracion;
                Obj.Pais = pais;
                Obj.Idioma = idioma;
                Obj.Subtitlo = subtitulo;
                Obj.Clasificacion = clasificacion;
                Obj.Genero = genero;
                Obj.Sinopsis = sinopsis;
                Obj.Ubicacion = ubicacion;

                return Data.Insertar(Obj);
            }
        }

        public static string Actualizar(int codigo,string titulo, string director, string productora,
           int id_tipo, int anio, int duracion, string pais, string idioma, string subtitulo,
           string clasificacion, string genero, string sinopsis, string ubicacion)
        {
            DVideo Data = new DVideo();
            string Exists = Data.Existe(titulo);
            if (Exists.Equals("1"))
            {
                Video Obj = new Video();
                Obj.Codigo_video = codigo;
                Obj.Titulo = titulo;
                Obj.Director = director;
                Obj.Productora = productora;
                Obj.Id_tipo = id_tipo;
                Obj.Anio = anio;
                Obj.Duracion = duracion;
                Obj.Pais = pais;
                Obj.Idioma = idioma;
                Obj.Subtitlo = subtitulo;
                Obj.Clasificacion = clasificacion;
                Obj.Genero = genero;
                Obj.Sinopsis = sinopsis;
                Obj.Ubicacion = ubicacion;

                return Data.Actualizar(Obj);
            }
            else
            {
                return "El video no existe";
            }
        }

        public static string Eliminar(int id)
        {
            DVideo Datos = new DVideo();
            return Datos.Eliminar(id);
        }
    }
}
