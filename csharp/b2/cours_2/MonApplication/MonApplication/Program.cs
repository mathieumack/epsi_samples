using System;
using System.Collections.Generic;
using System.Linq;

namespace MonApplication
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapez 1 pour jouer à : PlusMoinsGameVersionUtilisateur");
            Console.WriteLine("Tapez 2 pour jouer à : PlusMoinsGameVersionProgramme");
            Console.WriteLine("Sinon tapez sur n'importe quoi pour quitter.");
            Console.WriteLine("Pensez à valider par 'entrée'...");

            string typeJeu = Console.ReadLine();
            if (typeJeu == "1")
            {
                PlusMoinsGameVersionUtilisateur game = new PlusMoinsGameVersionUtilisateur();
                game.LancerJeu();
            }
            else if (typeJeu == "2")
            {
                PlusMoinsGameVersionProgramme game = new PlusMoinsGameVersionProgramme();
                game.LancerJeu();
            }
            else
                Console.WriteLine("Ok, bye !");

            Console.ReadLine();
        }
    }
}
