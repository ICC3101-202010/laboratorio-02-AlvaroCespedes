using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class espotifai
    {
        List<Cancion> ListaCanciones; // Creo que es mejor un diccionario
        public espotifai() // Constructor de la lista
        {
            ListaCanciones = new List<Cancion>();
        }

        public bool AgregarCancion(Cancion cancion)
        {
            ListaCanciones.Add(cancion);
            foreach (Cancion i in ListaCanciones) // Averiguar como recorrer bien una lista
            {
                if i == ListaCanciones[0]();
                return false;
            }
            return true;
        }
        public void VerCanciones() // Tiene que ver con la Informacion de la clase cancion. No retorna nada por el Void.
        {
            Console.WriteLine();
        }

        public Cancion[] CancionesPorCriterio(String criterio, String valor) // Metodo
        {
            return true;
        }
    }
}
