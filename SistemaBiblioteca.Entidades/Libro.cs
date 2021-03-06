using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entidades
{
    public class Libro
    {
        public int Codigo_libro { get; set; }
        public int No_ejemplares { get; set; }
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int A_edicion { get; set; }
        public int No_edicion {get;set;}
        public string Pais { get; set; }
        public string Idioma { get; set; }
        public string Materia { get; set; }
        public int No_paginas { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }

    }
}
