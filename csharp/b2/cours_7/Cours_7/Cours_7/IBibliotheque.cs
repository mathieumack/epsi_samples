using System;
using System.Collections.Generic;

namespace Cours_7
{
    public interface IBibliotheque
    {
        /// <summary>
        /// Permet de déterminer si un livre est réservable ou pas
        /// </summary>
        /// <param name="livreId"></param>
        /// <returns></returns>
        bool IsReservable(int livreId);

        /// <summary>
        /// Tente de réserver un livre à une date donnée
        /// </summary>
        /// <param name="livreId"></param>
        /// <param name="dateReservation"></param>
        /// <returns>Vrai si la réservation a réussi, faux si la rés ne peut pas se faire</returns>
        bool ReserveLivre(int livreId, DateTime dateReservation);

        /// <summary>
        /// Permet d'initialiser la bibliothèque
        /// </summary>
        /// <param name="livres"></param>
        /// <param name="utilisateurId"></param>
        /// <param name="utilisateurs"></param>
        void InitDatas(List<Livre> livres, int utilisateurId, List<Utilisateur> utilisateurs);
    }
}
