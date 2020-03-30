using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Cancion
    {
        private string Nombre;
        private string Album;
        private string Artista;
        private string Genero;

        public Cancion (string Nombre,string Album,string Artista, string Genero)
        {
            this.Nombre = Nombre;
            this.Album = Album;
            this.Artista = Artista;
            this.Genero = Genero;
        }
        public string Informacion()
        {
            return ("Genero: " + Genero + " Artista: " + Artista + " Album: " + Album + " Nombre: " + Nombre); 
        }
        public List<string> Criterios()
        {
            List<string> criterios = new List<string>();
            criterios.Add(Nombre);
            criterios.Add(Artista);
            criterios.Add(Genero);
            criterios.Add(Album);
            return criterios;
        }
    }
}
