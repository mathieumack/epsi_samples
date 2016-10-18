using System;

namespace MonApplication
{
    public static class Program
    {
        static void Main(string[] args)
        {
            IGame monJeuUtilisateur = new PlusMoinsGameVersionUtilisateur();
            IGame monJeuProgramme = new PlusMoinsGameVersionProgramme();

            Console.WriteLine("Tapez 1 pour jouer à : " + monJeuUtilisateur.NomJeu);
            Console.WriteLine("Tapez 2 pour jouer à : " + monJeuProgramme.NomJeu);
            Console.WriteLine("Sinon tapez sur n'importe quoi pour quitter.");
            Console.WriteLine("Pensez à valider par 'entrée'...");

            string typeJeu = Console.ReadLine();
            if (typeJeu == "1")
                monJeuUtilisateur.LancerJeu();
            else if (typeJeu == "2")
                monJeuProgramme.LancerJeu();
            else
                Console.WriteLine("Ok, bye !");
            
            Console.ReadLine();
        }
    }
}
