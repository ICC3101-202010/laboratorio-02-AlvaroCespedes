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
        List<string> ListaCanciones; //Creo la lista de la clase cancion
        public Cancion()//Creo el constructor de la lista 
        {
            ListaCanciones = new List<string>();

        }
        public string Informacion() // Primer Metodo de cancion
        {
            Console.WriteLine("Informacion de la cancion");
            {
                return null;
            }
        }
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
        public void AgregarCancion(string cancion)
        {
            lista1.Add(cancion);
        }
    }
}
