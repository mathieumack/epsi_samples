using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cours_7.Unit.Tests
{
    [TestClass]
    public class BibliothequeTests
    {
        private IBibliotheque bibliotheque;

        [TestInitialize]
        public void TestInit()
        {
            bibliotheque = new Bibliotheque();
            
            // On initialize avec des données fake :
            bibliotheque.InitDatas(GetFakeLivres(), GetFakeUtilisateurs());
        }

        [TestMethod]
        public void IsReservable()
        {
            Assert.IsTrue(bibliotheque.IsReservable(0));
            Assert.IsFalse(bibliotheque.IsReservable(1));
            Assert.IsTrue(bibliotheque.IsReservable(6));
            Assert.IsFalse(bibliotheque.IsReservable(9));
            Assert.IsFalse(bibliotheque.IsReservable(12));
        }

        [TestMethod]
        public void ReserveLivre_meme_livre_meme_date()
        {
            bool canReserver = bibliotheque.ReserveLivre(2, 1, DateTime.Now);
            Assert.IsTrue(canReserver);

            // Même livre à la même date pour le même utilisateur :
            canReserver = bibliotheque.ReserveLivre(2, 1, DateTime.Now);
            Assert.IsFalse(canReserver);

            // Même livre à la même date pour un autre utilisateur :
            canReserver = bibliotheque.ReserveLivre(2, 3, DateTime.Now);
            Assert.IsFalse(canReserver);
        }

        [TestMethod]
        public void ReserveLivre_3fois_par_utilisateur()
        {
            bool canReserver = bibliotheque.ReserveLivre(2, 1, DateTime.Now.AddDays(10));
            Assert.IsTrue(canReserver);

            canReserver = bibliotheque.ReserveLivre(4, 1, DateTime.Now.AddDays(10));
            Assert.IsTrue(canReserver);

            canReserver = bibliotheque.ReserveLivre(6, 1, DateTime.Now.AddDays(10));
            Assert.IsTrue(canReserver);

            canReserver = bibliotheque.ReserveLivre(8, 1, DateTime.Now.AddDays(10));
            Assert.IsFalse(canReserver);
        }

        #region Fake datas

        private List<Livre> GetFakeLivres()
        {
            List<Livre> result = new List<Livre>();

            for(int i = 0; i < 10; i++)
            {
                result.Add(new Livre()
                {
                    Id = i,
                    Titre = "Livre " + i.ToString(),
                    IsReservable = i % 2 == 0, // Seuls les nombres pairs sont réservables :
                    DateDisponibilite = DateTime.Now.AddDays(i-3) // Tous les jours à partir d'aujourd'hui - 3 jours un nouveau livre est réservable
                });
            }

            return result;
        }

        private List<Utilisateur> GetFakeUtilisateurs()
        {
            List<Utilisateur> result = new List<Utilisateur>();

            for (int i = 0; i < 10; i++)
            {
                result.Add(new Utilisateur()
                {
                    Id = i,
                    Nom = "Nom " + i.ToString()
                });
            }

            return result;
        }

        #endregion
    }
}
