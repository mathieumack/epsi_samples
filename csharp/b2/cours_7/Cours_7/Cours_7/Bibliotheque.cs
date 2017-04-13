using System;
using System.Collections.Generic;
using System.Linq;

namespace Cours_7
{
    public class Bibliotheque : IBibliotheque
    {
        private readonly int nbJoursResaParLivre;
        private readonly int nbResaParUtilisateursMax;

        private List<Livre> Livres { get; set; }

        private List<Emprunt> Emprunts { get; set; }

        private List<Utilisateur> Utilisateurs { get; set; }

        #region Constructor

        public Bibliotheque()
        {
            nbJoursResaParLivre = 2;
            nbResaParUtilisateursMax = 3;

            InitDatas();
        }

        #endregion

        #region Public methods
        

        #endregion

        #region Initialisation de la bibliotheque
        
        public void InitDatas()
        {
            Emprunts = new List<Emprunt>();
            InitLivres(new List<Livre>());
            InitUtilisateurs(new List<Utilisateur>());
        }

        public void InitDatas(List<Livre> livres, List<Utilisateur> utilisateurs)
        {
            if (livres == null)
                throw new ArgumentNullException();
            if (utilisateurs == null)
                throw new ArgumentNullException();

            Emprunts = new List<Emprunt>();
            InitLivres(livres);
            InitUtilisateurs(utilisateurs);
        }

        internal void InitLivres(List<Livre> livres)
        {
            if (livres == null)
                throw new ArgumentNullException();

            Livres = livres;
        }

        private void InitUtilisateurs(List<Utilisateur> utilisateurs)
        {
            if (utilisateurs == null)
                throw new ArgumentNullException();

            Utilisateurs = utilisateurs;
        }

        /// <summary>
        /// Indique si un livre est réservable ou pas.
        /// Un livre est réservable s'il existe dans la bibliothèque et qu'il est flagué comme réservable
        /// </summary>
        /// <param name="livreId"></param>
        /// <returns></returns>
        public bool IsReservable(int livreId)
        {
            if (Livres.Any(e => e.Id == livreId))
                return Livres.First(e => e.Id == livreId).IsReservable;
            else
                return false;
        }

        /// <summary>
        /// Indique si un livre est disponible ou pas à une date donnée
        /// </summary>
        /// <param name="livreId"></param>
        /// <param name="dateReservation"></param>
        /// <returns></returns>
        public bool IsDisponible(int livreId, DateTime dateReservation)
        {
            return Livres.Any(e => e.Id == livreId && e.DateDisponibilite <= dateReservation);
        }

        /// <summary>
        /// Permet de réserver un livre dans la bibliothèque
        /// </summary>
        /// <param name="livreId"></param>
        /// <param name="utilisateurId"></param>
        /// <param name="dateReservation"></param>
        /// <returns>Vrai si le livre e été réservé, faux s'il ne peut pas l'être</returns>
        public bool ReserveLivre(int livreId, int utilisateurId, DateTime dateReservation)
        {
            // Nous vérifions que le livre est réservable, et que l'utilisateur aussi :
            if (IsReservable(livreId) &&
                IsDisponible(livreId, dateReservation) &&
                Utilisateurs.Any(e => e.Id == utilisateurId))
            {
                // On génère les 2 dates d'emprunt pour le livre :
                List<Emprunt> emprunts = new List<Emprunt>();
                for (int i = 0; i < nbJoursResaParLivre; i++)
                {
                    emprunts.Add(new Emprunt()
                    {
                        LivreId = livreId,
                        UtilisateurId = utilisateurId,
                        DateReservation = dateReservation.Date.AddDays(i)
                    });
                }

                // On récupère les dates :
                List<DateTime> dates = emprunts.Select(e => e.DateReservation).ToList();

                // On vérifie que le livre n'est pas déjà réservé pour toutes les dates ci-dessus :
                bool dejaEmprunte = Emprunts.Any(e => e.LivreId == livreId && dates.Contains(e.DateReservation.Date));

                if (!dejaEmprunte)
                {
                    // On vérifie aussi que l'utilisateur n'a pas déjà d'autres réservations
                    bool utilisateurPeutReserver = true;
                    foreach (DateTime date in dates)
                    {
                        utilisateurPeutReserver &= Emprunts.Count(e => e.UtilisateurId == utilisateurId && e.DateReservation == date) < nbResaParUtilisateursMax;
                    }

                    if(utilisateurPeutReserver)
                        Emprunts.AddRange(emprunts);

                    return utilisateurPeutReserver;
                }
            }

            return false;
        }

        #endregion
    }
}
