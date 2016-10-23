using System;
using System.Collections;

namespace MonApplication
{
    public class PlusMoinsGameVersionUtilisateur : IGame
    {
        public string NomJeu
        {
            get
            {
                return "A toi de trouver !";
            }
        }

        private double nombreParties;
        private ArrayList statistiquesParPartie;

        public void LancerJeu()
        {
            Console.WriteLine("Bonjour, on va démarre");

            statistiquesParPartie = new ArrayList();
            do
            {
                Random randomValue = new Random();
                int valeurATrouver = randomValue.Next(0, 10001);

                string valeurSaisie;
                do
                {
                    int nbCoups = 0;

                    Console.WriteLine("Entrez une valeur : (tapez exit pour arréter de jouer)");
                    valeurSaisie = Console.ReadLine();

                    if (valeurSaisie != "exit")
                    {
                        nbCoups++;

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

                AfficherStatistiques();

                Console.WriteLine("Rejouer ? (oui/non)");
            }
            while (Console.ReadLine() == "oui");
        }

        public void AfficherStatistiques()
        {
            Console.WriteLine("Nombre de parties : " + nombreParties);
            Console.WriteLine("------------------------");
            double nombreTotalCoups = 0;
            for (int i = 0; i < statistiquesParPartie.Count; i++)
            {
                nombreTotalCoups += (int)statistiquesParPartie[i];
                Console.WriteLine("Partie " + i + " : " + statistiquesParPartie[i] + " coup(s)");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Nombre de coups moyen : " + (nombreTotalCoups / nombreParties));
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

        private double nombreParties;
        private ArrayList statistiquesParPartie;

        public void LancerJeu()
        {
            statistiquesParPartie = new ArrayList();
            do
            {
                nombreParties++;

                int nbCoups = 0;

                Console.WriteLine("Bonjour, on va démarrer. Choisissez un nombre entre 0 et 10000.");
                Console.WriteLine("Tapez sur la touche 'entrer' quand vous aurez choisi.");

                Console.ReadLine();

                int valeurMin = 0;
                int valeurMax = 10000;
                string valeur;
                do
                {
                    nbCoups++;
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

                statistiquesParPartie.Add(nbCoups);

                if (valeur == "=")
                    Console.WriteLine("Yes ! Je suis trop fort.");

                AfficherStatistiques();

                Console.WriteLine("Rejouer ? (oui/non)");
            }
            while (Console.ReadLine() == "oui");
        }

        public void AfficherStatistiques()
        {
            Console.WriteLine("Nombre de parties : " + nombreParties);
            Console.WriteLine("------------------------");
            double nombreTotalCoups = 0;
            for(int i = 0; i < statistiquesParPartie.Count; i++)
            {
                nombreTotalCoups += (int)statistiquesParPartie[i];
                Console.WriteLine("Partie " + i + " : " + statistiquesParPartie[i] + " coup(s)");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Nombre de coups moyen : " + (nombreTotalCoups/nombreParties));
        }

    }
}