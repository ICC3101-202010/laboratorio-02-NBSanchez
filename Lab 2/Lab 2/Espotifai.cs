using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Espotifai
    {
        private List<Cancion> songs = new List<Cancion>();
        private List<Playlist> guardadas = new List<Playlist>();

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
        public bool GenerarPlaylist(string criterio,string valor,string Name)
        {
            List<Cancion> orden = CancionesPorCriterio(criterio, valor);
            int suma = 0;
            for (int c = 0; c < guardadas.Count(); c++)
            {
                if (Name == guardadas[c].NamePlaylist())
                {
                    suma++;
                }
                else
                {
                    continue;

                }
            }
            if (orden.Count() == 0 && criterio != "NOMBRE" && criterio != "nombre" && criterio != "ALBUM" && criterio != "album" && criterio != "ARTISTA" && criterio != "artista" && criterio != "GENERO" && criterio != "genero")
            {
                return false;
            }
            else if (orden.Count() == 0)
            {
                Console.WriteLine("LO LAMENTO NO ENCONTRE CANCIONES QUE CUMPLAN ESTE CRITERIO");
                return false;
            }
            else if (suma != 0)
            {
                Console.WriteLine("UPS YA EXISTE UNA PLAYLIST CON ESTE NOMBRE :/");
                return false;
            }
            else
            {
                guardadas.Add(new Playlist(Name, orden));
                return true;
            }

        }
        public string VerMisPlaylists()
        {
            string entrega = "";
            if (guardadas.Count() == 0)
            {
                return "";
            }
            else
            {
                for(int n = 0; n < guardadas.Count(); n++)
                {
                    string Name = guardadas[n].NamePlaylist();
                    string data = "";
                    List<Cancion> canciones = guardadas[n].ReturnSongs();
                    for (int i = 0; i < canciones.Count(); i++)
                    {
                        data += canciones[i].Informacion() + Environment.NewLine;
                    }
                    entrega += Name + ":" + Environment.NewLine + data;








                }
                return entrega;
            }
        }
    }
}































