using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public class Cancion
    {
        public string Nombre;
        public string Album;
        public string Artista;
        public string Genero;
        public string Informacion() // Primer Metodo de cancion
        {
            Console.WriteLine("Informacion de la cancion");
            {
                return ListaCanciones;
            }
        }
        List<string>ListaCanciones; //Creo la lista de la clase cancion
        public Cancion (string nombre, string album, string artista, string genero) // Creo el constructor de la clase cancion
        {
            this.Nombre = nombre;
            this.Album = album;
            this.Artista = artista;
            this.Genero = genero;
        }
    }

    public class Espotifai //Solo tiene metodos relacionados con Cancion
    {
        public bool AgregarCancion(Cancion cancion)
        {

        }
    }
}
