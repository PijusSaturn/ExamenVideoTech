using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExamenVideoTech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula("Alien", "Ridley Scott", 1979, true));
            peliculas.Add(new Pelicula("Parasite", "Bong Joon-ho", 2019, false));
            peliculas.Add(new Pelicula("Fantastic Mr. Fox", "Wes Anderson", 2009, true));
            peliculas.Add(new Pelicula("Inception", "Christopher Nolan", 2010, true));
            foreach (Pelicula pelicula in peliculas)
            {
                Console.WriteLine(pelicula.ToString());
            }
            foreach (Pelicula pelicula in peliculas)
            {
                if (pelicula.directorPelicula.Contains("Nolan"))
                {
                    Console.WriteLine(pelicula.ToString());
                }
            }
            Console.WriteLine(DateTime.Now.ToShortDateString);
            
        }

        public static void GuardarPeliculas(List<Pelicula> peliculas, string ruta)
        {
           StreamWriter Peliculas = File.CreateText(ruta);
            foreach (Pelicula pelicula in peliculas)
            {
                Peliculas.WriteLine($"{pelicula.tituloPelicula};{pelicula.directorPelicula};{pelicula.anyoPelicula};{pelicula.disponiblePelicula}");
            }
            Peliculas.Close();
        }
    }
}
