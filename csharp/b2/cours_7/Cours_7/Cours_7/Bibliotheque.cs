using System;
using System.Collections.Generic;
using System.Linq;

namespace Cours_7
{
    public class Bibliotheque : IBibliotheque
    {
        private IList<Livre> Livres { get; set; }

        private IList<Emprunt> Emprunts { get; set; }

        private IList<Utilisateur> Utilisateurs { get; set; }

        #region Constructor

        public Bibliotheque()
        {
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
            Emprunts = new List<Emprunt>();
            InitLivres(livres);
            InitUtilisateurs(utilisateurs);
        }

        private void InitLivres(List<Livre> livres)
        {
            Livres = livres;
        }

        private void InitUtilisateurs(List<Utilisateur> utilisateurs)
        {
            Utilisateurs = utilisateurs;
        }

        public bool IsReservable(int livreId)
        {
            if (Livres.Any(e => e.Id == livreId))
                return Livres.First(e => e.Id == livreId).IsReservable;
            else
                return false;
        }

        public bool ReserveLivre(int livreId, int utilisateurId, DateTime dateReservation)
        {
            return false;
        }

        #endregion
    }
}
