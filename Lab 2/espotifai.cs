using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class espotifai
    {
        List<Cancion> ListaCanciones;
        public espotifai() // Constructor de la lista
        {
            ListaCanciones = new List<Cancion>();
        }

        public bool AgregarCancion(Cancion cancion)
        {
            ListaCanciones.Add(cancion);
            return true;
        }
        public void VerCanciones()
        {
            
        }

    }
}
