﻿using System;
using System.Collections;

namespace MonApplication
{
    public class PlusMoinsGameVersionUtilisateur : IGame
    {
        public string NomJeu { get; internal set; }
        public string Toto { get; set; }

        private int nombreParties { get; set; }
        private System.Collections.ArrayList nombreDeCoupsParPartie { get; set; }

        public void LancerJeu()
        {
            nombreDeCoupsParPartie = new System.Collections.ArrayList();
            nombreParties = 0;
            while (true)
            {
                nombreParties++;

                int nombreDecoups = 0;

                #region Code du jeu
                Console.WriteLine("Bonjour, on va démarre");

                Random randomValue = new Random();
                int valeurATrouver = randomValue.Next(0, 10001);

                string valeurSaisie;
                do
                {
                    nombreDecoups++;
                    Console.WriteLine("Entrez une valeur : (tapez exit pour arréter de jouer)");
                    valeurSaisie = Console.ReadLine();

                    if (valeurSaisie != "exit")
                    {
                        int valeurEntiere = int.Parse(valeurSaisie);
                        if (valeurEntiere > valeurATrouver)
                            Console.WriteLine("C'est moins.");
                        else if (valeurEntiere < valeurATrouver)
                            Console.WriteLine("C'est plus.");
                    }
                }
                while (valeurSaisie != "exit" && valeurSaisie != valeurATrouver.ToString());


                if (valeurSaisie == valeurATrouver.ToString())
                    Console.WriteLine("Bravo tu as trouvé !");

                #endregion

                nombreDeCoupsParPartie.Add(nombreDecoups);

                GetStatistiques();
            }
        }

        public void GetStatistiques()
        {
            Console.WriteLine("Nombre de parties : " + nombreParties);
        }

        public void GetStatistiques(System.DateTime dateMin)
        {
            Console.WriteLine("Statistiques");
        }
        
    }
    
    public class PlusMoinsGameVersionProgramme : IGame
    {
        public string NomJeu
        {
            get
            {
                return "A moi de trouver";
            }
        }

        public void GetStatistiques()
        {
            Console.WriteLine("0 parties.");
        }

        public void LancerJeu()
        {
            nombreParties = 0;
            while (true)
            {
                nombreParties++;

                Console.WriteLine("Bonjour, on va démarrer. Choisissez un nombre entre 0 et 10000.");
                Console.WriteLine("Tapez sur la touche 'entrer' quand vous aurez choisi.");

                Console.ReadLine();

                int valeurMin = 0;
                int valeurMax = 10000;
                string valeur;
                do
                {
                    int nouvelleProposition = (valeurMin + valeurMax) / 2;
                    Console.WriteLine("Est-ce " + nouvelleProposition + " ?");
                    valeur = Console.ReadLine();
                    if (valeur == "+")
                    {
                        valeurMin = nouvelleProposition;
                    }
                    else if (valeur == "-")
                    {
                        valeurMax = nouvelleProposition;
                    }
                }
                while (valeur != "exit" && valeur != "=");

                if (valeur == "=")
                    Console.WriteLine("Yes ! Je suis trop fort.");
            }
        }
    }
} 