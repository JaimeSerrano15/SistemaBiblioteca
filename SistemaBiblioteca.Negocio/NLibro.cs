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
    public class NLibro
    {
        public static DataTable Listar()
        {
            DLibro Data = new DLibro();
            return Data.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DLibro Data = new DLibro();
            return Data.Buscar(valor);
        }

        public static string Insertar(int no_ejemplares, string isbn, string titulo, 
            string autor, string editorial, int a_edicion, int no_edicion, string pais,
            string idioma, string materia, int no_paginas, string ubicacion, string descripcion)
        {
            DLibro Data = new DLibro();
            string Exists = Data.Existe(titulo);
            if (Exists.Equals("1"))
            {
                return "El libro ya existe";
            }
            else
            {
                Libro Obj = new Libro();
                Obj.No_ejemplares = no_ejemplares;
                Obj.No_edicion = no_edicion;
                Obj.Isbn = isbn;
                Obj.Titulo = titulo;
                Obj.Autor = autor;
                Obj.Editorial = editorial;
                Obj.A_edicion = a_edicion;
                Obj.No_edicion = no_edicion;
                Obj.Pais = pais;
                Obj.Idioma = idioma;
                Obj.Materia = materia;
                Obj.No_paginas = no_paginas;
                Obj.Ubicacion = ubicacion;
                Obj.Descripcion = descripcion;

                return Data.Insertar(Obj);
            }
        }

        public static string Actualizar(int codigo_libro,int no_ejemplares, string isbn, string titulo,
           string autor, string editorial, int a_edicion, int no_edicion, string pais,
           string idioma, string materia, int no_paginas, string ubicacion, string descripcion)
        {
            DLibro Data = new DLibro();
            string Exists = Data.Existe(titulo);
            if (Exists.Equals("1"))
            {
                Libro Obj = new Libro();
                Obj.Codigo_libro = codigo_libro;
                Obj.No_ejemplares = no_ejemplares;
                Obj.No_edicion = no_edicion;
                Obj.Isbn = isbn;
                Obj.Titulo = titulo;
                Obj.Autor = autor;
                Obj.Editorial = editorial;
                Obj.A_edicion = a_edicion;
                Obj.No_edicion = no_edicion;
                Obj.Pais = pais;
                Obj.Idioma = idioma;
                Obj.Materia = materia;
                Obj.No_paginas = no_paginas;
                Obj.Ubicacion = ubicacion;
                Obj.Descripcion = descripcion;

                return Data.Actualizar(Obj);
            }
            else
            {
                return "El libro no existe";
            }
        }

        public static string Eliminar(int id)
        {
            DLibro Datos = new DLibro();
            return Datos.Eliminar(id);
        }
    }
}
