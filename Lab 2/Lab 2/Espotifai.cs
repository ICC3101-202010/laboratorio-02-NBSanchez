using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Espotifai
    {
        List<Cancion> songs = new List<Cancion>();

        public Espotifai()
        {

        }

        public bool AgregarCancion(Cancion cancion)
        {
            int tamaño = songs.Count(); //TAMAÑO DE LA LISTA//
            int compare = 0; //VARIABLE//
            string data = cancion.Informacion(); //INFO DE LA CANCION AGREGADA//

            for (int x = 0; x < tamaño; x++) //CONOCIMIENTO DE LA EXISTENCIA DE LA CANCION//
            {
                if (data == songs[x].Informacion())
                {
                    compare++;
                }

                else
                {
                    continue;
                }
            }
            if (compare == 1)
            {
                return false;
            }
            else
            {
                songs.Add(cancion);
                return true;
            }
        }
        public void VerCanciones()
        {
            for (int y = 0; y < songs.Count(); y++)
            {
                Console.WriteLine(songs[y].Informacion());
            }
        }
    }
}
