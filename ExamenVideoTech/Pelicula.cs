using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenVideoTech
{
    internal class Pelicula
    {
        private string titulo;
        private string director;
        private int anyo;
        private bool disponible;

        public Pelicula(string titulo, string director, int anyo)
        {
            this.titulo = titulo;
            this.director = director;
            this.anyo = anyo;
            this.disponible = true; 
        }
        public string tituloPelicula
        {
            get { return titulo; }
        }
        public string directorPelicula
        {
            get { return director; }
        }
            public int anyoPelicula
        {
            get { return anyo; }
        }
        public bool disponiblePelicula
        {
            get { return disponible; }
        }
        public string ToString()
        {
            return $"{titulo} - {director} ({anyo})";
        }

    }
}
