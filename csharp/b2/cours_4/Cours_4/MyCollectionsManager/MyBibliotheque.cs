using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsManager
{
    public class MyBibliotheque
    {
        Manager<Film> Films { get; set; }
        Manager<Livre> Livres { get; set; }

        public MyBibliotheque()
        {
            Films = new Manager<Film>();
            Livres = new Manager<Livre>();
        }

        public void Start()
        {
            Console.WriteLine("Que veux-tu faire ?");
            string action = Console.ReadLine();
            while (action != "exit")
            {
                if (action == "ajouter un livre")
                {
                    Livres.Ajouter();
                }
                else if (action == "afficher les livres")
                {
                    Livres.AfficherListe();
                }
                else if (action == "editer un livre")
                {
                    Livres.Editer();
                }
                else if (action == "ajouter un film")
                {
                    Films.Ajouter();
                }
                else if (action == "afficher les films")
                {
                    Films.AfficherListe();
                }
                else if (action == "editer un film")
                {
                    Films.Editer();
                }
                Console.WriteLine("Que veux-tu faire ?");
                action = Console.ReadLine();
            }
        }
    }
}
