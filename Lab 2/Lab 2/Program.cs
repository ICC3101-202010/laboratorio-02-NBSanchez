using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Espotifai esp = new Espotifai();
            Console.WriteLine("BIENVENIDOS MIS CONOCEDORES AUDITORES A SU NUEVO REPRODUCTOR FAVORITO DE MUSICA!!");
            Console.WriteLine("");

            while (true)
            {

                Console.WriteLine("ESCOJA EL NUMERO DE ALGUNA DE LAS SIGUIENTES OPCIONES QUE TENEMOS PARA USTED: ");
                Console.WriteLine("");
                Console.WriteLine("1. VER TODAS LAS CANCIONES: ");
                Console.WriteLine("2. AGREGAR UNA CANCION: ");
                Console.WriteLine("3. VER CANCIONES POR CRITERIO: ");
                Console.WriteLine("4. GENERAR PLAYLIST: ");
                Console.WriteLine("5. VER MIS PLAYLIST: ");
                Console.WriteLine("E. SALIR DEL PROGRAMA: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    esp.VerCanciones();
                    Console.WriteLine("");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("");
                    Console.WriteLine("DAME LOS DATOS DE LA CANCION EN EL SIGUIENTE ORDEN: NOMBRE,ALBUM,ARTISTA,GENERO");
                    string Nombre = Console.ReadLine();
                    string Album = Console.ReadLine();
                    string Artista = Console.ReadLine();
                    string Genero = Console.ReadLine();
                    Console.WriteLine(esp.AgregarCancion(new Cancion(Nombre, Album, Artista, Genero)));
                    Console.WriteLine("");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("INGRESE EL CRITERIO (NOMBRE,ARTISTA,ALBUM,GENERO): ");
                    string Crit = Console.ReadLine();
                    Console.WriteLine("INGRESE SU BUSQUEDA: ");
                    string valor = Console.ReadLine();
                    List<Cancion> seleccion = esp.CancionesPorCriterio(Crit, valor);
                    for (int a = 0; a < seleccion.Count(); a++)
                    {
                        Console.WriteLine(seleccion[a].Informacion());
                    }

                }
                else if (choice == "4")
                {
                    Console.WriteLine("INGRESE SU CRITERIO, VALOR Y NOMBRE DE TU PLAYLIST");
                    string criterioplaylist = Console.ReadLine();
                    string valorcriterio = Console.ReadLine();
                    string nombreplaylist = Console.ReadLine();
                    Console.WriteLine(esp.GenerarPlaylist(criterioplaylist, valorcriterio, nombreplaylist));

                }
                else if (choice == "5")
                {
                    if (esp.VerMisPlaylists() == "")
                    {
                        Console.WriteLine("LO LAMENTO PERO TU NO TIENES PLAYLIST");
                    }
                    else
                    {
                        Console.WriteLine("BIENVENIDO A TUS PLAYLIST:");
                        Console.WriteLine("");
                        Console.WriteLine(esp.VerMisPlaylists());
                    }
                }

                else if (choice == "E" || choice == "e")
                {
                    Console.WriteLine("QUE LASTIMA PERO ADIOS ME DESPIDO DE TI Y ME VOY :/");
                    break;
                }
                else
                {
                    Console.WriteLine("LO LAMENTO NO ENTENDI INTENTELO DE NUEVO");
                    Console.WriteLine("");
                }
            }
        }
    }
}
