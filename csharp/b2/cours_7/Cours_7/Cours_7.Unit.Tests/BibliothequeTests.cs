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

            List<Livre> livres = new List<Livre>();
            for (int i = 1; i < 10; i++)
            {
                livres.Add(new Livre()
                {
                    Id = i,
                    Titre = "Titre 1",
                    IsReservable = i < 8,
                    DateDisponibilite = null
                });
            }

            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            for (int i = 1; i < 10; i++)
            {
                utilisateurs.Add(new Utilisateur()
                {
                    Id = i,
                    Nom = "Monsieur " + i.ToString()
                });
            }

            bibliotheque.InitDatas(livres, utilisateurs);
        }

        [TestMethod]
        public void IsReservable()
        {
            bool isReservable = bibliotheque.IsReservable(1);
            Assert.IsTrue(isReservable);

            isReservable = bibliotheque.IsReservable(2);
            Assert.IsFalse(isReservable);
        }

        [TestMethod]
        public void ReserveLivre_meme_livre_meme_date()
        {
            bool canReserver = bibliotheque.ReserveLivre(2, 1, new DateTime(2017, 2, 1));
            Assert.IsTrue(canReserver);

            canReserver = bibliotheque.ReserveLivre(2, 1, new DateTime(2017, 2, 1));
            Assert.IsFalse(canReserver);
        }

        [TestMethod]
        public void ReserveLivre_3fois_par_utilisateur()
        {
            bool canReserver = bibliotheque.ReserveLivre(1, 1, new DateTime(2017, 2, 1));
            Assert.IsTrue(canReserver);

            canReserver = bibliotheque.ReserveLivre(2, 1, new DateTime(2017, 2, 1));
            Assert.IsTrue(canReserver);

            canReserver = bibliotheque.ReserveLivre(3, 1, new DateTime(2017, 2, 1));
            Assert.IsTrue(canReserver);

            canReserver = bibliotheque.ReserveLivre(4, 1, new DateTime(2017, 2, 1));
            Assert.IsFalse(canReserver);
        }
    }
}
