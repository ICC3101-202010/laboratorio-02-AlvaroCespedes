using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Cancion
    {
        public string Nombre;
        public string Album;
        public string Artista;
        public string Genero;

        public string Informacion() // Primer Metodo de cancion
        {
            return ($"genero: {Genero}, artista: {Artista}, album: {Album}, nombre: {Nombre}");
        }

        public Cancion(string nombre, string album, string artista, string genero) // Creo el constructor de la clase cancion
        {
            this.Nombre = nombre;
            this.Album = album;
            this.Artista = artista;
            this.Genero = genero;
        }

    }
}
