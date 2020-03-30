using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Playlist
    {
        private string Name;
        private List<Cancion> playlist = new List<Cancion>();  // ARREGLO DE OBJETOS DEL TIPO CANCION//

        public Playlist(string Name, List<Cancion> canciones)
        {
            this.Name = Name;
            this.playlist = canciones;
        }
        public string NamePlaylist()
        {
            return Name;
        }
        public void ShowSongs()
        {
            for (int b = 0; b < playlist.Count(); b++)
            {
                Console.WriteLine(playlist[b].Informacion());

            }
        }
        public List<Cancion> ReturnSongs()
        {
            return playlist;
        }
    }
}
