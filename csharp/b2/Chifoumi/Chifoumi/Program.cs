using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chifoumi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tf = true;
            while (tf)
            {
                Console.WriteLine("Quel coup souhaitez-vous jouer ?");
                Console.WriteLine("Pierre : 0. Feuille : 1. Ciseaux : 2");
                string valeur = Console.ReadLine();
                
                if (valeur == "fin")
                    tf = false;
                else
                {
                    // Calcul du coup de l'ordinateur
                    Random random = new Random();
                    Coups ordinateur = (Coups)random.Next(0, 3);
                    Coups humain = (Coups)int.Parse(valeur);

                    Console.WriteLine("J'ai joué : " + ordinateur.ToString());

                    if (ordinateur == Coups.Pierre && humain == Coups.Feuille)
                        Console.WriteLine("Vous avez gagné !");
                    else if (ordinateur == Coups.Feuille && humain == Coups.Ciseaux)
                        Console.WriteLine("Vous avez gagné !");
                    else if (ordinateur == Coups.Ciseaux && humain == Coups.Pierre)
                        Console.WriteLine("Vous avez gagné !");
                    else if (ordinateur == humain)
                        Console.WriteLine("Egalité!");
                    else
                        Console.WriteLine("J'ai gagné !");
                }
            }
        }
    }

    public enum Coups
    {
        Pierre = 0,
        Feuille = 1,
        Ciseaux = 2
    }
}
