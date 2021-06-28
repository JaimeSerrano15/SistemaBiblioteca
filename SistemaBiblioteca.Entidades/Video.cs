using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entidades
{
    public class Video
    {
        public int Codigo_video { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string Productora { get; set; }
        public int Id_tipo { get; set; }
        public int Anio { get; set; }
        public int Duracion { get; set; }
        public string Pais { get; set; }
        public string Idioma { get; set; }
        public string Subtitlo { get; set; }
        public string Clasificacion { get; set; }
        public string Genero { get; set; }
        public string Sinopsis { get; set; }
        public string Ubicacion { get; set; }

    }
}
