using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;


namespace ExamenVideoTech
{
    internal class GestorBD
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlConnection.builder.Server Server = "localhost";
        MySqlConnection.builder.UserID user = "root";
        MySqlConnection.builder.Password password = "";
        MySqlConnection.builder.Database Database = "videotech";

        MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();

        public void InsertarPelicula(Pelicula pelicula)
        {
            string query = $"INSERT INTO peliculas (titulo, director, anyo, disponible) VALUES ('{pelicula.tituloPelicula}', '{pelicula.directorPelicula}', {pelicula.anyoPelicula}, {pelicula.disponiblePelicula})";
            using (MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder(builder.ToString()))
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
            }

        }
        public void ObtenerTodos(Pelicula pelicula)
        {
            string query = "SELECT * FROM peliculas";
        }



    }
}
