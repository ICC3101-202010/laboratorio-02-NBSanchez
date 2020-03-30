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

        public List<Cancion> CancionesPorCriterio(string criterio, string valor)
        {
            List<Cancion> entregar = new List<Cancion>();

            if (criterio == "NOMBRE" || criterio == "nombre")
            {
                for (int z = 0; z < songs.Count(); z++)
                {
                    List<string> Crit = songs[z].Criterios();
                    if (Crit[0] == valor)
                    {
                        entregar.Add(songs[z]);
                    }
                    else
                    {
                        continue;
                    }
                }
                return (entregar);
            }
            else if (criterio == "ARTISTA" || criterio == "artista")
            {
                for (int z = 0; z < songs.Count(); z++)
                {
                    List<string> Crit = songs[z].Criterios();
                    if (Crit[1] == valor)
                    {
                        entregar.Add(songs[z]);
                    }
                    else
                    {
                        continue;
                    }
                }
                return (entregar);
            }
            else if (criterio == "GENERO" || criterio == "genero")
            {
                for (int z = 0; z < songs.Count(); z++)
                {
                    List<string> Crit = songs[z].Criterios();
                    if (Crit[2] == valor)
                    {
                        entregar.Add(songs[z]);
                    }
                    else
                    {
                        continue;
                    }
                }
                return (entregar);
            }
            else if (criterio == "ALBUM" || criterio == "album")
            {
                for (int z = 0; z < songs.Count(); z++)
                {
                    List<string> Crit = songs[z].Criterios();
                    if (Crit[3] == valor)
                    {
                        entregar.Add(songs[z]);
                    }
                    else
                    {
                        continue;
                    }
                }
                return (entregar);
            }
            else
            {
                Console.WriteLine("LO LAMENTO PERO ESE CRITERIO NO EXISTE: " + criterio);
                return (entregar);
            }
        }
    }
}
